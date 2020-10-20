namespace Exercise6RadioButtonColor
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
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.textBoxColors = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(297, 51);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(297, 96);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 1;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(297, 148);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(53, 17);
            this.radioButtonWhite.TabIndex = 2;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // textBoxColors
            // 
            this.textBoxColors.Location = new System.Drawing.Point(297, 240);
            this.textBoxColors.Name = "textBoxColors";
            this.textBoxColors.Size = new System.Drawing.Size(278, 20);
            this.textBoxColors.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(183, 187);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxColors);
            this.Controls.Add(this.radioButtonWhite);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.radioButtonRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.TextBox textBoxColors;
        private System.Windows.Forms.Button buttonOK;
    }
}

