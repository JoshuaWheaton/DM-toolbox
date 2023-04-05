namespace GroupProject
{
    partial class EditForm
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
            this.addEntityGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.initiativeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dexterityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CHA = new System.Windows.Forms.Label();
            this.constitutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WIS = new System.Windows.Forms.Label();
            this.intelligenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DEX = new System.Windows.Forms.Label();
            this.wisdomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.INT = new System.Windows.Forms.Label();
            this.charismaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.STR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hitPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addEntityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitPointsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addEntityGroupBox
            // 
            this.addEntityGroupBox.Controls.Add(this.label2);
            this.addEntityGroupBox.Controls.Add(this.hitPointsNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.editButton);
            this.addEntityGroupBox.Controls.Add(this.label11);
            this.addEntityGroupBox.Controls.Add(this.initiativeNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.descriptionTextBox);
            this.addEntityGroupBox.Controls.Add(this.nameTextBox);
            this.addEntityGroupBox.Controls.Add(this.strengthNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.label9);
            this.addEntityGroupBox.Controls.Add(this.dexterityNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.CHA);
            this.addEntityGroupBox.Controls.Add(this.constitutionNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.WIS);
            this.addEntityGroupBox.Controls.Add(this.intelligenceNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.DEX);
            this.addEntityGroupBox.Controls.Add(this.wisdomNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.INT);
            this.addEntityGroupBox.Controls.Add(this.charismaNumericUpDown);
            this.addEntityGroupBox.Controls.Add(this.label1);
            this.addEntityGroupBox.Controls.Add(this.STR);
            this.addEntityGroupBox.Location = new System.Drawing.Point(14, 15);
            this.addEntityGroupBox.Name = "addEntityGroupBox";
            this.addEntityGroupBox.Size = new System.Drawing.Size(469, 357);
            this.addEntityGroupBox.TabIndex = 75;
            this.addEntityGroupBox.TabStop = false;
            this.addEntityGroupBox.Text = "Add Entity";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Firebrick;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editButton.Location = new System.Drawing.Point(355, 28);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(86, 31);
            this.editButton.TabIndex = 74;
            this.editButton.Text = "Edit Entity";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(203, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 32);
            this.label11.TabIndex = 73;
            this.label11.Text = "INIT";
            // 
            // initiativeNumericUpDown
            // 
            this.initiativeNumericUpDown.Location = new System.Drawing.Point(271, 268);
            this.initiativeNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.initiativeNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.initiativeNumericUpDown.Name = "initiativeNumericUpDown";
            this.initiativeNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.initiativeNumericUpDown.TabIndex = 72;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(21, 76);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Description";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(175, 241);
            this.descriptionTextBox.TabIndex = 37;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(21, 21);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Name";
            this.nameTextBox.Size = new System.Drawing.Size(114, 27);
            this.nameTextBox.TabIndex = 36;
            // 
            // strengthNumericUpDown
            // 
            this.strengthNumericUpDown.Location = new System.Drawing.Point(271, 28);
            this.strengthNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.strengthNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.strengthNumericUpDown.Name = "strengthNumericUpDown";
            this.strengthNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.strengthNumericUpDown.TabIndex = 38;
            this.strengthNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(206, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 32);
            this.label9.TabIndex = 71;
            this.label9.Text = "CON";
            // 
            // dexterityNumericUpDown
            // 
            this.dexterityNumericUpDown.Location = new System.Drawing.Point(271, 68);
            this.dexterityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dexterityNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.dexterityNumericUpDown.Name = "dexterityNumericUpDown";
            this.dexterityNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.dexterityNumericUpDown.TabIndex = 39;
            this.dexterityNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CHA
            // 
            this.CHA.AutoSize = true;
            this.CHA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CHA.Location = new System.Drawing.Point(203, 221);
            this.CHA.Name = "CHA";
            this.CHA.Size = new System.Drawing.Size(64, 32);
            this.CHA.TabIndex = 61;
            this.CHA.Text = "CHA";
            // 
            // constitutionNumericUpDown
            // 
            this.constitutionNumericUpDown.Location = new System.Drawing.Point(271, 108);
            this.constitutionNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.constitutionNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.constitutionNumericUpDown.Name = "constitutionNumericUpDown";
            this.constitutionNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.constitutionNumericUpDown.TabIndex = 40;
            this.constitutionNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // WIS
            // 
            this.WIS.AutoSize = true;
            this.WIS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WIS.Location = new System.Drawing.Point(203, 181);
            this.WIS.Name = "WIS";
            this.WIS.Size = new System.Drawing.Size(59, 32);
            this.WIS.TabIndex = 60;
            this.WIS.Text = "WIS";
            // 
            // intelligenceNumericUpDown
            // 
            this.intelligenceNumericUpDown.Location = new System.Drawing.Point(271, 148);
            this.intelligenceNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intelligenceNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.intelligenceNumericUpDown.Name = "intelligenceNumericUpDown";
            this.intelligenceNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.intelligenceNumericUpDown.TabIndex = 41;
            this.intelligenceNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DEX
            // 
            this.DEX.AutoSize = true;
            this.DEX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DEX.Location = new System.Drawing.Point(203, 61);
            this.DEX.Name = "DEX";
            this.DEX.Size = new System.Drawing.Size(61, 32);
            this.DEX.TabIndex = 58;
            this.DEX.Text = "DEX";
            // 
            // wisdomNumericUpDown
            // 
            this.wisdomNumericUpDown.Location = new System.Drawing.Point(271, 188);
            this.wisdomNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wisdomNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.wisdomNumericUpDown.Name = "wisdomNumericUpDown";
            this.wisdomNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.wisdomNumericUpDown.TabIndex = 42;
            this.wisdomNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // INT
            // 
            this.INT.AutoSize = true;
            this.INT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.INT.Location = new System.Drawing.Point(203, 141);
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(55, 32);
            this.INT.TabIndex = 58;
            this.INT.Text = "INT";
            // 
            // charismaNumericUpDown
            // 
            this.charismaNumericUpDown.Location = new System.Drawing.Point(271, 228);
            this.charismaNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.charismaNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.charismaNumericUpDown.Name = "charismaNumericUpDown";
            this.charismaNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.charismaNumericUpDown.TabIndex = 43;
            this.charismaNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 57;
            this.label1.Text = "STR";
            // 
            // STR
            // 
            this.STR.AutoSize = true;
            this.STR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.STR.Location = new System.Drawing.Point(207, 21);
            this.STR.Name = "STR";
            this.STR.Size = new System.Drawing.Size(57, 32);
            this.STR.TabIndex = 57;
            this.STR.Text = "STR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 78;
            this.label2.Text = "M.HP";
            // 
            // hitPointsNumericUpDown
            // 
            this.hitPointsNumericUpDown.Location = new System.Drawing.Point(271, 308);
            this.hitPointsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hitPointsNumericUpDown.Name = "hitPointsNumericUpDown";
            this.hitPointsNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.hitPointsNumericUpDown.TabIndex = 77;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(496, 384);
            this.Controls.Add(this.addEntityGroupBox);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.addEntityGroupBox.ResumeLayout(false);
            this.addEntityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constitutionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisdomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charismaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitPointsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label STR;
        public GroupBox addEntityGroupBox;
        public Label label11;
        public NumericUpDown initiativeNumericUpDown;
        public TextBox descriptionTextBox;
        public TextBox nameTextBox;
        public NumericUpDown strengthNumericUpDown;
        public Label label9;
        public NumericUpDown dexterityNumericUpDown;
        public Label CHA;
        public NumericUpDown constitutionNumericUpDown;
        public Label WIS;
        public NumericUpDown intelligenceNumericUpDown;
        public Label DEX;
        public NumericUpDown wisdomNumericUpDown;
        public Label INT;
        public NumericUpDown charismaNumericUpDown;
        public Label label1;
        public Button editButton;
        public Label label2;
        public NumericUpDown hitPointsNumericUpDown;
    }
}