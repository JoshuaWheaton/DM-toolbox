namespace GroupProject
{
    partial class AddStatusEffect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StatusName = new Label();
            OtherEffectsLabel = new Label();
            StatusDurationLabel = new Label();
            ConditionsBox = new GroupBox();
            Unconscious = new CheckBox();
            Stunned = new CheckBox();
            Restrained = new CheckBox();
            Prone = new CheckBox();
            Poisoned = new CheckBox();
            Petrified = new CheckBox();
            Paralyzed = new CheckBox();
            Invisible = new CheckBox();
            Incapacitated = new CheckBox();
            Grappled = new CheckBox();
            Frightened = new CheckBox();
            Deafened = new CheckBox();
            Charmed = new CheckBox();
            Blinded = new CheckBox();
            StatusNameBox = new TextBox();
            OtherEffectsBox = new TextBox();
            StatusDuration = new NumericUpDown();
            SvEndOfTurn = new CheckBox();
            SavingThrowBox = new GroupBox();
            SaveStatBox = new TextBox();
            SaveStatLabel = new Label();
            SaveDCLabel = new Label();
            SaveDCBox = new NumericUpDown();
            AddStatusButton = new Button();
            SvOnDmg = new CheckBox();
            SvStartOfTurn = new CheckBox();
            ConditionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StatusDuration).BeginInit();
            SavingThrowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SaveDCBox).BeginInit();
            SuspendLayout();
            // 
            // StatusName
            // 
            StatusName.AutoSize = true;
            StatusName.Location = new Point(12, 9);
            StatusName.Name = "StatusName";
            StatusName.Size = new Size(49, 20);
            StatusName.TabIndex = 0;
            StatusName.Text = "Name";
            // 
            // OtherEffectsLabel
            // 
            OtherEffectsLabel.AutoSize = true;
            OtherEffectsLabel.Location = new Point(12, 92);
            OtherEffectsLabel.Name = "OtherEffectsLabel";
            OtherEffectsLabel.Size = new Size(94, 20);
            OtherEffectsLabel.TabIndex = 1;
            OtherEffectsLabel.Text = "Other Effects";
            // 
            // StatusDurationLabel
            // 
            StatusDurationLabel.AutoSize = true;
            StatusDurationLabel.Location = new Point(12, 62);
            StatusDurationLabel.Name = "StatusDurationLabel";
            StatusDurationLabel.Size = new Size(130, 20);
            StatusDurationLabel.TabIndex = 2;
            StatusDurationLabel.Text = "Duration (Rounds)";
            // 
            // ConditionsBox
            // 
            ConditionsBox.Controls.Add(Unconscious);
            ConditionsBox.Controls.Add(Stunned);
            ConditionsBox.Controls.Add(Restrained);
            ConditionsBox.Controls.Add(Prone);
            ConditionsBox.Controls.Add(Poisoned);
            ConditionsBox.Controls.Add(Petrified);
            ConditionsBox.Controls.Add(Paralyzed);
            ConditionsBox.Controls.Add(Invisible);
            ConditionsBox.Controls.Add(Incapacitated);
            ConditionsBox.Controls.Add(Grappled);
            ConditionsBox.Controls.Add(Frightened);
            ConditionsBox.Controls.Add(Deafened);
            ConditionsBox.Controls.Add(Charmed);
            ConditionsBox.Controls.Add(Blinded);
            ConditionsBox.Location = new Point(352, 9);
            ConditionsBox.Name = "ConditionsBox";
            ConditionsBox.Size = new Size(309, 230);
            ConditionsBox.TabIndex = 3;
            ConditionsBox.TabStop = false;
            ConditionsBox.Text = "Conditions";
            // 
            // Unconscious
            // 
            Unconscious.AccessibleDescription = "";
            Unconscious.AutoSize = true;
            Unconscious.Location = new Point(144, 199);
            Unconscious.Name = "Unconscious";
            Unconscious.Size = new Size(113, 24);
            Unconscious.TabIndex = 18;
            Unconscious.Text = "Unconscious";
            Unconscious.UseVisualStyleBackColor = true;
            // 
            // Stunned
            // 
            Stunned.AccessibleDescription = "";
            Stunned.AutoSize = true;
            Stunned.Location = new Point(144, 169);
            Stunned.Name = "Stunned";
            Stunned.Size = new Size(85, 24);
            Stunned.TabIndex = 17;
            Stunned.Text = "Stunned";
            Stunned.UseVisualStyleBackColor = true;
            // 
            // Restrained
            // 
            Restrained.AccessibleDescription = "";
            Restrained.AutoSize = true;
            Restrained.Location = new Point(144, 139);
            Restrained.Name = "Restrained";
            Restrained.Size = new Size(101, 24);
            Restrained.TabIndex = 16;
            Restrained.Text = "Restrained";
            Restrained.UseVisualStyleBackColor = true;
            // 
            // Prone
            // 
            Prone.AccessibleDescription = "";
            Prone.AutoSize = true;
            Prone.Location = new Point(144, 109);
            Prone.Name = "Prone";
            Prone.Size = new Size(69, 24);
            Prone.TabIndex = 15;
            Prone.Text = "Prone";
            Prone.UseVisualStyleBackColor = true;
            // 
            // Poisoned
            // 
            Poisoned.AccessibleDescription = "";
            Poisoned.AutoSize = true;
            Poisoned.Location = new Point(144, 79);
            Poisoned.Name = "Poisoned";
            Poisoned.Size = new Size(91, 24);
            Poisoned.TabIndex = 14;
            Poisoned.Text = "Poisoned";
            Poisoned.UseVisualStyleBackColor = true;
            // 
            // Petrified
            // 
            Petrified.AccessibleDescription = "";
            Petrified.AutoSize = true;
            Petrified.Location = new Point(144, 49);
            Petrified.Name = "Petrified";
            Petrified.Size = new Size(86, 24);
            Petrified.TabIndex = 13;
            Petrified.Text = "Petrified";
            Petrified.UseVisualStyleBackColor = true;
            // 
            // Paralyzed
            // 
            Paralyzed.AccessibleDescription = "";
            Paralyzed.AutoSize = true;
            Paralyzed.Location = new Point(144, 22);
            Paralyzed.Name = "Paralyzed";
            Paralyzed.Size = new Size(94, 24);
            Paralyzed.TabIndex = 12;
            Paralyzed.Text = "Paralyzed";
            Paralyzed.UseVisualStyleBackColor = true;
            // 
            // Invisible
            // 
            Invisible.AccessibleDescription = "";
            Invisible.AutoSize = true;
            Invisible.Location = new Point(7, 199);
            Invisible.Name = "Invisible";
            Invisible.Size = new Size(85, 24);
            Invisible.TabIndex = 11;
            Invisible.Text = "Invisible";
            Invisible.UseVisualStyleBackColor = true;
            // 
            // Incapacitated
            // 
            Incapacitated.AccessibleDescription = "";
            Incapacitated.AutoSize = true;
            Incapacitated.Location = new Point(7, 169);
            Incapacitated.Name = "Incapacitated";
            Incapacitated.Size = new Size(121, 24);
            Incapacitated.TabIndex = 10;
            Incapacitated.Text = "Incapacitated";
            Incapacitated.UseVisualStyleBackColor = true;
            // 
            // Grappled
            // 
            Grappled.AccessibleDescription = "";
            Grappled.AutoSize = true;
            Grappled.Location = new Point(6, 139);
            Grappled.Name = "Grappled";
            Grappled.Size = new Size(93, 24);
            Grappled.TabIndex = 9;
            Grappled.Text = "Grappled";
            Grappled.UseVisualStyleBackColor = true;
            // 
            // Frightened
            // 
            Frightened.AccessibleDescription = "";
            Frightened.AutoSize = true;
            Frightened.Location = new Point(6, 109);
            Frightened.Name = "Frightened";
            Frightened.Size = new Size(102, 24);
            Frightened.TabIndex = 8;
            Frightened.Text = "Frightened";
            Frightened.UseVisualStyleBackColor = true;
            // 
            // Deafened
            // 
            Deafened.AccessibleDescription = "";
            Deafened.AutoSize = true;
            Deafened.Location = new Point(6, 79);
            Deafened.Name = "Deafened";
            Deafened.Size = new Size(96, 24);
            Deafened.TabIndex = 7;
            Deafened.Text = "Deafened";
            Deafened.UseVisualStyleBackColor = true;
            // 
            // Charmed
            // 
            Charmed.AccessibleDescription = "";
            Charmed.AutoSize = true;
            Charmed.Location = new Point(6, 49);
            Charmed.Name = "Charmed";
            Charmed.Size = new Size(91, 24);
            Charmed.TabIndex = 1;
            Charmed.Text = "Charmed";
            Charmed.UseVisualStyleBackColor = true;
            // 
            // Blinded
            // 
            Blinded.AccessibleDescription = "";
            Blinded.AutoSize = true;
            Blinded.Location = new Point(6, 22);
            Blinded.Name = "Blinded";
            Blinded.Size = new Size(82, 24);
            Blinded.TabIndex = 0;
            Blinded.Text = "Blinded";
            Blinded.UseVisualStyleBackColor = true;
            // 
            // StatusNameBox
            // 
            StatusNameBox.Location = new Point(12, 32);
            StatusNameBox.Name = "StatusNameBox";
            StatusNameBox.Size = new Size(191, 27);
            StatusNameBox.TabIndex = 4;
            // 
            // OtherEffectsBox
            // 
            OtherEffectsBox.Location = new Point(12, 115);
            OtherEffectsBox.Multiline = true;
            OtherEffectsBox.Name = "OtherEffectsBox";
            OtherEffectsBox.Size = new Size(191, 124);
            OtherEffectsBox.TabIndex = 5;
            // 
            // StatusDuration
            // 
            StatusDuration.Location = new Point(148, 62);
            StatusDuration.Name = "StatusDuration";
            StatusDuration.Size = new Size(55, 27);
            StatusDuration.TabIndex = 6;
            StatusDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SvEndOfTurn
            // 
            SvEndOfTurn.AutoSize = true;
            SvEndOfTurn.Location = new Point(6, 125);
            SvEndOfTurn.Name = "SvEndOfTurn";
            SvEndOfTurn.Size = new Size(107, 24);
            SvEndOfTurn.TabIndex = 7;
            SvEndOfTurn.Text = "End of Turn";
            SvEndOfTurn.UseVisualStyleBackColor = true;
            // 
            // SavingThrowBox
            // 
            SavingThrowBox.Controls.Add(SaveStatBox);
            SavingThrowBox.Controls.Add(SaveStatLabel);
            SavingThrowBox.Controls.Add(SaveDCLabel);
            SavingThrowBox.Controls.Add(SaveDCBox);
            SavingThrowBox.Controls.Add(AddStatusButton);
            SavingThrowBox.Controls.Add(SvOnDmg);
            SavingThrowBox.Controls.Add(SvStartOfTurn);
            SavingThrowBox.Controls.Add(SvEndOfTurn);
            SavingThrowBox.Location = new Point(209, 9);
            SavingThrowBox.Name = "SavingThrowBox";
            SavingThrowBox.Size = new Size(136, 230);
            SavingThrowBox.TabIndex = 8;
            SavingThrowBox.TabStop = false;
            SavingThrowBox.Text = "Saving Throws";
            // 
            // SaveStatBox
            // 
            SaveStatBox.Location = new Point(79, 26);
            SaveStatBox.Name = "SaveStatBox";
            SaveStatBox.Size = new Size(40, 27);
            SaveStatBox.TabIndex = 13;
            // 
            // SaveStatLabel
            // 
            SaveStatLabel.AutoSize = true;
            SaveStatLabel.Location = new Point(6, 30);
            SaveStatLabel.Name = "SaveStatLabel";
            SaveStatLabel.Size = new Size(73, 20);
            SaveStatLabel.TabIndex = 12;
            SaveStatLabel.Text = "Save Stat:";
            // 
            // SaveDCLabel
            // 
            SaveDCLabel.AutoSize = true;
            SaveDCLabel.Location = new Point(6, 60);
            SaveDCLabel.Name = "SaveDCLabel";
            SaveDCLabel.Size = new Size(67, 20);
            SaveDCLabel.TabIndex = 11;
            SaveDCLabel.Text = "Save DC:";
            // 
            // SaveDCBox
            // 
            SaveDCBox.Location = new Point(79, 58);
            SaveDCBox.Name = "SaveDCBox";
            SaveDCBox.Size = new Size(40, 27);
            SaveDCBox.TabIndex = 10;
            SaveDCBox.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // AddStatusButton
            // 
            AddStatusButton.BackColor = Color.Firebrick;
            AddStatusButton.FlatStyle = FlatStyle.Flat;
            AddStatusButton.ForeColor = SystemColors.ControlLight;
            AddStatusButton.Location = new Point(6, 194);
            AddStatusButton.Name = "AddStatusButton";
            AddStatusButton.Size = new Size(124, 29);
            AddStatusButton.TabIndex = 9;
            AddStatusButton.Text = "Add Status";
            AddStatusButton.UseVisualStyleBackColor = false;
            AddStatusButton.Click += AddStatusButton_Click;
            // 
            // SvOnDmg
            // 
            SvOnDmg.AccessibleDescription = "";
            SvOnDmg.AutoSize = true;
            SvOnDmg.Location = new Point(6, 155);
            SvOnDmg.Name = "SvOnDmg";
            SvOnDmg.Size = new Size(109, 24);
            SvOnDmg.TabIndex = 9;
            SvOnDmg.Text = "On damage";
            SvOnDmg.UseVisualStyleBackColor = true;
            // 
            // SvStartOfTurn
            // 
            SvStartOfTurn.AccessibleDescription = "";
            SvStartOfTurn.AutoSize = true;
            SvStartOfTurn.Location = new Point(6, 95);
            SvStartOfTurn.Name = "SvStartOfTurn";
            SvStartOfTurn.Size = new Size(113, 24);
            SvStartOfTurn.TabIndex = 8;
            SvStartOfTurn.Text = "Start of Turn";
            SvStartOfTurn.UseVisualStyleBackColor = true;
            // 
            // AddStatusEffect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(673, 257);
            Controls.Add(OtherEffectsBox);
            Controls.Add(SavingThrowBox);
            Controls.Add(StatusDuration);
            Controls.Add(StatusNameBox);
            Controls.Add(ConditionsBox);
            Controls.Add(StatusDurationLabel);
            Controls.Add(OtherEffectsLabel);
            Controls.Add(StatusName);
            Name = "AddStatusEffect";
            Text = "Add Status Effect";
            ConditionsBox.ResumeLayout(false);
            ConditionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StatusDuration).EndInit();
            SavingThrowBox.ResumeLayout(false);
            SavingThrowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SaveDCBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatusName;
        private Label OtherEffectsLabel;
        private Label StatusDurationLabel;
        private GroupBox ConditionsBox;
        private TextBox StatusNameBox;
        private TextBox OtherEffectsBox;
        private NumericUpDown StatusDuration;
        private CheckBox Charmed;
        private CheckBox Blinded;
        private CheckBox Unconscious;
        private CheckBox Stunned;
        private CheckBox Restrained;
        private CheckBox Prone;
        private CheckBox Poisoned;
        private CheckBox Petrified;
        private CheckBox Paralyzed;
        private CheckBox Invisible;
        private CheckBox Incapacitated;
        private CheckBox Grappled;
        private CheckBox Frightened;
        private CheckBox Deafened;
        private CheckBox SvEndOfTurn;
        private GroupBox SavingThrowBox;
        private CheckBox SvOnDmg;
        private CheckBox SvStartOfTurn;
        private Button AddStatusButton;
        private Label SaveDCLabel;
        private NumericUpDown SaveDCBox;
        private TextBox SaveStatBox;
        private Label SaveStatLabel;
    }
}