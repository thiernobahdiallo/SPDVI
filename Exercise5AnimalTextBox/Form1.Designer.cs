namespace Exercise5AnimalTextBox
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
            this.chekBoxRaton = new System.Windows.Forms.CheckBox();
            this.checkBoxGato = new System.Windows.Forms.CheckBox();
            this.checkBoxPerro = new System.Windows.Forms.CheckBox();
            this.BottonOk = new System.Windows.Forms.Button();
            this.textBoxAnimals = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chekBoxRaton
            // 
            this.chekBoxRaton.AutoSize = true;
            this.chekBoxRaton.Location = new System.Drawing.Point(210, 41);
            this.chekBoxRaton.Name = "chekBoxRaton";
            this.chekBoxRaton.Size = new System.Drawing.Size(58, 17);
            this.chekBoxRaton.TabIndex = 0;
            this.chekBoxRaton.Text = "Mouse";
            this.chekBoxRaton.UseVisualStyleBackColor = true;
            this.chekBoxRaton.CheckedChanged += new System.EventHandler(this.chekBoxRaton_CheckedChanged);
            // 
            // checkBoxGato
            // 
            this.checkBoxGato.AutoSize = true;
            this.checkBoxGato.Location = new System.Drawing.Point(210, 87);
            this.checkBoxGato.Name = "checkBoxGato";
            this.checkBoxGato.Size = new System.Drawing.Size(42, 17);
            this.checkBoxGato.TabIndex = 1;
            this.checkBoxGato.Text = "Cat";
            this.checkBoxGato.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerro
            // 
            this.checkBoxPerro.AutoSize = true;
            this.checkBoxPerro.Location = new System.Drawing.Point(210, 138);
            this.checkBoxPerro.Name = "checkBoxPerro";
            this.checkBoxPerro.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPerro.TabIndex = 2;
            this.checkBoxPerro.Text = "Dog";
            this.checkBoxPerro.UseVisualStyleBackColor = true;
            // 
            // BottonOk
            // 
            this.BottonOk.Location = new System.Drawing.Point(177, 194);
            this.BottonOk.Name = "BottonOk";
            this.BottonOk.Size = new System.Drawing.Size(75, 23);
            this.BottonOk.TabIndex = 3;
            this.BottonOk.Text = "ok";
            this.BottonOk.UseVisualStyleBackColor = true;
            this.BottonOk.Click += new System.EventHandler(this.BottonOk_Click);
            // 
            // textBoxAnimals
            // 
            this.textBoxAnimals.Location = new System.Drawing.Point(290, 232);
            this.textBoxAnimals.Name = "textBoxAnimals";
            this.textBoxAnimals.Size = new System.Drawing.Size(330, 20);
            this.textBoxAnimals.TabIndex = 4;
            this.textBoxAnimals.TextChanged += new System.EventHandler(this.textBoxAnimals_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAnimals);
            this.Controls.Add(this.BottonOk);
            this.Controls.Add(this.checkBoxPerro);
            this.Controls.Add(this.checkBoxGato);
            this.Controls.Add(this.chekBoxRaton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chekBoxRaton;
        private System.Windows.Forms.CheckBox checkBoxGato;
        private System.Windows.Forms.CheckBox checkBoxPerro;
        private System.Windows.Forms.Button BottonOk;
        private System.Windows.Forms.TextBox textBoxAnimals;
    }
}

