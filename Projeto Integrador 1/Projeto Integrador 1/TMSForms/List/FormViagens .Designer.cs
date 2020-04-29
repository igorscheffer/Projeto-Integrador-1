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
            this.MenuItens = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.btnMenuItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidadeSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidadeDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViagens)).BeginInit();
            this.MenuItens.SuspendLayout();
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
            this.colId,
            this.colCodigoInterno,
            this.colDataSaida,
            this.colDataChegada,
            this.colCidadeSaida,
            this.colCidadeDestino,
            this.colPlaca,
            this.colMotorista,
            this.colStatus});
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
            this.gridViagens.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnMouseEnterCell);
            // 
            // MenuItens
            // 
            this.MenuItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.MenuItens, "MenuItens");
            this.MenuItens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuItemEditar,
            this.btnMenuItemExcluir});
            this.MenuItens.Name = "MenuItens";
            this.MenuItens.RenderStyle.ArrowColor = System.Drawing.Color.White;
            this.MenuItens.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(147)))), ((int)(((byte)(196)))));
            this.MenuItens.RenderStyle.ColorTable = null;
            this.MenuItens.RenderStyle.RoundedEdges = true;
            this.MenuItens.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MenuItens.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.MenuItens.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MenuItens.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.MenuItens.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.MenuItens.ShowCheckMargin = true;
            // 
            // btnMenuItemEditar
            // 
            this.btnMenuItemEditar.ForeColor = System.Drawing.Color.White;
            this.btnMenuItemEditar.Name = "btnMenuItemEditar";
            this.btnMenuItemEditar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            resources.ApplyResources(this.btnMenuItemEditar, "btnMenuItemEditar");
            this.btnMenuItemEditar.Click += new System.EventHandler(this.OnSelectEditar);
            // 
            // btnMenuItemExcluir
            // 
            this.btnMenuItemExcluir.ForeColor = System.Drawing.Color.White;
            this.btnMenuItemExcluir.Name = "btnMenuItemExcluir";
            this.btnMenuItemExcluir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            resources.ApplyResources(this.btnMenuItemExcluir, "btnMenuItemExcluir");
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
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCodigoInterno
            // 
            this.colCodigoInterno.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colCodigoInterno.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCodigoInterno.FillWeight = 88.78702F;
            resources.ApplyResources(this.colCodigoInterno, "colCodigoInterno");
            this.colCodigoInterno.Name = "colCodigoInterno";
            this.colCodigoInterno.ReadOnly = true;
            // 
            // colDataSaida
            // 
            this.colDataSaida.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colDataSaida.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDataSaida.FillWeight = 83.05664F;
            resources.ApplyResources(this.colDataSaida, "colDataSaida");
            this.colDataSaida.Name = "colDataSaida";
            this.colDataSaida.ReadOnly = true;
            // 
            // colDataChegada
            // 
            this.colDataChegada.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colDataChegada.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDataChegada.FillWeight = 101.5228F;
            resources.ApplyResources(this.colDataChegada, "colDataChegada");
            this.colDataChegada.Name = "colDataChegada";
            this.colDataChegada.ReadOnly = true;
            // 
            // colCidadeSaida
            // 
            this.colCidadeSaida.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colCidadeSaida.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCidadeSaida.FillWeight = 105.9449F;
            resources.ApplyResources(this.colCidadeSaida, "colCidadeSaida");
            this.colCidadeSaida.Name = "colCidadeSaida";
            this.colCidadeSaida.ReadOnly = true;
            // 
            // colCidadeDestino
            // 
            this.colCidadeDestino.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colCidadeDestino.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCidadeDestino.FillWeight = 113.1045F;
            resources.ApplyResources(this.colCidadeDestino, "colCidadeDestino");
            this.colCidadeDestino.Name = "colCidadeDestino";
            this.colCidadeDestino.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.ContextMenuStrip = this.MenuItens;
            this.colPlaca.FillWeight = 95.67404F;
            resources.ApplyResources(this.colPlaca, "colPlaca");
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colMotorista
            // 
            this.colMotorista.ContextMenuStrip = this.MenuItens;
            this.colMotorista.FillWeight = 116.2358F;
            resources.ApplyResources(this.colMotorista, "colMotorista");
            this.colMotorista.Name = "colMotorista";
            this.colMotorista.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.ContextMenuStrip = this.MenuItens;
            this.colStatus.FillWeight = 95.67404F;
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
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
            this.MenuItens.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView gridViagens;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private Guna.UI.WinForms.GunaContextMenuStrip MenuItens;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemEditar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidadeSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidadeDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}