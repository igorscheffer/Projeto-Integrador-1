using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.CEP;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormMotoristas : Form
    {

        public FormMotoristas()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getMotoristaStatus();
            combStatus.SelectedValue = -1;

            combCategoriaCNH.DisplayMember = "Text";
            combCategoriaCNH.ValueMember = "Value";
            combCategoriaCNH.DataSource = ValuesComb.getCategoriasCNH();
            combCategoriaCNH.SelectedValue = -1;

            combSexo.DisplayMember = "Text";
            combSexo.ValueMember = "Value";
            combSexo.DataSource = ValuesComb.getSexo();
            combSexo.SelectedValue = -1;

            combEstadoCivil.DisplayMember = "Text";
            combEstadoCivil.ValueMember = "Value";
            combEstadoCivil.DataSource = ValuesComb.getEstadoCivil();
            combEstadoCivil.SelectedValue = -1;

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = ValuesComb.getEstados();
            combEstado.SelectedValue = -1;

            combCargo.DisplayMember = "Text";
            combCargo.ValueMember = "Value";
            combCargo.DataSource = ValuesComb.getMotoristaCargos();
            combCargo.SelectedValue = -1;

            timeVencimentoCNH.ResetText();
        }

        private void onBuscarCEP(object sender, EventArgs e)
        {
            try {
                cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                textEndereco.Text = endereco.Rua;
                textN.Focus();
                textBairro.Text = endereco.Bairro;
                textComplemento.Text = "";
                textCidade.Text = endereco.Cidade;
                combEstado.SelectedValue = endereco.UF;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void onEnviar(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(textNome, "Nome Completo", "required|max:100");
                Validate.addRule(textCPF, "CPF", @"required|regExp:^(\d{3})(\.\d{3})(\.\d{3})(\-\d{2})$");
                Validate.addRule(textRG, "RG", "numeric|max:12");
                Validate.addRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.addRule(textCNH, "CNH", "numeric|max:12");
                Validate.addRule(timeVencimentoCNH, "Vencimento", "date:dd/MM/yyyy");
                Validate.addRule(combCategoriaCNH, "Categoria", "min:1|max:2");
                Validate.addRule(combSexo, "Sexo", "required|exact:1");
                Validate.addRule(combEstadoCivil, "Estado Civil", "required|numeric|exact:1");
                Validate.addRule(textCEP, "CEP", @"regExp:^(\d{5})(\-\d{3})$");
                Validate.addRule(textEndereco, "Endereco", "max:100");
                Validate.addRule(textN, "Nº", "max:10");
                Validate.addRule(textBairro, "Bairro", "max:60");
                Validate.addRule(textComplemento, "Complemento", "max:100");
                Validate.addRule(textCidade, "Cidade", "max:100");
                Validate.addRule(combEstado, "Estado", "exact:2");
                Validate.addRule(combCargo, "Cargo", "numeric|exact:1");
                Validate.addRule(textTelefone, "Telefone", @"regExp:\(\d{2,}\) \d{4,}\-\d{4}$");
                Validate.addRule(textCelular, "Celular", @"regExp:\(\d{2,}\) \d{4,}\-\d{4}$");
                Validate.addRule(textEmail, "Email", "email|max:100");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    Motoristas motoristas = new Motoristas();

                    motoristas.Nome = textNome.Text;
                    motoristas.CPF = textCPF.Text;
                    motoristas.RG = textRG.Text;
                    motoristas.Status = combStatus.SelectedValue;
                    motoristas.CNH = textCNH.Text;
                    motoristas.Vencimento = timeVencimentoCNH.Text;
                    motoristas.Categoria = combCategoriaCNH.SelectedValue;
                    motoristas.Sexo = combSexo.SelectedValue;
                    motoristas.EstadoCivil = combEstadoCivil.SelectedValue;
                    motoristas.CEP = textCEP.Text;
                    motoristas.Endereco = textEndereco.Text;
                    motoristas.N = textN.Text;
                    motoristas.Bairro = textBairro.Text;
                    motoristas.Complemento = textComplemento.Text;
                    motoristas.Cidade = textCidade.Text;
                    motoristas.Estado = combEstado.SelectedValue;
                    motoristas.Cargo = combCargo.SelectedValue;
                    motoristas.Telefone = textTelefone.Text;
                    motoristas.Celular = textCelular.Text;
                    motoristas.Email = textEmail.Text;

                    motoristas.Create();

                    if (motoristas.Success)
                    {
                        MessageBox.Show(motoristas.Message);
                    }
                    else
                    {
                        MessageBox.Show("Houver um erro ao salvar o motorista (" + motoristas.Message + ")");
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
