namespace Exercise8ListBox
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
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.buttonClase1 = new System.Windows.Forms.Button();
            this.buttonClase2 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.Location = new System.Drawing.Point(164, 36);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(120, 95);
            this.listBoxNombres.TabIndex = 0;
            this.listBoxNombres.SelectedIndexChanged += new System.EventHandler(this.listBoxNombres_SelectedIndexChanged);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(506, 60);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombres.TabIndex = 1;
            // 
            // buttonClase1
            // 
            this.buttonClase1.Location = new System.Drawing.Point(164, 172);
            this.buttonClase1.Name = "buttonClase1";
            this.buttonClase1.Size = new System.Drawing.Size(75, 23);
            this.buttonClase1.TabIndex = 2;
            this.buttonClase1.Text = "Classroom 1";
            this.buttonClase1.UseVisualStyleBackColor = true;
            this.buttonClase1.Click += new System.EventHandler(this.buttonClase1_Click);
            // 
            // buttonClase2
            // 
            this.buttonClase2.Location = new System.Drawing.Point(164, 235);
            this.buttonClase2.Name = "buttonClase2";
            this.buttonClase2.Size = new System.Drawing.Size(75, 23);
            this.buttonClase2.TabIndex = 3;
            this.buttonClase2.Text = "Classroom 2";
            this.buttonClase2.UseVisualStyleBackColor = true;
            this.buttonClase2.Click += new System.EventHandler(this.buttonClase2_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(164, 307);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear List";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClase2);
            this.Controls.Add(this.buttonClase1);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.listBoxNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Button buttonClase1;
        private System.Windows.Forms.Button buttonClase2;
        private System.Windows.Forms.Button buttonClear;
    }
}

