using Correios.CEP;
using FontAwesome.Sharp;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Drawing;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormClientes : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormClientes(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            textInscricaoEstadual.KeyPress += Converter.OnlyNumber;
            textInscricaoMunicipal.KeyPress += Converter.OnlyNumber;

            combTipoCadastro.DisplayMember = "Text";
            combTipoCadastro.ValueMember = "Value";
            combTipoCadastro.DataSource = Listas.ClientesTipoCadastros;

            combTipoPessoa.DisplayMember = "Text";
            combTipoPessoa.ValueMember = "Value";
            combTipoPessoa.DataSource = Listas.ClientesTipoPessoas;

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = Listas.Estados;

            if (Id > 0) {
                Text = "Editar Cliente";
                this.Id = Id;
                PreencherDados();
            }
        }

        private void PreencherDados() {
            try {
                Clientes clientes = new Clientes();
                clientes.Id = Id;
                clientes.Get();

                dynamic cliente = clientes.Results[0];

                combTipoCadastro.SelectedValue = cliente.TipoCadastro;
                combTipoPessoa.SelectedValue = cliente.TipoPessoa;
                textCNPJ.Text = cliente.CNPJ;
                textRazaoSocial.Text = cliente.RazaoSocial;
                textInscricaoMunicipal.Text = cliente.InscricaoMunicipal;
                textInscricaoEstadual.Text = cliente.InscricaoEstadual;
                checkIsento.Checked = cliente.Isento;
                textCEP.Text = cliente.CEP;
                textEndereco.Text = cliente.Endereco;
                textN.Text = cliente.N;
                textBairro.Text = cliente.Bairro;
                textComplemento.Text = cliente.Complemento;
                textCidade.Text = cliente.Cidade;
                combEstado.SelectedValue = cliente.Estado;
                textNome.Text = cliente.Nome;
                textTelefone.Text = cliente.Telefone;
                textRamal.Text = cliente.Ramal;
                textCelular.Text = cliente.Celular;
                textEmail.Text = cliente.Email;
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
            }
        }

        private void onBuscarCEP(object sender, EventArgs e) {
            IconButton button = (IconButton)sender;

            IconChar defaultIcon = button.IconChar;

            button.IconChar = IconChar.Spinner;

            try {
                Validate Validate = new Validate();

                Validate.AddRule(textCEP, "CEP", "required|cep");
                Validate.Validation();

                if (Validate.IsValid()) {
                    cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                    textEndereco.Text = endereco.Rua;
                    textN.Focus();
                    textBairro.Text = endereco.Bairro;
                    textComplemento.Text = "";
                    textCidade.Text = endereco.Cidade;
                    combEstado.SelectedValue = endereco.UF;

                    button.IconChar = defaultIcon;
                }
                else {
                    button.IconChar = defaultIcon;
                    Validate.ErrorMessageBox();
                }
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
                textCNPJ.Mask = "000.000.000-00";

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
            else {
                if (string.IsNullOrWhiteSpace(Convert.ToString(Selected))) {
                    combTipoPessoa.SelectedValue = "PJ";
                }
                textCNPJ.Mask = "00.000.000/0000-00";

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
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(combTipoCadastro, "Tipo Cadastro", "required|in:C,F,A|exact:1");
                Validate.AddRule(combTipoPessoa, "Tipo Pessoa", "required|in:PF,PJ|exact:2");
                Validate.AddRule(textCNPJ, lblCNPJ.Text, "required|" + ((string)combTipoPessoa.SelectedValue == "PJ" ? "cnpj" : "cpf"));
                Validate.AddRule(textRazaoSocial, lblRazaoSocial.Text, "required|max:150");
                Validate.AddRule(textNomeFantasia, "Razão Social", "max:150");
                Validate.AddRule(textInscricaoMunicipal, lblInscricaoMunicipal.Text, "max:12");
                Validate.AddRule(textInscricaoEstadual, lblInscricaoEstadual.Text, "max:12");
                Validate.AddRule(textCEP, "CEP", "cep");
                Validate.AddRule(textEndereco, "Endereco", "max:100");
                Validate.AddRule(textN, "Nº", "max:10");
                Validate.AddRule(textBairro, "Bairro", "max:60");
                Validate.AddRule(textComplemento, "Complemento", "max:100");
                Validate.AddRule(textCidade, "Cidade", "max:100");
                Validate.AddRule(combEstado, "Estado", "exact:2");
                Validate.AddRule(textNome, "Contato Nome", "max:100");
                Validate.AddRule(textTelefone, "Telefone", "telefone");
                Validate.AddRule(textRamal, "Ramal", "numeric|max:10");
                Validate.AddRule(textCelular, "Celular", "telefone");
                Validate.AddRule(textEmail, "Email", "email|max:100");
                Validate.AddRule(textObservacoes, "Observações", "max:500");

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

                    if (Id > 0) {
                        clientes.Id = Convert.ToInt32(Id);
                        clientes.Update();
                    }
                    else {
                        clientes.Create();
                    }

                    if (clientes.Success) {
                        DialogResult SuccessBox = MessageBox.Show(clientes.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormClientes(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
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

        private void OnKeyPressUpTelefone(object sender, KeyEventArgs e) {
            MaskedTextBox Telefone = (MaskedTextBox)sender;
            Telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Telefone.PromptChar = (Telefone.MaskCompleted ? ' ' : '_');

            if (Telefone.Text.Length == 11) {
                Telefone.Mask = "(00) 00000-0000";
            }
            else {
                Telefone.Mask = "(00) 0000-00009";
            }
        }
    }
}
