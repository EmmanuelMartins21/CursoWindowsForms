
namespace Curso_WindowsForms
{
    partial class Form_ValidaSenha
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
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(12, 45);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(218, 20);
            this.textBox_Senha.TabIndex = 0;
            this.textBox_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Senha_KeyDown);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(12, 90);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(0, 22);
            this.label_Resultado.TabIndex = 1;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(245, 42);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(111, 23);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "Limpa";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // Form_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.textBox_Senha);
            this.Name = "Form_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Button button_Reset;
    }
}