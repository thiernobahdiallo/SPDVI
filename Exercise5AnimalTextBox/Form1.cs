using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5AnimalTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BottonOk_Click(object sender, EventArgs e)
        {
            String animales = "Choosen Animals: ";
            if (checkBoxGato.Checked)
            {
                animales += " Gato ";
            }
            if (chekBoxRaton.Checked)
            {
                animales += " Raton ";
            }
            if (checkBoxPerro.Checked)
            {
                animales += " Perro ";
            }
            textBoxAnimals.Text = animales;

        }

        private void chekBoxRaton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnimals_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
