using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupProject
{
    public partial class mainGUI : Form
    {
        private int initCounter = 0;    // Counter to track the active round of initative
        private List<Creature> creatureList = new List<Creature>(); // Create a list of creatures
        private EditForm editForm;  // A EditForm variable editForm that allows functions to access members of the edit form
        private AddEntity AddForm;  // A AddEntity variable AddForm that allows functions to access members of the add form
        private AddStatusEffect AddStatus; //An AddStatusEffect variable that allows functions to create the Add Status Effect form
        private int r=0, g=0, b=0;
        private Rectangle OriginalRectangleEntity;
        private Rectangle OriginalFormSize;
        private HPForm addHealth;

        // Constructor
        public mainGUI()
        {
            InitializeComponent();
            nameLabel.Text = "";
            ACLabel.Text = "";
            HPLabel.Text = "";
            tempHPLabel.Text = "";
            initLabel.Text = "";
            strengthLabel.Text = ""; ;
            dexterityLabel.Text = ""; ;
            constitutionLabel.Text = "";
            intelligenceLabel.Text = "";
            wisdomLabel.Text = "";
            charismaLabel.Text = "";
        }

        //Function that sorts creature list by initiative
        public void sortCreatureList()
        {
            creatureList = creatureList.OrderByDescending(o => o.GetInitiative()).ToList();
            creatureListBox.DataSource = creatureList;
        }

        //Function to update the loaded creature health label after the health is changed
        public void updateHpLabel()
        {
            Creature creature = creatureListBox.SelectedItem as Creature;
            HPLabel.Text = creature.GetCurrentHP().ToString() + "/" + creature.GetMaxHP().ToString();
        }

        // Function which loads given creatures data into several labels
        private void loadEntity(Creature creature)
        {
            // Display the creature's name, description, and stats in the form
            if (creature != null)
            {
                nameLabel.Text = creature.GetName();
                descriptionLabel.Text = creature.GetDescription();
                strengthLabel.Text = creature.GetStr().ToString();
                dexterityLabel.Text = creature.GetDex().ToString();
                constitutionLabel.Text = creature.GetCon().ToString();
                intelligenceLabel.Text = creature.GetInt().ToString();
                wisdomLabel.Text = creature.GetWis().ToString();
                charismaLabel.Text = creature.GetCha().ToString();
                ACLabel.Text = creature.GetAC().ToString();
                initLabel.Text = creature.GetInitiative().ToString();
                tempHPLabel.Text = creature.GetTempHP().ToString();
                HPLabel.Text = creature.GetCurrentHP().ToString() + "/" + creature.GetMaxHP().ToString();
                addHpButton.Show();
                subtractHpButton.Show();
                
                // If the edit popup form is open, update it with the values of the
                // selected creature, so it can be edited
                if (editForm != null)
                {
                    editForm.nameTextBox.Text = creature.GetName();
                    editForm.descriptionTextBox.Text = creature.GetDescription();
                    editForm.strengthNumericUpDown.Value = creature.GetStr();
                    editForm.dexterityNumericUpDown.Value = creature.GetDex();
                    editForm.constitutionNumericUpDown.Value = creature.GetCon();
                    editForm.intelligenceNumericUpDown.Value = creature.GetInt();
                    editForm.wisdomNumericUpDown.Value = creature.GetWis();
                    editForm.charismaNumericUpDown.Value = creature.GetCha();
                    editForm.initiativeNumericUpDown.Value = creature.GetInitiative();
                    editForm.hitPointsNumericUpDown.Value = creature.GetMaxHP();
                    editForm.acNumericUpDown.Value = creature.GetAC();
                }
            }
        }

        // Function that will add a creature to the creature list when the "Add Enity" button is clicked
        private void addCreatureButton_Click(object sender, EventArgs e)
        {
            // Create a new creature with the given name, description, and stats
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            byte strength = (byte)strengthNumericUpDown.Value;
            byte dexterity = (byte)dexterityNumericUpDown.Value;
            byte constitution = (byte)constitutionNumericUpDown.Value;
            byte intelligence = (byte)intelligenceNumericUpDown.Value;
            byte wisdom = (byte)wisdomNumericUpDown.Value;
            byte charisma = (byte)charismaNumericUpDown.Value;
            byte initiative = (byte)initiativeNumericUpDown.Value;
            Creature creature = new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma);
            creature.SetInitiative(initiative);

            // Add the creature to the list
            creatureList.Add(creature);

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

            // Display the newly added creature to the list on the left for clear input feedback
            creatureListBox.DataSource = null;
            creatureListBox.DataSource = creatureList;
            sortCreatureList();
        }

        public void AddtoList( string name, string description, byte strength, byte dexterity, byte constitution, byte intelligence, byte wisdom, byte charisma, byte initiative, byte hp, byte ac)
        {
            Creature creature = new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma);
            creature.SetInitiative(initiative);
            creature.SetMaxHP(hp);
            creature.SetHP(hp);
            creature.SetAC(ac);
            creatureList.Add(creature);
            // Display the newly added creature to the list on the left for clear input feedback
            creatureListBox.DataSource = null;
            creatureListBox.DataSource = creatureList;
            sortCreatureList();
        }

        // A function called by the Edit Form popup form that sorts the creatures, and updates the listbox
        public void editButton_Click(object sender, EventArgs e)
        {
            // Refresh the ListBox with the updated data
            creatureListBox.DataSource = null;
            creatureListBox.DataSource = creatureList;
            sortCreatureList();
        }

        // Function that loads information into the display section whenver a creature is selected from the listbox
        private void creatureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected creature
            Creature selectedCreature = creatureListBox.SelectedItem as Creature;
            if (selectedCreature == null)
            {
                return; // No creature selected
            }

            // Load the selected creature's data into the form
            loadEntity(selectedCreature);
        }

        // Sort list of entities by initative descending
        private void loadCreatureButton_Click(object sender, EventArgs e)
        {
            sortCreatureList();
        }

        // Function that will remove a creature from the creature list when the "removeCreatureButton" button is clicked
        private void removeCreatureButton_Click(object sender, EventArgs e)
        {
            Creature creature = creatureListBox.SelectedItem as Creature;

            if (creature != null)
            {
                creatureList.Remove(creature);
                creatureListBox.DataSource = null;
                creatureListBox.DataSource = creatureList;
            }
        }

        // Function that saves the current encounter to a file with the file extension .enc
        private void saveCreatureButton_Click(object sender, EventArgs e)
        {
            // Save the list of creatures to a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Encounter files (*.enc)|*.enc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Creature creature in creatureList)
                    {
                        writer.WriteLine(creature.Serialize());
                    }
                }
            }
        }

        // Function that loads a file with the file extension .enc and displays the entities in the encounter to be loaded
        private void loadCreatureListButton_Click(object sender, EventArgs e)
        {
            // Load the list of creatures from a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encounter files (*.enc)|*.enc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //creatureList.Clear();
                // Open and read file
                using (System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Creature creature = Creature.Deserialize(line);
                        if (creature != null)
                        {
                            creatureList.Add(creature);
                        }
                    }
                }
                // Display the entities in the npc list
                creatureListBox.DataSource = null;
                creatureListBox.DataSource = creatureList;
                sortCreatureList();
            }
        }

        private void copyMonsterButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                Creature creature = creatureListBox.SelectedItem as Creature;
                Creature copy_creature = creature.make_copy();
                copy_creature.SetName(creature.GetName() + " copy");
                creatureList.Add(copy_creature);
                creatureListBox.DataSource = null;
                creatureListBox.DataSource = creatureList;
            }
        }

        // Function that creates a popup of the EditForm.cs form, and sets this form as it's parent
        private void editMenu_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EditForm
            editForm = new EditForm();

            // Make the popup a child of the main form
            editForm.Owner = this;
            editForm.editButton.BackColor = Settings_button.BackColor;
            // Load the inital data from the listbox into the forms in the pop-up
            creatureListBox_SelectedIndexChanged(sender, e);

            // Display the EditForm as a modal dialog box
            // Create a screen object to determine which monitor the mainGUI is on
            Screen screen = Screen.FromControl(this);

            // Calculate the position of the pop-up form on the same screen
            int x = screen.WorkingArea.Right - editForm.Width * 2;
            int y = screen.WorkingArea.Bottom - editForm.Height * 2;

            // Set the start position and location of the pop-up form
            editForm.StartPosition = FormStartPosition.Manual;
            editForm.Location = new Point(x, y);

            editForm.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void round1_Click(object sender, EventArgs e)
        {
        }

        private void round2_Click(object sender, EventArgs e)
        {
        }

        private void round3_Click(object sender, EventArgs e)
        {
        }

        private void round4_Click(object sender, EventArgs e)
        {
        }

        private void round5_Click(object sender, EventArgs e)
        {
        }

        private void round6_Click(object sender, EventArgs e)
        {
        }

        private void round7_Click(object sender, EventArgs e)
        {
        }

        private void round8_Click(object sender, EventArgs e)
        {
        }

        private void round9_Click(object sender, EventArgs e)
        {
        }

        private void round10_Click(object sender, EventArgs e)
        {
        }

        private void round11_Click(object sender, EventArgs e)
        {
        }

        private void round12_Click(object sender, EventArgs e)
        {
        }

        private void round13_Click(object sender, EventArgs e)
        {
        }

        private void round14_Click(object sender, EventArgs e)
        {
        }

        private void round15_Click(object sender, EventArgs e)
        {
        }

        private void round16_Click(object sender, EventArgs e)
        {
        }

        private void round17_Click(object sender, EventArgs e)
        {
        }

        private void round18_Click(object sender, EventArgs e)
        {
        }

        private void round19_Click(object sender, EventArgs e)
        {
        }

        private void round20_Click(object sender, EventArgs e)
        {
        }

        private void round21_Click(object sender, EventArgs e)
        {
        }

        private void round22_Click(object sender, EventArgs e)
        {
        }

        private void round23_Click(object sender, EventArgs e)
        {
        }

        private void round24_Click(object sender, EventArgs e)
        {
        }

        private void round25_Click(object sender, EventArgs e)
        {
        }

        private void prevRound_Click(object sender, EventArgs e)
        {
            // Decrement the round
            initCounter--;
            // Verify that it wasn't round 1 when the user clicked previous round, if it was, then reset the round to 0
            if (initCounter == -1)
            {
                initCounter = 0;
            }
            // Create a switch statement to determine the active round of combat
            // Format:
            // ACTIVE ROUND - > Change color to green
            // NEXT ROUND - > Ensure it is the default color
            // PREVIOUS ROUND - > Ensure it is the default color
            // Exit case
            switch (initCounter)
            {
                case 1:
                    round1.BackColor = Color.Green;
                    round2.BackColor = Color.Firebrick;
                    round25.BackColor = Color.Firebrick;
                    break;

                case 2:
                    round2.BackColor = Color.Green;
                    round3.BackColor = Color.Firebrick;
                    round1.BackColor = Color.Firebrick;
                    break;

                case 3:
                    round3.BackColor = Color.Green;
                    round4.BackColor = Color.Firebrick;
                    round2.BackColor = Color.Firebrick;
                    break;

                case 4:
                    round4.BackColor = Color.Green;
                    round5.BackColor = Color.Firebrick;
                    round3.BackColor = Color.Firebrick;
                    break;

                case 5:
                    round5.BackColor = Color.Green;
                    round6.BackColor = Color.Firebrick;
                    round4.BackColor = Color.Firebrick;
                    break;

                case 6:
                    round6.BackColor = Color.Green;
                    round7.BackColor = Color.Firebrick;
                    round5.BackColor = Color.Firebrick;
                    break;

                case 7:
                    round7.BackColor = Color.Green;
                    round8.BackColor = Color.Firebrick;
                    round6.BackColor = Color.Firebrick;
                    break;

                case 8:
                    round8.BackColor = Color.Green;
                    round9.BackColor = Color.Firebrick;
                    round7.BackColor = Color.Firebrick;
                    break;

                case 9:
                    round9.BackColor = Color.Green;
                    round10.BackColor = Color.Firebrick;
                    round8.BackColor = Color.Firebrick;
                    break;

                case 10:
                    round10.BackColor = Color.Green;
                    round11.BackColor = Color.Firebrick;
                    round9.BackColor = Color.Firebrick;
                    break;

                case 11:
                    round11.BackColor = Color.Green;
                    round12.BackColor = Color.Firebrick;
                    round10.BackColor = Color.Firebrick;
                    break;

                case 12:
                    round12.BackColor = Color.Green;
                    round13.BackColor = Color.Firebrick;
                    round11.BackColor = Color.Firebrick;
                    break;

                case 13:
                    round13.BackColor = Color.Green;
                    round14.BackColor = Color.Firebrick;
                    round12.BackColor = Color.Firebrick;
                    break;

                case 14:
                    round14.BackColor = Color.Green;
                    round15.BackColor = Color.Firebrick;
                    round13.BackColor = Color.Firebrick;
                    break;

                case 15:
                    round15.BackColor = Color.Green;
                    round16.BackColor = Color.Firebrick;
                    round14.BackColor = Color.Firebrick;
                    break;

                case 16:
                    round16.BackColor = Color.Green;
                    round17.BackColor = Color.Firebrick;
                    round15.BackColor = Color.Firebrick;
                    break;

                case 17:
                    round17.BackColor = Color.Green;
                    round18.BackColor = Color.Firebrick;
                    round16.BackColor = Color.Firebrick;
                    break;

                case 18:
                    round18.BackColor = Color.Green;
                    round19.BackColor = Color.Firebrick;
                    round17.BackColor = Color.Firebrick;
                    break;

                case 19:
                    round19.BackColor = Color.Green;
                    round20.BackColor = Color.Firebrick;
                    round18.BackColor = Color.Firebrick;
                    break;

                case 20:
                    round20.BackColor = Color.Green;
                    round21.BackColor = Color.Firebrick;
                    round19.BackColor = Color.Firebrick;
                    break;

                case 21:
                    round21.BackColor = Color.Green;
                    round22.BackColor = Color.Firebrick;
                    round20.BackColor = Color.Firebrick;
                    break;

                case 22:
                    round22.BackColor = Color.Green;
                    round23.BackColor = Color.Firebrick;
                    round21.BackColor = Color.Firebrick;
                    break;

                case 23:
                    round23.BackColor = Color.Green;
                    round24.BackColor = Color.Firebrick;
                    round22.BackColor = Color.Firebrick;
                    break;

                case 24:
                    round24.BackColor = Color.Green;
                    round25.BackColor = Color.Firebrick;
                    round23.BackColor = Color.Firebrick;
                    break;

                case 25:
                    round25.BackColor = Color.Green;
                    round1.BackColor = Color.Firebrick;
                    round24.BackColor = Color.Firebrick;
                    break;
            }
        }

        private void nextRound_Click(object sender, EventArgs e)
        {
            // Decrement the round
            initCounter++;
            // Verify that it wasn't round 1 when the user clicked previous round, if it was, then reset the round to 0
            if (initCounter == 26)
            {
                initCounter = 1;
            }
            // Create a switch statement to determine the active round of combat
            // Format:
            // ACTIVE ROUND - > Change color to green
            // NEXT ROUND - > Ensure it is the default color
            // PREVIOUS ROUND - > Ensure it is the default color
            // Exit case
            switch (initCounter)
            {
                case 1:
                    round1.BackColor = Color.Green;
                    round2.BackColor = Color.Firebrick;
                    round25.BackColor = Color.Firebrick;
                    break;

                case 2:
                    round2.BackColor = Color.Green;
                    round3.BackColor = Color.Firebrick;
                    round1.BackColor = Color.Firebrick;
                    break;

                case 3:
                    round3.BackColor = Color.Green;
                    round4.BackColor = Color.Firebrick;
                    round2.BackColor = Color.Firebrick;
                    break;

                case 4:
                    round4.BackColor = Color.Green;
                    round5.BackColor = Color.Firebrick;
                    round3.BackColor = Color.Firebrick;
                    break;

                case 5:
                    round5.BackColor = Color.Green;
                    round6.BackColor = Color.Firebrick;
                    round4.BackColor = Color.Firebrick;
                    break;

                case 6:
                    round6.BackColor = Color.Green;
                    round7.BackColor = Color.Firebrick;
                    round5.BackColor = Color.Firebrick;
                    break;

                case 7:
                    round7.BackColor = Color.Green;
                    round8.BackColor = Color.Firebrick;
                    round6.BackColor = Color.Firebrick;
                    break;

                case 8:
                    round8.BackColor = Color.Green;
                    round9.BackColor = Color.Firebrick;
                    round7.BackColor = Color.Firebrick;
                    break;

                case 9:
                    round9.BackColor = Color.Green;
                    round10.BackColor = Color.Firebrick;
                    round8.BackColor = Color.Firebrick;
                    break;

                case 10:
                    round10.BackColor = Color.Green;
                    round11.BackColor = Color.Firebrick;
                    round9.BackColor = Color.Firebrick;
                    break;

                case 11:
                    round11.BackColor = Color.Green;
                    round12.BackColor = Color.Firebrick;
                    round10.BackColor = Color.Firebrick;
                    break;

                case 12:
                    round12.BackColor = Color.Green;
                    round13.BackColor = Color.Firebrick;
                    round11.BackColor = Color.Firebrick;
                    break;

                case 13:
                    round13.BackColor = Color.Green;
                    round14.BackColor = Color.Firebrick;
                    round12.BackColor = Color.Firebrick;
                    break;

                case 14:
                    round14.BackColor = Color.Green;
                    round15.BackColor = Color.Firebrick;
                    round13.BackColor = Color.Firebrick;
                    break;

                case 15:
                    round15.BackColor = Color.Green;
                    round16.BackColor = Color.Firebrick;
                    round14.BackColor = Color.Firebrick;
                    break;

                case 16:
                    round16.BackColor = Color.Green;
                    round17.BackColor = Color.Firebrick;
                    round15.BackColor = Color.Firebrick;
                    break;

                case 17:
                    round17.BackColor = Color.Green;
                    round18.BackColor = Color.Firebrick;
                    round16.BackColor = Color.Firebrick;
                    break;

                case 18:
                    round18.BackColor = Color.Green;
                    round19.BackColor = Color.Firebrick;
                    round17.BackColor = Color.Firebrick;
                    break;

                case 19:
                    round19.BackColor = Color.Green;
                    round20.BackColor = Color.Firebrick;
                    round18.BackColor = Color.Firebrick;
                    break;

                case 20:
                    round20.BackColor = Color.Green;
                    round21.BackColor = Color.Firebrick;
                    round19.BackColor = Color.Firebrick;
                    break;

                case 21:
                    round21.BackColor = Color.Green;
                    round22.BackColor = Color.Firebrick;
                    round20.BackColor = Color.Firebrick;
                    break;

                case 22:
                    round22.BackColor = Color.Green;
                    round23.BackColor = Color.Firebrick;
                    round21.BackColor = Color.Firebrick;
                    break;

                case 23:
                    round23.BackColor = Color.Green;
                    round24.BackColor = Color.Firebrick;
                    round22.BackColor = Color.Firebrick;
                    break;

                case 24:
                    round24.BackColor = Color.Green;
                    round25.BackColor = Color.Firebrick;
                    round23.BackColor = Color.Firebrick;
                    break;

                case 25:
                    round25.BackColor = Color.Green;
                    round1.BackColor = Color.Firebrick;
                    round24.BackColor = Color.Firebrick;
                    break;
            }
        }

        private void mainGUI_Load(object sender, EventArgs e)
        {
        }

        private void mainGUI_Resize(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void INT_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dexterityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void strengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            if (Settings_group_box.Visible == true)
            {
                Settings_group_box.Visible = false;
                Color_choices.Visible = false;
            }
            else
                Settings_group_box.Visible = true;
        }

        private void Change_Bcolor_Click(object sender, EventArgs e)
        {
            if (Color_choices.Visible == true)
            {
                Color_choices.Visible = false;
            }
            else
                Color_choices.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void AddEntityButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EditForm
            AddForm = new AddEntity();

            // Make the popup a child of the main form
            AddForm.Owner = this;
            AddForm.AddButton.BackColor = Settings_button.BackColor;
            // Display the EditForm as a modal dialog box
            // Create a screen object to determine which monitor the mainGUI is on
            Screen screen = Screen.FromControl(this);

            // Calculate the position of the pop-up form on the same screen
            int x = screen.WorkingArea.Right - AddForm.Width * 2;
            int y = screen.WorkingArea.Bottom - AddForm.Height * 2;

            // Set the start position and location of the pop-up form
            AddForm.StartPosition = FormStartPosition.Manual;
            AddForm.Location = new Point(x, y);

            AddForm.Show();
        }

        private void AddStatusEffect_Click(object sender, EventArgs e)
        {
            //Create a new instance of AddStatusEffect
            AddStatus = new AddStatusEffect();

            //Make the popup a child of the main form
            AddStatus.Owner = this;

            //Display the AddStatusEffect form as a modal dialogue box
            //Create a screen object to find the monitor the GUI is on
            Screen screen = Screen.FromControl(this);

            //Set the pop-up's position on the same screen
            int x = screen.WorkingArea.Right - AddStatus.Width * 2;
            int y = screen.WorkingArea.Bottom - AddStatus.Height * 2;

            //Set the start position of the pop-up
            AddStatus.StartPosition = FormStartPosition.Manual;
            AddStatus.Location = new Point(x, y);

            AddStatus.Show();
         }
        private void setColor()
        {
            prevRound.BackColor = Color.FromArgb(r,g,b);
            nextRound.BackColor = Color.FromArgb(r, g, b);
            sortEntitiesButton.BackColor = Color.FromArgb(r, g, b);
            Copy_monster.BackColor = Color.FromArgb(r, g, b);
            removeCreatureButton.BackColor = Color.FromArgb(r, g, b);
            button5.BackColor = Color.FromArgb(r, g, b);
            AddEntityButton.BackColor = Color.FromArgb(r, g, b);
            button8.BackColor = Color.FromArgb(r, g, b);
            button10.BackColor = Color.FromArgb(r, g, b);
            AddStatusEffect.BackColor = Color.FromArgb(r, g, b);
            addCreatureButton.BackColor = Color.FromArgb(r, g, b);
            editMenuButton.BackColor = Color.FromArgb(r, g, b);
            saveCreatureButton.BackColor = Color.FromArgb(r, g, b);
            loadCreatureListButton.BackColor = Color.FromArgb(r, g, b);
            Settings_button.BackColor = Color.FromArgb(r, g, b);
            Change_Bcolor.BackColor = Color.FromArgb(r, g, b);
        }

        private void ScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            r = ScrollRed.Value;
            setColor();
        }

        private void ScrollGreen_Scroll(object sender, ScrollEventArgs e)
        {
            g = ScrollGreen.Value;
            setColor();
        }
        private void ScrollBlue_Scroll(object sender, ScrollEventArgs e)
        {
            b = ScrollBlue.Value;
            setColor();
        }

        private void addHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to increase the health by?", "ADD");

                // Make the popup a child of the main form
                addHealth.Owner = this;

                // Display the EditForm as a modal dialog box
                // Create a screen object to determine which monitor the mainGUI is on
                Screen screen = Screen.FromControl(this);

                // Calculate the position of the pop-up form on the same screen
                int x = screen.WorkingArea.Right - addHealth.Width * 2;
                int y = screen.WorkingArea.Bottom - addHealth.Height * 2;

                // Set the start position and location of the pop-up form
                addHealth.StartPosition = FormStartPosition.Manual;
                addHealth.Location = new Point(x, y);

                addHealth.Show();

            }

        }

        private void subtractHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to decrease the health by?", "SUB");

                // Make the popup a child of the main form
                addHealth.Owner = this;

                // Display the EditForm as a modal dialog box
                // Create a screen object to determine which monitor the mainGUI is on
                Screen screen = Screen.FromControl(this);

                // Calculate the position of the pop-up form on the same screen
                int x = screen.WorkingArea.Right - addHealth.Width * 2;
                int y = screen.WorkingArea.Bottom - addHealth.Height * 2;

                // Set the start position and location of the pop-up form
                addHealth.StartPosition = FormStartPosition.Manual;
                addHealth.Location = new Point(x, y);

                addHealth.Show();
            }
        }
    }
}