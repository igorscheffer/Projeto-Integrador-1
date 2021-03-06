﻿namespace Projeto_Integrador_1.TMSForms.Register {
    partial class FormFinanceiro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinanceiro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEnviar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnGerarParcelas = new FontAwesome.Sharp.IconButton();
            this.lblQtdParcelas = new System.Windows.Forms.Label();
            this.panelInfoPagamento = new System.Windows.Forms.Panel();
            this.lblInfoPagamento = new System.Windows.Forms.Label();
            this.gridParcelas = new Guna.UI.WinForms.GunaDataGridView();
            this.colParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormaPagamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textGridCustoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textGridCustoTotal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.combOcorrencia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.combTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combCentroCusto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combFormaPagamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeDataEmissao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timeDataVencimento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.textDocumento = new Guna.UI2.WinForms.Guna2TextBox();
            this.textQtdParcelas = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).BeginInit();
            this.SuspendLayout();
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
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(20, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "INFORMAÇÕES DE PAGAMENTO";
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
            this.btnEnviar.Location = new System.Drawing.Point(891, 571);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(10);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Rotation = 0D;
            this.btnEnviar.Size = new System.Drawing.Size(130, 35);
            this.btnEnviar.TabIndex = 279;
            this.btnEnviar.Text = "Salvar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.OnEnviar);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 288;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(290, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 290;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(470, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 292;
            this.label3.Text = "Centro de Custo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(660, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 294;
            this.label4.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(870, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 296;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 298;
            this.label6.Text = "Data Emissao";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(180, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 300;
            this.label9.Text = "Data Vencimento";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(340, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 35);
            this.panel3.TabIndex = 303;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label14.Location = new System.Drawing.Point(6, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 250;
            this.label14.Text = "R$";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(340, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 18);
            this.label16.TabIndex = 302;
            this.label16.Text = "Valor";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(20, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 18);
            this.label17.TabIndex = 305;
            this.label17.Text = "Nº Documento";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(240, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 18);
            this.label18.TabIndex = 307;
            this.label18.Text = "Ocorrencia";
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerarParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(186)))), ((int)(((byte)(69)))));
            this.btnGerarParcelas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.btnGerarParcelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.btnGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarParcelas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGerarParcelas.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnGerarParcelas.IconColor = System.Drawing.Color.White;
            this.btnGerarParcelas.IconSize = 16;
            this.btnGerarParcelas.Location = new System.Drawing.Point(485, 227);
            this.btnGerarParcelas.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Rotation = 0D;
            this.btnGerarParcelas.Size = new System.Drawing.Size(35, 35);
            this.btnGerarParcelas.TabIndex = 12;
            this.btnGerarParcelas.UseVisualStyleBackColor = false;
            this.btnGerarParcelas.Visible = false;
            this.btnGerarParcelas.Click += new System.EventHandler(this.OnClickGerarParcela);
            // 
            // lblQtdParcelas
            // 
            this.lblQtdParcelas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQtdParcelas.AutoSize = true;
            this.lblQtdParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdParcelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQtdParcelas.Location = new System.Drawing.Point(390, 204);
            this.lblQtdParcelas.Name = "lblQtdParcelas";
            this.lblQtdParcelas.Size = new System.Drawing.Size(98, 18);
            this.lblQtdParcelas.TabIndex = 310;
            this.lblQtdParcelas.Text = "Qtd. Parcelas";
            this.lblQtdParcelas.Visible = false;
            // 
            // panelInfoPagamento
            // 
            this.panelInfoPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelInfoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInfoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoPagamento.ForeColor = System.Drawing.Color.Silver;
            this.panelInfoPagamento.Location = new System.Drawing.Point(20, 300);
            this.panelInfoPagamento.Margin = new System.Windows.Forms.Padding(10, 3, 10, 15);
            this.panelInfoPagamento.Name = "panelInfoPagamento";
            this.panelInfoPagamento.Size = new System.Drawing.Size(1000, 2);
            this.panelInfoPagamento.TabIndex = 312;
            this.panelInfoPagamento.Visible = false;
            // 
            // lblInfoPagamento
            // 
            this.lblInfoPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoPagamento.AutoSize = true;
            this.lblInfoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPagamento.ForeColor = System.Drawing.Color.Silver;
            this.lblInfoPagamento.Location = new System.Drawing.Point(20, 277);
            this.lblInfoPagamento.Name = "lblInfoPagamento";
            this.lblInfoPagamento.Size = new System.Drawing.Size(290, 20);
            this.lblInfoPagamento.TabIndex = 311;
            this.lblInfoPagamento.Text = "INFORMAÇÕES DE PARCELAMENTO";
            this.lblInfoPagamento.Visible = false;
            // 
            // gridParcelas
            // 
            this.gridParcelas.AllowUserToAddRows = false;
            this.gridParcelas.AllowUserToDeleteRows = false;
            this.gridParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridParcelas.BackgroundColor = System.Drawing.Color.White;
            this.gridParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridParcelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridParcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridParcelas.ColumnHeadersHeight = 35;
            this.gridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParcela,
            this.colData,
            this.colValor,
            this.colFormaPagamento,
            this.textGridCustoValor,
            this.textGridCustoTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridParcelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridParcelas.EnableHeadersVisualStyles = false;
            this.gridParcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridParcelas.Location = new System.Drawing.Point(20, 322);
            this.gridParcelas.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.gridParcelas.MultiSelect = false;
            this.gridParcelas.Name = "gridParcelas";
            this.gridParcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridParcelas.RowHeadersVisible = false;
            this.gridParcelas.RowTemplate.DividerHeight = 1;
            this.gridParcelas.RowTemplate.Height = 30;
            this.gridParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParcelas.Size = new System.Drawing.Size(1000, 284);
            this.gridParcelas.TabIndex = 313;
            this.gridParcelas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridParcelas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridParcelas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridParcelas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridParcelas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridParcelas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridParcelas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridParcelas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridParcelas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gridParcelas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridParcelas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.gridParcelas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridParcelas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParcelas.ThemeStyle.HeaderStyle.Height = 35;
            this.gridParcelas.ThemeStyle.ReadOnly = false;
            this.gridParcelas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridParcelas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridParcelas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.gridParcelas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.gridParcelas.ThemeStyle.RowsStyle.Height = 30;
            this.gridParcelas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridParcelas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridParcelas.Visible = false;
            // 
            // colParcela
            // 
            this.colParcela.HeaderText = "PARCELA";
            this.colParcela.Name = "colParcela";
            this.colParcela.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "VALOR";
            this.colValor.MaxInputLength = 100;
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.HeaderText = "FORMA DE PAGAMENTO";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFormaPagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textGridCustoValor
            // 
            this.textGridCustoValor.HeaderText = "OBSERVAÇÃO";
            this.textGridCustoValor.Name = "textGridCustoValor";
            // 
            // textGridCustoTotal
            // 
            this.textGridCustoTotal.HeaderText = "PAGO";
            this.textGridCustoTotal.Name = "textGridCustoTotal";
            this.textGridCustoTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.textGridCustoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // combOcorrencia
            // 
            this.combOcorrencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combOcorrencia.BackColor = System.Drawing.Color.Transparent;
            this.combOcorrencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combOcorrencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOcorrencia.FocusedColor = System.Drawing.Color.Empty;
            this.combOcorrencia.FocusedState.Parent = this.combOcorrencia;
            this.combOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combOcorrencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combOcorrencia.FormattingEnabled = true;
            this.combOcorrencia.HoverState.Parent = this.combOcorrencia;
            this.combOcorrencia.ItemHeight = 29;
            this.combOcorrencia.ItemsAppearance.Parent = this.combOcorrencia;
            this.combOcorrencia.Location = new System.Drawing.Point(240, 227);
            this.combOcorrencia.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combOcorrencia.Name = "combOcorrencia";
            this.combOcorrencia.ShadowDecoration.Parent = this.combOcorrencia;
            this.combOcorrencia.Size = new System.Drawing.Size(130, 35);
            this.combOcorrencia.TabIndex = 10;
            this.combOcorrencia.SelectedValueChanged += new System.EventHandler(this.OnSelectOcorrencia);
            // 
            // textNome
            // 
            this.textNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.textNome.Location = new System.Drawing.Point(20, 75);
            this.textNome.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textNome.Name = "textNome";
            this.textNome.PasswordChar = '\0';
            this.textNome.PlaceholderText = "";
            this.textNome.SelectedText = "";
            this.textNome.ShadowDecoration.Parent = this.textNome;
            this.textNome.Size = new System.Drawing.Size(250, 35);
            this.textNome.TabIndex = 1;
            // 
            // combTipo
            // 
            this.combTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combTipo.BackColor = System.Drawing.Color.Transparent;
            this.combTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipo.FocusedColor = System.Drawing.Color.Empty;
            this.combTipo.FocusedState.Parent = this.combTipo;
            this.combTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combTipo.FormattingEnabled = true;
            this.combTipo.HoverState.Parent = this.combTipo;
            this.combTipo.ItemHeight = 29;
            this.combTipo.ItemsAppearance.Parent = this.combTipo;
            this.combTipo.Location = new System.Drawing.Point(290, 75);
            this.combTipo.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combTipo.Name = "combTipo";
            this.combTipo.ShadowDecoration.Parent = this.combTipo;
            this.combTipo.Size = new System.Drawing.Size(160, 35);
            this.combTipo.TabIndex = 2;
            // 
            // combCentroCusto
            // 
            this.combCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combCentroCusto.BackColor = System.Drawing.Color.Transparent;
            this.combCentroCusto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combCentroCusto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combCentroCusto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCentroCusto.FocusedColor = System.Drawing.Color.Empty;
            this.combCentroCusto.FocusedState.Parent = this.combCentroCusto;
            this.combCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combCentroCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combCentroCusto.FormattingEnabled = true;
            this.combCentroCusto.HoverState.Parent = this.combCentroCusto;
            this.combCentroCusto.ItemHeight = 29;
            this.combCentroCusto.ItemsAppearance.Parent = this.combCentroCusto;
            this.combCentroCusto.Location = new System.Drawing.Point(470, 75);
            this.combCentroCusto.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combCentroCusto.Name = "combCentroCusto";
            this.combCentroCusto.ShadowDecoration.Parent = this.combCentroCusto;
            this.combCentroCusto.Size = new System.Drawing.Size(170, 35);
            this.combCentroCusto.TabIndex = 3;
            // 
            // combFormaPagamento
            // 
            this.combFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combFormaPagamento.BackColor = System.Drawing.Color.Transparent;
            this.combFormaPagamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.combFormaPagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFormaPagamento.FocusedColor = System.Drawing.Color.Empty;
            this.combFormaPagamento.FocusedState.Parent = this.combFormaPagamento;
            this.combFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combFormaPagamento.FormattingEnabled = true;
            this.combFormaPagamento.HoverState.Parent = this.combFormaPagamento;
            this.combFormaPagamento.ItemHeight = 29;
            this.combFormaPagamento.ItemsAppearance.Parent = this.combFormaPagamento;
            this.combFormaPagamento.Location = new System.Drawing.Point(663, 75);
            this.combFormaPagamento.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combFormaPagamento.Name = "combFormaPagamento";
            this.combFormaPagamento.ShadowDecoration.Parent = this.combFormaPagamento;
            this.combFormaPagamento.Size = new System.Drawing.Size(187, 35);
            this.combFormaPagamento.TabIndex = 4;
            // 
            // combStatus
            // 
            this.combStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.combStatus.Location = new System.Drawing.Point(870, 75);
            this.combStatus.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.combStatus.Name = "combStatus";
            this.combStatus.ShadowDecoration.Parent = this.combStatus;
            this.combStatus.Size = new System.Drawing.Size(150, 35);
            this.combStatus.TabIndex = 5;
            // 
            // timeDataEmissao
            // 
            this.timeDataEmissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeDataEmissao.BackColor = System.Drawing.Color.Transparent;
            this.timeDataEmissao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.timeDataEmissao.BorderThickness = 1;
            this.timeDataEmissao.CheckedState.Parent = this.timeDataEmissao;
            this.timeDataEmissao.CustomFormat = " ";
            this.timeDataEmissao.FillColor = System.Drawing.Color.White;
            this.timeDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.timeDataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDataEmissao.HoverState.Parent = this.timeDataEmissao;
            this.timeDataEmissao.Location = new System.Drawing.Point(20, 151);
            this.timeDataEmissao.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.timeDataEmissao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeDataEmissao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeDataEmissao.Name = "timeDataEmissao";
            this.timeDataEmissao.ShadowDecoration.Parent = this.timeDataEmissao;
            this.timeDataEmissao.Size = new System.Drawing.Size(144, 35);
            this.timeDataEmissao.TabIndex = 6;
            this.timeDataEmissao.UseTransparentBackground = true;
            this.timeDataEmissao.Value = new System.DateTime(2020, 5, 3, 16, 47, 44, 411);
            // 
            // timeDataVencimento
            // 
            this.timeDataVencimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timeDataVencimento.BackColor = System.Drawing.Color.Transparent;
            this.timeDataVencimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.timeDataVencimento.BorderThickness = 1;
            this.timeDataVencimento.CheckedState.Parent = this.timeDataVencimento;
            this.timeDataVencimento.CustomFormat = " ";
            this.timeDataVencimento.FillColor = System.Drawing.Color.White;
            this.timeDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.timeDataVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDataVencimento.HoverState.Parent = this.timeDataVencimento;
            this.timeDataVencimento.Location = new System.Drawing.Point(183, 151);
            this.timeDataVencimento.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.timeDataVencimento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeDataVencimento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeDataVencimento.Name = "timeDataVencimento";
            this.timeDataVencimento.ShadowDecoration.Parent = this.timeDataVencimento;
            this.timeDataVencimento.Size = new System.Drawing.Size(137, 35);
            this.timeDataVencimento.TabIndex = 7;
            this.timeDataVencimento.UseTransparentBackground = true;
            this.timeDataVencimento.Value = new System.DateTime(2020, 5, 3, 16, 47, 44, 411);
            // 
            // textValor
            // 
            this.textValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textValor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textValor.DefaultText = "";
            this.textValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textValor.DisabledState.Parent = this.textValor;
            this.textValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textValor.FocusedState.Parent = this.textValor;
            this.textValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textValor.HoverState.Parent = this.textValor;
            this.textValor.Location = new System.Drawing.Point(375, 151);
            this.textValor.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textValor.Name = "textValor";
            this.textValor.PasswordChar = '\0';
            this.textValor.PlaceholderText = "";
            this.textValor.SelectedText = "";
            this.textValor.ShadowDecoration.Parent = this.textValor;
            this.textValor.Size = new System.Drawing.Size(145, 35);
            this.textValor.TabIndex = 8;
            this.textValor.TextChanged += new System.EventHandler(this.OnChangedTextValor);
            // 
            // textDocumento
            // 
            this.textDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textDocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDocumento.DefaultText = "";
            this.textDocumento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDocumento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDocumento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDocumento.DisabledState.Parent = this.textDocumento;
            this.textDocumento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDocumento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDocumento.FocusedState.Parent = this.textDocumento;
            this.textDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDocumento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDocumento.HoverState.Parent = this.textDocumento;
            this.textDocumento.Location = new System.Drawing.Point(20, 227);
            this.textDocumento.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.PasswordChar = '\0';
            this.textDocumento.PlaceholderText = "";
            this.textDocumento.SelectedText = "";
            this.textDocumento.ShadowDecoration.Parent = this.textDocumento;
            this.textDocumento.Size = new System.Drawing.Size(200, 35);
            this.textDocumento.TabIndex = 9;
            // 
            // textQtdParcelas
            // 
            this.textQtdParcelas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textQtdParcelas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textQtdParcelas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textQtdParcelas.DefaultText = "";
            this.textQtdParcelas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textQtdParcelas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textQtdParcelas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textQtdParcelas.DisabledState.Parent = this.textQtdParcelas;
            this.textQtdParcelas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textQtdParcelas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textQtdParcelas.FocusedState.Parent = this.textQtdParcelas;
            this.textQtdParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textQtdParcelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textQtdParcelas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textQtdParcelas.HoverState.Parent = this.textQtdParcelas;
            this.textQtdParcelas.Location = new System.Drawing.Point(390, 227);
            this.textQtdParcelas.Margin = new System.Windows.Forms.Padding(10, 5, 10, 15);
            this.textQtdParcelas.Name = "textQtdParcelas";
            this.textQtdParcelas.PasswordChar = '\0';
            this.textQtdParcelas.PlaceholderText = "";
            this.textQtdParcelas.SelectedText = "";
            this.textQtdParcelas.ShadowDecoration.Parent = this.textQtdParcelas;
            this.textQtdParcelas.Size = new System.Drawing.Size(95, 35);
            this.textQtdParcelas.TabIndex = 11;
            this.textQtdParcelas.Visible = false;
            // 
            // FormFinanceiro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 625);
            this.Controls.Add(this.textQtdParcelas);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.timeDataVencimento);
            this.Controls.Add(this.timeDataEmissao);
            this.Controls.Add(this.combStatus);
            this.Controls.Add(this.combFormaPagamento);
            this.Controls.Add(this.combCentroCusto);
            this.Controls.Add(this.combTipo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.combOcorrencia);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.gridParcelas);
            this.Controls.Add(this.panelInfoPagamento);
            this.Controls.Add(this.lblInfoPagamento);
            this.Controls.Add(this.btnGerarParcelas);
            this.Controls.Add(this.lblQtdParcelas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFinanceiro";
            this.Text = "Cadastrar Financeiro";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnGerarParcelas;
        private System.Windows.Forms.Label lblQtdParcelas;
        private System.Windows.Forms.Panel panelInfoPagamento;
        private System.Windows.Forms.Label lblInfoPagamento;
        private Guna.UI.WinForms.GunaDataGridView gridParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn textGridCustoValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn textGridCustoTotal;
        private Guna.UI2.WinForms.Guna2ComboBox combOcorrencia;
        private Guna.UI2.WinForms.Guna2TextBox textNome;
        private Guna.UI2.WinForms.Guna2ComboBox combTipo;
        private Guna.UI2.WinForms.Guna2ComboBox combCentroCusto;
        private Guna.UI2.WinForms.Guna2ComboBox combFormaPagamento;
        private Guna.UI2.WinForms.Guna2ComboBox combStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeDataEmissao;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeDataVencimento;
        private Guna.UI2.WinForms.Guna2TextBox textValor;
        private Guna.UI2.WinForms.Guna2TextBox textDocumento;
        private Guna.UI2.WinForms.Guna2TextBox textQtdParcelas;
    }
}