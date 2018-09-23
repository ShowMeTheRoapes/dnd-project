using dnd_project.Core.BusinessModels.Dice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_project
{
    public partial class DieRoller : Form
    {
        public DieRoller()
        {
            InitializeComponent();
            rollerChoice.SelectedIndex = 0;
        }

        private void rollerChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = rollerChoice.GetItemText(rollerChoice.SelectedItem);
            if (selectedItem == "Attribute")
            {
                generalRollerPanel.Visible = false;
                attributeRollerPanel.Visible = true;
            }
            else
            {
                attributeRollerPanel.Visible = false;
                generalRollerPanel.Visible = true;
            }
        }

        private void attributeRollButton_Click(object sender, EventArgs e)
        {
            DiceRoller roller = new DiceRoller();
            roller.RollAttributes(6, 6, 4, 3);
            rollOutput.Clear();
            rollOutput.Text = roller.GetFullRollDetails();
        }

        private void generalRollButton_Click(object sender, EventArgs e)
        {
            DiceRoller roller = new DiceRoller();
            Regex rx = new Regex(@"^\d+\s*[dD]\s*\d+(\s*[+-]\s*\d+)*$");
            if (rx.IsMatch(rollStringInput.Text))
            {
                roller.RollString(rollStringInput.Text);
                rollOutput.Clear();
                rollOutput.Text = roller.GetFullRollDetails();
            }
            else if(inputDieNumber.Value * inputDieSize.Value != 0)
            {
                roller.Roll((int)inputDieNumber.Value, (int)inputDieSize.Value, (int)inputModifier.Value);
                rollOutput.Clear();
                rollOutput.Text = roller.GetFullRollDetails();

            }
            else
            {
                rollOutput.Clear();
                rollOutput.Text = "Both string input and selector input were invalid. Please try again.";
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
    }
}
