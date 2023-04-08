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
    public partial class AddEntity : Form
    {
        public AddEntity()
        {
            InitializeComponent();
        }

        // Function that will add a creature to the creature list when the "Add Enity" button is clicked
        private void AddButton_Click(object sender, EventArgs e)
        {
            mainGUI parentForm = (mainGUI)this.Owner;

            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            byte strength = (byte)strengthNumericUpDown.Value;
            byte dexterity = (byte)dexterityNumericUpDown.Value;
            byte constitution = (byte)constitutionNumericUpDown.Value;
            byte intelligence = (byte)intelligenceNumericUpDown.Value;
            byte wisdom = (byte)wisdomNumericUpDown.Value;
            byte charisma = (byte)charismaNumericUpDown.Value;
            byte initiative = (byte)initiativeNumericUpDown.Value;
            int hp = (int)hitPointsNumericUpDown.Value;
            byte ac = (byte)acNumericUpDown.Value;
            

            // Add the creature to the list
            parentForm.AddtoList(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma, initiative, hp, ac);

            // Clear the form for the next creature
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            strengthNumericUpDown.Value = 10;
            dexterityNumericUpDown.Value = 10;
            constitutionNumericUpDown.Value = 10;
            intelligenceNumericUpDown.Value = 10;
            wisdomNumericUpDown.Value = 10;
            charismaNumericUpDown.Value = 10;
            initiativeNumericUpDown.Value = 0;
            hitPointsNumericUpDown.Value = 0;
            acNumericUpDown.Value = 10;

            parentForm.editButton_Click(sender, e);
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {

        }
    }
}
