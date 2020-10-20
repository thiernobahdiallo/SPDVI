namespace Exercices7Combobox
{
    partial class Form1
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
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.textBoxColors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.AutoCompleteCustomSource.AddRange(new string[] {
            "Yellow",
            "Blue",
            "Green",
            "Red",
            "Black"});
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Yellow",
            "Green",
            "Blue",
            "Red",
            "Black"});
            this.comboBoxColors.Location = new System.Drawing.Point(252, 53);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColors.TabIndex = 0;
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxColors_SelectedIndexChanged);
            // 
            // textBoxColors
            // 
            this.textBoxColors.Location = new System.Drawing.Point(252, 232);
            this.textBoxColors.Name = "textBoxColors";
            this.textBoxColors.Size = new System.Drawing.Size(259, 20);
            this.textBoxColors.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxColors);
            this.Controls.Add(this.comboBoxColors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.TextBox textBoxColors;
    }
}

