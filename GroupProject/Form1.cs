namespace GroupProject
{
    public partial class mainGUI : Form
    {
        int initCounter = 0;    // Counter to track the active round of initative

        public mainGUI()
        {
            InitializeComponent();
        }

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
    }
}