namespace petshop_PF
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.linkLogin = new Guna.UI.WinForms.GunaLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.userCadaster = new Guna.UI.WinForms.GunaLabel();
            this.nameCadaster = new Guna.UI.WinForms.GunaLabel();
            this.txtUserCadaster = new Guna.UI.WinForms.GunaTextBox();
            this.txtNameCadaster = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailCadaster = new Guna.UI.WinForms.GunaTextBox();
            this.txtPasswordCadaster = new Guna.UI.WinForms.GunaTextBox();
            this.emailCadaster = new Guna.UI.WinForms.GunaLabel();
            this.passwordCadaster = new Guna.UI.WinForms.GunaLabel();
            this.btnCadaster = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkColor = System.Drawing.Color.Blue;
            this.linkLogin.Location = new System.Drawing.Point(127, 557);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(149, 14);
            this.linkLogin.TabIndex = 13;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Já tem cadastro? Entre agora";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "CADASTRO";
            // 
            // userCadaster
            // 
            this.userCadaster.AutoSize = true;
            this.userCadaster.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCadaster.Location = new System.Drawing.Point(126, 347);
            this.userCadaster.Name = "userCadaster";
            this.userCadaster.Size = new System.Drawing.Size(116, 20);
            this.userCadaster.TabIndex = 11;
            this.userCadaster.Text = "Nome de usuário:";
            // 
            // nameCadaster
            // 
            this.nameCadaster.AutoSize = true;
            this.nameCadaster.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCadaster.Location = new System.Drawing.Point(126, 266);
            this.nameCadaster.Name = "nameCadaster";
            this.nameCadaster.Size = new System.Drawing.Size(109, 20);
            this.nameCadaster.TabIndex = 10;
            this.nameCadaster.Text = "Nome completo:";
            // 
            // txtUserCadaster
            // 
            this.txtUserCadaster.BaseColor = System.Drawing.Color.White;
            this.txtUserCadaster.BorderColor = System.Drawing.Color.Silver;
            this.txtUserCadaster.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserCadaster.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserCadaster.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtUserCadaster.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserCadaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserCadaster.Location = new System.Drawing.Point(130, 370);
            this.txtUserCadaster.Name = "txtUserCadaster";
            this.txtUserCadaster.PasswordChar = '\0';
            this.txtUserCadaster.SelectedText = "";
            this.txtUserCadaster.Size = new System.Drawing.Size(230, 30);
            this.txtUserCadaster.TabIndex = 9;
            this.txtUserCadaster.TabStop = false;
            // 
            // txtNameCadaster
            // 
            this.txtNameCadaster.BaseColor = System.Drawing.Color.White;
            this.txtNameCadaster.BorderColor = System.Drawing.Color.Silver;
            this.txtNameCadaster.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCadaster.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameCadaster.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtNameCadaster.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameCadaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameCadaster.Location = new System.Drawing.Point(130, 289);
            this.txtNameCadaster.Name = "txtNameCadaster";
            this.txtNameCadaster.PasswordChar = '\0';
            this.txtNameCadaster.SelectedText = "";
            this.txtNameCadaster.Size = new System.Drawing.Size(230, 30);
            this.txtNameCadaster.TabIndex = 8;
            this.txtNameCadaster.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameCadaster_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmailCadaster
            // 
            this.txtEmailCadaster.BaseColor = System.Drawing.Color.White;
            this.txtEmailCadaster.BorderColor = System.Drawing.Color.Silver;
            this.txtEmailCadaster.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailCadaster.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmailCadaster.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtEmailCadaster.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmailCadaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailCadaster.Location = new System.Drawing.Point(130, 445);
            this.txtEmailCadaster.Name = "txtEmailCadaster";
            this.txtEmailCadaster.PasswordChar = '\0';
            this.txtEmailCadaster.SelectedText = "";
            this.txtEmailCadaster.Size = new System.Drawing.Size(230, 30);
            this.txtEmailCadaster.TabIndex = 14;
            this.txtEmailCadaster.TabStop = false;
            this.txtEmailCadaster.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailCadaster_Validating);
            // 
            // txtPasswordCadaster
            // 
            this.txtPasswordCadaster.BaseColor = System.Drawing.Color.White;
            this.txtPasswordCadaster.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordCadaster.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordCadaster.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPasswordCadaster.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtPasswordCadaster.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordCadaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPasswordCadaster.Location = new System.Drawing.Point(130, 524);
            this.txtPasswordCadaster.Name = "txtPasswordCadaster";
            this.txtPasswordCadaster.PasswordChar = '*';
            this.txtPasswordCadaster.SelectedText = "";
            this.txtPasswordCadaster.Size = new System.Drawing.Size(230, 30);
            this.txtPasswordCadaster.TabIndex = 15;
            this.txtPasswordCadaster.TabStop = false;
            // 
            // emailCadaster
            // 
            this.emailCadaster.AutoSize = true;
            this.emailCadaster.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCadaster.Location = new System.Drawing.Point(126, 422);
            this.emailCadaster.Name = "emailCadaster";
            this.emailCadaster.Size = new System.Drawing.Size(46, 20);
            this.emailCadaster.TabIndex = 16;
            this.emailCadaster.Text = "Email:";
            // 
            // passwordCadaster
            // 
            this.passwordCadaster.AutoSize = true;
            this.passwordCadaster.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCadaster.Location = new System.Drawing.Point(126, 501);
            this.passwordCadaster.Name = "passwordCadaster";
            this.passwordCadaster.Size = new System.Drawing.Size(51, 20);
            this.passwordCadaster.TabIndex = 17;
            this.passwordCadaster.Text = "Senha:";
            // 
            // btnCadaster
            // 
            this.btnCadaster.AnimationHoverSpeed = 0.07F;
            this.btnCadaster.AnimationSpeed = 0.03F;
            this.btnCadaster.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCadaster.BorderColor = System.Drawing.Color.Black;
            this.btnCadaster.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCadaster.FocusedColor = System.Drawing.Color.Empty;
            this.btnCadaster.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadaster.ForeColor = System.Drawing.Color.White;
            this.btnCadaster.Image = null;
            this.btnCadaster.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCadaster.Location = new System.Drawing.Point(130, 597);
            this.btnCadaster.Name = "btnCadaster";
            this.btnCadaster.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCadaster.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCadaster.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCadaster.OnHoverImage = null;
            this.btnCadaster.OnPressedColor = System.Drawing.Color.Black;
            this.btnCadaster.Size = new System.Drawing.Size(230, 37);
            this.btnCadaster.TabIndex = 18;
            this.btnCadaster.Text = "CADASTRAR";
            this.btnCadaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCadaster.Click += new System.EventHandler(this.btnCadaster_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.btnCadaster);
            this.Controls.Add(this.passwordCadaster);
            this.Controls.Add(this.emailCadaster);
            this.Controls.Add(this.txtPasswordCadaster);
            this.Controls.Add(this.txtEmailCadaster);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCadaster);
            this.Controls.Add(this.nameCadaster);
            this.Controls.Add(this.txtUserCadaster);
            this.Controls.Add(this.txtNameCadaster);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinkLabel linkLogin;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel userCadaster;
        private Guna.UI.WinForms.GunaLabel nameCadaster;
        private Guna.UI.WinForms.GunaTextBox txtUserCadaster;
        private Guna.UI.WinForms.GunaTextBox txtNameCadaster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtEmailCadaster;
        private Guna.UI.WinForms.GunaTextBox txtPasswordCadaster;
        private Guna.UI.WinForms.GunaLabel emailCadaster;
        private Guna.UI.WinForms.GunaLabel passwordCadaster;
        private Guna.UI.WinForms.GunaButton btnCadaster;
    }
}