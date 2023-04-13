using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.DataFormats;

namespace GroupProject
{
    public partial class EditForm : Form
    {

        // Constructor
        public EditForm()
        {
            InitializeComponent();
        }

        // Function that updates a creature and closes the edit pop up when the "Edit Entity" button is clicked.
        private void editButton_Click(object sender, EventArgs e)
        {
            // Get a reference to the main form
            mainGUI parentForm = (mainGUI)this.Owner;
            Creature selectedCreature = parentForm.creatureListBox.SelectedItem as Creature;


            if (selectedCreature == null)
            {
                return; // No creature selected
            }
            // Call the edit button function from the main form
            // Update the selected creature with the new data
            selectedCreature.SetName(nameTextBox.Text);
            selectedCreature.SetDescription(descriptionTextBox.Text);
            selectedCreature.SetStr((byte)strengthNumericUpDown.Value);
            selectedCreature.SetDex((byte)dexterityNumericUpDown.Value);
            selectedCreature.SetCon((byte)constitutionNumericUpDown.Value);
            selectedCreature.SetInt((byte)intelligenceNumericUpDown.Value);
            selectedCreature.SetWis((byte)wisdomNumericUpDown.Value);
            selectedCreature.SetCha((byte)charismaNumericUpDown.Value);
            selectedCreature.SetInitiative((byte)initiativeNumericUpDown.Value);
            selectedCreature.SetMaxHP((byte)hitPointsNumericUpDown.Value);
            if (selectedCreature.GetCurrentHP() > selectedCreature.GetMaxHP()) { selectedCreature.SetHP((byte)hitPointsNumericUpDown.Value); }
            selectedCreature.SetAC((byte)acNumericUpDown.Value);

            parentForm.editButton_Click(sender, e);

            // After the user edits the creature, close the pop up
            parentForm.sortCreatureList();
            this.Close();
        }

        private void Enter_keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                editButton_Click(sender, e);
            }
        }
    }
}
