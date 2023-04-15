using System.Text;

namespace GroupProject
{
    public partial class mainGUI : Form
    {
        private int initCounter = 0;    // Counter to track the active round of initative
        private List<Creature> creatureList = new List<Creature>(); // Create a list of creatures
        private EditForm editForm;  // A EditForm variable editForm that allows functions to access members of the edit form
        private AddEntity AddForm;  // A AddEntity variable AddForm that allows functions to access members of the add form
        private MonManForm monsterForm; // A MomManForm variable monsterForm that creates a pop up containing a list of every creature from the monster manual
        private AddStatusEffect AddStatus; //An AddStatusEffect variable that allows functions to create the Add Status Effect form
        private int r = 0, g = 0, b = 0;
        private Rectangle OriginalRectangleEntity;
        private Rectangle OriginalFormSize;
        private HPForm addHealth;

        // Constructor
        public mainGUI()
        {
            InitializeComponent();
            clearDisplay();
        }

        //Helper function that sorts creature list by initiative
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
            tempHPLabel.Text = creature.GetTempHP().ToString();
            sortCreatureList();
        }

        // Function that clears out all info displayed in the information groupbox
        public void clearDisplay()
        {
            nameLabel.Text = "";
            descriptionLabel.Text = "";
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
            addHpButton.Hide();
            subtractHpButton.Hide();
            addTempHpButton.Hide();
            subtractTempHpButton.Hide();
            RemoveStatus.Hide();
            AddStatusEffect.Hide();
            statusListBox.Hide();
        }

        //Sets the description box in a way which uses RTF
        private void setDescription(string desc)
        {
            StringBuilder text = new StringBuilder();

            //append format header information;
            text.Append(@"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}" + @"{\f1\fnil Microsoft Sans Serif;}}\viewkind4\uc1\pard\lang2052\f0\fs17");

            //Add description
            text.Append(desc);

            //Replace necessary characters
            text.Replace("<p>", "<p> ");
            text.Replace("<p>", "");
            text.Replace("</p>", "\\par\\par");
            text.Replace("<em>", "\\i");
            text.Replace("</em>", "\\i0");
            text.Replace("<strong>", "<strong> ");
            text.Replace("<strong>", "\\b");
            text.Replace("</strong>", "\\b0");

            // the end
            text.Append(@"}");

            descriptionLabel.Rtf = text.ToString();
        }

        // Function which loads given creatures data into several labels
        private void loadEntity(Creature creature)
        {
            // Display the creature's name, description, and stats in the form
            if (creature != null)
            {
                nameLabel.Text = creature.GetName();
                setDescription(creature.GetDescription());
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
                statusListBox.DataSource = null;
                statusListBox.DataSource = creature.StatusEffects;
                addTempHpButton.Show();
                subtractTempHpButton.Show();
                RemoveStatus.Show();
                AddStatusEffect.Show();
                statusListBox.Show();

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

        // Creatures a creature with the given inputs and adds it to the list of creatures
        public void AddtoList(string name, string description, byte strength, byte dexterity, byte constitution, byte intelligence, byte wisdom, byte charisma, byte initiative, int hp, byte ac)
        {
            //Create creature and add to list
            Creature creature = new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma, hp, ac, initiative);
            creatureList.Add(creature);

            // Display the newly added creature to the list on the left for clear input feedback
            creatureListBox.DataSource = null;
            creatureListBox.DataSource = creatureList;
            sortCreatureList();
        }

        // Add a status effect to the status effect list
        public void AddtoStatusList(StatusEffect newStatEffect)
        {
            Creature creature = (Creature)creatureListBox.SelectedItem;
            creature.StatusEffects.Add(newStatEffect);
            //Display the newly added status effect to the list
            statusListBox.DataSource = null;
            statusListBox.DataSource = creature.StatusEffects;
        }

        // Display information about status effect
        public void displayEffectDetails(StatusEffect displayEffect)
        {
            displayEffect.DisplayStatusInfo();
        }

        // Show details of a status effect when it is double clicked
        private void statusListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StatusEffect selectedEffect = (StatusEffect)statusListBox.SelectedItem;
            if (selectedEffect == null)
            {
                return; //If therer is no selected effect, return nothing
            }

            //Display selected status affect's details
            selectedEffect.DisplayStatusInfo();
        }

