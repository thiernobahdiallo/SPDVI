using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClase1_Click(object sender, EventArgs e)
        {
            listBoxNombres.Items.Add("Julian");
            listBoxNombres.Items.Add("Maria");
            listBoxNombres.Items.Add("Sofia");
            listBoxNombres.Items.Add("Raul");
        }

        private void buttonClase2_Click(object sender, EventArgs e)
        {
            listBoxNombres.Items.Add("Alex");
            listBoxNombres.Items.Add("Toni");
            listBoxNombres.Items.Add("Donald");
            listBoxNombres.Items.Add("Michelle");
            listBoxNombres.Items.Add("John");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxNombres.Items.Clear();
        }

        private void listBoxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxNombres.SelectedIndex;
            String nombre = "";
            nombre = nombre + listBoxNombres.Items[index];
            textBoxNombres.Text = nombre;
        }
    }
}
