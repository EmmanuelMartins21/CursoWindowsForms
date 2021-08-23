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
        {
            //limpa as infomações fornecidas e reccebidas
            textBox1.Clear();
            txt_Input.Clear();

            // volta as caixas de maiusculo e minusculo para vazia
            labelUpper.Text = "";
            labelLower.Text = "";
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            // adiciona uma quebra de linha,faz um comentario com qual tecla foi pressionada 
            // o responsavel por capturar a tecla pressionada e o KeyCode
            textBox1.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");

            //pega o codigo da tecla convertendo a mesma para inteiro. OBS: converção de dados explicita  
            textBox1.AppendText("\t" + "Codigo da tecla: " + ((int)e.KeyCode) + "\r\n");

            //pega o nome comum da tecla
            textBox1.AppendText("\t" + "Nome da tecla: " + e.KeyData + "\r\n");

            //Mostra a letra minuscula
            labelLower.Text = e.KeyCode.ToString().ToLower();

            //Mostra a letra maiuscula
            labelUpper.Text = e.KeyCode.ToString().ToUpper();
        }
    }
}
