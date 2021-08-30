
namespace Curso_WindowsForms
{
    partial class Form_Mascara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label_Conteudo = new System.Windows.Forms.Label();
            this.label_MascaraAtiva = new System.Windows.Forms.Label();
            this.button_Hora = new System.Windows.Forms.Button();
            this.button_CEP = new System.Windows.Forms.Button();
            this.button_Moeda = new System.Windows.Forms.Button();
            this.button_Data = new System.Windows.Forms.Button();
            this.button_Senha = new System.Windows.Forms.Button();
            this.button_Telefone = new System.Windows.Forms.Button();
            this.button_VerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox.Location = new System.Drawing.Point(23, 31);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(258, 26);
            this.maskedTextBox.TabIndex = 0;
            // 
            // label_Conteudo
            // 
            this.label_Conteudo.AutoSize = true;
            this.label_Conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Conteudo.Location = new System.Drawing.Point(23, 246);
            this.label_Conteudo.Name = "label_Conteudo";
            this.label_Conteudo.Size = new System.Drawing.Size(0, 19);
            this.label_Conteudo.TabIndex = 1;
            // 
            // label_MascaraAtiva
            // 
            this.label_MascaraAtiva.AutoSize = true;
            this.label_MascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.label_MascaraAtiva.Name = "label_MascaraAtiva";
            this.label_MascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.label_MascaraAtiva.TabIndex = 2;
            // 
            // button_Hora
            // 
            this.button_Hora.Location = new System.Drawing.Point(23, 110);
            this.button_Hora.Name = "button_Hora";
            this.button_Hora.Size = new System.Drawing.Size(82, 37);
            this.button_Hora.TabIndex = 3;
            this.button_Hora.Text = "Hora";
            this.button_Hora.UseVisualStyleBackColor = true;
            this.button_Hora.Click += new System.EventHandler(this.button_Hora_Click);
            // 
            // button_CEP
            // 
            this.button_CEP.Location = new System.Drawing.Point(111, 110);
            this.button_CEP.Name = "button_CEP";
            this.button_CEP.Size = new System.Drawing.Size(82, 37);
            this.button_CEP.TabIndex = 4;
            this.button_CEP.Text = "CEP";
            this.button_CEP.UseVisualStyleBackColor = true;
            this.button_CEP.Click += new System.EventHandler(this.button_CEP_Click);
            // 
            // button_Moeda
            // 
            this.button_Moeda.Location = new System.Drawing.Point(199, 110);
            this.button_Moeda.Name = "button_Moeda";
            this.button_Moeda.Size = new System.Drawing.Size(82, 37);
            this.button_Moeda.TabIndex = 5;
            this.button_Moeda.Text = "Moeda";
            this.button_Moeda.UseVisualStyleBackColor = true;
            this.button_Moeda.Click += new System.EventHandler(this.button_Moeda_Click);
            // 
            // button_Data
            // 
            this.button_Data.Location = new System.Drawing.Point(23, 153);
            this.button_Data.Name = "button_Data";
            this.button_Data.Size = new System.Drawing.Size(82, 37);
            this.button_Data.TabIndex = 6;
            this.button_Data.Text = "Data";
            this.button_Data.UseVisualStyleBackColor = true;
            this.button_Data.Click += new System.EventHandler(this.button_Data_Click);
            // 
            // button_Senha
            // 
            this.button_Senha.Location = new System.Drawing.Point(111, 153);
            this.button_Senha.Name = "button_Senha";
            this.button_Senha.Size = new System.Drawing.Size(82, 37);
            this.button_Senha.TabIndex = 7;
            this.button_Senha.Text = "Senha";
            this.button_Senha.UseVisualStyleBackColor = true;
            this.button_Senha.Click += new System.EventHandler(this.button_Senha_Click);
            // 
            // button_Telefone
            // 
            this.button_Telefone.Location = new System.Drawing.Point(199, 153);
            this.button_Telefone.Name = "button_Telefone";
            this.button_Telefone.Size = new System.Drawing.Size(82, 37);
            this.button_Telefone.TabIndex = 8;
            this.button_Telefone.Text = "Telefone";
            this.button_Telefone.UseVisualStyleBackColor = true;
            this.button_Telefone.Click += new System.EventHandler(this.button_Telefone_Click);
            // 
            // button_VerConteudo
            // 
            this.button_VerConteudo.Location = new System.Drawing.Point(23, 196);
            this.button_VerConteudo.Name = "button_VerConteudo";
            this.button_VerConteudo.Size = new System.Drawing.Size(258, 37);
            this.button_VerConteudo.TabIndex = 9;
            this.button_VerConteudo.Text = "Ver Conteudo";
            this.button_VerConteudo.UseVisualStyleBackColor = true;
            this.button_VerConteudo.Click += new System.EventHandler(this.button_VerConteudo_Click);
            // 
            // Form_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.button_VerConteudo);
            this.Controls.Add(this.button_Telefone);
            this.Controls.Add(this.button_Senha);
            this.Controls.Add(this.button_Data);
            this.Controls.Add(this.button_Moeda);
            this.Controls.Add(this.button_CEP);
            this.Controls.Add(this.button_Hora);
            this.Controls.Add(this.label_MascaraAtiva);
            this.Controls.Add(this.label_Conteudo);
            this.Controls.Add(this.maskedTextBox);
            this.Name = "Form_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos de máscaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label_Conteudo;
        private System.Windows.Forms.Label label_MascaraAtiva;
        private System.Windows.Forms.Button button_Hora;
        private System.Windows.Forms.Button button_CEP;
        private System.Windows.Forms.Button button_Moeda;
        private System.Windows.Forms.Button button_Data;
        private System.Windows.Forms.Button button_Senha;
        private System.Windows.Forms.Button button_Telefone;
        private System.Windows.Forms.Button button_VerConteudo;
    }
}