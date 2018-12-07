﻿using dnd_project.Core.Data;
using dnd_project.Core;
using dnd_project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_project
{
    public partial class NewCharacter : Form
    {
        private CharacterController controller;
        private JsonRaceData raceData;
        private JsonFeatData featData;

        public NewCharacter()
        {
            InitializeComponent();
            controller = new CharacterController();
            raceData = controller.GetRaceData();
            featData = controller.GetFeatData();
            SetRaceValues();
        }

        private void SetRaceValues()
        {
            List<string> raceNames = raceData.Races.Keys.ToList();
            foreach(string name in raceNames)
            {
                raceList.Items.Add(name);
            }
        }

        private void UpdateRaceDetails(string selectedItem)
        {
            raceInfoTable.Visible = true;
            raceDescriptionPanel.Visible = false;
            raceDescriptionLabel.Text = "";
            JsonRaceInfo currentRace = raceData.Races[selectedItem];
            raceAgeBox.Text = currentRace.Ages[0] + " - " + currentRace.Ages[1] + " years old";
            raceSizeBox.Text = currentRace.Size;
            raceAlignBox.Text = currentRace.CommonAlignment;
            raceMoveBox.Text = currentRace.Movement.ToString() + " feet";
            raceAttrBox.Items.Clear();
            raceGearBox.Items.Clear();
            raceLanguageBox.Items.Clear();
            raceFeatsBox.Items.Clear();
            raceProficienciesBox.Items.Clear();
            foreach (RaceAttribute att in currentRace.AttributeScores)
            {
                raceAttrBox.Items.Add(att.ToString());
            }
            foreach(string gear in currentRace.GearChoices)
            {
                raceGearBox.Items.Add(gear);
            }
            foreach(string lang in currentRace.Languages)
            {
                raceLanguageBox.Items.Add(lang);
            }
            foreach(string feat in currentRace.Feats)
            {
                raceFeatsBox.Items.Add(feat);
            }
            foreach(string prof in currentRace.Proficiencies)
            {
                raceProficienciesBox.Items.Add(prof);
            }
        }

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
            controller.SetCharacterProperty(CharacterValues.Race, selectedItem);

        }

        private void raceFeatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceFeatsBox.SelectedIndex != -1) {
                string selectedItem = raceFeatsBox.GetItemText(raceFeatsBox.SelectedItem);
                updateRaceDescription(selectedItem, !featData.Feats.ContainsKey(selectedItem) ? selectedItem : featData.Feats[selectedItem].Description);
                raceFeatsBox.SelectedIndex = -1;
            }
        }

        private void updateRaceDescription(string selectedItem, string description)
        {
            if(raceDescriptionLabel.Text != selectedItem) {
                raceDescriptionPanel.Visible = true;
                raceDescriptionLabel.Text = selectedItem;
                raceDescriptionBox.Text = description;
            } else {
                raceDescriptionPanel.Visible = false;
                raceDescriptionLabel.Text = "";
            }
        }

        private void raceAttrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceAttrBox.SelectedIndex != -1)
            {
                string selectedItem = raceAttrBox.GetItemText(raceAttrBox.SelectedItem);
                string selectedAttr = selectedItem.Substring(0,selectedItem.Length - 1);
                string selectedVal = selectedItem.Substring(selectedItem.Length - 1, 1);
                updateRaceDescription(selectedItem, "Your character starts with the " + selectedAttr + " attribute increased by " + selectedVal);
                raceAttrBox.SelectedIndex = -1;
            }
        }

        private void raceGearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceGearBox.SelectedIndex != -1)
            {
                string selectedItem = raceGearBox.GetItemText(raceGearBox.SelectedItem);
                updateRaceDescription(selectedItem, "You have the option of selecting " + selectedItem + " as a starting gear collection.");
                raceGearBox.SelectedIndex = -1;
            }
        }

        private void raceLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceLanguageBox.SelectedIndex != -1)
            {
                string selectedItem = raceLanguageBox.GetItemText(raceLanguageBox.SelectedItem);
                updateRaceDescription(selectedItem, "You can speak in the " + selectedItem + " tongue.");
                raceLanguageBox.SelectedIndex = -1;
            }
        }

        private void raceProficienciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (raceProficienciesBox.SelectedIndex != -1)
            {
                string selectedItem = raceProficienciesBox.GetItemText(raceProficienciesBox.SelectedItem);
                updateRaceDescription(selectedItem, "You have trained with " + selectedItem + " and can now properly use it in combat situations.");
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
    }
}
