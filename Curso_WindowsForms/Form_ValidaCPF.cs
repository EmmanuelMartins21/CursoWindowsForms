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

        // Função que valida o cpf dada pela propria alura.
        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
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
            validaCPF = Valida(cpf);

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