        //Remove Status Effect from list
        private void RemoveStatus_Click(object sender, EventArgs e)
        {
            Creature creature = (Creature)creatureListBox.SelectedItem;
            StatusEffect selectedEffect = (StatusEffect)statusListBox.SelectedItem;
            if (selectedEffect != null)
            {
                creature.StatusEffects.Remove(selectedEffect);
                statusListBox.DataSource = null;
                statusListBox.DataSource = creature.StatusEffects;
            }
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete this creature?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    creatureList.Remove(creature);
                    creatureListBox.DataSource = null;
                    creatureListBox.DataSource = creatureList;
                    clearDisplay();
                }
            }
        }

        // Removes all entities from the creature list
        private void deleteEncounterButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all creatures?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                clearDisplay();
                creatureListBox.DataSource = null;
                creatureList.Clear();
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

        //Allows user to load a pre-existing encounter
        private void loadEncounterFile()
        {
            // Load the list of creatures from a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encounter files (*.enc)|*.enc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
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
                // Display the entities in the entity list
                creatureListBox.DataSource = null;
                creatureListBox.DataSource = creatureList;
                sortCreatureList();
            }
        }

        // Function that loads a file with the file extension .enc and displays the entities in the encounter to be loaded
        //CLears out previous encounter before new one loads
        private void loadCreatureListButton_Click(object sender, EventArgs e)
        {
            // Clear out the previous encounter, to over-ride it with the newly loaded one
            creatureList.Clear();
            // Load the new encounter
            loadEncounterFile();
        }

        // Function that loads a file with the file extension .enc and appends the loaded file to the current encounter
        //Similar to above but does not clear previous encounter
        private void loadGroupButton_Click(object sender, EventArgs e)
        {
            // Append a loaded encounter to the current displayed encounter
            loadEncounterFile();
        }

        //Creates a copy of the selected monster
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
            sortCreatureList();
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

        //Goes to previous round, changing the buttons as necessary
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
                    round2.BackColor = Settings_button.BackColor;
                    round25.BackColor = Settings_button.BackColor;
                    break;

                case 2:
                    round2.BackColor = Color.Green;
                    round3.BackColor = Settings_button.BackColor;
                    round1.BackColor = Settings_button.BackColor;
                    break;

                case 3:
                    round3.BackColor = Color.Green;
                    round4.BackColor = Settings_button.BackColor;
                    round2.BackColor = Settings_button.BackColor;
                    break;

                case 4:
                    round4.BackColor = Color.Green;
                    round5.BackColor = Settings_button.BackColor;
                    round3.BackColor = Settings_button.BackColor;
                    break;

                case 5:
                    round5.BackColor = Color.Green;
                    round6.BackColor = Settings_button.BackColor;
                    round4.BackColor = Settings_button.BackColor;
                    break;

                case 6:
                    round6.BackColor = Color.Green;
                    round7.BackColor = Settings_button.BackColor;
                    round5.BackColor = Settings_button.BackColor;
                    break;

                case 7:
                    round7.BackColor = Color.Green;
                    round8.BackColor = Settings_button.BackColor;
                    round6.BackColor = Settings_button.BackColor;
                    break;

                case 8:
                    round8.BackColor = Color.Green;
                    round9.BackColor = Settings_button.BackColor;
                    round7.BackColor = Settings_button.BackColor;
                    break;

                case 9:
                    round9.BackColor = Color.Green;
                    round10.BackColor = Settings_button.BackColor;
                    round8.BackColor = Settings_button.BackColor;
                    break;

                case 10:
                    round10.BackColor = Color.Green;
                    round11.BackColor = Settings_button.BackColor;
                    round9.BackColor = Settings_button.BackColor;
                    break;

                case 11:
                    round11.BackColor = Color.Green;
                    round12.BackColor = Settings_button.BackColor;
                    round10.BackColor = Settings_button.BackColor;
                    break;

                case 12:
                    round12.BackColor = Color.Green;
                    round13.BackColor = Settings_button.BackColor;
                    round11.BackColor = Settings_button.BackColor;
                    break;

                case 13:
                    round13.BackColor = Color.Green;
                    round14.BackColor = Settings_button.BackColor;
                    round12.BackColor = Settings_button.BackColor;
                    break;

                case 14:
                    round14.BackColor = Color.Green;
                    round15.BackColor = Settings_button.BackColor;
                    round13.BackColor = Settings_button.BackColor;
                    break;

                case 15:
                    round15.BackColor = Color.Green;
                    round16.BackColor = Settings_button.BackColor;
                    round14.BackColor = Settings_button.BackColor;
                    break;

                case 16:
                    round16.BackColor = Color.Green;
                    round17.BackColor = Settings_button.BackColor;
                    round15.BackColor = Settings_button.BackColor;
                    break;

                case 17:
                    round17.BackColor = Color.Green;
                    round18.BackColor = Settings_button.BackColor;
                    round16.BackColor = Settings_button.BackColor;
                    break;

                case 18:
                    round18.BackColor = Color.Green;
                    round19.BackColor = Settings_button.BackColor;
                    round17.BackColor = Settings_button.BackColor;
                    break;

                case 19:
                    round19.BackColor = Color.Green;
                    round20.BackColor = Settings_button.BackColor;
                    round18.BackColor = Settings_button.BackColor;
                    break;

                case 20:
                    round20.BackColor = Color.Green;
                    round21.BackColor = Settings_button.BackColor;
                    round19.BackColor = Settings_button.BackColor;
                    break;

                case 21:
                    round21.BackColor = Color.Green;
                    round22.BackColor = Settings_button.BackColor;
                    round20.BackColor = Settings_button.BackColor;
                    break;

                case 22:
                    round22.BackColor = Color.Green;
                    round23.BackColor = Settings_button.BackColor;
                    round21.BackColor = Settings_button.BackColor;
                    break;

                case 23:
                    round23.BackColor = Color.Green;
                    round24.BackColor = Settings_button.BackColor;
                    round22.BackColor = Settings_button.BackColor;
                    break;

                case 24:
                    round24.BackColor = Color.Green;
                    round25.BackColor = Settings_button.BackColor;
                    round23.BackColor = Settings_button.BackColor;
                    break;

                case 25:
                    round25.BackColor = Color.Green;
                    round1.BackColor = Settings_button.BackColor;
                    round24.BackColor = Settings_button.BackColor;
                    break;
            }
        }

        //Goes to next round, changing the buttons as necessary
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
                    round2.BackColor = Settings_button.BackColor;
                    round25.BackColor = Settings_button.BackColor;
                    break;

                case 2:
                    round2.BackColor = Color.Green;
                    round3.BackColor = Settings_button.BackColor;
                    round1.BackColor = Settings_button.BackColor;
                    break;

                case 3:
                    round3.BackColor = Color.Green;
                    round4.BackColor = Settings_button.BackColor;
                    round2.BackColor = Settings_button.BackColor;
                    break;

                case 4:
                    round4.BackColor = Color.Green;
                    round5.BackColor = Settings_button.BackColor;
                    round3.BackColor = Settings_button.BackColor;
                    break;

                case 5:
                    round5.BackColor = Color.Green;
                    round6.BackColor = Settings_button.BackColor;
                    round4.BackColor = Settings_button.BackColor;
                    break;

                case 6:
                    round6.BackColor = Color.Green;
                    round7.BackColor = Settings_button.BackColor;
                    round5.BackColor = Settings_button.BackColor;
                    break;

                case 7:
                    round7.BackColor = Color.Green;
                    round8.BackColor = Settings_button.BackColor;
                    round6.BackColor = Settings_button.BackColor;
                    break;

                case 8:
                    round8.BackColor = Color.Green;
                    round9.BackColor = Settings_button.BackColor;
                    round7.BackColor = Settings_button.BackColor;
                    break;

                case 9:
                    round9.BackColor = Color.Green;
                    round10.BackColor = Settings_button.BackColor;
                    round8.BackColor = Settings_button.BackColor;
                    break;

                case 10:
                    round10.BackColor = Color.Green;
                    round11.BackColor = Settings_button.BackColor;
                    round9.BackColor = Settings_button.BackColor;
                    break;

                case 11:
                    round11.BackColor = Color.Green;
                    round12.BackColor = Settings_button.BackColor;
                    round10.BackColor = Settings_button.BackColor;
                    break;

                case 12:
                    round12.BackColor = Color.Green;
                    round13.BackColor = Settings_button.BackColor;
                    round11.BackColor = Settings_button.BackColor;
                    break;

                case 13:
                    round13.BackColor = Color.Green;
                    round14.BackColor = Settings_button.BackColor;
                    round12.BackColor = Settings_button.BackColor;
                    break;

                case 14:
                    round14.BackColor = Color.Green;
                    round15.BackColor = Settings_button.BackColor;
                    round13.BackColor = Settings_button.BackColor;
                    break;

                case 15:
                    round15.BackColor = Color.Green;
                    round16.BackColor = Settings_button.BackColor;
                    round14.BackColor = Settings_button.BackColor;
                    break;

                case 16:
                    round16.BackColor = Color.Green;
                    round17.BackColor = Settings_button.BackColor;
                    round15.BackColor = Settings_button.BackColor;
                    break;

                case 17:
                    round17.BackColor = Color.Green;
                    round18.BackColor = Settings_button.BackColor;
                    round16.BackColor = Settings_button.BackColor;
                    break;

                case 18:
                    round18.BackColor = Color.Green;
                    round19.BackColor = Settings_button.BackColor;
                    round17.BackColor = Settings_button.BackColor;
                    break;

                case 19:
                    round19.BackColor = Color.Green;
                    round20.BackColor = Settings_button.BackColor;
                    round18.BackColor = Settings_button.BackColor;
                    break;

                case 20:
                    round20.BackColor = Color.Green;
                    round21.BackColor = Settings_button.BackColor;
                    round19.BackColor = Settings_button.BackColor;
                    break;

                case 21:
                    round21.BackColor = Color.Green;
                    round22.BackColor = Settings_button.BackColor;
                    round20.BackColor = Settings_button.BackColor;
                    break;

                case 22:
                    round22.BackColor = Color.Green;
                    round23.BackColor = Settings_button.BackColor;
                    round21.BackColor = Settings_button.BackColor;
                    break;

                case 23:
                    round23.BackColor = Color.Green;
                    round24.BackColor = Settings_button.BackColor;
                    round22.BackColor = Settings_button.BackColor;
                    break;

                case 24:
                    round24.BackColor = Color.Green;
                    round25.BackColor = Settings_button.BackColor;
                    round23.BackColor = Settings_button.BackColor;
                    break;

                case 25:
                    round25.BackColor = Color.Green;
                    round1.BackColor = Settings_button.BackColor;
                    round24.BackColor = Settings_button.BackColor;
                    break;
            }
        }

        //Opens the settings menu
        private void Settings_button_Click(object sender, EventArgs e)
        {
            // Make GroupBox with settings buttons visible.
            if (Settings_group_box.Visible == true)
            {
                Settings_group_box.Visible = false;
                Color_choices.Visible = false;
            }
            else
                Settings_group_box.Visible = true;
        }

        //Open the menu to change button colors
        private void Change_Bcolor_Click(object sender, EventArgs e)
        {
            // Make GroupBox with RGB scrollbars visible.
            if (Color_choices.Visible == true)
            {
                Color_choices.Visible = false;
            }
            else
                Color_choices.Visible = true;
        }

        //Creates pop up form for creating a new entity
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

        //Creates new menu for adding a status effect
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
        //Gets currently selected rgb values and sets all the buttons to that color
        private void setColor()
        {
            // Sets color of all buttons based on the scroll bars.
            prevRound.BackColor = Color.FromArgb(r, g, b);
            nextRound.BackColor = Color.FromArgb(r, g, b);
            sortEntitiesButton.BackColor = Color.FromArgb(r, g, b);
            Copy_monster.BackColor = Color.FromArgb(r, g, b);
            removeCreatureButton.BackColor = Color.FromArgb(r, g, b);
            deleteEncounterButton.BackColor = Color.FromArgb(r, g, b);
            AddEntityButton.BackColor = Color.FromArgb(r, g, b);
            monsterButton.BackColor = Color.FromArgb(r, g, b);
            loadCreatureListButton.BackColor = Color.FromArgb(r, g, b);
            AddStatusEffect.BackColor = Color.FromArgb(r, g, b);
            loadGroupButton.BackColor = Color.FromArgb(r, g, b);
            editMenuButton.BackColor = Color.FromArgb(r, g, b);
            saveCreatureButton.BackColor = Color.FromArgb(r, g, b);
            loadCreatureListButton.BackColor = Color.FromArgb(r, g, b);
            Settings_button.BackColor = Color.FromArgb(r, g, b);
            Change_Bcolor.BackColor = Color.FromArgb(r, g, b);
            loadGroupButton.BackColor = Color.FromArgb(r, g, b);
            Change_Pic.BackColor = Color.FromArgb(r, g, b);
            addHpButton.BackColor = Color.FromArgb(r, g, b);
            subtractHpButton.BackColor = Color.FromArgb(r, g, b);
            NextTurn.BackColor = Color.FromArgb(r, g, b);
            addTempHpButton.BackColor = Color.FromArgb(r, g, b);
            subtractTempHpButton.BackColor = Color.FromArgb(r, g, b);
            RemoveStatus.BackColor = Color.FromArgb(r, g, b);
            // Round Colors
            round1.BackColor = Color.FromArgb(r, g, b);
            round2.BackColor = Color.FromArgb(r, g, b);
            round3.BackColor = Color.FromArgb(r, g, b);
            round4.BackColor = Color.FromArgb(r, g, b);
            round5.BackColor = Color.FromArgb(r, g, b);
            round6.BackColor = Color.FromArgb(r, g, b);
            round7.BackColor = Color.FromArgb(r, g, b);
            round8.BackColor = Color.FromArgb(r, g, b);
            round9.BackColor = Color.FromArgb(r, g, b);
            round10.BackColor = Color.FromArgb(r, g, b);
            round11.BackColor = Color.FromArgb(r, g, b);
            round12.BackColor = Color.FromArgb(r, g, b);
            round13.BackColor = Color.FromArgb(r, g, b);
            round14.BackColor = Color.FromArgb(r, g, b);
            round15.BackColor = Color.FromArgb(r, g, b);
            round16.BackColor = Color.FromArgb(r, g, b);
            round17.BackColor = Color.FromArgb(r, g, b);
            round18.BackColor = Color.FromArgb(r, g, b);
            round19.BackColor = Color.FromArgb(r, g, b);
            round20.BackColor = Color.FromArgb(r, g, b);
            round21.BackColor = Color.FromArgb(r, g, b);
            round22.BackColor = Color.FromArgb(r, g, b);
            round23.BackColor = Color.FromArgb(r, g, b);
            round24.BackColor = Color.FromArgb(r, g, b);
            round25.BackColor = Color.FromArgb(r, g, b);
        }

        //Gets red color from scrool bar
        private void ScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            r = ScrollRed.Value;
            setColor();
        }

        //Gets green color from scrool bar
        private void ScrollGreen_Scroll(object sender, ScrollEventArgs e)
        {
            g = ScrollGreen.Value;
            setColor();
        }

        //Gets blue color from scrool bar
        private void ScrollBlue_Scroll(object sender, ScrollEventArgs e)
        {
            b = ScrollBlue.Value;
            setColor();
        }

        //Allows user to change background color
        private void Change_Pic_Click(object sender, EventArgs e)
        {
            // Try and catch in case of error
            try
            {
                // Get Image
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)| *.jpg| PNG files(*.png)| *.png";

                // Set Form background picture to picture selected by user.
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackgroundImage = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Image needs to be .jpg or .png", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Opens up monster manual form
        private void monsterButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EditForm
            monsterForm = new MonManForm();

            // Make the popup a child of the main form
            monsterForm.Owner = this;
            monsterForm.addMonsterButton.BackColor = Settings_button.BackColor;

            // Display the EditForm as a modal dialog box
            // Create a screen object to determine which monitor the mainGUI is on
            Screen screen = Screen.FromControl(this);

            // Calculate the position of the pop-up form on the same screen
            int x = screen.WorkingArea.Right - monsterForm.Width * 2;
            int y = screen.WorkingArea.Bottom - monsterForm.Height * 2;

            // Set the start position and location of the pop-up form
            monsterForm.StartPosition = FormStartPosition.Manual;
            monsterForm.Location = new Point(x, y);

            monsterForm.Show();
        }

        //Pops up temp hp form
        private void addTempHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to increase the health by?", "ADD", "TEMP");

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

        //Pops up temp hp form
        private void subtractTempHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to decrease the health by?", "SUB", "TEMP");

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

        //Opens up add health form
        private void addHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to increase the health by?", "ADD", "NORMAL");

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

        //Opens up subtract health form
        private void subtractHpButton_Click(object sender, EventArgs e)
        {
            if (creatureListBox.SelectedItem != null)
            {
                // Create a new instance of the HpForm
                addHealth = new HPForm("How much would like to decrease the health by?", "SUB", "NORMAL");

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

        private void NextTurn_Click(object sender, EventArgs e)
        {
            string saves = "";
            Creature thisGuy = (Creature)creatureListBox.SelectedItem;
            //Search the creature's status effect list and compile its EoT saves
            saves = findEoTSaves(thisGuy.StatusEffects);

            //If selected creature has a saving throw to make at the end of the turn, display alert
            if(saves != "")
            {
                MessageBox.Show($"{thisGuy.GetName()} needs to make the following saving throw(s):\n" + saves);
            }

            decrementDuration(thisGuy.StatusEffects);

            //Progess the turn to the next creature
            try
            {
                creatureListBox.SelectedIndex += 1;
                thisGuy = (Creature)creatureListBox.SelectedItem;
            }
            catch (ArgumentOutOfRangeException)
            {
                creatureListBox.SelectedIndex = 0;
                nextRound_Click(sender, e);
            }

            //Use a try/catch to set the index back to zero if it goes out of range
            //Search the new creature's status effect list and compile its SoT saves
            saves = "";
            saves = findSoTSaves(thisGuy.StatusEffects);

            //If newly selected creature has a saving throw to make at the start of its turn, display alert
            if(saves != "")
            {
                MessageBox.Show($"{thisGuy.GetName()} needs to make the following saving throw(s):\n" + saves);
            }
        }

        private string findEoTSaves(List<StatusEffect> effects)
        {
            string saveList = "";
            foreach (StatusEffect effect in effects)
            {
                if(effect.EndOfTurn == true)
                { saveList += $"{effect.Name}: DC {effect.saveDC} {effect.saveType} Save\n"; }
            }
            return saveList;
        }

        private string findSoTSaves(List<StatusEffect> effects)
        {
            string saveList = "";
            foreach(StatusEffect effect in effects)
            {
                if (effect.StartOfTurn == true)
                { saveList += $"{effect.Name}: DC {effect.saveDC} {effect.saveType} Save\n"; }
            }
            return saveList;
        }

        private void decrementDuration(List<StatusEffect> effects)
        {
            for(int i = 0; i < effects.Count; i++)
            {
                effects[i].Duration -= 1;
            }
            effects.RemoveAll(effect =>  effect.Duration == 0);
        }
    }
}