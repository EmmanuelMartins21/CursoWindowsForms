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
    public partial class Form_DemonstracaoKey : Form
    {
        public Form_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void labelMaius_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {//limpa as duas caixas com infomações
            textBox1.Clear();
            txt_Input.Clear();
        }

        private void buttonInsere_Click(object sender, EventArgs e)
        {// Botão apenas idealizado, será criado uma lista para guardar esses dados
            textBox1.Text = txt_Input.Text.ToString();
            txt_Input.Clear();
        }
    }
}
