using Projeto_Integrador_1.Util;

namespace Projeto_Integrador_1.TMSForms.Register
{
    partial class FormMotoristas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotoristas));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCNH = new System.Windows.Forms.Label();
            this.lblVencimentoCNH = new System.Windows.Forms.Label();
            this.lblCategoriaCNH = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.buttonBuscarCEP = new FontAwesome.Sharp.IconButton();
            this.btnEnviar = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textCelular = new System.Windows.Forms.MaskedTextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textCEP = new System.Windows.Forms.MaskedTextBox();
            this.textEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.combCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeVencimentoCNH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.textRG = new Guna.UI2.WinForms.Guna2TextBox();
            this.combStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textCNH = new Guna.UI2.WinForms.Guna2TextBox();
            this.combCategoriaCNH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combEstadoCivil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.textN = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.textComplemento = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.combEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(20, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(118, 18);
            this.lblNome.TabIndex = 88;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCPF.Location = new System.Drawing.Point(339, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 18);
            this.lblCPF.TabIndex = 90;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRG.Location = new System.Drawing.Point(609, 48);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 18);
            this.lblRG.TabIndex = 92;
            this.lblRG.Text = "RG";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(879, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 94;
            this.lblStatus.Text = "Status";
            // 
            // lblCNH
            // 
            this.lblCNH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCNH.AutoSize = true;
            this.lblCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCNH.Location = new System.Drawing.Point(20, 121);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(41, 18);
            this.lblCNH.TabIndex = 96;
            this.lblCNH.Text = "CNH";
            // 
            // lblVencimentoCNH
            // 
            this.lblVencimentoCNH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVencimentoCNH.AutoSize = true;
            this.lblVencimentoCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimentoCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVencimentoCNH.Location = new System.Drawing.Point(319, 121);
            this.lblVencimentoCNH.Name = "lblVencimentoCNH";
            this.lblVencimentoCNH.Size = new System.Drawing.Size(123, 18);
            this.lblVencimentoCNH.TabIndex = 98;
            this.lblVencimentoCNH.Text = "Vencimento CNH";
            // 
            // lblCategoriaCNH
            // 
            this.lblCategoriaCNH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoriaCNH.AutoSize = true;
            this.lblCategoriaCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoriaCNH.Location = new System.Drawing.Point(546, 121);
            this.lblCategoriaCNH.Name = "lblCategoriaCNH";
            this.lblCategoriaCNH.Size = new System.Drawing.Size(72, 18);
            this.lblCategoriaCNH.TabIndex = 101;
            this.lblCategoriaCNH.Text = "Categoria";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSexo.Location = new System.Drawing.Point(696, 121);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 18);
            this.lblSexo.TabIndex = 103;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadoCivil.Location = new System.Drawing.Point(846, 121);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 18);
            this.lblEstadoCivil.TabIndex = 105;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(20, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "INFORMAÇÕES PESSOAIS";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(20, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 2);
            this.panel1.TabIndex = 86;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(20, 218);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 2);
            this.panel2.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(20, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 20);
            this.label16.TabIndex = 106;
            this.label16.Text = "INFORMAÇÕES ADICIONAIS";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Location = new System.Drawing.Point(220, 307);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 168;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCidade.Location = new System.Drawing.Point(20, 307);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 18);
            this.lblCidade.TabIndex = 167;
            this.lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComplemento.Location = new System.Drawing.Point(789, 234);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(102, 18);
            this.lblComplemento.TabIndex = 165;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBairro.Location = new System.Drawing.Point(589, 234);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 18);
            this.lblBairro.TabIndex = 163;
            this.lblBairro.Text = "Bairro";
            // 
            // lblN
            // 
            this.lblN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblN.Location = new System.Drawing.Point(489, 235);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(24, 18);
            this.lblN.TabIndex = 161;
            this.lblN.Text = "Nº";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndereco.Location = new System.Drawing.Point(170, 235);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 18);
            this.lblEndereco.TabIndex = 159;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCEP.Location = new System.Drawing.Point(20, 234);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 18);
            this.lblCEP.TabIndex = 157;
            this.lblCEP.Text = "CEP";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(629, 380);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 177;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCelular.Location = new System.Drawing.Point(435, 380);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 18);
            this.lblCelular.TabIndex = 175;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefone.Location = new System.Drawing.Point(240, 380);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 18);
            this.lblTelefone.TabIndex = 173;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCargo.Location = new System.Drawing.Point(20, 380);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 179;
            this.lblCargo.Text = "Cargo";
            // 
            // buttonBuscarCEP
            // 
            this.buttonBuscarCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuscarCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(186)))), ((int)(((byte)(69)))));
            this.buttonBuscarCEP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.buttonBuscarCEP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.buttonBuscarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCEP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBuscarCEP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonBuscarCEP.IconColor = System.Drawing.Color.White;
            this.buttonBuscarCEP.IconSize = 16;
            this.buttonBuscarCEP.Location = new System.Drawing.Point(115, 257);
            this.buttonBuscarCEP.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.buttonBuscarCEP.Name = "buttonBuscarCEP";
            this.buttonBuscarCEP.Rotation = 0D;
            this.buttonBuscarCEP.Size = new System.Drawing.Size(35, 35);
            this.buttonBuscarCEP.TabIndex = 11;
            this.buttonBuscarCEP.UseVisualStyleBackColor = false;
            this.buttonBuscarCEP.Click += new System.EventHandler(this.onBuscarCEP);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(186)))), ((int)(((byte)(69)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnviar.Font = new System.Drawing.Font("SansSerif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnEnviar.IconColor = System.Drawing.Color.White;
            this.btnEnviar.IconSize = 16;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(891, 481);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Rotation = 0D;
            this.btnEnviar.Size = new System.Drawing.Size(130, 35);
            this.btnEnviar.TabIndex = 180;
            this.btnEnviar.Text = "Salvar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.onEnviar);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Location = new System.Drawing.Point(240, 403);
            this.panel4.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 35);
            this.panel4.TabIndex = 191;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 8);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 90;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Location = new System.Drawing.Point(435, 403);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 35);
            this.panel5.TabIndex = 192;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Mobile;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox2.IconSize = 20;
            this.iconPictureBox2.Location = new System.Drawing.Point(9, 8);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox2.TabIndex = 90;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.iconPictureBox3);
            this.panel6.Location = new System.Drawing.Point(630, 403);
            this.panel6.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(35, 35);
            this.panel6.TabIndex = 193;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.At;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.iconPictureBox3.IconSize = 20;
            this.iconPictureBox3.Location = new System.Drawing.Point(9, 8);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox3.TabIndex = 90;
            this.iconPictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(339, 71);
            this.panel7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1);
            this.panel7.Size = new System.Drawing.Size(250, 35);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.textCPF);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 1);
            this.panel8.Margin = new System.Windows.Forms.Padding(1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(248, 33);
            this.panel8.TabIndex = 1;
            // 
            // textCPF
            // 
            this.textCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCPF.BackColor = System.Drawing.Color.White;
            this.textCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCPF.Location = new System.Drawing.Point(3, 7);
            this.textCPF.Mask = "000.000.000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(243, 22);
            this.textCPF.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(275, 403);
            this.panel9.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(1);
            this.panel9.Size = new System.Drawing.Size(140, 35);
            this.panel9.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.textTelefone);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(1, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(138, 33);
            this.panel10.TabIndex = 0;
            // 
            // textTelefone
            // 
            this.textTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTelefone.BackColor = System.Drawing.Color.White;
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textTelefone.Location = new System.Drawing.Point(3, 7);
            this.textTelefone.Mask = "(00) 90000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(133, 22);
            this.textTelefone.TabIndex = 20;
            this.textTelefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyPressUpTelefone);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Location = new System.Drawing.Point(470, 403);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(140, 35);
            this.panel3.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.textCelular);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(138, 33);
            this.panel11.TabIndex = 0;
            // 
            // textCelular
            // 
            this.textCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCelular.BackColor = System.Drawing.Color.White;
            this.textCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCelular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCelular.Location = new System.Drawing.Point(3, 7);
            this.textCelular.Mask = "(00) 90000-0000";
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(133, 22);
            this.textCelular.TabIndex = 21;
            this.textCelular.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyPressUpTelefone);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(20, 257);
            this.panel13.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(1);
            this.panel13.Size = new System.Drawing.Size(95, 35);
            this.panel13.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.textCEP);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(1, 1);
            this.panel14.Margin = new System.Windows.Forms.Padding(1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(93, 33);
            this.panel14.TabIndex = 0;
            // 
            // textCEP
            // 
            this.textCEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCEP.BackColor = System.Drawing.Color.White;
            this.textCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCEP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCEP.Location = new System.Drawing.Point(3, 7);
            this.textCEP.Mask = "00000-000";
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(88, 22);
            this.textCEP.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.DefaultText = "";
            this.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.DisabledState.Parent = this.textEmail;
            this.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.FocusedState.Parent = this.textEmail;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEmail.HoverState.Parent = this.textEmail;
            this.textEmail.Location = new System.Drawing.Point(665, 403);
            this.textEmail.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textEmail.Name = "textEmail";
            this.textEmail.PasswordChar = '\0';
            this.textEmail.PlaceholderText = "";
            this.textEmail.SelectedText = "";
            this.textEmail.ShadowDecoration.Parent = this.textEmail;
            this.textEmail.Size = new System.Drawing.Size(355, 35);
            this.textEmail.TabIndex = 22;
            // 
            // combCargo
            // 
            this.combCargo.BackColor = System.Drawing.Color.Transparent;
            this.combCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCargo.FocusedColor = System.Drawing.Color.Empty;
            this.combCargo.FocusedState.Parent = this.combCargo;
            this.combCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combCargo.FormattingEnabled = true;
            this.combCargo.HoverState.Parent = this.combCargo;
            this.combCargo.ItemHeight = 29;
            this.combCargo.ItemsAppearance.Parent = this.combCargo;
            this.combCargo.Location = new System.Drawing.Point(21, 403);
            this.combCargo.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combCargo.Name = "combCargo";
            this.combCargo.ShadowDecoration.Parent = this.combCargo;
            this.combCargo.Size = new System.Drawing.Size(199, 35);
            this.combCargo.TabIndex = 18;
            // 
            // timeVencimentoCNH
            // 
            this.timeVencimentoCNH.BackColor = System.Drawing.Color.Transparent;
            this.timeVencimentoCNH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.timeVencimentoCNH.BorderThickness = 1;
            this.timeVencimentoCNH.CheckedState.Parent = this.timeVencimentoCNH;
            this.timeVencimentoCNH.CustomFormat = " ";
            this.timeVencimentoCNH.FillColor = System.Drawing.Color.White;
            this.timeVencimentoCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.timeVencimentoCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeVencimentoCNH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeVencimentoCNH.HoverState.Parent = this.timeVencimentoCNH;
            this.timeVencimentoCNH.Location = new System.Drawing.Point(319, 144);
            this.timeVencimentoCNH.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.timeVencimentoCNH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeVencimentoCNH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeVencimentoCNH.Name = "timeVencimentoCNH";
            this.timeVencimentoCNH.ShadowDecoration.Parent = this.timeVencimentoCNH;
            this.timeVencimentoCNH.Size = new System.Drawing.Size(207, 35);
            this.timeVencimentoCNH.TabIndex = 6;
            this.timeVencimentoCNH.UseTransparentBackground = true;
            this.timeVencimentoCNH.Value = new System.DateTime(2020, 5, 3, 16, 47, 44, 411);
            // 
            // textNome
            // 
            this.textNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNome.DefaultText = "";
            this.textNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNome.DisabledState.Parent = this.textNome;
            this.textNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNome.FocusedState.Parent = this.textNome;
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textNome.HoverState.Parent = this.textNome;
            this.textNome.Location = new System.Drawing.Point(21, 71);
            this.textNome.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textNome.Name = "textNome";
            this.textNome.PasswordChar = '\0';
            this.textNome.PlaceholderText = "";
            this.textNome.SelectedText = "";
            this.textNome.ShadowDecoration.Parent = this.textNome;
            this.textNome.Size = new System.Drawing.Size(298, 35);
            this.textNome.TabIndex = 1;
            // 
            // textRG
            // 
            this.textRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textRG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRG.DefaultText = "";
            this.textRG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textRG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textRG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRG.DisabledState.Parent = this.textRG;
            this.textRG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRG.FocusedState.Parent = this.textRG;
            this.textRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textRG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRG.HoverState.Parent = this.textRG;
            this.textRG.Location = new System.Drawing.Point(609, 71);
            this.textRG.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textRG.Name = "textRG";
            this.textRG.PasswordChar = '\0';
            this.textRG.PlaceholderText = "";
            this.textRG.SelectedText = "";
            this.textRG.ShadowDecoration.Parent = this.textRG;
            this.textRG.Size = new System.Drawing.Size(250, 35);
            this.textRG.TabIndex = 3;
            // 
            // combStatus
            // 
            this.combStatus.BackColor = System.Drawing.Color.Transparent;
            this.combStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStatus.FocusedColor = System.Drawing.Color.Empty;
            this.combStatus.FocusedState.Parent = this.combStatus;
            this.combStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combStatus.FormattingEnabled = true;
            this.combStatus.HoverState.Parent = this.combStatus;
            this.combStatus.ItemHeight = 29;
            this.combStatus.ItemsAppearance.Parent = this.combStatus;
            this.combStatus.Location = new System.Drawing.Point(879, 71);
            this.combStatus.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combStatus.Name = "combStatus";
            this.combStatus.ShadowDecoration.Parent = this.combStatus;
            this.combStatus.Size = new System.Drawing.Size(141, 35);
            this.combStatus.TabIndex = 4;
            // 
            // textCNH
            // 
            this.textCNH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textCNH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCNH.DefaultText = "";
            this.textCNH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCNH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCNH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCNH.DisabledState.Parent = this.textCNH;
            this.textCNH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCNH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCNH.FocusedState.Parent = this.textCNH;
            this.textCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCNH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCNH.HoverState.Parent = this.textCNH;
            this.textCNH.Location = new System.Drawing.Point(20, 144);
            this.textCNH.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textCNH.Name = "textCNH";
            this.textCNH.PasswordChar = '\0';
            this.textCNH.PlaceholderText = "";
            this.textCNH.SelectedText = "";
            this.textCNH.ShadowDecoration.Parent = this.textCNH;
            this.textCNH.Size = new System.Drawing.Size(279, 35);
            this.textCNH.TabIndex = 5;
            // 
            // combCategoriaCNH
            // 
            this.combCategoriaCNH.BackColor = System.Drawing.Color.Transparent;
            this.combCategoriaCNH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combCategoriaCNH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combCategoriaCNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCategoriaCNH.FocusedColor = System.Drawing.Color.Empty;
            this.combCategoriaCNH.FocusedState.Parent = this.combCategoriaCNH;
            this.combCategoriaCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combCategoriaCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combCategoriaCNH.FormattingEnabled = true;
            this.combCategoriaCNH.HoverState.Parent = this.combCategoriaCNH;
            this.combCategoriaCNH.ItemHeight = 29;
            this.combCategoriaCNH.ItemsAppearance.Parent = this.combCategoriaCNH;
            this.combCategoriaCNH.Location = new System.Drawing.Point(546, 144);
            this.combCategoriaCNH.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combCategoriaCNH.Name = "combCategoriaCNH";
            this.combCategoriaCNH.ShadowDecoration.Parent = this.combCategoriaCNH;
            this.combCategoriaCNH.Size = new System.Drawing.Size(130, 35);
            this.combCategoriaCNH.TabIndex = 7;
            // 
            // combSexo
            // 
            this.combSexo.BackColor = System.Drawing.Color.Transparent;
            this.combSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSexo.FocusedColor = System.Drawing.Color.Empty;
            this.combSexo.FocusedState.Parent = this.combSexo;
            this.combSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combSexo.FormattingEnabled = true;
            this.combSexo.HoverState.Parent = this.combSexo;
            this.combSexo.ItemHeight = 29;
            this.combSexo.ItemsAppearance.Parent = this.combSexo;
            this.combSexo.Location = new System.Drawing.Point(696, 144);
            this.combSexo.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combSexo.Name = "combSexo";
            this.combSexo.ShadowDecoration.Parent = this.combSexo;
            this.combSexo.Size = new System.Drawing.Size(130, 35);
            this.combSexo.TabIndex = 8;
            // 
            // combEstadoCivil
            // 
            this.combEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.combEstadoCivil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEstadoCivil.FocusedColor = System.Drawing.Color.Empty;
            this.combEstadoCivil.FocusedState.Parent = this.combEstadoCivil;
            this.combEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combEstadoCivil.FormattingEnabled = true;
            this.combEstadoCivil.HoverState.Parent = this.combEstadoCivil;
            this.combEstadoCivil.ItemHeight = 29;
            this.combEstadoCivil.ItemsAppearance.Parent = this.combEstadoCivil;
            this.combEstadoCivil.Location = new System.Drawing.Point(846, 144);
            this.combEstadoCivil.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combEstadoCivil.Name = "combEstadoCivil";
            this.combEstadoCivil.ShadowDecoration.Parent = this.combEstadoCivil;
            this.combEstadoCivil.Size = new System.Drawing.Size(174, 35);
            this.combEstadoCivil.TabIndex = 9;
            // 
            // textEndereco
            // 
            this.textEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEndereco.DefaultText = "";
            this.textEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEndereco.DisabledState.Parent = this.textEndereco;
            this.textEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEndereco.FocusedState.Parent = this.textEndereco;
            this.textEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEndereco.HoverState.Parent = this.textEndereco;
            this.textEndereco.Location = new System.Drawing.Point(170, 257);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.PasswordChar = '\0';
            this.textEndereco.PlaceholderText = "";
            this.textEndereco.SelectedText = "";
            this.textEndereco.ShadowDecoration.Parent = this.textEndereco;
            this.textEndereco.Size = new System.Drawing.Size(299, 35);
            this.textEndereco.TabIndex = 12;
            // 
            // textN
            // 
            this.textN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textN.DefaultText = "";
            this.textN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textN.DisabledState.Parent = this.textN;
            this.textN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textN.FocusedState.Parent = this.textN;
            this.textN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textN.HoverState.Parent = this.textN;
            this.textN.Location = new System.Drawing.Point(489, 257);
            this.textN.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textN.Name = "textN";
            this.textN.PasswordChar = '\0';
            this.textN.PlaceholderText = "";
            this.textN.SelectedText = "";
            this.textN.ShadowDecoration.Parent = this.textN;
            this.textN.Size = new System.Drawing.Size(80, 35);
            this.textN.TabIndex = 13;
            // 
            // textBairro
            // 
            this.textBairro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBairro.DefaultText = "";
            this.textBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBairro.DisabledState.Parent = this.textBairro;
            this.textBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBairro.FocusedState.Parent = this.textBairro;
            this.textBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBairro.HoverState.Parent = this.textBairro;
            this.textBairro.Location = new System.Drawing.Point(589, 258);
            this.textBairro.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textBairro.Name = "textBairro";
            this.textBairro.PasswordChar = '\0';
            this.textBairro.PlaceholderText = "";
            this.textBairro.SelectedText = "";
            this.textBairro.ShadowDecoration.Parent = this.textBairro;
            this.textBairro.Size = new System.Drawing.Size(180, 35);
            this.textBairro.TabIndex = 14;
            // 
            // textComplemento
            // 
            this.textComplemento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textComplemento.DefaultText = "";
            this.textComplemento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textComplemento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textComplemento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textComplemento.DisabledState.Parent = this.textComplemento;
            this.textComplemento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textComplemento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textComplemento.FocusedState.Parent = this.textComplemento;
            this.textComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textComplemento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textComplemento.HoverState.Parent = this.textComplemento;
            this.textComplemento.Location = new System.Drawing.Point(789, 258);
            this.textComplemento.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.PasswordChar = '\0';
            this.textComplemento.PlaceholderText = "";
            this.textComplemento.SelectedText = "";
            this.textComplemento.ShadowDecoration.Parent = this.textComplemento;
            this.textComplemento.Size = new System.Drawing.Size(231, 35);
            this.textComplemento.TabIndex = 15;
            // 
            // textCidade
            // 
            this.textCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCidade.DefaultText = "";
            this.textCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCidade.DisabledState.Parent = this.textCidade;
            this.textCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCidade.FocusedState.Parent = this.textCidade;
            this.textCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textCidade.HoverState.Parent = this.textCidade;
            this.textCidade.Location = new System.Drawing.Point(20, 330);
            this.textCidade.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textCidade.Name = "textCidade";
            this.textCidade.PasswordChar = '\0';
            this.textCidade.PlaceholderText = "";
            this.textCidade.SelectedText = "";
            this.textCidade.ShadowDecoration.Parent = this.textCidade;
            this.textCidade.Size = new System.Drawing.Size(180, 35);
            this.textCidade.TabIndex = 16;
            // 
            // combEstado
            // 
            this.combEstado.BackColor = System.Drawing.Color.Transparent;
            this.combEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEstado.FocusedColor = System.Drawing.Color.Empty;
            this.combEstado.FocusedState.Parent = this.combEstado;
            this.combEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combEstado.FormattingEnabled = true;
            this.combEstado.HoverState.Parent = this.combEstado;
            this.combEstado.ItemHeight = 29;
            this.combEstado.ItemsAppearance.Parent = this.combEstado;
            this.combEstado.Location = new System.Drawing.Point(220, 330);
            this.combEstado.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combEstado.Name = "combEstado";
            this.combEstado.ShadowDecoration.Parent = this.combEstado;
            this.combEstado.Size = new System.Drawing.Size(160, 35);
            this.combEstado.TabIndex = 17;
            // 
            // FormMotoristas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 535);
            this.Controls.Add(this.combEstado);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textComplemento);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.combEstadoCivil);
            this.Controls.Add(this.combSexo);
            this.Controls.Add(this.combCategoriaCNH);
            this.Controls.Add(this.textCNH);
            this.Controls.Add(this.combStatus);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.combCargo);
            this.Controls.Add(this.timeVencimentoCNH);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.buttonBuscarCEP);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCategoriaCNH);
            this.Controls.Add(this.lblVencimentoCNH);
            this.Controls.Add(this.lblCNH);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMotoristas";
            this.Text = "Cadastrar Motorista";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.Label lblVencimentoCNH;
        private System.Windows.Forms.Label lblCategoriaCNH;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCargo;
        private FontAwesome.Sharp.IconButton buttonBuscarCEP;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.MaskedTextBox textCelular;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.MaskedTextBox textCEP;
        private Guna.UI2.WinForms.Guna2TextBox textEmail;
        private Guna.UI2.WinForms.Guna2ComboBox combCargo;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeVencimentoCNH;
        private Guna.UI2.WinForms.Guna2TextBox textNome;
        private Guna.UI2.WinForms.Guna2TextBox textRG;
        private Guna.UI2.WinForms.Guna2ComboBox combStatus;
        private Guna.UI2.WinForms.Guna2TextBox textCNH;
        private Guna.UI2.WinForms.Guna2ComboBox combCategoriaCNH;
        private Guna.UI2.WinForms.Guna2ComboBox combSexo;
        private Guna.UI2.WinForms.Guna2ComboBox combEstadoCivil;
        private Guna.UI2.WinForms.Guna2TextBox textEndereco;
        private Guna.UI2.WinForms.Guna2TextBox textN;
        private Guna.UI2.WinForms.Guna2TextBox textBairro;
        private Guna.UI2.WinForms.Guna2TextBox textComplemento;
        private Guna.UI2.WinForms.Guna2TextBox textCidade;
        private Guna.UI2.WinForms.Guna2ComboBox combEstado;
    }
}