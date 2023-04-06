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
    }
}
