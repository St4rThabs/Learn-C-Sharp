namespace CadastroPacientes.View
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            panel1 = new Panel();
            btnVerSenha = new Button();
            lblForcePassword = new Label();
            lblConfirmPassword = new Label();
            mskConfirmPassword = new MaskedTextBox();
            mskPassword = new MaskedTextBox();
            btnRegister = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitulo = new Label();
            textoUsername = new TextBox();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            lblPasswordError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(lblPasswordError);
            panel1.Controls.Add(btnVerSenha);
            panel1.Controls.Add(lblForcePassword);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(mskConfirmPassword);
            panel1.Controls.Add(mskPassword);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(textoUsername);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(52, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 560);
            panel1.TabIndex = 4;
            // 
            // btnVerSenha
            // 
            btnVerSenha.BackColor = Color.Transparent;
            btnVerSenha.FlatAppearance.BorderSize = 0;
            btnVerSenha.FlatStyle = FlatStyle.Flat;
            btnVerSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerSenha.ForeColor = Color.Black;
            btnVerSenha.Image = Properties.Resources.eye1;
            btnVerSenha.Location = new Point(542, 286);
            btnVerSenha.Name = "btnVerSenha";
            btnVerSenha.Size = new Size(27, 26);
            btnVerSenha.TabIndex = 13;
            btnVerSenha.UseVisualStyleBackColor = false;
            btnVerSenha.Click += btnVerSenha_Click;
            // 
            // lblForcePassword
            // 
            lblForcePassword.AutoSize = true;
            lblForcePassword.Font = new Font("Segoe UI", 8.5F);
            lblForcePassword.Location = new Point(270, 325);
            lblForcePassword.Name = "lblForcePassword";
            lblForcePassword.Size = new Size(0, 15);
            lblForcePassword.TabIndex = 12;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 8.5F);
            lblConfirmPassword.Location = new Point(267, 344);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // mskConfirmPassword
            // 
            mskConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            mskConfirmPassword.Font = new Font("Bahnschrift Light Condensed", 12.75F);
            mskConfirmPassword.Location = new Point(270, 362);
            mskConfirmPassword.Name = "mskConfirmPassword";
            mskConfirmPassword.PasswordChar = '*';
            mskConfirmPassword.Size = new Size(300, 28);
            mskConfirmPassword.TabIndex = 10;
            // 
            // mskPassword
            // 
            mskPassword.BorderStyle = BorderStyle.FixedSingle;
            mskPassword.Font = new Font("Bahnschrift Light Condensed", 12.75F);
            mskPassword.Location = new Point(270, 285);
            mskPassword.Name = "mskPassword";
            mskPassword.PasswordChar = '*';
            mskPassword.Size = new Size(300, 28);
            mskPassword.TabIndex = 9;
            mskPassword.KeyDown += mskPassword_KeyDown;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateBlue;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(309, 434);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.5F);
            lblPassword.Location = new Point(267, 267);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 8.5F);
            lblUsername.Location = new Point(267, 194);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.Location = new Point(335, 114);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(152, 15);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Fill in and register your user";
            // 
            // textoUsername
            // 
            textoUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textoUsername.BorderStyle = BorderStyle.FixedSingle;
            textoUsername.Font = new Font("Bahnschrift Light Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textoUsername.Location = new Point(270, 212);
            textoUsername.Name = "textoUsername";
            textoUsername.Size = new Size(300, 28);
            textoUsername.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 32F);
            lblWelcome.Location = new Point(321, 55);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(199, 59);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 560);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI", 8.5F);
            lblPasswordError.Location = new Point(270, 405);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 15);
            lblPasswordError.TabIndex = 14;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(704, 641);
            Controls.Add(panel1);
            Name = "FormCadastro";
            Text = "Register";
            Load += FormCadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox mskPassword;
        private Button btnRegister;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblSubtitulo;
        private TextBox textoUsername;
        private Label lblWelcome;
        private PictureBox pictureBox1;
        private MaskedTextBox mskConfirmPassword;
        private Label lblForcePassword;
        private Label lblConfirmPassword;
        private Button btnVerSenha;
        private Label lblPasswordError;
    }
}