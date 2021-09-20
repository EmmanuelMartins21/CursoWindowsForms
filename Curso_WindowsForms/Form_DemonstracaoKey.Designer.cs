
namespace Curso_WindowsForms
{
    partial class Form_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DemonstracaoKey));
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMinus = new System.Windows.Forms.Label();
            this.labelMaius = new System.Windows.Forms.Label();
            this.labelUpper = new System.Windows.Forms.Label();
            this.labelLower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(8, 8);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(100, 20);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Input_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 232);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(328, 8);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 28);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Limpa";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Location = new System.Drawing.Point(320, 57);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(35, 13);
            this.labelMinus.TabIndex = 4;
            this.labelMinus.Text = "Maius";
            // 
            // labelMaius
            // 
            this.labelMaius.AutoSize = true;
            this.labelMaius.Location = new System.Drawing.Point(320, 104);
            this.labelMaius.Name = "labelMaius";
            this.labelMaius.Size = new System.Drawing.Size(35, 13);
            this.labelMaius.TabIndex = 5;
            this.labelMaius.Text = "Minus";
            this.labelMaius.Click += new System.EventHandler(this.labelMaius_Click);
            // 
            // labelUpper
            // 
            this.labelUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUpper.Location = new System.Drawing.Point(361, 56);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(32, 23);
            this.labelUpper.TabIndex = 6;
            // 
            // labelLower
            // 
            this.labelLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLower.Location = new System.Drawing.Point(361, 103);
            this.labelLower.Name = "labelLower";
            this.labelLower.Size = new System.Drawing.Size(32, 23);
            this.labelLower.TabIndex = 7;
            // 
            // Form_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.labelLower);
            this.Controls.Add(this.labelUpper);
            this.Controls.Add(this.labelMaius);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstracao Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label labelMaius;
        private System.Windows.Forms.Label labelUpper;
        private System.Windows.Forms.Label labelLower;
    }
}