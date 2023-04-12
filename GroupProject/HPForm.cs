using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class HPForm : Form
    {
        private string changeType;
        private bool isEdited = false;
        public HPForm(string labelText, string changeType)
        {
            InitializeComponent();
            userPrompt.Text = labelText;
            this.changeType = changeType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainGUI parentForm = (mainGUI)this.Owner;

            //If an item is selected
            if (parentForm.creatureListBox.SelectedItem != null)
            {
                Creature selectedCreature = parentForm.creatureListBox.SelectedItem as Creature;
                byte healthChange = (byte)healthChangeNumericUpDown.Value;

                if (changeType == "ADD")
                {
                    selectedCreature.SetHP(selectedCreature.GetCurrentHP() + healthChange);
                }
                else if (changeType == "SUB")
                {
                    selectedCreature.SetHP(selectedCreature.GetCurrentHP() - healthChange);
                }
            }
            else
            {

                return; // No creature selected
            }

            parentForm.updateHpLabel();
            this.Close();
        }

        private void userPrompt_Click(object sender, EventArgs e)
        {

        }

        private void healthChangeNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isEdited && e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 ||
                !isEdited && e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                healthChangeNumericUpDown.Text = ""; // Clear the previous value
                isEdited = true; // Set the flag to true to indicate that the control has been edited
            }
        }

        private void Enter_keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(sender, e);

            }
        }
    }
}
