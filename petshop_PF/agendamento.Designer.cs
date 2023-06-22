namespace petshop_PF
{
    partial class agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agendamento));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbData = new Guna.UI.WinForms.GunaComboBox();
            this.cmbHora = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cmbMes = new Guna.UI.WinForms.GunaComboBox();
            this.cmbAno = new Guna.UI.WinForms.GunaComboBox();
            this.loginLabel = new Guna.UI.WinForms.GunaLabel();
            this.lblPet = new Guna.UI.WinForms.GunaLabel();
            this.cmbMinuto = new Guna.UI.WinForms.GunaComboBox();
            this.txtCpfTutor = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbPet = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cmbServico = new Guna.UI.WinForms.GunaComboBox();
            this.lblServico = new Guna.UI.WinForms.GunaLabel();
            this.btnAgendar = new Guna.UI.WinForms.GunaButton();
            this.txtValue = new Guna.UI.WinForms.GunaTextBox();
            this.lblValor = new Guna.UI.WinForms.GunaLabel();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.lblNameTutor = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "AGENDAMENTO";
            // 
            // cmbData
            // 
            this.cmbData.BackColor = System.Drawing.Color.Transparent;
            this.cmbData.BaseColor = System.Drawing.Color.White;
            this.cmbData.BorderColor = System.Drawing.Color.Silver;
            this.cmbData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbData.FocusedColor = System.Drawing.Color.Empty;
            this.cmbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbData.ForeColor = System.Drawing.Color.Black;
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbData.Location = new System.Drawing.Point(125, 322);
            this.cmbData.Name = "cmbData";
            this.cmbData.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbData.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbData.Size = new System.Drawing.Size(82, 27);
            this.cmbData.TabIndex = 16;
            // 
            // cmbHora
            // 
            this.cmbHora.BackColor = System.Drawing.Color.Transparent;
            this.cmbHora.BaseColor = System.Drawing.Color.White;
            this.cmbHora.BorderColor = System.Drawing.Color.Silver;
            this.cmbHora.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FocusedColor = System.Drawing.Color.Empty;
            this.cmbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHora.ForeColor = System.Drawing.Color.Black;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cmbHora.Location = new System.Drawing.Point(125, 397);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbHora.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbHora.Size = new System.Drawing.Size(82, 27);
            this.cmbHora.TabIndex = 18;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(121, 299);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Data";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(121, 374);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Hora";
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.BaseColor = System.Drawing.Color.White;
            this.cmbMes.BorderColor = System.Drawing.Color.Silver;
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.ForeColor = System.Drawing.Color.Black;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(254, 322);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMes.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMes.Size = new System.Drawing.Size(82, 27);
            this.cmbMes.TabIndex = 21;
            // 
            // cmbAno
            // 
            this.cmbAno.BackColor = System.Drawing.Color.Transparent;
            this.cmbAno.BaseColor = System.Drawing.Color.White;
            this.cmbAno.BorderColor = System.Drawing.Color.Silver;
            this.cmbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAno.ForeColor = System.Drawing.Color.Black;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbAno.Location = new System.Drawing.Point(383, 322);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAno.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAno.Size = new System.Drawing.Size(82, 27);
            this.cmbAno.TabIndex = 22;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(121, 206);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(77, 20);
            this.loginLabel.TabIndex = 23;
            this.loginLabel.Text = "CPF Tutor*:";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(292, 206);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(33, 20);
            this.lblPet.TabIndex = 24;
            this.lblPet.Text = "Pet:";
            // 
            // cmbMinuto
            // 
            this.cmbMinuto.BackColor = System.Drawing.Color.Transparent;
            this.cmbMinuto.BaseColor = System.Drawing.Color.White;
            this.cmbMinuto.BorderColor = System.Drawing.Color.Silver;
            this.cmbMinuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinuto.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinuto.ForeColor = System.Drawing.Color.Black;
            this.cmbMinuto.FormattingEnabled = true;
            this.cmbMinuto.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbMinuto.Location = new System.Drawing.Point(255, 397);
            this.cmbMinuto.Name = "cmbMinuto";
            this.cmbMinuto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMinuto.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMinuto.Size = new System.Drawing.Size(81, 27);
            this.cmbMinuto.TabIndex = 25;
            // 
            // txtCpfTutor
            // 
            this.txtCpfTutor.BaseColor = System.Drawing.Color.White;
            this.txtCpfTutor.BorderColor = System.Drawing.Color.Silver;
            this.txtCpfTutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpfTutor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCpfTutor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtCpfTutor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCpfTutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCpfTutor.Location = new System.Drawing.Point(125, 229);
            this.txtCpfTutor.Name = "txtCpfTutor";
            this.txtCpfTutor.PasswordChar = '\0';
            this.txtCpfTutor.SelectedText = "";
            this.txtCpfTutor.Size = new System.Drawing.Size(123, 30);
            this.txtCpfTutor.TabIndex = 26;
            this.txtCpfTutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfTutor_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(251, 299);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Mês";
            // 
            // cmbPet
            // 
            this.cmbPet.BackColor = System.Drawing.Color.Transparent;
            this.cmbPet.BaseColor = System.Drawing.Color.White;
            this.cmbPet.BorderColor = System.Drawing.Color.Silver;
            this.cmbPet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPet.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPet.ForeColor = System.Drawing.Color.Black;
            this.cmbPet.FormattingEnabled = true;
            this.cmbPet.Location = new System.Drawing.Point(296, 233);
            this.cmbPet.Name = "cmbPet";
            this.cmbPet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbPet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPet.Size = new System.Drawing.Size(123, 26);
            this.cmbPet.TabIndex = 29;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(379, 299);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(38, 20);
            this.gunaLabel4.TabIndex = 30;
            this.gunaLabel4.Text = "Ano";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(251, 374);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel5.TabIndex = 31;
            this.gunaLabel5.Text = "Minuto";
            // 
            // cmbServico
            // 
            this.cmbServico.BackColor = System.Drawing.Color.Transparent;
            this.cmbServico.BaseColor = System.Drawing.Color.White;
            this.cmbServico.BorderColor = System.Drawing.Color.Silver;
            this.cmbServico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.FocusedColor = System.Drawing.Color.Empty;
            this.cmbServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbServico.ForeColor = System.Drawing.Color.Black;
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Items.AddRange(new object[] {
            "Banho",
            "Tosa",
            "Banho e Tosa"});
            this.cmbServico.Location = new System.Drawing.Point(125, 473);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbServico.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbServico.Size = new System.Drawing.Size(211, 26);
            this.cmbServico.TabIndex = 32;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(121, 450);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(61, 20);
            this.lblServico.TabIndex = 33;
            this.lblServico.Text = "Serviço";
            // 
            // btnAgendar
            // 
            this.btnAgendar.AnimationHoverSpeed = 0.07F;
            this.btnAgendar.AnimationSpeed = 0.03F;
            this.btnAgendar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnAgendar.BorderColor = System.Drawing.Color.Black;
            this.btnAgendar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgendar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgendar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Image = null;
            this.btnAgendar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgendar.Location = new System.Drawing.Point(196, 533);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnAgendar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgendar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgendar.OnHoverImage = null;
            this.btnAgendar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgendar.Size = new System.Drawing.Size(184, 37);
            this.btnAgendar.TabIndex = 43;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtValue
            // 
            this.txtValue.BaseColor = System.Drawing.Color.White;
            this.txtValue.BorderColor = System.Drawing.Color.Silver;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtValue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.txtValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValue.Location = new System.Drawing.Point(383, 469);
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.SelectedText = "";
            this.txtValue.Size = new System.Drawing.Size(82, 30);
            this.txtValue.TabIndex = 44;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(379, 446);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 45;
            this.lblValor.Text = "Valor";
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(125, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNameTutor
            // 
            this.lblNameTutor.AutoSize = true;
            this.lblNameTutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTutor.Location = new System.Drawing.Point(213, 265);
            this.lblNameTutor.Name = "lblNameTutor";
            this.lblNameTutor.Size = new System.Drawing.Size(0, 20);
            this.lblNameTutor.TabIndex = 47;
            // 
            // agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.lblNameTutor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cmbPet);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtCpfTutor);
            this.Controls.Add(this.cmbMinuto);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbData;
        private Guna.UI.WinForms.GunaComboBox cmbHora;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cmbMes;
        private Guna.UI.WinForms.GunaComboBox cmbAno;
        private Guna.UI.WinForms.GunaLabel loginLabel;
        private Guna.UI.WinForms.GunaLabel lblPet;
        private Guna.UI.WinForms.GunaComboBox cmbMinuto;
        private Guna.UI.WinForms.GunaTextBox txtCpfTutor;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cmbPet;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cmbServico;
        private Guna.UI.WinForms.GunaLabel lblServico;
        private Guna.UI.WinForms.GunaButton btnAgendar;
        private Guna.UI.WinForms.GunaTextBox txtValue;
        private Guna.UI.WinForms.GunaLabel lblValor;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaLabel lblNameTutor;
    }
}