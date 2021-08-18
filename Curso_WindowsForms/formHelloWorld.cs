using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_WindowsForms
{
    public partial class formHelloWorld : Form
    {
        public formHelloWorld()
        {
            InitializeComponent();
        }

    
        private void formHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificaTexto_Click(object sender, EventArgs e)
        {
            label1.Text = textBoxModifica.Text.ToString();
        }
    }
}
