namespace Exercise10Scrollbar
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
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scrollBar
            // 
            this.scrollBar.Location = new System.Drawing.Point(160, 45);
            this.scrollBar.Maximum = 89;
            this.scrollBar.Minimum = 50;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(320, 47);
            this.scrollBar.TabIndex = 0;
            this.scrollBar.Value = 50;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(222, 285);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(285, 20);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.scrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.TextBox textBox;
    }
}

