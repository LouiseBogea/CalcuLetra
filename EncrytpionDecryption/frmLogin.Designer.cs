namespace EncrytpionDecryption
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassoword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.Linklabel = new System.Windows.Forms.LinkLabel();
            this.btnCloseSignup = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(146, 193);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 18);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuário";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Purple;
            this.txtUserName.Location = new System.Drawing.Point(226, 187);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 38);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(155, 241);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 18);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Senha";
            // 
            // txtPassoword
            // 
            this.txtPassoword.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassoword.ForeColor = System.Drawing.Color.Purple;
            this.txtPassoword.Location = new System.Drawing.Point(226, 233);
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.PasswordChar = '۝';
            this.txtPassoword.Size = new System.Drawing.Size(259, 40);
            this.txtPassoword.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::EncrytpionDecryption.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("RomanS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 184);
            this.label1.TabIndex = 9;
            this.label1.Text = "CalcuLetra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(29)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(313, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 29);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Conectar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Gray;
            this.btnCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Location = new System.Drawing.Point(402, 283);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(83, 29);
            this.btnCLose.TabIndex = 11;
            this.btnCLose.Text = "Fechar";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // Linklabel
            // 
            this.Linklabel.AutoSize = true;
            this.Linklabel.Location = new System.Drawing.Point(13, 325);
            this.Linklabel.Name = "Linklabel";
            this.Linklabel.Size = new System.Drawing.Size(52, 13);
            this.Linklabel.TabIndex = 12;
            this.Linklabel.TabStop = true;
            this.Linklabel.Text = "Cadastrar";
            this.Linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linklabel_LinkClicked);
            // 
            // btnCloseSignup
            // 
            this.btnCloseSignup.BackColor = System.Drawing.Color.Gray;
            this.btnCloseSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSignup.ForeColor = System.Drawing.Color.White;
            this.btnCloseSignup.Location = new System.Drawing.Point(93, 283);
            this.btnCloseSignup.Name = "btnCloseSignup";
            this.btnCloseSignup.Size = new System.Drawing.Size(83, 29);
            this.btnCloseSignup.TabIndex = 14;
            this.btnCloseSignup.Text = "Sair ";
            this.btnCloseSignup.UseVisualStyleBackColor = false;
            this.btnCloseSignup.Click += new System.EventHandler(this.btnCloseSignup_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(188)))));
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(4, 283);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(83, 29);
            this.btnSignup.TabIndex = 13;
            this.btnSignup.Text = "Cadastrar";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCLose;
            this.ClientSize = new System.Drawing.Size(662, 348);
            this.Controls.Add(this.btnCloseSignup);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.Linklabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassoword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassoword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.LinkLabel Linklabel;
        private System.Windows.Forms.Button btnCloseSignup;
        private System.Windows.Forms.Button btnSignup;
    }
}

