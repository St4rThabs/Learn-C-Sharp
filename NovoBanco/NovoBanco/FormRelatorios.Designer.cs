
namespace NovoBanco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.Resumo = new System.Windows.Forms.GroupBox();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.botaoMedia = new System.Windows.Forms.Button();
            this.Resumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(440, 160);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.BackColor = System.Drawing.Color.CadetBlue;
            this.botaoFiltroSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.botaoFiltroSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFiltroSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFiltroSaldo.ForeColor = System.Drawing.Color.Transparent;
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 399);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(110, 30);
            this.botaoFiltroSaldo.TabIndex = 5;
            this.botaoFiltroSaldo.Text = "Saldo > 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = false;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // Resumo
            // 
            this.Resumo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Resumo.Controls.Add(this.labelMaiorSaldo);
            this.Resumo.Controls.Add(this.labelSaldoTotal);
            this.Resumo.Controls.Add(this.label2);
            this.Resumo.Controls.Add(this.label1);
            this.Resumo.Location = new System.Drawing.Point(12, 196);
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(440, 183);
            this.Resumo.TabIndex = 6;
            this.Resumo.TabStop = false;
            this.Resumo.Text = "Resumo";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelMaiorSaldo.Location = new System.Drawing.Point(251, 119);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(121, 19);
            this.labelMaiorSaldo.TabIndex = 12;
            this.labelMaiorSaldo.Text = "labelMaiorSaldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelSaldoTotal.Location = new System.Drawing.Point(251, 48);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(116, 19);
            this.labelSaldoTotal.TabIndex = 11;
            this.labelSaldoTotal.Text = "labelSaldoTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Maior Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Saldo Total";
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.BackColor = System.Drawing.Color.CadetBlue;
            this.botaoAntigas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.botaoAntigas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAntigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAntigas.ForeColor = System.Drawing.Color.Transparent;
            this.botaoAntigas.Location = new System.Drawing.Point(342, 399);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(110, 30);
            this.botaoAntigas.TabIndex = 7;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = false;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // botaoMedia
            // 
            this.botaoMedia.BackColor = System.Drawing.Color.CadetBlue;
            this.botaoMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.botaoMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMedia.ForeColor = System.Drawing.Color.Transparent;
            this.botaoMedia.Location = new System.Drawing.Point(177, 399);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(110, 30);
            this.botaoMedia.TabIndex = 8;
            this.botaoMedia.Text = "Média";
            this.botaoMedia.UseVisualStyleBackColor = false;
            this.botaoMedia.Click += new System.EventHandler(this.botaoMedia_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.botaoMedia);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Resumo.ResumeLayout(false);
            this.Resumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.GroupBox Resumo;
        private System.Windows.Forms.Button botaoAntigas;
        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}