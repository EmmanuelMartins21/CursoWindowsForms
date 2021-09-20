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
    public partial class Form_ValidaCPF2 : Form
    {
        public Form_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            maskedTextBox_CPF.Text = "";
        }

        private void button_Valida_Click(object sender, EventArgs e)
        {
            string Conteudo = maskedTextBox_CPF.Text;
            Conteudo = Conteudo.Replace(".", "").Replace("-", ""); // Substitui os valores por nada
            Conteudo = Conteudo.Trim();// Exclui os espços vazios
            if(Conteudo == "")
            {
                MessageBox.Show("Você precisa preencher o campo do CPF", "Resultado da Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Conteudo.Length == 12)
            {
                // COnfirmação se quer ou não validar o CPF digitado
                if (MessageBox.Show("Voce deseja validar mesmo esse CPF?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //cria variavel prar receber o retorno da função de validação
                    bool validaCPF = false;
                    string cpf = maskedTextBox_CPF.Text;
                    validaCPF = Class_Uteis.Valida(cpf);

                    if (validaCPF == true)
                    {
                        MessageBox.Show(" CPF valido", "Resultado da Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" CPF invalido", "Resultado da Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    maskedTextBox_CPF.Text = "";
                }
            }
            else
            {
                MessageBox.Show(" O CPF precisa conter 12 digitos", "Resultado da Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
