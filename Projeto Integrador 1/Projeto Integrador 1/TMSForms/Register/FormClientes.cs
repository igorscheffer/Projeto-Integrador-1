using Correios.CEP;
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
                lblInscricaoEstadual.Text = "INSCRIÇÃO PRODUTOR RURAL";

                lblNomeFantasia.Visible = false;
                textNomeFantasia.Visible = false;

                lblInscricaoMunicipal.Visible = false;
                textInscricaoMunicipal.Visible = false;

                if ((lblInscricaoEstadual.Location.X - widthNF - widthIM) > 0){
                    lblInscricaoEstadual.Location = new Point((lblInscricaoEstadual.Location.X - widthNF - widthIM), lblInscricaoEstadual.Location.Y);
                    textInscricaoEstadual.Location = new Point((textInscricaoEstadual.Location.X - widthNF - widthIM), textInscricaoEstadual.Location.Y);
                    checkIsento.Location = new Point((checkIsento.Location.X - widthNF - widthIM), checkIsento.Location.Y);
                }
            }
            else if(Selected == "PJ") {
                lblCNPJ.Text = "CNPJ";
                lblNomeFantasia.Text = "NOME FANTASIA";
                lblInscricaoEstadual.Text = "INSCRIÇÃO ESTADUAL";

                lblNomeFantasia.Visible = true;
                textNomeFantasia.Visible = true;

                lblInscricaoMunicipal.Visible = true;
                textInscricaoMunicipal.Visible = true;

                if ((lblInscricaoEstadual.Location.X + widthNF + widthIM) < textComplemento.Location.X) {
                    lblInscricaoEstadual.Location = new Point((lblInscricaoEstadual.Location.X + widthNF + widthIM), lblInscricaoEstadual.Location.Y);
                    textInscricaoEstadual.Location = new Point((textInscricaoEstadual.Location.X + widthNF + widthIM), textInscricaoEstadual.Location.Y);
                    checkIsento.Location = new Point((checkIsento.Location.X + widthNF + widthIM), checkIsento.Location.Y);
                }
            }
        }
    }
}
