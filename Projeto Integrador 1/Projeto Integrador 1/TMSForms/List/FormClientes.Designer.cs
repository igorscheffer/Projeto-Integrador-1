namespace Projeto_Integrador_1.TMSForms.List
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.frota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.gridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.NullValue = "---";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.gridClientes, "gridClientes");
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frota,
            this.cor,
            this.placa,
            this.veiculo});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle15;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridClientes.Name = "gridClientes";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowTemplate.Height = 35;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gridClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridClientes.ThemeStyle.HeaderStyle.Height = 40;
            this.gridClientes.ThemeStyle.ReadOnly = false;
            this.gridClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.gridClientes.ThemeStyle.RowsStyle.Height = 35;
            this.gridClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            // frota
            // 
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.frota.DefaultCellStyle = dataGridViewCellStyle11;
            this.frota.FillWeight = 61.80534F;
            resources.ApplyResources(this.frota, "frota");
            this.frota.Name = "frota";
            this.frota.ReadOnly = true;
            // 
            // cor
            // 
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cor.DefaultCellStyle = dataGridViewCellStyle12;
            this.cor.FillWeight = 50.7614F;
            resources.ApplyResources(this.cor, "cor");
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            // 
            // placa
            // 
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.placa.DefaultCellStyle = dataGridViewCellStyle13;
            this.placa.FillWeight = 62.70886F;
            resources.ApplyResources(this.placa, "placa");
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // veiculo
            // 
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.veiculo.DefaultCellStyle = dataGridViewCellStyle14;
            this.veiculo.FillWeight = 255.6464F;
            resources.ApplyResources(this.veiculo, "veiculo");
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            // 
            // FormClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView gridClientes;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn frota;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
    }
}