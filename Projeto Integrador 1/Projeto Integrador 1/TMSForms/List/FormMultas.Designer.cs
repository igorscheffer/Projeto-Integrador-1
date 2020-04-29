namespace Projeto_Integrador_1.TMSForms.List {
    partial class FormMultas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMultas = new Guna.UI.WinForms.GunaDataGridView();
            this.MenuItens = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.btnMenuItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuItemExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcorrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGravidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultas)).BeginInit();
            this.MenuItens.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMultas
            // 
            this.gridMultas.AllowUserToAddRows = false;
            this.gridMultas.AllowUserToDeleteRows = false;
            this.gridMultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridMultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMultas.BackgroundColor = System.Drawing.Color.White;
            this.gridMultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "---";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.gridMultas, "gridMultas");
            this.gridMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colOcorrencia,
            this.colPlaca,
            this.colMotorista,
            this.colInfracao,
            this.colGravidade,
            this.colValor,
            this.colVencimento,
            this.colStatus});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMultas.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridMultas.EnableHeadersVisualStyles = false;
            this.gridMultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridMultas.Name = "gridMultas";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridMultas.RowHeadersVisible = false;
            this.gridMultas.RowTemplate.Height = 35;
            this.gridMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMultas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridMultas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridMultas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridMultas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridMultas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridMultas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridMultas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridMultas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridMultas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gridMultas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridMultas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridMultas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridMultas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMultas.ThemeStyle.HeaderStyle.Height = 40;
            this.gridMultas.ThemeStyle.ReadOnly = false;
            this.gridMultas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridMultas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMultas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridMultas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.gridMultas.ThemeStyle.RowsStyle.Height = 35;
            this.gridMultas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridMultas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridMultas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnMouseEnterCell);
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
            // colOcorrencia
            // 
            this.colOcorrencia.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colOcorrencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOcorrencia.FillWeight = 90F;
            resources.ApplyResources(this.colOcorrencia, "colOcorrencia");
            this.colOcorrencia.Name = "colOcorrencia";
            this.colOcorrencia.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colPlaca.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPlaca.FillWeight = 70F;
            resources.ApplyResources(this.colPlaca, "colPlaca");
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colMotorista
            // 
            this.colMotorista.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colMotorista.DefaultCellStyle = dataGridViewCellStyle5;
            this.colMotorista.FillWeight = 130F;
            resources.ApplyResources(this.colMotorista, "colMotorista");
            this.colMotorista.Name = "colMotorista";
            this.colMotorista.ReadOnly = true;
            // 
            // colInfracao
            // 
            this.colInfracao.ContextMenuStrip = this.MenuItens;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.colInfracao.DefaultCellStyle = dataGridViewCellStyle6;
            this.colInfracao.FillWeight = 80F;
            resources.ApplyResources(this.colInfracao, "colInfracao");
            this.colInfracao.Name = "colInfracao";
            this.colInfracao.ReadOnly = true;
            // 
            // colGravidade
            // 
            this.colGravidade.ContextMenuStrip = this.MenuItens;
            this.colGravidade.FillWeight = 65F;
            resources.ApplyResources(this.colGravidade, "colGravidade");
            this.colGravidade.Name = "colGravidade";
            this.colGravidade.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.ContextMenuStrip = this.MenuItens;
            this.colValor.FillWeight = 130F;
            resources.ApplyResources(this.colValor, "colValor");
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colVencimento
            // 
            this.colVencimento.ContextMenuStrip = this.MenuItens;
            this.colVencimento.FillWeight = 75F;
            resources.ApplyResources(this.colVencimento, "colVencimento");
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.ContextMenuStrip = this.MenuItens;
            this.colStatus.FillWeight = 90F;
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // FormMultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gridMultas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMultas";
            ((System.ComponentModel.ISupportInitialize)(this.gridMultas)).EndInit();
            this.MenuItens.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView gridMultas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private Guna.UI.WinForms.GunaContextMenuStrip MenuItens;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemEditar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuItemExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcorrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGravidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}