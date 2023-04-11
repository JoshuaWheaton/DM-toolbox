/*
This code file defines the MonManForm class, which is a form used to display a list of creatures and allow the user to select one to add to another list.
The form loads a list of creatures from a file, displays them in a ListBox control, and allows the user to select one and add it to another list by clicking a button.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class MonManForm : Form
    {
        // Create a list of creatures to be loaded from a file
        private List<Creature> monsterList = new List<Creature>(); // Create a list of creatures
        private List<Creature> searchResults = new List<Creature>(); // New list to store search results
        private string previousSearchText = ""; // Variable to track previous search text

        // Constructor for the MonManForm class
        public MonManForm()
        {
            // Initialize the form components and load the list of creatures from a file
            InitializeComponent();
            loadMonsterFile();
        }

        // Event handler for the "Add" button click event
        // This method retrieves the selected creature from the ListBox control and passes its information to a method in the mainGUI form.
        private void addMonsterButton_Click(object sender, EventArgs e)
        {
            // Get a reference to the main form
            mainGUI parentForm = (mainGUI)this.Owner;

            // Get the currently selected creature from the ListBox control
            Creature selectedCreature = monsterManListBox.SelectedItem as Creature;

            // Call the AddtoList function from the mainGUI form, passing it in the needed information about the selected creature
            parentForm.AddtoList(selectedCreature.GetName(), selectedCreature.GetDescription(), (byte)selectedCreature.GetStr(), (byte)selectedCreature.GetDex(), (byte)selectedCreature.GetCon(), (byte)selectedCreature.GetInt(), (byte)selectedCreature.GetWis(), (byte)selectedCreature.GetCha(), selectedCreature.GetInitiative(), selectedCreature.GetMaxHP(), selectedCreature.GetAC());
        }

        // Method that allows the user to search for a specific monster within the listbox
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Clear the ListBox items
            monsterManListBox.DataSource = null;
            monsterManListBox.Items.Clear();

            // Clear the searchResults list
            searchResults.Clear();

            // Get the search text from the TextBox control
            string searchText = searchBox.Text;

            // If the search text is not empty, search for matching creatures
            if (!string.IsNullOrEmpty(searchText))
            {
                // Loop through the monsterList to find creatures whose name contains the search text
                foreach (Creature creature in monsterList)
                {
                    if (creature.GetName().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        searchResults.Add(creature);
                    }
                }
                // Set the DataSource of the ListBox control to the searchResults list
                monsterManListBox.DataSource = searchResults;

                // Store the current search text
                previousSearchText = searchText;
            }
            // If the search text is empty, restore the original monsterList to the ListBox control
            else
            {
                monsterManListBox.DataSource = monsterList;
            }
        }

        // Method to load the list of creatures from a file and display them in a ListBox control
        private void loadMonsterFile()
        {

            // Get a reference to the main form
            mainGUI parentForm = (mainGUI)this.Owner;

            // Load the list of creatures from a file
            string filePath = "..//..//..//MonsterManual//MonsterManual.enc";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Creature creature = Creature.Deserialize(line);
                    if (creature != null)
                    {
                        // Add each creature to the monsterList
                        monsterList.Add(creature);
                    }
                }
            }

            // Display the entities in the monsterList in the ListBox control
            monsterManListBox.DataSource = null;
            monsterManListBox.DataSource = monsterList;
        }
    }
}
