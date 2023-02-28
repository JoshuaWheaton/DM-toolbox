using DM_Toolkit;
using System.Drawing.Imaging;
using System.Xml;
using static GroupProject.mainGUI;

namespace GroupProject
{
    public partial class mainGUI : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        int initCounter = 0;    // Counter to track the active round of initative

        private List<Creature> creatureList = new List<Creature>(); // Create a list of creatures

        public mainGUI()
        {
            InitializeComponent();
        }

        // Function that will add a creature to the creature list when the "Add Enity" button is clicked
        private void addCreatureButton_Click(object sender, EventArgs e)
        {
            // Create a new creature with the given name, description, and stats
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int strength = (int)strengthNumericUpDown.Value;
            int dexterity = (int)dexterityNumericUpDown.Value;
            int constitution = (int)constitutionNumericUpDown.Value;
            int intelligence = (int)intelligenceNumericUpDown.Value;
            int wisdom = (int)wisdomNumericUpDown.Value;
            int charisma = (int)charismaNumericUpDown.Value;
            Creature creature = new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma);

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

            // Display the newly added creature to the list on the left for clear input feedback
            creatureListBox.DataSource = null;
            creatureListBox.DataSource = creatureList;
        }

        // Function that will display the stats of a creature when the "Load Enity" button is clicked
        private void loadCreatureButton_Click(object sender, EventArgs e)
        {
            // Get the selected creature from the list
            Creature creature = creatureListBox.SelectedItem as Creature;

            // Display the creature's name, description, and stats in the form
            if (creature != null)
            {
                nameLabel.Text = creature.Name;
                descriptionLabel.Text = creature.Description;
                strengthLabel.Text = creature.Strength.ToString();
                dexterityLabel.Text = creature.Dexterity.ToString();
                constitutionLabel.Text = creature.Constitution.ToString();
                intelligenceLabel.Text = creature.Intelligence.ToString();
                wisdomLabel.Text = creature.Wisdom.ToString();
                charismaLabel.Text = creature.Charisma.ToString();
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
                creatureList.Clear();
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
            }
        }

        // Public class that defines what a "Creature" or otherwise sometimes called an "NPC" or "Entity" is
        public class Creature
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
            
            // Constructor, Takes 8 args, Creature Name, Description, and Stats
            public Creature(string name, string description, int strength, int dexterity, int constitution,int intelligence, int wisdom, int charisma)
            {
                Name = name;
                Description = description;
                Strength = strength;
                Dexterity = dexterity;
                Constitution = constitution;
                Intelligence = intelligence;
                Wisdom = wisdom;
                Charisma = charisma;
            }

            public string Serialize()
            {
                return $"{Name}|{Description}|{Strength}|{Dexterity}|{Constitution}|{Intelligence}|{Wisdom}|{Charisma}";
            }

            public static Creature Deserialize(string serializedString)
            {
                string[] parts = serializedString.Split('|');
                if (parts.Length == 8)
                {
                    string name = parts[0];
                    string description = parts[1];
                    int strength = 10;
                    int dexterity = 10;
                    int constitution = 10;
                    int intelligence = 10;
                    int wisdom = 10;
                    int charisma = 10;
                    int.TryParse(parts[2], out strength);
                    int.TryParse(parts[3], out dexterity);
                    int.TryParse(parts[4], out constitution);
                    int.TryParse(parts[5], out intelligence);
                    int.TryParse(parts[6], out wisdom);
                    int.TryParse(parts[7], out charisma);
                    return new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma);
                }
                else
                {
                    return null;
                }
            }

            public override string ToString()
            {
                return Name;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {

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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void mainGUI_Load(object sender, EventArgs e)
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
    }
}