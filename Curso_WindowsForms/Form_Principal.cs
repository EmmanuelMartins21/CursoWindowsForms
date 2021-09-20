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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void button_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            Form_DemonstracaoKey formDKey = new Form_DemonstracaoKey();
            formDKey.ShowDialog();
        }

        private void button_HelloWorld_Click(object sender, EventArgs e)
        {
            formHelloWorld f = new formHelloWorld();
            f.ShowDialog();
        }

        private void button_Mascara_Click(object sender, EventArgs e)
        {
            Form_Mascara f = new Form_Mascara();
            f.ShowDialog();
        }

        private void button_ValidaCPF_Click(object sender, EventArgs e)
        {
            Form_ValidaCPF f = new Form_ValidaCPF();
            f.ShowDialog();
        }

        private void button_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Form_ValidaCPF2 f = new Form_ValidaCPF2();
            f.ShowDialog();
        }

        private void button_ValidaSenha_Click(object sender, EventArgs e)
        {
            Form_ValidaSenha f = new Form_ValidaSenha();
            f.ShowDialog();
        }
    }
}
