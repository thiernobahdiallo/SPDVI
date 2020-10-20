namespace Exercise9EvenOdd
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
            this.buttonEven = new System.Windows.Forms.Button();
            this.buttonOdd = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEven
            // 
            this.buttonEven.Location = new System.Drawing.Point(418, 65);
            this.buttonEven.Name = "buttonEven";
            this.buttonEven.Size = new System.Drawing.Size(75, 23);
            this.buttonEven.TabIndex = 0;
            this.buttonEven.Text = "Even (par)";
            this.buttonEven.UseVisualStyleBackColor = true;
            this.buttonEven.Click += new System.EventHandler(this.buttonEven_Click);
            // 
            // buttonOdd
            // 
            this.buttonOdd.Location = new System.Drawing.Point(576, 65);
            this.buttonOdd.Name = "buttonOdd";
            this.buttonOdd.Size = new System.Drawing.Size(75, 23);
            this.buttonOdd.TabIndex = 1;
            this.buttonOdd.Text = "Odd (impar)";
            this.buttonOdd.UseVisualStyleBackColor = true;
            this.buttonOdd.Click += new System.EventHandler(this.buttonOdd_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(242, 274);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(409, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.FormattingEnabled = true;
            this.comboBoxNumbers.Location = new System.Drawing.Point(127, 100);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumbers.TabIndex = 5;
            this.comboBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumbers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxNumbers);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonOdd);
            this.Controls.Add(this.buttonEven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEven;
        private System.Windows.Forms.Button buttonOdd;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxNumbers;
    }
}

