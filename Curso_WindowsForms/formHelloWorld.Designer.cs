
namespace Curso_WindowsForms
{
    partial class formHelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHelloWorld));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonModificaTexto = new System.Windows.Forms.Button();
            this.textBoxModifica = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visual Studio .NET VERSION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonModificaTexto
            // 
            this.buttonModificaTexto.Location = new System.Drawing.Point(25, 54);
            this.buttonModificaTexto.Name = "buttonModificaTexto";
            this.buttonModificaTexto.Size = new System.Drawing.Size(170, 25);
            this.buttonModificaTexto.TabIndex = 1;
            this.buttonModificaTexto.Text = "Modifica Texto do label";
            this.buttonModificaTexto.UseVisualStyleBackColor = true;
            this.buttonModificaTexto.Click += new System.EventHandler(this.buttonModificaTexto_Click);
            // 
            // textBoxModifica
            // 
            this.textBoxModifica.Location = new System.Drawing.Point(25, 95);
            this.textBoxModifica.Name = "textBoxModifica";
            this.textBoxModifica.Size = new System.Drawing.Size(247, 20);
            this.textBoxModifica.TabIndex = 2;
            this.textBoxModifica.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fechar aplicação";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formHelloWorld
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxModifica);
            this.Controls.Add(this.buttonModificaTexto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHelloWorld";
            this.Load += new System.EventHandler(this.formHelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonFecharAplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonModificaTexto;
        private System.Windows.Forms.TextBox textBoxModifica;
        private System.Windows.Forms.Button button2;
    }
}

