
namespace CursoWindowsFormsAlura
{
    partial class Frm_HelloWorld
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Modifica = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(206, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(250, 265);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Fechar a Aplicação";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Modifica
            // 
            this.btn_Modifica.Location = new System.Drawing.Point(30, 100);
            this.btn_Modifica.Name = "btn_Modifica";
            this.btn_Modifica.Size = new System.Drawing.Size(202, 23);
            this.btn_Modifica.TabIndex = 2;
            this.btn_Modifica.Text = "Modifica texto do label";
            this.btn_Modifica.UseVisualStyleBackColor = true;
            this.btn_Modifica.Click += new System.EventHandler(this.btn_Modifica_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(30, 65);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(200, 20);
            this.txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 300);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_Modifica);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Modifica;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

