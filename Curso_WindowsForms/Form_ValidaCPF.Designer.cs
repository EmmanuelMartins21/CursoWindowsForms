﻿
namespace Curso_WindowsForms
{
    partial class Form_ValidaCPF
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
            this.maskedTextBox_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox_CPF
            // 
            this.maskedTextBox_CPF.Location = new System.Drawing.Point(12, 45);
            this.maskedTextBox_CPF.Mask = "000,000,000-00";
            this.maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            this.maskedTextBox_CPF.Size = new System.Drawing.Size(218, 20);
            this.maskedTextBox_CPF.TabIndex = 0;
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
            // button_Valida
            // 
            this.button_Valida.Location = new System.Drawing.Point(245, 71);
            this.button_Valida.Name = "button_Valida";
            this.button_Valida.Size = new System.Drawing.Size(111, 23);
            this.button_Valida.TabIndex = 3;
            this.button_Valida.Text = "Valida";
            this.button_Valida.UseVisualStyleBackColor = true;
            this.button_Valida.Click += new System.EventHandler(this.button_Valida_Click);
            // 
            // Form_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.button_Valida);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.maskedTextBox_CPF);
            this.Name = "Form_ValidaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação CPF ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_CPF;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Valida;
    }
}