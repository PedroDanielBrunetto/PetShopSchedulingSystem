namespace petshop_PF
{
    partial class cadastroPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroPet));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomePet = new Guna.UI.WinForms.GunaTextBox();
            this.lblCpf = new Guna.UI.WinForms.GunaLabel();
            this.cmbTipoPet = new Guna.UI.WinForms.GunaComboBox();
            this.lblNomePet = new Guna.UI.WinForms.GunaLabel();
            this.lblTipoAnimal = new Guna.UI.WinForms.GunaLabel();
            this.txtPullCpf = new Guna.UI.WinForms.GunaTextBox();
            this.lblRacaAnimal = new Guna.UI.WinForms.GunaLabel();
            this.txtRacaAnimal = new Guna.UI.WinForms.GunaTextBox();
            this.btnCadastrarPet = new Guna.UI.WinForms.GunaButton();
            this.lblNameTutor = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "CADASTRO PET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomePet
            // 
            this.txtNomePet.BaseColor = System.Drawing.Color.White;
            this.txtNomePet.BorderColor = System.Drawing.Color.Silver;
            this.txtNomePet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomePet.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomePet.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtNomePet.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomePet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomePet.Location = new System.Drawing.Point(129, 321);
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.PasswordChar = '\0';
            this.txtNomePet.SelectedText = "";
            this.txtNomePet.Size = new System.Drawing.Size(230, 30);
            this.txtNomePet.TabIndex = 34;
            this.txtNomePet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePet_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(125, 226);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(93, 20);
            this.lblCpf.TabIndex = 36;
            this.lblCpf.Text = "CPF do tutor*:";
            // 
            // cmbTipoPet
            // 
            this.cmbTipoPet.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoPet.BaseColor = System.Drawing.Color.White;
            this.cmbTipoPet.BorderColor = System.Drawing.Color.Silver;
            this.cmbTipoPet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPet.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoPet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoPet.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoPet.FormattingEnabled = true;
            this.cmbTipoPet.Items.AddRange(new object[] {
            "Cachorro",
            "Gato"});
            this.cmbTipoPet.Location = new System.Drawing.Point(129, 396);
            this.cmbTipoPet.Name = "cmbTipoPet";
            this.cmbTipoPet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTipoPet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTipoPet.Size = new System.Drawing.Size(230, 26);
            this.cmbTipoPet.TabIndex = 37;
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePet.Location = new System.Drawing.Point(125, 298);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(98, 20);
            this.lblNomePet.TabIndex = 38;
            this.lblNomePet.Text = "Nome do Pet*:";
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnimal.Location = new System.Drawing.Point(125, 373);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(64, 20);
            this.lblTipoAnimal.TabIndex = 39;
            this.lblTipoAnimal.Text = "Espécie*";
            // 
            // txtPullCpf
            // 
            this.txtPullCpf.BaseColor = System.Drawing.Color.White;
            this.txtPullCpf.BorderColor = System.Drawing.Color.Silver;
            this.txtPullCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPullCpf.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPullCpf.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtPullCpf.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPullCpf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPullCpf.Location = new System.Drawing.Point(129, 249);
            this.txtPullCpf.Name = "txtPullCpf";
            this.txtPullCpf.PasswordChar = '\0';
            this.txtPullCpf.SelectedText = "";
            this.txtPullCpf.Size = new System.Drawing.Size(230, 30);
            this.txtPullCpf.TabIndex = 33;
            this.txtPullCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPullCpf_KeyPress);
            // 
            // lblRacaAnimal
            // 
            this.lblRacaAnimal.AutoSize = true;
            this.lblRacaAnimal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacaAnimal.Location = new System.Drawing.Point(125, 437);
            this.lblRacaAnimal.Name = "lblRacaAnimal";
            this.lblRacaAnimal.Size = new System.Drawing.Size(48, 20);
            this.lblRacaAnimal.TabIndex = 41;
            this.lblRacaAnimal.Text = "Raça*:";
            // 
            // txtRacaAnimal
            // 
            this.txtRacaAnimal.BaseColor = System.Drawing.Color.White;
            this.txtRacaAnimal.BorderColor = System.Drawing.Color.Silver;
            this.txtRacaAnimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRacaAnimal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRacaAnimal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtRacaAnimal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRacaAnimal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRacaAnimal.Location = new System.Drawing.Point(129, 460);
            this.txtRacaAnimal.Name = "txtRacaAnimal";
            this.txtRacaAnimal.PasswordChar = '\0';
            this.txtRacaAnimal.SelectedText = "";
            this.txtRacaAnimal.Size = new System.Drawing.Size(230, 30);
            this.txtRacaAnimal.TabIndex = 40;
            // 
            // btnCadastrarPet
            // 
            this.btnCadastrarPet.AnimationHoverSpeed = 0.07F;
            this.btnCadastrarPet.AnimationSpeed = 0.03F;
            this.btnCadastrarPet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCadastrarPet.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarPet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCadastrarPet.FocusedColor = System.Drawing.Color.Empty;
            this.btnCadastrarPet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPet.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPet.Image = null;
            this.btnCadastrarPet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCadastrarPet.Location = new System.Drawing.Point(129, 521);
            this.btnCadastrarPet.Name = "btnCadastrarPet";
            this.btnCadastrarPet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCadastrarPet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCadastrarPet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCadastrarPet.OnHoverImage = null;
            this.btnCadastrarPet.OnPressedColor = System.Drawing.Color.Black;
            this.btnCadastrarPet.Size = new System.Drawing.Size(230, 37);
            this.btnCadastrarPet.TabIndex = 42;
            this.btnCadastrarPet.Text = "CADASTRAR";
            this.btnCadastrarPet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCadastrarPet.Click += new System.EventHandler(this.btnCadastrarPet_Click);
            // 
            // lblNameTutor
            // 
            this.lblNameTutor.AutoSize = true;
            this.lblNameTutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTutor.Location = new System.Drawing.Point(125, 282);
            this.lblNameTutor.Name = "lblNameTutor";
            this.lblNameTutor.Size = new System.Drawing.Size(14, 20);
            this.lblNameTutor.TabIndex = 43;
            this.lblNameTutor.Text = "*";
            // 
            // cadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.lblNameTutor);
            this.Controls.Add(this.btnCadastrarPet);
            this.Controls.Add(this.lblRacaAnimal);
            this.Controls.Add(this.txtRacaAnimal);
            this.Controls.Add(this.lblTipoAnimal);
            this.Controls.Add(this.lblNomePet);
            this.Controls.Add(this.cmbTipoPet);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.txtPullCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtNomePet;
        private Guna.UI.WinForms.GunaLabel lblCpf;
        private Guna.UI.WinForms.GunaComboBox cmbTipoPet;
        private Guna.UI.WinForms.GunaLabel lblNomePet;
        private Guna.UI.WinForms.GunaLabel lblTipoAnimal;
        private Guna.UI.WinForms.GunaTextBox txtPullCpf;
        private Guna.UI.WinForms.GunaLabel lblRacaAnimal;
        private Guna.UI.WinForms.GunaTextBox txtRacaAnimal;
        private Guna.UI.WinForms.GunaButton btnCadastrarPet;
        private Guna.UI.WinForms.GunaLabel lblNameTutor;
    }
}