using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices7Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            String color = "The choosen color is: ";
            int index = comboBoxColors.SelectedIndex;
            color = color + comboBoxColors.Items[index];
            textBoxColors.Text = color;
        }
    }
}
