namespace CadastroPacientes
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            textoPassword = new MaskedTextBox();
            botaoLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSubtitulo = new Label();
            textoUsername = new TextBox();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textoPassword);
            panel1.Controls.Add(botaoLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(textoUsername);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(52, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 560);
            panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(331, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Register";
            linkLabel1.VisitedLinkColor = Color.DarkSlateBlue;
            // 
            // textoPassword
            // 
            textoPassword.BorderStyle = BorderStyle.FixedSingle;
            textoPassword.Font = new Font("Bahnschrift Light Condensed", 12.75F);
            textoPassword.Location = new Point(270, 302);
            textoPassword.Name = "textoPassword";
            textoPassword.PasswordChar = '*';
            textoPassword.Size = new Size(300, 28);
            textoPassword.TabIndex = 9;
            // 
            // botaoLogin
            // 
            botaoLogin.BackColor = Color.DarkSlateBlue;
            botaoLogin.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            botaoLogin.FlatStyle = FlatStyle.Flat;
            botaoLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoLogin.ForeColor = Color.White;
            botaoLogin.Location = new Point(309, 369);
            botaoLogin.Name = "botaoLogin";
            botaoLogin.Size = new Size(220, 30);
            botaoLogin.TabIndex = 8;
            botaoLogin.Text = "Login";
            botaoLogin.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 8.5F);
            lblPassword.Location = new Point(267, 284);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
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
            lblUsername.Click += lblUsername_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.Location = new Point(309, 114);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(208, 15);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Fill in your username and password     ";
            lblSubtitulo.Click += lblSubtitulo_Click;
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
            lblWelcome.Click += lblWelcome_Click;
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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(704, 641);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textoUsername;
        private Label lblWelcome;
        private PictureBox pictureBox1;
        private Label lblSubtitulo;
        private Label lblPassword;
        private Label lblUsername;
        private Button botaoLogin;
        private MaskedTextBox textoPassword;
        private LinkLabel linkLabel1;
    }
}
