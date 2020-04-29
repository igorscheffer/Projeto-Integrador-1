using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Projeto_Integrador_1.Connection;

namespace Projeto_Integrador_1 {
    public partial class FormPrincipal : Form {
        private IconButton currentButton;
        private List<string> menuItens = new List<string>();
        private bool menuHidde;

        private Form currentForm;

        private async void testeCep() {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/14787022/json/");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }

        private void VerificarConexao() {
            try {
                Config Connexao = new Config();

                if (Connexao.Open()) {
                    this.Enabled = true;
                    Connexao.Close();
                }
                else {
                    this.Enabled = false;
                    throw new Exception("Não foi possivel conectar com o banco de dados.");
                }
            }
            catch (Exception e) {
                this.Enabled = false;

                DialogResult VerificarConexao = MessageBox.Show(e.Message, "Conexao Offline", MessageBoxButtons.RetryCancel);

                if (VerificarConexao == DialogResult.Retry) {
                     this.VerificarConexao();
                }
                else {
                    Application.Exit();
                }
            }
        }

        public FormPrincipal() {
            VerificarConexao();

            InitializeComponent();
            AtivarForm(new TMSForms.FormHome(this));
        }

        private void HiddenMenu() {
            if (menuHidde == false) {
                foreach (Control btnControl in painelMenu.Controls) {
                    if (btnControl.GetType() == typeof(IconButton)) {
                        IconButton menuItem = (IconButton)btnControl;
                        menuItens.Add(menuItem.Text);
                        menuItem.Text = "";
                        menuItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
                        menuItem.Height = 60;
                        menuItem.IconSize = 45;
                        menuHidde = true;
                    }
                }

                txtLogo.Hide();
                painelMenu.Width = 60;
            }
            else {
                int c = 0;
                foreach (Control btnControl in painelMenu.Controls) {
                    if (btnControl.GetType() == typeof(IconButton)) {
                        IconButton menuItem = (IconButton)btnControl;
                        menuItem.Text = menuItens[c];
                        menuItem.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
                        menuItem.Height = 40;
                        menuItem.IconSize = 22;
                        menuHidde = false;
                        c++;
                    }
                }

                txtLogo.Show();
                painelMenu.Width = 220;
            }
        }

        private void DesabilitarBotao() {
            foreach (Control btnControl in painelMenu.Controls) {
                if (btnControl.GetType() == typeof(IconButton)) {
                    IconButton disableButton = (IconButton)btnControl;
                    disableButton.BackColor = Color.FromArgb(5, 178, 220);
                    disableButton.IconColor = Color.White;
                    disableButton.ForeColor = Color.White;
                }
            }
        }

        private void AtivarBotao(object btnSender) {
            if (btnSender != null) {
                currentButton = (IconButton)btnSender;
                DesabilitarBotao();
                currentButton.BackColor = Color.FromArgb(4, 166, 210);
                currentButton.IconColor = Color.White;
                currentButton.ForeColor = Color.White;
            }
        }

        public void AtivarForm(Form formSender) {
            Console.WriteLine(formSender);

            if (currentForm != null) {
                currentForm.Close();
            }

            currentForm = formSender;

            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            txtHeader.Text = currentForm.Text;
            painelForm.Controls.Add(currentForm);
            painelForm.Tag = currentForm;

            currentForm.BringToFront();
            currentForm.Show();
        }

        private void OnClickHiddenMenu(object sender, EventArgs e) {
            HiddenMenu();
        }

        private void OnClickMenu(object sender, EventArgs e) {
            IconButton Button = (IconButton)sender;
            
            AtivarBotao(sender);
            
            switch (Button.Tag) {
                case "home":
                    AtivarForm(new TMSForms.FormHome(this));
                    break;
                case "motoristas":
                    AtivarForm(new TMSForms.List.FormMotoristas(this));
                    break;
                case "veiculos":
                    AtivarForm(new TMSForms.List.FormVeiculos(this));
                    break;
                case "clientes":
                    AtivarForm(new TMSForms.List.FormClientes(this));
                    break;
                case "viagens":
                    AtivarForm(new TMSForms.List.FormViagens(this));
                    break;
                case "manutencoes":
                    AtivarForm(new TMSForms.List.FormManutencoes(this));
                    break;
                case "abastecimentos":
                    AtivarForm(new TMSForms.List.FormAbastecimentos(this));
                    break;
                case "multas":
                    AtivarForm(new TMSForms.List.FormMultas(this));
                    break;
                case "financeiro":
                    AtivarForm(new TMSForms.List.FormFinanceiro(this));
                    break;
            }
        }
    }
}
