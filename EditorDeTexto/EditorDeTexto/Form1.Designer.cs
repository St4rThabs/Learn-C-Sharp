
namespace EditorDeTexto
{
    partial class Form1
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
            this.botaoGrava = new System.Windows.Forms.Button();
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoGrava
            // 
            this.botaoGrava.BackColor = System.Drawing.Color.SlateGray;
            this.botaoGrava.FlatAppearance.BorderSize = 0;
            this.botaoGrava.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoGrava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoGrava.Location = new System.Drawing.Point(12, 436);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 0;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = false;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // textoConteudo
            // 
            this.textoConteudo.BackColor = System.Drawing.Color.White;
            this.textoConteudo.Location = new System.Drawing.Point(12, 12);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(472, 353);
            this.textoConteudo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.Location = new System.Drawing.Point(146, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(58, 25);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(260, 20);
            this.textoBusca.TabIndex = 0;
            // 
            // botaoBusca
            // 
            this.botaoBusca.BackColor = System.Drawing.Color.SlateGray;
            this.botaoBusca.FlatAppearance.BorderSize = 0;
            this.botaoBusca.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoBusca.Location = new System.Drawing.Point(140, 65);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 3;
            this.botaoBusca.Text = "Find";
            this.botaoBusca.UseVisualStyleBackColor = false;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textoConteudo);
            this.Controls.Add(this.botaoGrava);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoBusca;
    }
}

