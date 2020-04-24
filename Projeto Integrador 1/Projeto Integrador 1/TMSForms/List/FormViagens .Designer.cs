namespace Projeto_Integrador_1.TMSForms.List
{
    partial class FormViagens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViagens));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViagens = new Guna.UI.WinForms.GunaDataGridView();
            this.frota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViagens)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViagens
            // 
            this.gridViagens.AllowUserToAddRows = false;
            this.gridViagens.AllowUserToDeleteRows = false;
            this.gridViagens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViagens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViagens.BackgroundColor = System.Drawing.Color.White;
            this.gridViagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViagens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViagens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "---";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.gridViagens, "gridViagens");
            this.gridViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frota,
            this.placa,
            this.veiculo,
            this.cor,
            this.status,
            this.Column1,
            this.Motorista,
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.NullValue = "---";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViagens.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridViagens.EnableHeadersVisualStyles = false;
            this.gridViagens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridViagens.Name = "gridViagens";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.NullValue = "---";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViagens.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridViagens.RowHeadersVisible = false;
            this.gridViagens.RowTemplate.DefaultCellStyle.NullValue = "---";
            this.gridViagens.RowTemplate.Height = 35;
            this.gridViagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViagens.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridViagens.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViagens.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViagens.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViagens.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViagens.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViagens.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViagens.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridViagens.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gridViagens.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViagens.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViagens.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViagens.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViagens.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViagens.ThemeStyle.ReadOnly = false;
            this.gridViagens.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViagens.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViagens.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViagens.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.gridViagens.ThemeStyle.RowsStyle.Height = 35;
            this.gridViagens.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridViagens.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // frota
            // 
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frota.DefaultCellStyle = dataGridViewCellStyle3;
            this.frota.FillWeight = 88.78702F;
            resources.ApplyResources(this.frota, "frota");
            this.frota.Name = "frota";
            this.frota.ReadOnly = true;
            // 
            // placa
            // 
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.placa.DefaultCellStyle = dataGridViewCellStyle4;
            this.placa.FillWeight = 83.05664F;
            resources.ApplyResources(this.placa, "placa");
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // veiculo
            // 
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.veiculo.DefaultCellStyle = dataGridViewCellStyle5;
            this.veiculo.FillWeight = 101.5228F;
            resources.ApplyResources(this.veiculo, "veiculo");
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            // 
            // cor
            // 
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cor.DefaultCellStyle = dataGridViewCellStyle6;
            this.cor.FillWeight = 105.9449F;
            resources.ApplyResources(this.cor, "cor");
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            // 
            // status
            // 
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.status.DefaultCellStyle = dataGridViewCellStyle7;
            this.status.FillWeight = 113.1045F;
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 95.67404F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Motorista
            // 
            this.Motorista.FillWeight = 116.2358F;
            resources.ApplyResources(this.Motorista, "Motorista");
            this.Motorista.Name = "Motorista";
            this.Motorista.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 95.67404F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnCadastrar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(152)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCadastrar.IconColor = System.Drawing.Color.White;
            this.btnCadastrar.IconSize = 16;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Rotation = 0D;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormViagens
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gridViagens);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViagens";
            ((System.ComponentModel.ISupportInitialize)(this.gridViagens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView gridViagens;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn frota;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}