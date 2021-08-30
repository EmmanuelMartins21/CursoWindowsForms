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
    public partial class Form_Mascara : Form
    {
        public Form_Mascara()
        {
            InitializeComponent();
        }

        private void button_Hora_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;

            //Limpa o conteudo dos label's 
            label_Conteudo.Text = "";

            //Define o tipo de marcação 
            maskedTextBox.Mask = "00:00";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }

        private void button_CEP_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;
            label_Conteudo.Text = "";

            //Define o tipo de marcação
            maskedTextBox.Mask = "00000-000";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }

        private void button_Moeda_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;
            label_Conteudo.Text = "";

            //Define o tipo de marcação
            maskedTextBox.Mask = "$ 000,000,000.00";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }

        private void button_VerConteudo_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;
            label_Conteudo.Text = maskedTextBox.Text;
        }

        private void button_Data_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;
            label_Conteudo.Text = "";

            //Define o tipo de marcação
            maskedTextBox.Mask = "00/00/0000";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }

        private void button_Telefone_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto não é uma senha
            maskedTextBox.UseSystemPasswordChar = false;
            label_Conteudo.Text = "";

            //Define o tipo de marcação
            maskedTextBox.Mask = "(00) 0 0000-0000";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }

        private void button_Senha_Click(object sender, EventArgs e)
        {
            // Define  que o conteudo da caixa de texto é uma senha
            maskedTextBox.UseSystemPasswordChar = true;            
            label_Conteudo.Text = "";

            //Define o tipo de marcação
            maskedTextBox.Mask = "000000";
            label_MascaraAtiva.Text = maskedTextBox.Mask;

            //Limpa a caixa de texto e define o foco do cursor nela
            maskedTextBox.Text = "";
            maskedTextBox.Focus();
        }
    }
}
