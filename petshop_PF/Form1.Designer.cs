namespace petshop_PF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserLogin = new Guna.UI.WinForms.GunaTextBox();
            this.txtPasswordLogin = new Guna.UI.WinForms.GunaTextBox();
            this.loginLabel = new Guna.UI.WinForms.GunaLabel();
            this.passwordLabel = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkCadaster = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.BaseColor = System.Drawing.Color.White;
            this.txtUserLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtUserLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserLogin.Location = new System.Drawing.Point(124, 240);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.PasswordChar = '\0';
            this.txtUserLogin.SelectedText = "";
            this.txtUserLogin.Size = new System.Drawing.Size(230, 30);
            this.txtUserLogin.TabIndex = 1;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BaseColor = System.Drawing.Color.White;
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtPasswordLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordLogin.Location = new System.Drawing.Point(124, 321);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.SelectedText = "";
            this.txtPasswordLogin.Size = new System.Drawing.Size(230, 30);
            this.txtPasswordLogin.TabIndex = 2;
            this.txtPasswordLogin.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(120, 217);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 20);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Usuário:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(120, 298);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(51, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // linkCadaster
            // 
            this.linkCadaster.AutoSize = true;
            this.linkCadaster.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadaster.LinkColor = System.Drawing.Color.Blue;
            this.linkCadaster.Location = new System.Drawing.Point(121, 354);
            this.linkCadaster.Name = "linkCadaster";
            this.linkCadaster.Size = new System.Drawing.Size(198, 14);
            this.linkCadaster.TabIndex = 6;
            this.linkCadaster.TabStop = true;
            this.linkCadaster.Text = "Não tem cadastro?  Faça agora mesmo!";
            this.linkCadaster.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(124, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(230, 37);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkCadaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtUserLogin;
        private Guna.UI.WinForms.GunaTextBox txtPasswordLogin;
        private Guna.UI.WinForms.GunaLabel loginLabel;
        private Guna.UI.WinForms.GunaLabel passwordLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLinkLabel linkCadaster;
        private Guna.UI.WinForms.GunaButton btnLogin;
    }
}

