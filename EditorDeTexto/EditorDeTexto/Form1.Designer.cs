
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
            this.botaoReplace = new System.Windows.Forms.Button();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoMaisuculo = new System.Windows.Forms.Button();
            this.botaoMinusculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoGrava
            // 
            this.botaoGrava.BackColor = System.Drawing.Color.SlateGray;
            this.botaoGrava.FlatAppearance.BorderSize = 0;
            this.botaoGrava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoGrava.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoGrava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoGrava.Location = new System.Drawing.Point(33, 355);
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
            this.textoConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoConteudo.Location = new System.Drawing.Point(12, 12);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoConteudo.Size = new System.Drawing.Size(472, 337);
            this.textoConteudo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoReplace);
            this.groupBox1.Controls.Add(this.botaoReplace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // textoBusca
            // 
            this.textoBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoBusca.Location = new System.Drawing.Point(62, 25);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(205, 20);
            this.textoBusca.TabIndex = 0;
            // 
            // botaoBusca
            // 
            this.botaoBusca.BackColor = System.Drawing.Color.SlateGray;
            this.botaoBusca.FlatAppearance.BorderSize = 0;
            this.botaoBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoBusca.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBusca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoBusca.Location = new System.Drawing.Point(273, 22);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find";
            // 
            // botaoReplace
            // 
            this.botaoReplace.BackColor = System.Drawing.Color.SlateGray;
            this.botaoReplace.FlatAppearance.BorderSize = 0;
            this.botaoReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoReplace.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoReplace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoReplace.Location = new System.Drawing.Point(273, 71);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 5;
            this.botaoReplace.Text = "Replace";
            this.botaoReplace.UseVisualStyleBackColor = false;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // textoReplace
            // 
            this.textoReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoReplace.Location = new System.Drawing.Point(62, 71);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(205, 20);
            this.textoReplace.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Replace";
            // 
            // botaoMaisuculo
            // 
            this.botaoMaisuculo.BackColor = System.Drawing.Color.SlateGray;
            this.botaoMaisuculo.FlatAppearance.BorderSize = 0;
            this.botaoMaisuculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMaisuculo.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMaisuculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoMaisuculo.Location = new System.Drawing.Point(33, 396);
            this.botaoMaisuculo.Name = "botaoMaisuculo";
            this.botaoMaisuculo.Size = new System.Drawing.Size(75, 23);
            this.botaoMaisuculo.TabIndex = 3;
            this.botaoMaisuculo.Text = "Maíusculo";
            this.botaoMaisuculo.UseVisualStyleBackColor = false;
            this.botaoMaisuculo.Click += new System.EventHandler(this.botaoMaisuculo_Click);
            // 
            // botaoMinusculo
            // 
            this.botaoMinusculo.BackColor = System.Drawing.Color.SlateGray;
            this.botaoMinusculo.FlatAppearance.BorderSize = 0;
            this.botaoMinusculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMinusculo.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMinusculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botaoMinusculo.Location = new System.Drawing.Point(33, 438);
            this.botaoMinusculo.Name = "botaoMinusculo";
            this.botaoMinusculo.Size = new System.Drawing.Size(75, 23);
            this.botaoMinusculo.TabIndex = 4;
            this.botaoMinusculo.Text = "Minúsculo";
            this.botaoMinusculo.UseVisualStyleBackColor = false;
            this.botaoMinusculo.Click += new System.EventHandler(this.botaoMinusculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.botaoMinusculo);
            this.Controls.Add(this.botaoMaisuculo);
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
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Button botaoMaisuculo;
        private System.Windows.Forms.Button botaoMinusculo;
    }
}

