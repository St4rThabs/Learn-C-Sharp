namespace TrocaDeValores
{
    partial class frmTrocaDeValores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botaoTrocar = new Button();
            txtPrimeiroValor = new TextBox();
            txtSegundoValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // botaoTrocar
            // 
            botaoTrocar.Location = new Point(87, 50);
            botaoTrocar.Name = "botaoTrocar";
            botaoTrocar.Size = new Size(75, 23);
            botaoTrocar.TabIndex = 0;
            botaoTrocar.Text = "Trocar";
            botaoTrocar.UseVisualStyleBackColor = true;
            botaoTrocar.Click += botaoTrocar_Click;
            // 
            // txtPrimeiroValor
            // 
            txtPrimeiroValor.Location = new Point(48, 24);
            txtPrimeiroValor.Multiline = true;
            txtPrimeiroValor.Name = "txtPrimeiroValor";
            txtPrimeiroValor.Size = new Size(70, 20);
            txtPrimeiroValor.TabIndex = 1;
            // 
            // txtSegundoValor
            // 
            txtSegundoValor.Location = new Point(169, 24);
            txtSegundoValor.Multiline = true;
            txtSegundoValor.Name = "txtSegundoValor";
            txtSegundoValor.Size = new Size(70, 20);
            txtSegundoValor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 27);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor 2:";
            // 
            // frmTrocaDeValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 76);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSegundoValor);
            Controls.Add(txtPrimeiroValor);
            Controls.Add(botaoTrocar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTrocaDeValores";
            Text = "Troca de valores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoTrocar;
        private TextBox txtPrimeiroValor;
        private TextBox txtSegundoValor;
        private Label label1;
        private Label label2;
    }
}
