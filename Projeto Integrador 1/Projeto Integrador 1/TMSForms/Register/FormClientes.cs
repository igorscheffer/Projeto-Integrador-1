using Correios.CEP;
using FontAwesome.Sharp;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormClientes : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();
        public FormClientes() {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combTipoCadastro.DisplayMember = "Text";
            combTipoCadastro.ValueMember = "Value";
            combTipoCadastro.DataSource = ValuesComb.getClienteTipoCadastro();

            combTipoPessoa.DisplayMember = "Text";
            combTipoPessoa.ValueMember = "Value";
            combTipoPessoa.DataSource = ValuesComb.getClienteTipoPessoa();

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = ValuesComb.getEstados();
        }

        private void onBuscarCEP(object sender, EventArgs e) {
            IconButton button = (IconButton)sender;

            IconChar defaultIcon = button.IconChar;

            button.IconChar = IconChar.Spinner;

            try {
                cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                textEndereco.Text = endereco.Rua;
                textN.Focus();
                textBairro.Text = endereco.Bairro;
                textComplemento.Text = "";
                textCidade.Text = endereco.Cidade;
                combEstado.SelectedValue = endereco.UF;

                button.IconChar = defaultIcon;
            }
            catch (Exception ex) {
                button.IconChar = defaultIcon;
                MessageBox.Show(ex.Message);
            }
        }

        private void onChangeIsento(object sender, EventArgs e) {
            if (checkIsento.Checked) {
                textInscricaoEstadual.Text = "ISENTO";
                textInscricaoEstadual.Enabled = false;
            }
            else {
                textInscricaoEstadual.ResetText();
                textInscricaoEstadual.Enabled = true;
            }
        }

        private int WidthComponent(Control component) {
            int width = component.Width;
            int marginLeft = component.Margin.Left;
            int marginRight = component.Margin.Right;

            return width + marginLeft + marginRight;
        }

        private void onSelectTipoPessoa(object sender, EventArgs e) {
            int widthNF = WidthComponent(textNomeFantasia);
            int widthIM = WidthComponent(textInscricaoMunicipal);

            var Selected = combTipoPessoa.SelectedValue;

            if (Convert.ToString(Selected) == "PF") {
                lblCNPJ.Text = "CPF";
                lblRazaoSocial.Text = "Nome";
                lblInscricaoMunicipal.Text = "RG";
                lblInscricaoEstadual.Text = "Insc. Estadual Produtor Rural";

                lblNomeFantasia.Visible = false;
                textNomeFantasia.Visible = false;

                textCNPJ.MaxLength = 14;

                if ((textInscricaoMunicipal.Location.X - widthNF) > 0) {
                    lblInscricaoMunicipal.Location = new Point((lblInscricaoMunicipal.Location.X - widthNF), lblInscricaoMunicipal.Location.Y);
                    textInscricaoMunicipal.Location = new Point((textInscricaoMunicipal.Location.X - widthNF), textInscricaoMunicipal.Location.Y);

                    lblInscricaoEstadual.Location = new Point((lblInscricaoEstadual.Location.X - widthNF), lblInscricaoEstadual.Location.Y);
                    textInscricaoEstadual.Location = new Point((textInscricaoEstadual.Location.X - widthNF), textInscricaoEstadual.Location.Y);

                    checkIsento.Location = new Point((checkIsento.Location.X - widthNF), checkIsento.Location.Y);
                }
            }
            else if (Convert.ToString(Selected) == "PJ") {
                lblCNPJ.Text = "CNPJ";
                lblNomeFantasia.Text = "Nome Fantasia";
                lblInscricaoMunicipal.Text = "Inscrição Municipal";
                lblInscricaoEstadual.Text = "Inscrição Estadual";

                lblNomeFantasia.Visible = true;
                textNomeFantasia.Visible = true;

                textCNPJ.MaxLength = 18;

                if ((textInscricaoEstadual.Location.X + widthNF) < textComplemento.Location.X) {
                    lblInscricaoMunicipal.Location = new Point((lblInscricaoMunicipal.Location.X + widthNF), lblInscricaoMunicipal.Location.Y);
                    textInscricaoMunicipal.Location = new Point((textInscricaoMunicipal.Location.X + widthNF), textInscricaoMunicipal.Location.Y);

                    lblInscricaoEstadual.Location = new Point((lblInscricaoEstadual.Location.X + widthNF), lblInscricaoEstadual.Location.Y);
                    textInscricaoEstadual.Location = new Point((textInscricaoEstadual.Location.X + widthNF), textInscricaoEstadual.Location.Y);

                    checkIsento.Location = new Point((checkIsento.Location.X + widthNF), checkIsento.Location.Y);
                }
            }
        }

        private void onEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Util.Validate();

                Validate.addRule(combTipoCadastro, "Tipo Cadastro", "required|in:C,F,A|exact:1");
                Validate.addRule(combTipoPessoa, "Tipo Pessoa", "required|in:PF,PJ|exact:2");
                Validate.addRule(textCNPJ, lblCNPJ.Text, "required|" + ((string)combTipoPessoa.SelectedValue == "PJ" ? "cnpj" : "cpf"));
                Validate.addRule(textRazaoSocial, lblRazaoSocial.Text, "required|max:150");
                Validate.addRule(textNomeFantasia, "Razão Social", "max:150");
                Validate.addRule(textInscricaoMunicipal, lblInscricaoMunicipal.Text, "max:12");
                Validate.addRule(textInscricaoEstadual, lblInscricaoEstadual.Text, "max:12");
                Validate.addRule(textCEP, "CEP", "cep");
                Validate.addRule(textEndereco, "Endereco", "max:100");
                Validate.addRule(textN, "Nº", "max:10");
                Validate.addRule(textBairro, "Bairro", "max:60");
                Validate.addRule(textComplemento, "Complemento", "max:100");
                Validate.addRule(textCidade, "Cidade", "max:100");
                Validate.addRule(combEstado, "Estado", "exact:2");
                Validate.addRule(textNome, "Contato Nome", "max:100");
                Validate.addRule(textTelefone, "Telefone", "telefone");
                Validate.addRule(textRamal, "Ramal", "numeric|max:10");
                Validate.addRule(textCelular, "Celular", "telefone");
                Validate.addRule(textEmail, "Email", "email|max:100");
                Validate.addRule(textObservacoes, "Observações", "max:500");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Clientes clientes = new Clientes();

                    clientes.TipoCadastro = combTipoCadastro.SelectedValue;
                    clientes.TipoPessoa = combTipoPessoa.SelectedValue;
                    clientes.CNPJ = textCNPJ.Text;
                    clientes.RazaoSocial = textRazaoSocial.Text;
                    clientes.NomeFantasia = textNomeFantasia.Text;
                    clientes.InscricaoMunicipal = textInscricaoMunicipal.Text;
                    clientes.InscricaoEstadual = textInscricaoEstadual.Text;
                    clientes.Isento = checkIsento.Checked;
                    clientes.CEP = textCEP.Text;
                    clientes.Endereco = textEndereco.Text;
                    clientes.N = textN.Text;
                    clientes.Bairro = textBairro.Text;
                    clientes.Complemento = textComplemento.Text;
                    clientes.Cidade = textCidade.Text;
                    clientes.Estado = combEstado.SelectedValue;
                    clientes.Nome = textNome.Text;
                    clientes.Telefone = textTelefone.Text;
                    clientes.Ramal = textRamal.Text;
                    clientes.Celular = textCelular.Text;
                    clientes.Email = textEmail.Text;
                    clientes.Observacoes = textObservacoes.Text;

                    clientes.Create();

                    if (clientes.Success) {
                        MessageBox.Show(clientes.Message);
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar o cliente (" + clientes.Message + ")");
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
