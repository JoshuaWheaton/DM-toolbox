namespace GroupProject
{
    partial class HPForm
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
            this.userPrompt = new System.Windows.Forms.Label();
            this.healthChangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthChangeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // userPrompt
            // 
            this.userPrompt.AutoSize = true;
            this.userPrompt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userPrompt.ForeColor = System.Drawing.SystemColors.Control;
            this.userPrompt.Location = new System.Drawing.Point(10, 21);
            this.userPrompt.Name = "userPrompt";
            this.userPrompt.Size = new System.Drawing.Size(263, 15);
            this.userPrompt.TabIndex = 0;
            this.userPrompt.Text = "How much would like to decrease the health by?";
            this.userPrompt.Click += new System.EventHandler(this.userPrompt_Click);
            // 
            // healthChangeNumericUpDown
            // 
            this.healthChangeNumericUpDown.Location = new System.Drawing.Point(122, 56);
            this.healthChangeNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.healthChangeNumericUpDown.Name = "healthChangeNumericUpDown";
            this.healthChangeNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.healthChangeNumericUpDown.Size = new System.Drawing.Size(61, 23);
            this.healthChangeNumericUpDown.TabIndex = 1;
            this.healthChangeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.healthChangeNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.healthChangeNumericUpDown_KeyDown);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(109, 95);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(82, 22);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(307, 128);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.healthChangeNumericUpDown);
            this.Controls.Add(this.userPrompt);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HPForm";
            this.Text = "HPForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_keypress);
            ((System.ComponentModel.ISupportInitialize)(this.healthChangeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userPrompt;
        private NumericUpDown healthChangeNumericUpDown;
        private Button confirmButton;
    }
}