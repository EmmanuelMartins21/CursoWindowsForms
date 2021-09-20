
namespace Curso_WindowsForms
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.button_DemonstracaoKey = new System.Windows.Forms.Button();
            this.button_HelloWorld = new System.Windows.Forms.Button();
            this.button_Mascara = new System.Windows.Forms.Button();
            this.button_ValidaCPF = new System.Windows.Forms.Button();
            this.button_ValidaCPF2 = new System.Windows.Forms.Button();
            this.button_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_DemonstracaoKey
            // 
            this.button_DemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("button_DemonstracaoKey.Image")));
            this.button_DemonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.button_DemonstracaoKey.Name = "button_DemonstracaoKey";
            this.button_DemonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.button_DemonstracaoKey.TabIndex = 0;
            this.button_DemonstracaoKey.Text = "Demonstração Key";
            this.button_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.button_DemonstracaoKey.Click += new System.EventHandler(this.button_DemonstracaoKey_Click);
            // 
            // button_HelloWorld
            // 
            this.button_HelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("button_HelloWorld.Image")));
            this.button_HelloWorld.Location = new System.Drawing.Point(132, 12);
            this.button_HelloWorld.Name = "button_HelloWorld";
            this.button_HelloWorld.Size = new System.Drawing.Size(114, 48);
            this.button_HelloWorld.TabIndex = 1;
            this.button_HelloWorld.Text = "Hello World";
            this.button_HelloWorld.UseVisualStyleBackColor = true;
            this.button_HelloWorld.Click += new System.EventHandler(this.button_HelloWorld_Click);
            // 
            // button_Mascara
            // 
            this.button_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("button_Mascara.Image")));
            this.button_Mascara.Location = new System.Drawing.Point(252, 12);
            this.button_Mascara.Name = "button_Mascara";
            this.button_Mascara.Size = new System.Drawing.Size(114, 48);
            this.button_Mascara.TabIndex = 2;
            this.button_Mascara.Text = "Mascara";
            this.button_Mascara.UseVisualStyleBackColor = true;
            this.button_Mascara.Click += new System.EventHandler(this.button_Mascara_Click);
            // 
            // button_ValidaCPF
            // 
            this.button_ValidaCPF.Image = ((System.Drawing.Image)(resources.GetObject("button_ValidaCPF.Image")));
            this.button_ValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.button_ValidaCPF.Name = "button_ValidaCPF";
            this.button_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.button_ValidaCPF.TabIndex = 3;
            this.button_ValidaCPF.Text = "Valida CPF";
            this.button_ValidaCPF.UseVisualStyleBackColor = true;
            this.button_ValidaCPF.Click += new System.EventHandler(this.button_ValidaCPF_Click);
            // 
            // button_ValidaCPF2
            // 
            this.button_ValidaCPF2.Image = ((System.Drawing.Image)(resources.GetObject("button_ValidaCPF2.Image")));
            this.button_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.button_ValidaCPF2.Name = "button_ValidaCPF2";
            this.button_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.button_ValidaCPF2.TabIndex = 4;
            this.button_ValidaCPF2.Text = "Valida CPF2";
            this.button_ValidaCPF2.UseVisualStyleBackColor = true;
            this.button_ValidaCPF2.Click += new System.EventHandler(this.button_ValidaCPF2_Click);
            // 
            // button_ValidaSenha
            // 
            this.button_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("button_ValidaSenha.Image")));
            this.button_ValidaSenha.Location = new System.Drawing.Point(251, 66);
            this.button_ValidaSenha.Name = "button_ValidaSenha";
            this.button_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.button_ValidaSenha.TabIndex = 5;
            this.button_ValidaSenha.Text = "Valida Senha";
            this.button_ValidaSenha.UseVisualStyleBackColor = true;
            this.button_ValidaSenha.Click += new System.EventHandler(this.button_ValidaSenha_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.button_ValidaSenha);
            this.Controls.Add(this.button_ValidaCPF2);
            this.Controls.Add(this.button_ValidaCPF);
            this.Controls.Add(this.button_Mascara);
            this.Controls.Add(this.button_HelloWorld);
            this.Controls.Add(this.button_DemonstracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_DemonstracaoKey;
        private System.Windows.Forms.Button button_HelloWorld;
        private System.Windows.Forms.Button button_Mascara;
        private System.Windows.Forms.Button button_ValidaCPF;
        private System.Windows.Forms.Button button_ValidaCPF2;
        private System.Windows.Forms.Button button_ValidaSenha;
    }
}