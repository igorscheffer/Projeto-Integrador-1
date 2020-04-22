using Correios.CEP;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combTipoCadastro.DisplayMember = "Text";
            combTipoCadastro.ValueMember = "Value";
            combTipoCadastro.DataSource = ValuesComb.getClienteTipoCadastro();
            combTipoCadastro.SelectedValue = -1;

            combTipoPessoa.DisplayMember = "Text";
            combTipoPessoa.ValueMember = "Value";
            combTipoPessoa.DataSource = ValuesComb.getClienteTipoPessoa();
            combTipoPessoa.SelectedValue = -1;

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = ValuesComb.getEstados();
            combEstado.SelectedValue = -1;
        }

        private void onBuscarCEP(object sender, EventArgs e)
        {
            try
            {
                cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                textEndereco.Text = endereco.Rua;
                textN.Focus();
                textBairro.Text = endereco.Bairro;
                textComplemento.Text = "";
                textCidade.Text = endereco.Cidade;
                combEstado.SelectedValue = endereco.UF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onChangeIsento(object sender, EventArgs e)
        {
            if (checkIsento.Checked)
            {
                textInscricaoEstadual.Text = "ISENTO";
                textInscricaoEstadual.Enabled = false;
            }
            else
            {
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

        private void onSelectTipoPessoa(object sender, EventArgs e)
        {
            int widthNF = this.WidthComponent(textNomeFantasia);
            int widthIM = this.WidthComponent(textInscricaoMunicipal);

            var Selected = combTipoPessoa.SelectedValue;

            if (Selected == "PF")
            {
                lblCNPJ.Text = "CPF";
                lblRazaoSocial.Text = "NOME";
                lblInscricaoMunicipal.Text = "RG";
                lblInscricaoEstadual.Text = "INSCRIÇÃO PRODUTOR RURAL";

                lblNomeFantasia.Visible = false;
                textNomeFantasia.Visible = false;

                textCNPJ.MaxLength = 14;

                if ((textInscricaoMunicipal.Location.X - widthNF) > 0){
                    lblInscricaoMunicipal.Location = new Point((lblInscricaoMunicipal.Location.X - widthNF), lblInscricaoMunicipal.Location.Y);
                    textInscricaoMunicipal.Location = new Point((textInscricaoMunicipal.Location.X - widthNF), textInscricaoMunicipal.Location.Y);

                    lblInscricaoEstadual.Location = new Point((lblInscricaoEstadual.Location.X - widthNF), lblInscricaoEstadual.Location.Y);
                    textInscricaoEstadual.Location = new Point((textInscricaoEstadual.Location.X - widthNF), textInscricaoEstadual.Location.Y);
                    
                    checkIsento.Location = new Point((checkIsento.Location.X - widthNF), checkIsento.Location.Y);
                }
            }
            else if(Selected == "PJ") {
                lblCNPJ.Text = "CNPJ";
                lblNomeFantasia.Text = "NOME FANTASIA";
                lblInscricaoMunicipal.Text = "INSCRIÇÃO MUNICIPAL";
                lblInscricaoEstadual.Text = "INSCRIÇÃO ESTADUAL";

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

        private void onEnviar(object sender, EventArgs e)
        {
            try
            {
                string regExpCNPJ = @"^(\d{2})(\.\d{3}){2}(\/\d{4})(\-\d{2})$";
                string regExpCPF = @"^(\d{3})(\.\d{3})(\.\d{3})(\-\d{2})$";

                Validate Validate = new Util.Validate();

                Validate.addRule(combTipoCadastro,          "Tipo Cadastro",            "required|in:C,F,A|exact:1");
                Validate.addRule(combTipoPessoa,            "Tipo Pessoa",              "required|in:PF,PJ|exact:2");
                Validate.addRule(textCNPJ,                  lblCNPJ.Text,               "required|regExp:" + (combTipoPessoa.SelectedValue == "PJ" ? regExpCNPJ : regExpCPF));
                Validate.addRule(textRazaoSocial,           lblRazaoSocial.Text,        "required|max:150");
                Validate.addRule(textNomeFantasia,          "Razão Social",             "max:150");
                Validate.addRule(textInscricaoMunicipal,    lblInscricaoMunicipal.Text, "max:12");
                Validate.addRule(textInscricaoEstadual,     lblInscricaoEstadual.Text,  "max:12");
                Validate.addRule(textCEP,                   "CEP",                      @"regExp:^(\d{5})(\-\d{3})$");
                Validate.addRule(textEndereco,              "Endereco",                 "max:100");
                Validate.addRule(textN,                     "Nº",                       "max:10");
                Validate.addRule(textBairro,                "Bairro",                   "max:60");
                Validate.addRule(textComplemento,           "Complemento",              "max:100");
                Validate.addRule(textCidade,                "Cidade",                   "max:100");
                Validate.addRule(combEstado,                "Estado",                   "exact:2");
                Validate.addRule(textNome,                  "Contato Nome",             "max:100");
                Validate.addRule(textTelefone,              "Telefone",                 @"regExp:\(\d{2,}\) \d{4,}\-\d{4}$");
                Validate.addRule(textRamal,                 "Ramal",                    "numeric|max:10");
                Validate.addRule(textCelular,               "Celular",                  @"regExp:\(\d{2,}\) \d{4,}\-\d{4}$");
                Validate.addRule(textEmail,                 "Email",                    "email|max:100");
                Validate.addRule(textObservacoes,           "Observações",              "max:500");

                Validate.Validation();

                if (Validate.IsValid())
                {
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

                    if (clientes.Success){
                        MessageBox.Show(clientes.Message);
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar o cliente (" + clientes.Message + ")");
                    }
                }
                else
                {
                    string ShowMessage = "";

                    foreach (dynamic Erro in Validate.getErrors())
                    {
                        ShowMessage += Erro.Message + "\n";
                    }

                    MessageBox.Show(ShowMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
