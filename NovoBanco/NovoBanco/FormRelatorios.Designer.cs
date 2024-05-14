
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
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(440, 134);
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
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(120, 30);
            this.botaoFiltroSaldo.TabIndex = 5;
            this.botaoFiltroSaldo.Text = "Saldo > 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = false;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // Resumo
            // 
            this.Resumo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Resumo.Location = new System.Drawing.Point(12, 161);
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(440, 232);
            this.Resumo.TabIndex = 6;
            this.Resumo.TabStop = false;
            this.Resumo.Text = "Resumo";
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.BackColor = System.Drawing.Color.CadetBlue;
            this.botaoAntigas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.botaoAntigas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAntigas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAntigas.ForeColor = System.Drawing.Color.Transparent;
            this.botaoAntigas.Location = new System.Drawing.Point(332, 399);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(120, 30);
            this.botaoAntigas.TabIndex = 7;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = false;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.GroupBox Resumo;
        private System.Windows.Forms.Button botaoAntigas;
    }
}