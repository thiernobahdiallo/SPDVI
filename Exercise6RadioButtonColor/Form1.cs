using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6RadioButtonColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            String colores = "Choosen Color: ";
            if (radioButtonRed.Checked)
            {
                colores += " Red ";
            }
            if (radioButtonBlue.Checked)
            {
                colores += " Blue ";
            }
            if (radioButtonWhite.Checked)
            {
                colores += " White ";
            }
            textBoxColors.Text = colores;
        }
    }
}
