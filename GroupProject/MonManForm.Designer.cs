namespace GroupProject
{
    partial class MonManForm
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
            this.monsterManListBox = new System.Windows.Forms.ListBox();
            this.addMonsterButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // monsterManListBox
            // 
            this.monsterManListBox.FormattingEnabled = true;
            this.monsterManListBox.ItemHeight = 15;
            this.monsterManListBox.Location = new System.Drawing.Point(12, 41);
            this.monsterManListBox.Name = "monsterManListBox";
            this.monsterManListBox.Size = new System.Drawing.Size(205, 304);
            this.monsterManListBox.TabIndex = 0;
            // 
            // addMonsterButton
            // 
            this.addMonsterButton.BackColor = System.Drawing.Color.Firebrick;
            this.addMonsterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMonsterButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMonsterButton.Location = new System.Drawing.Point(12, 351);
            this.addMonsterButton.Name = "addMonsterButton";
            this.addMonsterButton.Size = new System.Drawing.Size(94, 23);
            this.addMonsterButton.TabIndex = 75;
            this.addMonsterButton.Text = "Add Monster";
            this.addMonsterButton.UseVisualStyleBackColor = false;
            this.addMonsterButton.Click += new System.EventHandler(this.addMonsterButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(71, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(146, 23);
            this.searchBox.TabIndex = 76;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(5, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 21);
            this.searchLabel.TabIndex = 77;
            this.searchLabel.Text = "Search:";
            // 
            // MonManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(229, 382);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addMonsterButton);
            this.Controls.Add(this.monsterManListBox);
            this.Name = "MonManForm";
            this.Text = "Monster Manual Creatures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox monsterManListBox;
        public Button addMonsterButton;
        private TextBox searchBox;
        private Label searchLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}