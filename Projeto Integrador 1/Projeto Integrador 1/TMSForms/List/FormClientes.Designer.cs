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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.btnMenuItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItens = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.gridClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.MenuItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
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
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "---";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.gridClientes, "gridClientes");
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTipoCadastro,
            this.colTipoPessoa,
            this.colCNPJ,
            this.colRazaoSocial});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridClientes.EnableHeadersVisualStyles = false;
            this.gridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridClientes.Name = "gridClientes";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            this.gridClientes.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnMouseEnterCell);
            // 
            // colId
            // 
            resources.ApplyResources(this.colId, "colId");
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTipoCadastro
            // 
            this.colTipoCadastro.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colTipoCadastro.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTipoCadastro.FillWeight = 61.80534F;
            resources.ApplyResources(this.colTipoCadastro, "colTipoCadastro");
            this.colTipoCadastro.Name = "colTipoCadastro";
            this.colTipoCadastro.ReadOnly = true;
            // 
            // colTipoPessoa
            // 
            this.colTipoPessoa.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colTipoPessoa.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTipoPessoa.FillWeight = 50.7614F;
            resources.ApplyResources(this.colTipoPessoa, "colTipoPessoa");
            this.colTipoPessoa.Name = "colTipoPessoa";
            this.colTipoPessoa.ReadOnly = true;
            // 
            // colCNPJ
            // 
            this.colCNPJ.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colCNPJ.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCNPJ.FillWeight = 62.70886F;
            resources.ApplyResources(this.colCNPJ, "colCNPJ");
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colRazaoSocial.DefaultCellStyle = dataGridViewCellStyle6;
            this.colRazaoSocial.FillWeight = 255.6464F;
            resources.ApplyResources(this.colRazaoSocial, "colRazaoSocial");
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.ReadOnly = true;
            // 
            // FormClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.panel1.ResumeLayout(false);
            this.MenuItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemEditar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemExcluir;
        private Guna.UI.WinForms.GunaContextMenuStrip MenuItens;
        private Guna.UI.WinForms.GunaDataGridView gridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazaoSocial;
    }
}