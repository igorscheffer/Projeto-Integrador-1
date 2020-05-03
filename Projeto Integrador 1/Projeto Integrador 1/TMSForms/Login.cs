using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;
using Projeto_Integrador_1.Connection;

namespace Projeto_Integrador_1.TMSForms {
    public partial class Login : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        public Login() {
            InitializeComponent();

            if (Properties.Settings.Default.salvarSenha) {
                textLogin.Text = Properties.Settings.Default.login;
                textSenha.Text = Properties.Settings.Default.senha;
                checkSalvarDados.Checked = Properties.Settings.Default.salvarSenha;
            }
        }

        private void OnClickClose(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OnMouseEnterClose(object sender, EventArgs e) {
            IconButton Close = (IconButton)sender;

            Close.IconColor = Color.FromArgb(5, 178, 220);
        }

        private void OnMouseLeaveClose(object sender, EventArgs e) {
            IconButton Close = (IconButton)sender;

            Close.IconColor = Color.FromArgb(255, 255, 255);
        }

        private void OnClickLogar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(textLogin, "Usuario", "required|email|max:100");
                Validate.AddRule(textSenha, "Senha", "required|min:4|max:20");
                Validate.Validation();

                if (Validate.IsValid()) {
                    Usuario login = new Usuario();

                    login.Login = textLogin.Text;
                    login.Senha = textSenha.Text;
                    login.SalvarSenha = checkSalvarDados.Checked;
                    login.Logar();

                    if (login.Success) {
                        Form FormPrincipal = new FormPrincipal();

                        Hide();

                        FormPrincipal.Closed += (fSender, eSender) => Close();
                        FormPrincipal.Show();
                    }
                    else {
                        throw new Exception(login.Message);
                    }
                }
                else {
                    Validate.ErrorProviderShow();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
