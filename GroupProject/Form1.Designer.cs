namespace GroupProject
{
    partial class mainGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Copy_monster = new Button();
            prevRound = new Button();
            nextRound = new Button();
            removeCreatureButton = new Button();
            menuGroupBox = new GroupBox();
            loadGroupButton = new Button();
            Settings_button = new Button();
            button8 = new Button();
            AddEntityButton = new Button();
            deleteEncounterButton = new Button();
            saveCreatureButton = new Button();
            loadCreatureListButton = new Button();
            AddStatusEffect = new Button();
            round1 = new Button();
            round2 = new Button();
            round3 = new Button();
            round4 = new Button();
            round8 = new Button();
            round7 = new Button();
            round6 = new Button();
            round5 = new Button();
            round12 = new Button();
            round11 = new Button();
            round10 = new Button();
            round9 = new Button();
            round24 = new Button();
            round23 = new Button();
            round22 = new Button();
            round21 = new Button();
            round20 = new Button();
            round19 = new Button();
            round18 = new Button();
            round17 = new Button();
            round16 = new Button();
            round15 = new Button();
            round14 = new Button();
            round13 = new Button();
            round25 = new Button();
            creatureListBox = new ListBox();
            nameLabel = new Label();
            strengthLabel = new Label();
            dexterityLabel = new Label();
            constitutionLabel = new Label();
            intelligenceLabel = new Label();
            wisdomLabel = new Label();
            charismaLabel = new Label();
            sortEntitiesButton = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            name = new Label();
            label8 = new Label();
            descriptionLabel = new TextBox();
            groupBox2 = new GroupBox();
            RemoveStatus = new Button();
            statusListBox = new ListBox();
            subtractHpButton = new Button();
            addHpButton = new Button();
            div3Label = new Label();
            div2Label = new Label();
            div1Label = new Label();
            editMenuButton = new Button();
            HPLabel = new Label();
            label17 = new Label();
            tempHPLabel = new Label();
            label15 = new Label();
            initLabel = new Label();
            label13 = new Label();
            ACLabel = new Label();
            label10 = new Label();
            entityListGroupBox = new GroupBox();
            diceRollerGroupBox = new GroupBox();
            diceRollerTextBox = new RichTextBox();
            Settings_group_box = new GroupBox();
            Change_Bcolor = new Button();
            Color_choices = new GroupBox();
            ScrollBlue = new HScrollBar();
            ScrollGreen = new HScrollBar();
            ScrollRed = new HScrollBar();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            NextTurn = new Button();
            menuGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            entityListGroupBox.SuspendLayout();
            diceRollerGroupBox.SuspendLayout();
            Settings_group_box.SuspendLayout();
            Color_choices.SuspendLayout();
            SuspendLayout();
            // 
            // Copy_monster
            // 
            Copy_monster.BackColor = Color.Firebrick;
            Copy_monster.FlatStyle = FlatStyle.Flat;
            Copy_monster.ForeColor = SystemColors.ControlLightLight;
            Copy_monster.Location = new Point(137, 595);
            Copy_monster.Margin = new Padding(3, 4, 3, 4);
            Copy_monster.Name = "Copy_monster";
            Copy_monster.Size = new Size(123, 31);
            Copy_monster.TabIndex = 0;
            Copy_monster.Text = " Copy Creature";
            Copy_monster.UseVisualStyleBackColor = false;
            Copy_monster.Click += copyMonsterButton_Click;
            // 
            // prevRound
            // 
            prevRound.BackColor = Color.Firebrick;
            prevRound.FlatStyle = FlatStyle.Flat;
            prevRound.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            prevRound.ForeColor = SystemColors.ControlLightLight;
            prevRound.Location = new Point(31, 48);
            prevRound.Margin = new Padding(3, 4, 3, 4);
            prevRound.Name = "prevRound";
            prevRound.Size = new Size(63, 63);
            prevRound.TabIndex = 3;
            prevRound.Text = "Previous Round";
            prevRound.UseVisualStyleBackColor = false;
            prevRound.Click += prevRound_Click;
            // 
            // nextRound
            // 
            nextRound.BackColor = Color.Firebrick;
            nextRound.FlatStyle = FlatStyle.Flat;
            nextRound.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            nextRound.ForeColor = SystemColors.ControlLightLight;
            nextRound.Location = new Point(971, 48);
            nextRound.Margin = new Padding(3, 4, 3, 4);
            nextRound.Name = "nextRound";
            nextRound.Size = new Size(63, 63);
            nextRound.TabIndex = 4;
            nextRound.Text = "Next Round";
            nextRound.UseVisualStyleBackColor = false;
            nextRound.Click += nextRound_Click;
            // 
            // removeCreatureButton
            // 
            removeCreatureButton.BackColor = Color.Firebrick;
            removeCreatureButton.FlatStyle = FlatStyle.Flat;
            removeCreatureButton.ForeColor = SystemColors.ControlLightLight;
            removeCreatureButton.Location = new Point(291, 595);
            removeCreatureButton.Margin = new Padding(3, 4, 3, 4);
            removeCreatureButton.Name = "removeCreatureButton";
            removeCreatureButton.Size = new Size(95, 31);
            removeCreatureButton.TabIndex = 5;
            removeCreatureButton.Text = "Del Creature";
            removeCreatureButton.UseVisualStyleBackColor = false;
            removeCreatureButton.Click += removeCreatureButton_Click;
            // 
            // menuGroupBox
            // 
            menuGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menuGroupBox.AutoSize = true;
            menuGroupBox.Controls.Add(loadGroupButton);
            menuGroupBox.Controls.Add(Settings_button);
            menuGroupBox.Controls.Add(button8);
            menuGroupBox.Controls.Add(AddEntityButton);
            menuGroupBox.Controls.Add(deleteEncounterButton);
            menuGroupBox.Controls.Add(saveCreatureButton);
            menuGroupBox.Controls.Add(loadCreatureListButton);
            menuGroupBox.Location = new Point(990, 152);
            menuGroupBox.Margin = new Padding(3, 4, 3, 4);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Padding = new Padding(3, 4, 3, 4);
            menuGroupBox.Size = new Size(309, 274);
            menuGroupBox.TabIndex = 6;
            menuGroupBox.TabStop = false;
            menuGroupBox.Text = "Menu";
            menuGroupBox.Enter += groupBox1_Enter;
            // 
            // loadGroupButton
            // 
            loadGroupButton.BackColor = Color.Firebrick;
            loadGroupButton.FlatStyle = FlatStyle.Flat;
            loadGroupButton.ForeColor = SystemColors.ControlLightLight;
            loadGroupButton.Location = new Point(7, 81);
            loadGroupButton.Margin = new Padding(3, 4, 3, 4);
            loadGroupButton.Name = "loadGroupButton";
            loadGroupButton.Size = new Size(121, 31);
            loadGroupButton.TabIndex = 57;
            loadGroupButton.Text = "Add Entity";
            loadGroupButton.UseVisualStyleBackColor = false;
            loadGroupButton.Click += loadGroupButton_Click;
            // 
            // Settings_button
            // 
            Settings_button.BackColor = Color.Firebrick;
            Settings_button.FlatStyle = FlatStyle.Flat;
            Settings_button.ForeColor = SystemColors.ControlLightLight;
            Settings_button.Location = new Point(192, 215);
            Settings_button.Margin = new Padding(3, 4, 3, 4);
            Settings_button.Name = "Settings_button";
            Settings_button.Size = new Size(86, 31);
            Settings_button.TabIndex = 13;
            Settings_button.Text = "Settings";
            Settings_button.UseVisualStyleBackColor = false;
            Settings_button.Click += Settings_button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Firebrick;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(7, 215);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // AddEntityButton
            // 
            AddEntityButton.BackColor = Color.Firebrick;
            AddEntityButton.FlatStyle = FlatStyle.Flat;
            AddEntityButton.ForeColor = SystemColors.ControlLightLight;
            AddEntityButton.Location = new Point(7, 27);
            AddEntityButton.Margin = new Padding(3, 4, 3, 4);
            AddEntityButton.Name = "AddEntityButton";
            AddEntityButton.Size = new Size(121, 31);
            AddEntityButton.TabIndex = 7;
            AddEntityButton.Text = "Create Entity";
            AddEntityButton.UseVisualStyleBackColor = false;
            AddEntityButton.Click += AddEntityButton_Click;
            // 
            // deleteEncounterButton
            // 
            deleteEncounterButton.BackColor = Color.Firebrick;
            deleteEncounterButton.FlatStyle = FlatStyle.Flat;
            deleteEncounterButton.ForeColor = SystemColors.ControlLightLight;
            deleteEncounterButton.Location = new Point(75, 140);
            deleteEncounterButton.Margin = new Padding(3, 4, 3, 4);
            deleteEncounterButton.Name = "deleteEncounterButton";
            deleteEncounterButton.Size = new Size(125, 31);
            deleteEncounterButton.TabIndex = 6;
            deleteEncounterButton.Text = "Del Encounter";
            deleteEncounterButton.UseVisualStyleBackColor = false;
            deleteEncounterButton.Click += deleteEncounterButton_Click;
            // 
            // saveCreatureButton
            // 
            saveCreatureButton.BackColor = Color.Firebrick;
            saveCreatureButton.FlatStyle = FlatStyle.Flat;
            saveCreatureButton.Location = new Point(153, 27);
            saveCreatureButton.Margin = new Padding(3, 4, 3, 4);
            saveCreatureButton.Name = "saveCreatureButton";
            saveCreatureButton.Size = new Size(121, 31);
            saveCreatureButton.TabIndex = 54;
            saveCreatureButton.Text = "Save Encounter";
            saveCreatureButton.UseVisualStyleBackColor = false;
            saveCreatureButton.Click += saveCreatureButton_Click;
            // 
            // loadCreatureListButton
            // 
            loadCreatureListButton.BackColor = Color.Firebrick;
            loadCreatureListButton.FlatStyle = FlatStyle.Flat;
            loadCreatureListButton.Location = new Point(153, 81);
            loadCreatureListButton.Margin = new Padding(3, 4, 3, 4);
            loadCreatureListButton.Name = "loadCreatureListButton";
            loadCreatureListButton.Size = new Size(125, 31);
            loadCreatureListButton.TabIndex = 56;
            loadCreatureListButton.Text = "Load Encounter";
            loadCreatureListButton.UseVisualStyleBackColor = false;
            loadCreatureListButton.Click += loadCreatureListButton_Click;
            // 
            // AddStatusEffect
            // 
            AddStatusEffect.BackColor = Color.Firebrick;
            AddStatusEffect.FlatStyle = FlatStyle.Flat;
            AddStatusEffect.ForeColor = SystemColors.ControlLightLight;
            AddStatusEffect.Location = new Point(399, 81);
            AddStatusEffect.Margin = new Padding(3, 4, 3, 4);
            AddStatusEffect.Name = "AddStatusEffect";
            AddStatusEffect.Size = new Size(86, 31);
            AddStatusEffect.TabIndex = 14;
            AddStatusEffect.Text = "Add";
            AddStatusEffect.UseVisualStyleBackColor = false;
            AddStatusEffect.Click += AddStatusEffect_Click;
            // 
            // round1
            // 
            round1.BackColor = Color.Firebrick;
            round1.FlatStyle = FlatStyle.Popup;
            round1.ForeColor = SystemColors.ControlLightLight;
            round1.Location = new Point(149, 65);
            round1.Margin = new Padding(3, 4, 3, 4);
            round1.Name = "round1";
            round1.Padding = new Padding(1);
            round1.Size = new Size(34, 31);
            round1.TabIndex = 9;
            round1.Text = "1";
            round1.UseVisualStyleBackColor = false;
            round1.Click += round1_Click;
            // 
            // round2
            // 
            round2.BackColor = Color.Firebrick;
            round2.FlatStyle = FlatStyle.Popup;
            round2.Location = new Point(179, 65);
            round2.Margin = new Padding(3, 4, 3, 4);
            round2.Name = "round2";
            round2.Padding = new Padding(1);
            round2.Size = new Size(34, 31);
            round2.TabIndex = 10;
            round2.Text = "2";
            round2.UseVisualStyleBackColor = false;
            round2.Click += round2_Click;
            // 
            // round3
            // 
            round3.BackColor = Color.Firebrick;
            round3.FlatStyle = FlatStyle.Popup;
            round3.Location = new Point(209, 65);
            round3.Margin = new Padding(3, 4, 3, 4);
            round3.Name = "round3";
            round3.Padding = new Padding(1);
            round3.Size = new Size(34, 31);
            round3.TabIndex = 11;
            round3.Text = "3";
            round3.UseVisualStyleBackColor = false;
            round3.Click += round3_Click;
            // 
            // round4
            // 
            round4.BackColor = Color.Firebrick;
            round4.FlatStyle = FlatStyle.Popup;
            round4.Location = new Point(239, 65);
            round4.Margin = new Padding(3, 4, 3, 4);
            round4.Name = "round4";
            round4.Padding = new Padding(1);
            round4.Size = new Size(34, 31);
            round4.TabIndex = 13;
            round4.Text = "4";
            round4.UseVisualStyleBackColor = false;
            round4.Click += round4_Click;
            // 
            // round8
            // 
            round8.BackColor = Color.Firebrick;
            round8.FlatStyle = FlatStyle.Popup;
            round8.Location = new Point(357, 65);
            round8.Margin = new Padding(3, 4, 3, 4);
            round8.Name = "round8";
            round8.Padding = new Padding(1);
            round8.Size = new Size(34, 31);
            round8.TabIndex = 17;
            round8.Text = "8";
            round8.UseVisualStyleBackColor = false;
            round8.Click += round8_Click;
            // 
            // round7
            // 
            round7.BackColor = Color.Firebrick;
            round7.FlatStyle = FlatStyle.Popup;
            round7.Location = new Point(327, 65);
            round7.Margin = new Padding(3, 4, 3, 4);
            round7.Name = "round7";
            round7.Padding = new Padding(1);
            round7.Size = new Size(34, 31);
            round7.TabIndex = 16;
            round7.Text = "7";
            round7.UseVisualStyleBackColor = false;
            round7.Click += round7_Click;
            // 
            // round6
            // 
            round6.BackColor = Color.Firebrick;
            round6.FlatStyle = FlatStyle.Popup;
            round6.Location = new Point(297, 65);
            round6.Margin = new Padding(3, 4, 3, 4);
            round6.Name = "round6";
            round6.Padding = new Padding(1);
            round6.Size = new Size(34, 31);
            round6.TabIndex = 15;
            round6.Text = "6";
            round6.UseVisualStyleBackColor = false;
            round6.Click += round6_Click;
            // 
            // round5
            // 
            round5.BackColor = Color.Firebrick;
            round5.FlatStyle = FlatStyle.Popup;
            round5.Location = new Point(266, 65);
            round5.Margin = new Padding(3, 4, 3, 4);
            round5.Name = "round5";
            round5.Padding = new Padding(1);
            round5.Size = new Size(34, 31);
            round5.TabIndex = 14;
            round5.Text = "5";
            round5.UseVisualStyleBackColor = false;
            round5.Click += round5_Click;
            // 
            // round12
            // 
            round12.BackColor = Color.Firebrick;
            round12.FlatStyle = FlatStyle.Popup;
            round12.Location = new Point(480, 65);
            round12.Margin = new Padding(3, 4, 3, 4);
            round12.Name = "round12";
            round12.Size = new Size(34, 31);
            round12.TabIndex = 21;
            round12.Text = "12";
            round12.UseVisualStyleBackColor = false;
            round12.Click += round12_Click;
            // 
            // round11
            // 
            round11.BackColor = Color.Firebrick;
            round11.FlatStyle = FlatStyle.Popup;
            round11.Location = new Point(450, 65);
            round11.Margin = new Padding(3, 4, 3, 4);
            round11.Name = "round11";
            round11.Size = new Size(34, 31);
            round11.TabIndex = 20;
            round11.Text = "11";
            round11.UseVisualStyleBackColor = false;
            round11.Click += round11_Click;
            // 
            // round10
            // 
            round10.BackColor = Color.Firebrick;
            round10.FlatStyle = FlatStyle.Popup;
            round10.Location = new Point(421, 65);
            round10.Margin = new Padding(3, 4, 3, 4);
            round10.Name = "round10";
            round10.Size = new Size(34, 31);
            round10.TabIndex = 19;
            round10.Text = "10";
            round10.UseVisualStyleBackColor = false;
            round10.Click += round10_Click;
            // 
            // round9
            // 
            round9.BackColor = Color.Firebrick;
            round9.FlatStyle = FlatStyle.Popup;
            round9.Location = new Point(390, 65);
            round9.Margin = new Padding(3, 4, 3, 4);
            round9.Name = "round9";
            round9.Padding = new Padding(1);
            round9.Size = new Size(34, 31);
            round9.TabIndex = 18;
            round9.Text = "9";
            round9.UseVisualStyleBackColor = false;
            round9.Click += round9_Click;
            // 
            // round24
            // 
            round24.BackColor = Color.Firebrick;
            round24.FlatStyle = FlatStyle.Popup;
            round24.Location = new Point(841, 65);
            round24.Margin = new Padding(3, 4, 3, 4);
            round24.Name = "round24";
            round24.Size = new Size(34, 31);
            round24.TabIndex = 33;
            round24.Text = "24";
            round24.UseVisualStyleBackColor = false;
            round24.Click += round24_Click;
            // 
            // round23
            // 
            round23.BackColor = Color.Firebrick;
            round23.FlatStyle = FlatStyle.Popup;
            round23.Location = new Point(811, 65);
            round23.Margin = new Padding(3, 4, 3, 4);
            round23.Name = "round23";
            round23.Size = new Size(34, 31);
            round23.TabIndex = 32;
            round23.Text = "23";
            round23.UseVisualStyleBackColor = false;
            round23.Click += round23_Click;
            // 
            // round22
            // 
            round22.BackColor = Color.Firebrick;
            round22.FlatStyle = FlatStyle.Popup;
            round22.Location = new Point(782, 65);
            round22.Margin = new Padding(3, 4, 3, 4);
            round22.Name = "round22";
            round22.Size = new Size(34, 31);
            round22.TabIndex = 31;
            round22.Text = "22";
            round22.UseVisualStyleBackColor = false;
            round22.Click += round22_Click;
            // 
            // round21
            // 
            round21.BackColor = Color.Firebrick;
            round21.FlatStyle = FlatStyle.Popup;
            round21.Location = new Point(751, 65);
            round21.Margin = new Padding(3, 4, 3, 4);
            round21.Name = "round21";
            round21.Size = new Size(34, 31);
            round21.TabIndex = 30;
            round21.Text = "21";
            round21.UseVisualStyleBackColor = false;
            round21.Click += round21_Click;
            // 
            // round20
            // 
            round20.BackColor = Color.Firebrick;
            round20.FlatStyle = FlatStyle.Popup;
            round20.Location = new Point(718, 65);
            round20.Margin = new Padding(3, 4, 3, 4);
            round20.Name = "round20";
            round20.Size = new Size(34, 31);
            round20.TabIndex = 29;
            round20.Text = "20";
            round20.UseVisualStyleBackColor = false;
            round20.Click += round20_Click;
            // 
            // round19
            // 
            round19.BackColor = Color.Firebrick;
            round19.FlatStyle = FlatStyle.Popup;
            round19.Location = new Point(688, 65);
            round19.Margin = new Padding(3, 4, 3, 4);
            round19.Name = "round19";
            round19.Size = new Size(34, 31);
            round19.TabIndex = 28;
            round19.Text = "19";
            round19.UseVisualStyleBackColor = false;
            round19.Click += round19_Click;
            // 
            // round18
            // 
            round18.BackColor = Color.Firebrick;
            round18.FlatStyle = FlatStyle.Popup;
            round18.Location = new Point(658, 65);
            round18.Margin = new Padding(3, 4, 3, 4);
            round18.Name = "round18";
            round18.Size = new Size(34, 31);
            round18.TabIndex = 27;
            round18.Text = "18";
            round18.UseVisualStyleBackColor = false;
            round18.Click += round18_Click;
            // 
            // round17
            // 
            round17.BackColor = Color.Firebrick;
            round17.FlatStyle = FlatStyle.Popup;
            round17.Location = new Point(627, 65);
            round17.Margin = new Padding(3, 4, 3, 4);
            round17.Name = "round17";
            round17.Size = new Size(34, 31);
            round17.TabIndex = 26;
            round17.Text = "17";
            round17.UseVisualStyleBackColor = false;
            round17.Click += round17_Click;
            // 
            // round16
            // 
            round16.BackColor = Color.Firebrick;
            round16.FlatStyle = FlatStyle.Popup;
            round16.Location = new Point(599, 65);
            round16.Margin = new Padding(3, 4, 3, 4);
            round16.Name = "round16";
            round16.Size = new Size(34, 31);
            round16.TabIndex = 25;
            round16.Text = "16";
            round16.UseVisualStyleBackColor = false;
            round16.Click += round16_Click;
            // 
            // round15
            // 
            round15.BackColor = Color.Firebrick;
            round15.FlatStyle = FlatStyle.Popup;
            round15.Location = new Point(569, 65);
            round15.Margin = new Padding(3, 4, 3, 4);
            round15.Name = "round15";
            round15.Size = new Size(34, 31);
            round15.TabIndex = 24;
            round15.Text = "15";
            round15.UseVisualStyleBackColor = false;
            round15.Click += round15_Click;
            // 
            // round14
            // 
            round14.BackColor = Color.Firebrick;
            round14.FlatStyle = FlatStyle.Popup;
            round14.Location = new Point(539, 65);
            round14.Margin = new Padding(3, 4, 3, 4);
            round14.Name = "round14";
            round14.Size = new Size(34, 31);
            round14.TabIndex = 23;
            round14.Text = "14";
            round14.UseVisualStyleBackColor = false;
            round14.Click += round14_Click;
            // 
            // round13
            // 
            round13.BackColor = Color.Firebrick;
            round13.FlatStyle = FlatStyle.Popup;
            round13.Location = new Point(509, 65);
            round13.Margin = new Padding(3, 4, 3, 4);
            round13.Name = "round13";
            round13.Size = new Size(34, 31);
            round13.TabIndex = 22;
            round13.Text = "13";
            round13.UseVisualStyleBackColor = false;
            round13.Click += round13_Click;
            // 
            // round25
            // 
            round25.BackColor = Color.Firebrick;
            round25.FlatStyle = FlatStyle.Popup;
            round25.Location = new Point(873, 65);
            round25.Margin = new Padding(3, 4, 3, 4);
            round25.Name = "round25";
            round25.Size = new Size(34, 31);
            round25.TabIndex = 34;
            round25.Text = "25";
            round25.UseVisualStyleBackColor = false;
            round25.Click += round25_Click;
            // 
            // creatureListBox
            // 
            creatureListBox.FormattingEnabled = true;
            creatureListBox.ItemHeight = 20;
            creatureListBox.Location = new Point(21, 80);
            creatureListBox.Margin = new Padding(3, 4, 3, 4);
            creatureListBox.Name = "creatureListBox";
            creatureListBox.Size = new Size(233, 504);
            creatureListBox.TabIndex = 44;
            creatureListBox.SelectedIndexChanged += creatureListBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(83, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 45;
            nameLabel.Text = "Name";
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            strengthLabel.Location = new Point(17, 247);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(42, 32);
            strengthLabel.TabIndex = 46;
            strengthLabel.Text = "SV";
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dexterityLabel.Location = new Point(77, 247);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(45, 32);
            dexterityLabel.TabIndex = 47;
            dexterityLabel.Text = "DV";
            // 
            // constitutionLabel
            // 
            constitutionLabel.AutoSize = true;
            constitutionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            constitutionLabel.Location = new Point(136, 247);
            constitutionLabel.Name = "constitutionLabel";
            constitutionLabel.Size = new Size(44, 32);
            constitutionLabel.TabIndex = 48;
            constitutionLabel.Text = "CV";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            intelligenceLabel.Location = new Point(195, 247);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(35, 32);
            intelligenceLabel.TabIndex = 49;
            intelligenceLabel.Text = "IV";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            wisdomLabel.Location = new Point(255, 247);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(51, 32);
            wisdomLabel.TabIndex = 50;
            wisdomLabel.Text = "WV";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            charismaLabel.Location = new Point(314, 247);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(44, 32);
            charismaLabel.TabIndex = 51;
            charismaLabel.Text = "CV";
            // 
            // sortEntitiesButton
            // 
            sortEntitiesButton.BackColor = Color.Firebrick;
            sortEntitiesButton.FlatStyle = FlatStyle.Flat;
            sortEntitiesButton.Location = new Point(21, 36);
            sortEntitiesButton.Margin = new Padding(3, 4, 3, 4);
            sortEntitiesButton.Name = "sortEntitiesButton";
            sortEntitiesButton.Size = new Size(114, 31);
            sortEntitiesButton.TabIndex = 55;
            sortEntitiesButton.Text = "Sort";
            sortEntitiesButton.UseVisualStyleBackColor = false;
            sortEntitiesButton.Click += loadCreatureButton_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "creatureTest";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(306, 213);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 67;
            label2.Text = "CHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(247, 213);
            label3.Name = "label3";
            label3.Size = new Size(59, 32);
            label3.TabIndex = 66;
            label3.Text = "WIS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(128, 213);
            label4.Name = "label4";
            label4.Size = new Size(66, 32);
            label4.TabIndex = 65;
            label4.Text = "CON";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(69, 213);
            label5.Name = "label5";
            label5.Size = new Size(61, 32);
            label5.TabIndex = 63;
            label5.Text = "DEX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(187, 213);
            label6.Name = "label6";
            label6.Size = new Size(55, 32);
            label6.TabIndex = 64;
            label6.Text = "INT";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(9, 213);
            label7.Name = "label7";
            label7.Size = new Size(57, 32);
            label7.TabIndex = 62;
            label7.Text = "STR";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(8, 25);
            name.Name = "name";
            name.Size = new Size(77, 28);
            name.TabIndex = 68;
            name.Text = "NAME:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 296);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 69;
            label8.Text = "Description:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(8, 328);
            descriptionLabel.Margin = new Padding(3, 4, 3, 4);
            descriptionLabel.Multiline = true;
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.ScrollBars = ScrollBars.Vertical;
            descriptionLabel.Size = new Size(378, 236);
            descriptionLabel.TabIndex = 70;
            descriptionLabel.Text = "Description";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(RemoveStatus);
            groupBox2.Controls.Add(AddStatusEffect);
            groupBox2.Controls.Add(name);
            groupBox2.Controls.Add(statusListBox);
            groupBox2.Controls.Add(nameLabel);
            groupBox2.Controls.Add(subtractHpButton);
            groupBox2.Controls.Add(addHpButton);
            groupBox2.Controls.Add(div3Label);
            groupBox2.Controls.Add(div2Label);
            groupBox2.Controls.Add(div1Label);
            groupBox2.Controls.Add(editMenuButton);
            groupBox2.Controls.Add(removeCreatureButton);
            groupBox2.Controls.Add(Copy_monster);
            groupBox2.Controls.Add(HPLabel);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(tempHPLabel);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(initLabel);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(ACLabel);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(descriptionLabel);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(strengthLabel);
            groupBox2.Controls.Add(dexterityLabel);
            groupBox2.Controls.Add(charismaLabel);
            groupBox2.Controls.Add(constitutionLabel);
            groupBox2.Controls.Add(wisdomLabel);
            groupBox2.Controls.Add(intelligenceLabel);
            groupBox2.Location = new Point(327, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 653);
            groupBox2.TabIndex = 72;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entity Description";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // RemoveStatus
            // 
            RemoveStatus.BackColor = Color.Firebrick;
            RemoveStatus.FlatStyle = FlatStyle.Flat;
            RemoveStatus.Location = new Point(401, 133);
            RemoveStatus.Name = "RemoveStatus";
            RemoveStatus.Size = new Size(84, 29);
            RemoveStatus.TabIndex = 1;
            RemoveStatus.Text = "Remove";
            RemoveStatus.UseVisualStyleBackColor = false;
            RemoveStatus.Click += RemoveStatus_Click;
            // 
            // statusListBox
            // 
            statusListBox.FormattingEnabled = true;
            statusListBox.ItemHeight = 20;
            statusListBox.Location = new Point(261, 75);
            statusListBox.Name = "statusListBox";
            statusListBox.Size = new Size(134, 124);
            statusListBox.TabIndex = 0;
            statusListBox.MouseDoubleClick += statusListBox_MouseDoubleClick;
            // 
            // subtractHpButton
            // 
            subtractHpButton.BackColor = Color.Firebrick;
            subtractHpButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            subtractHpButton.Location = new Point(201, 104);
            subtractHpButton.Name = "subtractHpButton";
            subtractHpButton.Size = new Size(29, 28);
            subtractHpButton.TabIndex = 85;
            subtractHpButton.Text = "-";
            subtractHpButton.TextAlign = ContentAlignment.TopCenter;
            subtractHpButton.UseVisualStyleBackColor = false;
            subtractHpButton.Visible = false;
            subtractHpButton.Click += subtractHpButton_Click;
            // 
            // addHpButton
            // 
            addHpButton.BackColor = Color.Firebrick;
            addHpButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            addHpButton.Location = new Point(165, 104);
            addHpButton.Name = "addHpButton";
            addHpButton.Size = new Size(29, 28);
            addHpButton.TabIndex = 84;
            addHpButton.Text = "+";
            addHpButton.TextAlign = ContentAlignment.TopCenter;
            addHpButton.UseVisualStyleBackColor = false;
            addHpButton.Visible = false;
            addHpButton.Click += addHpButton_Click;
            // 
            // div3Label
            // 
            div3Label.AutoSize = true;
            div3Label.Location = new Point(8, 275);
            div3Label.Margin = new Padding(1, 0, 1, 0);
            div3Label.Name = "div3Label";
            div3Label.Size = new Size(399, 20);
            div3Label.TabIndex = 83;
            div3Label.Text = "_________________________________________________________________";
            // 
            // div2Label
            // 
            div2Label.AutoSize = true;
            div2Label.Location = new Point(7, 193);
            div2Label.Name = "div2Label";
            div2Label.Size = new Size(399, 20);
            div2Label.TabIndex = 82;
            div2Label.Text = "_________________________________________________________________";
            // 
            // div1Label
            // 
            div1Label.AutoSize = true;
            div1Label.BackColor = Color.Transparent;
            div1Label.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            div1Label.Location = new Point(7, 47);
            div1Label.Name = "div1Label";
            div1Label.Size = new Size(399, 20);
            div1Label.TabIndex = 80;
            div1Label.Text = "_________________________________________________________________";
            // 
            // editMenuButton
            // 
            editMenuButton.BackColor = Color.Firebrick;
            editMenuButton.FlatStyle = FlatStyle.Flat;
            editMenuButton.ForeColor = SystemColors.ControlLightLight;
            editMenuButton.Location = new Point(9, 595);
            editMenuButton.Margin = new Padding(3, 4, 3, 4);
            editMenuButton.Name = "editMenuButton";
            editMenuButton.Size = new Size(98, 31);
            editMenuButton.TabIndex = 79;
            editMenuButton.Text = "Edit Creature";
            editMenuButton.UseVisualStyleBackColor = false;
            editMenuButton.Click += editMenu_Click;
            // 
            // HPLabel
            // 
            HPLabel.AutoSize = true;
            HPLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HPLabel.Location = new Point(83, 100);
            HPLabel.Name = "HPLabel";
            HPLabel.Size = new Size(44, 32);
            HPLabel.TabIndex = 78;
            HPLabel.Text = "HP";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(14, 100);
            label17.Name = "label17";
            label17.Size = new Size(47, 32);
            label17.TabIndex = 77;
            label17.Text = "HP";
            // 
            // tempHPLabel
            // 
            tempHPLabel.AutoSize = true;
            tempHPLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tempHPLabel.Location = new Point(83, 133);
            tempHPLabel.Name = "tempHPLabel";
            tempHPLabel.Size = new Size(57, 32);
            tempHPLabel.TabIndex = 76;
            tempHPLabel.Text = "THP";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(14, 133);
            label15.Name = "label15";
            label15.Size = new Size(66, 32);
            label15.TabIndex = 75;
            label15.Text = "T.HP";
            // 
            // initLabel
            // 
            initLabel.AutoSize = true;
            initLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            initLabel.Location = new Point(83, 167);
            initLabel.Name = "initLabel";
            initLabel.Size = new Size(57, 32);
            initLabel.TabIndex = 74;
            initLabel.Text = "INIT";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 167);
            label13.Name = "label13";
            label13.Size = new Size(63, 32);
            label13.TabIndex = 73;
            label13.Text = "INIT";
            // 
            // ACLabel
            // 
            ACLabel.AutoSize = true;
            ACLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ACLabel.Location = new Point(83, 67);
            ACLabel.Name = "ACLabel";
            ACLabel.Size = new Size(44, 32);
            ACLabel.TabIndex = 72;
            ACLabel.Text = "AC";
            ACLabel.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 67);
            label10.Name = "label10";
            label10.Size = new Size(46, 32);
            label10.TabIndex = 71;
            label10.Text = "AC";
            // 
            // entityListGroupBox
            // 
            entityListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            entityListGroupBox.AutoSize = true;
            entityListGroupBox.Controls.Add(NextTurn);
            entityListGroupBox.Controls.Add(creatureListBox);
            entityListGroupBox.Controls.Add(sortEntitiesButton);
            entityListGroupBox.Location = new Point(31, 152);
            entityListGroupBox.Name = "entityListGroupBox";
            entityListGroupBox.Size = new Size(274, 644);
            entityListGroupBox.TabIndex = 73;
            entityListGroupBox.TabStop = false;
            entityListGroupBox.Text = "Entity List";
            // 
            // diceRollerGroupBox
            // 
            diceRollerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            diceRollerGroupBox.AutoSize = true;
            diceRollerGroupBox.Controls.Add(diceRollerTextBox);
            diceRollerGroupBox.Location = new Point(818, 152);
            diceRollerGroupBox.Name = "diceRollerGroupBox";
            diceRollerGroupBox.Size = new Size(166, 286);
            diceRollerGroupBox.TabIndex = 75;
            diceRollerGroupBox.TabStop = false;
            diceRollerGroupBox.Text = "Dice Roller";
            // 
            // diceRollerTextBox
            // 
            diceRollerTextBox.Location = new Point(21, 29);
            diceRollerTextBox.Name = "diceRollerTextBox";
            diceRollerTextBox.Size = new Size(125, 231);
            diceRollerTextBox.TabIndex = 0;
            diceRollerTextBox.Text = "";
            // 
            // Settings_group_box
            // 
            Settings_group_box.AutoSize = true;
            Settings_group_box.BackColor = Color.Gray;
            Settings_group_box.Controls.Add(Change_Bcolor);
            Settings_group_box.Location = new Point(1165, 434);
            Settings_group_box.Margin = new Padding(3, 4, 3, 4);
            Settings_group_box.Name = "Settings_group_box";
            Settings_group_box.Padding = new Padding(3, 4, 3, 4);
            Settings_group_box.Size = new Size(134, 87);
            Settings_group_box.TabIndex = 76;
            Settings_group_box.TabStop = false;
            Settings_group_box.Visible = false;
            // 
            // Change_Bcolor
            // 
            Change_Bcolor.BackColor = Color.Firebrick;
            Change_Bcolor.FlatStyle = FlatStyle.Flat;
            Change_Bcolor.Location = new Point(6, 11);
            Change_Bcolor.Name = "Change_Bcolor";
            Change_Bcolor.Size = new Size(120, 48);
            Change_Bcolor.TabIndex = 0;
            Change_Bcolor.Text = "Set Main Color";
            Change_Bcolor.UseVisualStyleBackColor = false;
            Change_Bcolor.Click += Change_Bcolor_Click;
            // 
            // Color_choices
            // 
            Color_choices.AutoSize = true;
            Color_choices.BackColor = Color.DimGray;
            Color_choices.Controls.Add(ScrollBlue);
            Color_choices.Controls.Add(ScrollGreen);
            Color_choices.Controls.Add(ScrollRed);
            Color_choices.Controls.Add(label16);
            Color_choices.Controls.Add(label14);
            Color_choices.Controls.Add(label12);
            Color_choices.Location = new Point(1080, 528);
            Color_choices.Name = "Color_choices";
            Color_choices.Size = new Size(219, 144);
            Color_choices.TabIndex = 77;
            Color_choices.TabStop = false;
            Color_choices.Visible = false;
            // 
            // ScrollBlue
            // 
            ScrollBlue.Location = new Point(63, 97);
            ScrollBlue.Maximum = 255;
            ScrollBlue.Name = "ScrollBlue";
            ScrollBlue.Size = new Size(142, 17);
            ScrollBlue.TabIndex = 8;
            ScrollBlue.Scroll += ScrollBlue_Scroll;
            // 
            // ScrollGreen
            // 
            ScrollGreen.Location = new Point(63, 67);
            ScrollGreen.Maximum = 255;
            ScrollGreen.Name = "ScrollGreen";
            ScrollGreen.Size = new Size(142, 17);
            ScrollGreen.TabIndex = 7;
            ScrollGreen.Scroll += ScrollGreen_Scroll;
            // 
            // ScrollRed
            // 
            ScrollRed.Location = new Point(63, 37);
            ScrollRed.Maximum = 255;
            ScrollRed.Name = "ScrollRed";
            ScrollRed.Size = new Size(142, 17);
            ScrollRed.TabIndex = 6;
            ScrollRed.Scroll += ScrollRed_Scroll;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 97);
            label16.Name = "label16";
            label16.Size = new Size(43, 20);
            label16.TabIndex = 5;
            label16.Text = "BLUE";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 67);
            label14.Name = "label14";
            label14.Size = new Size(55, 20);
            label14.TabIndex = 4;
            label14.Text = "GREEN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(10, 37);
            label12.Name = "label12";
            label12.Size = new Size(37, 20);
            label12.TabIndex = 3;
            label12.Text = "RED";
            // 
            // NextTurn
            // 
            NextTurn.BackColor = Color.Firebrick;
            NextTurn.FlatStyle = FlatStyle.Flat;
            NextTurn.Location = new Point(148, 36);
            NextTurn.Name = "NextTurn";
            NextTurn.Size = new Size(106, 31);
            NextTurn.TabIndex = 56;
            NextTurn.Text = "Next Turn";
            NextTurn.UseVisualStyleBackColor = false;
            NextTurn.Click += NextTurn_Click;
            // 
            // mainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources._4a55526f0568117ab1807a87c13a6802;
            ClientSize = new Size(1311, 855);
            Controls.Add(Color_choices);
            Controls.Add(Settings_group_box);
            Controls.Add(diceRollerGroupBox);
            Controls.Add(entityListGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(round1);
            Controls.Add(round25);
            Controls.Add(round24);
            Controls.Add(round23);
            Controls.Add(round22);
            Controls.Add(round21);
            Controls.Add(round20);
            Controls.Add(round19);
            Controls.Add(round18);
            Controls.Add(round17);
            Controls.Add(round16);
            Controls.Add(round15);
            Controls.Add(round14);
            Controls.Add(round13);
            Controls.Add(round12);
            Controls.Add(round11);
            Controls.Add(round10);
            Controls.Add(round9);
            Controls.Add(round8);
            Controls.Add(round7);
            Controls.Add(round6);
            Controls.Add(round5);
            Controls.Add(round4);
            Controls.Add(menuGroupBox);
            Controls.Add(nextRound);
            Controls.Add(prevRound);
            Controls.Add(round3);
            Controls.Add(round2);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainGUI";
            Text = "DM-Toolbox";
            Load += mainGUI_Load;
            Resize += mainGUI_Resize;
            menuGroupBox.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            entityListGroupBox.ResumeLayout(false);
            diceRollerGroupBox.ResumeLayout(false);
            Settings_group_box.ResumeLayout(false);
            Color_choices.ResumeLayout(false);
            Color_choices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Copy_monster;
        private Button prevRound;
        private Button nextRound;
        private Button removeCreatureButton;
        private GroupBox menuGroupBox;
        private Button deleteEncounterButton;
        private Button AddStatusEffect;
        private Button Settings_button;
        private Button button8;
        private Button AddEntityButton;
        private Button round1;
        private Button round2;
        private Button round3;
        private Button round4;
        private Button round8;
        private Button round7;
        private Button round6;
        private Button round5;
        private Button round12;
        private Button round11;
        private Button round10;
        private Button round9;
        private Button round24;
        private Button round23;
        private Button round22;
        private Button round21;
        private Button round20;
        private Button round19;
        private Button round18;
        private Button round17;
        private Button round16;
        private Button round15;
        private Button round14;
        private Button round13;
        private Button round25;
        private Label nameLabel;
        private Label strengthLabel;
        private Label dexterityLabel;
        private Label constitutionLabel;
        private Label intelligenceLabel;
        private Label wisdomLabel;
        private Label charismaLabel;
        private Button saveCreatureButton;
        private Button sortEntitiesButton;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button loadCreatureListButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label name;
        private Label label8;
        private TextBox descriptionLabel;
        private GroupBox groupBox2;
        private GroupBox entityListGroupBox;
        private GroupBox diceRollerGroupBox;
        private RichTextBox diceRollerTextBox;
        private Label HPLabel;
        private Label label17;
        private Label tempHPLabel;
        private Label label15;
        private Label initLabel;
        private Label label13;
        private Label ACLabel;
        private Label label10;
        private GroupBox Settings_group_box;
        private Button Change_Bcolor;
        private GroupBox Color_choices;
        private Button editMenuButton;
        public ListBox creatureListBox;
        private Label div3Label;
        private Label div2Label;
        private Label div1Label;
        private HScrollBar ScrollBlue;
        private HScrollBar ScrollGreen;
        private HScrollBar ScrollRed;
        private Label label16;
        private Label label14;
        private Label label12;
        private Button addHpButton;
        private Button subtractHpButton;
        private Button loadGroupButton;
        private ListBox statusListBox;
        private Button RemoveStatus;
        private Button NextTurn;
    }
}