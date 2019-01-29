using dnd_project.Core.BusinessModels;
using dnd_project.Core.Data;
using dnd_project.Core;
using dnd_project.Core.ViewModels;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace dnd_project
{
    public partial class NewCharacter : Form
    {
        private CharacterController controller;

        public NewCharacter()
        {
            InitializeComponent();
            controller = new CharacterController();
            SetRaceValues();
        }
        #region Helper Methods

        /// <summary>
        /// Adds all of the races to the race list
        /// </summary>
        private void SetRaceValues()
        {
            List<string> races = controller.GetAllRaces();
            foreach(string race in races)
            {
                raceList.Items.Add(race);
            }
        }
        /// <summary>
        /// Populates the details on the Race selection page
        /// </summary>
        /// <param name="selectedItem"></param>
        private void UpdateRaceDetails(string selectedItem)
        {
            raceInfoTable.Visible = true;
            raceDescriptionPanel.Visible = false;
            raceDescriptionLabel.Text = "";
            Race currentRace = controller.GetRace(selectedItem);
            raceAgeBox.Text = currentRace.Ages[0] + " - " + currentRace.Ages[1] + " years old";
            raceSizeBox.Text = currentRace.Size;
            raceAlignBox.Text = currentRace.Alignment;
            raceMoveBox.Text = currentRace.Speed.ToString() + " feet";
            raceAttrBox.Items.Clear();
            raceGearBox.Items.Clear();
            raceLanguageBox.Items.Clear();
            raceFeatsBox.Items.Clear();
            raceProficienciesBox.Items.Clear();
            foreach (RaceAttribute att in currentRace.AttributeMods)
            {
                raceAttrBox.Items.Add(att.ToString());
            }

            foreach (string gear in currentRace.GearChoices)
            {
                raceGearBox.Items.Add(gear);
            }
            foreach (string lang in currentRace.Languages)
            {
                raceLanguageBox.Items.Add(lang);
            }
            foreach (string feat in currentRace.Feats)
            {
                raceFeatsBox.Items.Add(feat);
            }
            foreach(string prof in currentRace.Proficiencies)
            {
                raceProficienciesBox.Items.Add(prof);
            }
        }
        /// <summary>
        /// Updates the desciption box on the race page
        /// </summary>
        /// <param name="selectedItem">The currently selected item on the page</param>
        /// <param name="description">The description of the item</param>
        private void UpdateRaceDescription(string selectedItem, string description)
        {
            if (raceDescriptionLabel.Text != selectedItem)
            {
                raceDescriptionPanel.Visible = true;
                raceDescriptionLabel.Text = selectedItem;
                raceDescriptionBox.Text = description;
            }
            else
            {
                raceDescriptionPanel.Visible = false;
                raceDescriptionLabel.Text = "";
            }
        }

        /// <summary>
        /// Updates the CharacterSummary side panel to show overall current stats
        /// </summary>
        private void UpdateCharacterSummary()
        {
            Dictionary<string, Dictionary<string, int>> values = controller.GetAttributeValuesAndMods();

            characterSummaryNameValue.Text = controller.GetBasicCharacterProperty(CharacterValues.Name);
            characterSummaryRaceValue.Text = controller.GetRaceCurrent();
            characterSummaryClassValue.Text = controller.GetClassCurrent();
            characterSummaryStrengthValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Strength]["Value"], values[CharacterAttributes.Strength]["Mod"]);
            characterSummaryDexterityValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Dexterity]["Value"], values[CharacterAttributes.Dexterity]["Mod"]);
            characterSummaryConstitutionValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Constitution]["Value"], values[CharacterAttributes.Constitution]["Mod"]);
            characterSummaryIntelligenceValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Intelligence]["Value"], values[CharacterAttributes.Intelligence]["Mod"]); 
            characterSummaryWisdomValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Wisdom]["Value"], values[CharacterAttributes.Wisdom]["Mod"]);
            characterSummaryCharismaValue.Text 
                = GenerateAttrModString(values[CharacterAttributes.Charisma]["Value"], values[CharacterAttributes.Charisma]["Mod"]);
        }

        /// <summary>
        /// Generates a string with the format like "xx (+y)" where xx is the attribute value and y is the calulated modifier
        /// </summary>
        /// <param name="attr">Int value of the attribute</param>
        /// <param name="mod">Int value of the modifier</param>
        /// <returns>String with attribute and modifier values</returns>
        private string GenerateAttrModString(int attr, int mod)
        {
            return String.Format("{0} ({1}{2})", attr, mod >= 0 ? "+" : "", mod);
        }
        #endregion
        #region Event Handler Methods
        private void main_button_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void raceList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = raceList.GetItemText(raceList.SelectedItem);
            raceHeader.Text = selectedItem;
            UpdateRaceDetails(selectedItem);
            controller.SetRace(selectedItem);

        }

        private void raceFeatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceFeatsBox.SelectedIndex != -1) {
                string selectedItem = raceFeatsBox.GetItemText(raceFeatsBox.SelectedItem);
                UpdateRaceDescription(selectedItem, controller.GetAllFeats().Contains(selectedItem) ?
                    controller.GetFeat(selectedItem).Description : selectedItem);
                raceFeatsBox.SelectedIndex = -1;
            }
        }

        private void raceAttrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceAttrBox.SelectedIndex != -1)
            {
                string selectedItem = raceAttrBox.GetItemText(raceAttrBox.SelectedItem);
                string selectedAttr = selectedItem.Substring(0,selectedItem.Length - 1);
                string selectedVal = selectedItem.Substring(selectedItem.Length - 1, 1);
                UpdateRaceDescription(selectedItem, "Your character starts with the " + selectedAttr + " attribute increased by " + selectedVal);
                raceAttrBox.SelectedIndex = -1;
            }
        }

        private void raceGearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceGearBox.SelectedIndex != -1)
            {
                string selectedItem = raceGearBox.GetItemText(raceGearBox.SelectedItem);
                UpdateRaceDescription(selectedItem, "You have the option of selecting " + selectedItem + " as a starting gear collection.");
                raceGearBox.SelectedIndex = -1;
            }
        }

        private void raceLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceLanguageBox.SelectedIndex != -1)
            {
                string selectedItem = raceLanguageBox.GetItemText(raceLanguageBox.SelectedItem);
                UpdateRaceDescription(selectedItem, "You can speak in the " + selectedItem + " tongue.");
                raceLanguageBox.SelectedIndex = -1;
            }
        }

        private void raceProficienciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceProficienciesBox.SelectedIndex != -1)
            {
                string selectedItem = raceProficienciesBox.GetItemText(raceProficienciesBox.SelectedItem);
                UpdateRaceDescription(selectedItem, "You have trained with " + selectedItem + " and can now properly use it in combat situations.");
                raceProficienciesBox.SelectedIndex = -1;
            }
        }

        private void eyesTextBox_Click(object sender, EventArgs e)
        {
            descriptionEyeColorPicker.ShowDialog();
            descriptionEyesTextBox.Text = descriptionEyeColorPicker.Color.Name;
        }

        private void skinTextBox_Click(object sender, EventArgs e)
        {
            descriptionSkinColorPicker.ShowDialog();
            descriptionSkinTextBox.Text = descriptionSkinColorPicker.Color.Name;
        }

        private void hairTextBox_Click(object sender, EventArgs e)
        {
            descriptionHairColorPicker.ShowDialog();
            descriptionHairTextBox.Text = descriptionHairColorPicker.Color.Name;
        }

        private void dieRollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DieRoller().Show();
        }

        private void backgroundBackgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Background, backgroundBackgroundComboBox.SelectedItem);
        }

        private void backgroundFactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Faction, backgroundFactionComboBox.SelectedItem);
        }

        private void backgroundPersonalityTextBox_Leave(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.PersonalityTraits, backgroundPersonalityTextBox.Text);
        }

        private void backgroundIdealsTextBox_Leave(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Ideals, backgroundIdealsTextBox.Text);
        }

        private void backgroundBondsTextBox_Leave(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Bonds, backgroundBondsTextBox.Text);
        }

        private void backgroundFlawsTextBox_Leave(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Flaws, backgroundFlawsTextBox.Text);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.PrintCharacterToConsole();
            UpdateCharacterSummary();
        }

        private void descriptionAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Alignment, descriptionAlignmentComboBox.Text);
        }

        private void descriptionAgeNumericSelector_ValueChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Age, (int)descriptionAgeNumericSelector.Value);
        }

        private void descriptionHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Height, descriptionHeightTextBox.Text);
        }

        private void descriptionWeightNumericBox_ValueChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Weight, (int)descriptionWeightNumericBox.Value);
        }

        private void descriptionEyesTextBox_TextChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Eyes, descriptionEyesTextBox.Text);
        }

        private void descriptionSkinTextBox_TextChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Skin, descriptionSkinTextBox.Text);
        }

        private void descriptionHairTextBox_TextChanged(object sender, EventArgs e)
        {
            controller.SetCharacterProperty(CharacterValues.Hair, descriptionHairTextBox.Text);
        }
        #endregion
    }
}
