namespace Projeto_Integrador_1.TMSForms {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textLogin = new Guna.UI.WinForms.GunaLineTextBox();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.iconSenha = new FontAwesome.Sharp.IconPictureBox();
            this.textSenha = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnLogar = new FontAwesome.Sharp.IconButton();
            this.checkSalvarDados = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.lblSalvarDados = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_Integrador_1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.FocusedLineColor = System.Drawing.Color.White;
            this.textLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textLogin.ForeColor = System.Drawing.Color.White;
            this.textLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(197)))), ((int)(((byte)(239)))));
            this.textLogin.Location = new System.Drawing.Point(71, 274);
            this.textLogin.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.Size = new System.Drawing.Size(259, 35);
            this.textLogin.TabIndex = 1;
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconLogin.IconColor = System.Drawing.Color.White;
            this.iconLogin.IconSize = 35;
            this.iconLogin.Location = new System.Drawing.Point(30, 274);
            this.iconLogin.Margin = new System.Windows.Forms.Padding(20, 10, 3, 10);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(35, 35);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconLogin.TabIndex = 2;
            this.iconLogin.TabStop = false;
            // 
            // iconSenha
            // 
            this.iconSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.iconSenha.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconSenha.IconColor = System.Drawing.Color.White;
            this.iconSenha.IconSize = 35;
            this.iconSenha.Location = new System.Drawing.Point(30, 329);
            this.iconSenha.Margin = new System.Windows.Forms.Padding(20, 10, 3, 10);
            this.iconSenha.Name = "iconSenha";
            this.iconSenha.Size = new System.Drawing.Size(35, 35);
            this.iconSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconSenha.TabIndex = 4;
            this.iconSenha.TabStop = false;
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.textSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSenha.FocusedLineColor = System.Drawing.Color.White;
            this.textSenha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textSenha.ForeColor = System.Drawing.Color.White;
            this.textSenha.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(197)))), ((int)(((byte)(239)))));
            this.textSenha.Location = new System.Drawing.Point(71, 329);
            this.textSenha.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(259, 35);
            this.textSenha.TabIndex = 2;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(147)))), ((int)(((byte)(196)))));
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(183)))), ((int)(((byte)(228)))));
            this.btnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(147)))), ((int)(((byte)(196)))));
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogar.IconColor = System.Drawing.Color.White;
            this.btnLogar.IconSize = 26;
            this.btnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogar.Location = new System.Drawing.Point(29, 443);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Rotation = 0D;
            this.btnLogar.Size = new System.Drawing.Size(300, 46);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Log In";
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.OnClickLogar);
            // 
            // checkSalvarDados
            // 
            this.checkSalvarDados.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.checkSalvarDados.CheckedOffColor = System.Drawing.Color.White;
            this.checkSalvarDados.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(178)))), ((int)(((byte)(220)))));
            this.checkSalvarDados.FillColor = System.Drawing.Color.White;
            this.checkSalvarDados.Location = new System.Drawing.Point(310, 384);
            this.checkSalvarDados.Margin = new System.Windows.Forms.Padding(3, 10, 20, 3);
            this.checkSalvarDados.Name = "checkSalvarDados";
            this.checkSalvarDados.Size = new System.Drawing.Size(20, 20);
            this.checkSalvarDados.TabIndex = 3;
            // 
            // lblSalvarDados
            // 
            this.lblSalvarDados.AutoSize = true;
            this.lblSalvarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSalvarDados.ForeColor = System.Drawing.Color.White;
            this.lblSalvarDados.Location = new System.Drawing.Point(215, 386);
            this.lblSalvarDados.Name = "lblSalvarDados";
            this.lblSalvarDados.Size = new System.Drawing.Size(91, 17);
            this.lblSalvarDados.TabIndex = 7;
            this.lblSalvarDados.Text = "Salvar dados";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(316, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClickClose);
            this.btnClose.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.btnClose.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 518);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSalvarDados);
            this.Controls.Add(this.checkSalvarDados);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.iconSenha);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox textLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private FontAwesome.Sharp.IconPictureBox iconSenha;
        private Guna.UI.WinForms.GunaLineTextBox textSenha;
        private FontAwesome.Sharp.IconButton btnLogar;
        private Guna.UI.WinForms.GunaMediumCheckBox checkSalvarDados;
        private System.Windows.Forms.Label lblSalvarDados;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}