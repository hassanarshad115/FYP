namespace FYP
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mcstabPage1 = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.springradioButton = new System.Windows.Forms.RadioButton();
            this.fallradioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.mcstabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.mcstabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 194);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 196);
            this.tabControl1.TabIndex = 0;
            // 
            // mcstabPage1
            // 
            this.mcstabPage1.BackColor = System.Drawing.Color.Silver;
            this.mcstabPage1.Controls.Add(this.maskedTextBox1);
            this.mcstabPage1.Controls.Add(this.springradioButton);
            this.mcstabPage1.Controls.Add(this.fallradioButton);
            this.mcstabPage1.Controls.Add(this.button1);
            this.mcstabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcstabPage1.Location = new System.Drawing.Point(4, 22);
            this.mcstabPage1.Name = "mcstabPage1";
            this.mcstabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.mcstabPage1.Size = new System.Drawing.Size(298, 170);
            this.mcstabPage1.TabIndex = 0;
            this.mcstabPage1.Text = "MCS";
            this.mcstabPage1.ToolTipText = "MCS";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(113, 41);
            this.maskedTextBox1.Mask = "2000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(60, 21);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // springradioButton
            // 
            this.springradioButton.AutoSize = true;
            this.springradioButton.Location = new System.Drawing.Point(39, 83);
            this.springradioButton.Name = "springradioButton";
            this.springradioButton.Size = new System.Drawing.Size(61, 19);
            this.springradioButton.TabIndex = 1;
            this.springradioButton.TabStop = true;
            this.springradioButton.Text = "Spring";
            this.springradioButton.UseVisualStyleBackColor = true;
            // 
            // fallradioButton
            // 
            this.fallradioButton.AutoSize = true;
            this.fallradioButton.Location = new System.Drawing.Point(192, 83);
            this.fallradioButton.Name = "fallradioButton";
            this.fallradioButton.Size = new System.Drawing.Size(45, 19);
            this.fallradioButton.TabIndex = 2;
            this.fallradioButton.TabStop = true;
            this.fallradioButton.Text = "Fall";
            this.fallradioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(298, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BSCS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result System";
            this.tabControl1.ResumeLayout(false);
            this.mcstabPage1.ResumeLayout(false);
            this.mcstabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mcstabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton springradioButton;
        private System.Windows.Forms.RadioButton fallradioButton;
        private System.Windows.Forms.Button button1;
    }
}