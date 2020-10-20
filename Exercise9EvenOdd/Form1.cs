using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9EvenOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEven_Click(object sender, EventArgs e)
        {
            comboBoxNumbers.Items.Clear();
            for(int i = 2; i < 12; i++)
            {
                if(i % 2 == 0)
                {
                    comboBoxNumbers.Items.Add(i);
                }
            }   
        }

        private void buttonOdd_Click(object sender, EventArgs e)
        {
            comboBoxNumbers.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    comboBoxNumbers.Items.Add(i);
                }
            }
        }

        private void comboBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxNumbers.SelectedIndex;
            String numero = "";
            numero = numero + comboBoxNumbers.Items[index];
            textBoxResult.Text = numero;
        }
    }
}
