
namespace NovoBanco
{
    partial class FormCadastroConta
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
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitularCadastro = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.Label();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.pbxConta = new System.Windows.Forms.PictureBox();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.groupBoxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConta)).BeginInit();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textoNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textoNumero.Location = new System.Drawing.Point(97, 205);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(279, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoTitularCadastro
            // 
            this.textoTitularCadastro.Location = new System.Drawing.Point(97, 263);
            this.textoTitularCadastro.Name = "textoTitularCadastro";
            this.textoTitularCadastro.Size = new System.Drawing.Size(279, 20);
            this.textoTitularCadastro.TabIndex = 1;
            this.textoTitularCadastro.TextChanged += new System.EventHandler(this.textoTitularCadastro_TextChanged);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(24, 207);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(58, 16);
            this.Numero.TabIndex = 2;
            this.Numero.Text = "Numero";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(0, 0);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 23);
            this.textoTitular.TabIndex = 8;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.BackColor = System.Drawing.Color.CadetBlue;
            this.botaoCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.botaoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastro.ForeColor = System.Drawing.Color.White;
            this.botaoCadastro.Location = new System.Drawing.Point(155, 326);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(100, 30);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = false;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxCadastro.Controls.Add(this.comboTipoConta);
            this.groupBoxCadastro.Controls.Add(this.lblTitular);
            this.groupBoxCadastro.Controls.Add(this.label2);
            this.groupBoxCadastro.Controls.Add(this.lblSubTitulo);
            this.groupBoxCadastro.Controls.Add(this.pbxConta);
            this.groupBoxCadastro.Controls.Add(this.botaoCadastro);
            this.groupBoxCadastro.Controls.Add(this.Numero);
            this.groupBoxCadastro.Controls.Add(this.textoTitular);
            this.groupBoxCadastro.Controls.Add(this.textoTitularCadastro);
            this.groupBoxCadastro.Controls.Add(this.textoNumero);
            this.groupBoxCadastro.Location = new System.Drawing.Point(31, 26);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(401, 378);
            this.groupBoxCadastro.TabIndex = 5;
            this.groupBoxCadastro.TabStop = false;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(24, 265);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(49, 16);
            this.lblTitular.TabIndex = 9;
            this.lblTitular.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastre uma nova conta";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(112, 49);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(253, 41);
            this.lblSubTitulo.TabIndex = 6;
            this.lblSubTitulo.Text = "Seja Bem-vindo";
            this.lblSubTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pbxConta
            // 
            this.pbxConta.ImageLocation = "C:\\Users\\thabata.lima\\source\\repos\\NovoBanco\\conta.png";
            this.pbxConta.Location = new System.Drawing.Point(6, 40);
            this.pbxConta.Name = "pbxConta";
            this.pbxConta.Size = new System.Drawing.Size(100, 100);
            this.pbxConta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConta.TabIndex = 5;
            this.pbxConta.TabStop = false;
            this.pbxConta.Click += new System.EventHandler(this.pbxConta_Click);
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Location = new System.Drawing.Point(255, 155);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(121, 21);
            this.comboTipoConta.TabIndex = 10;
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboTipoConta_SelectedIndexChanged);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.groupBoxCadastro);
            this.Name = "FormCadastroConta";
            this.Text = "Form2";
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitularCadastro;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label textoTitular;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.PictureBox pbxConta;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}