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
    public partial class Form_ValidaCPF : Form
    {
        public Form_ValidaCPF()
        {
            InitializeComponent();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            //Apaga todos os campos
            label_Resultado.Text = "";
            maskedTextBox_CPF.Text = "";
        }

        private void button_Valida_Click(object sender, EventArgs e)
        {
            label_Resultado.Text = "";

            //cria variavel prar receber o retorno da função de validação
            bool validaCPF = false;
            string cpf = maskedTextBox_CPF.Text;
            validaCPF = Class_Uteis.Valida(cpf);

            if (validaCPF == true )
            {
                label_Resultado.Text = " CPF valido";
                label_Resultado.ForeColor = Color.Green;
            }
            else
            {
                label_Resultado.Text = " CPF invalido";
                label_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
