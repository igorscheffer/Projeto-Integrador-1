using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormMultas : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormMultas(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            LoadVeiculos();
            LoadMotoristas();

            combGravidade.DisplayMember = "Text";
            combGravidade.ValueMember = "Value";
            combGravidade.DataSource = Listas.MultasGravidades;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = Listas.MultasStatus;

            if (Id > 0) {
                Text = "Editar Multa";
                this.Id = Id;
                PreencherDados();
            }
        }

        private void PreencherDados() {

            Multas multas = new Multas();
            multas.Id = Id;
            multas.Get();

            dynamic multa = multas.Results[0];

            combVeiculo.SelectedValue = Convert.ToInt32(multa.Veiculo);
            combMotorista.SelectedValue = Convert.ToInt32(multa.Motorista);
            combGravidade.SelectedValue = Convert.ToInt32(multa.Gravidade);
            combStatus.SelectedValue = Convert.ToInt32(multa.Status);
            timeDataOcorrencia.Text = multa.DataOcorrencia;
            timeDataNotificacao.Text = multa.DataNotificacao;
            timeDataVencimento.Text = multa.DataVencimento;
            textValor.Text = Converter.DecimalToReais(Convert.ToDecimal(multa.Valor));
            textDescricao.Text = multa.Descricao;
            textLocal.Text = multa.Local;

        }

        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
            combVeiculo.SelectedValue = -1;
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotorista.DisplayMember = "Nome";
            combMotorista.ValueMember = "Id";
            combMotorista.DataSource = new List<dynamic>(motoristas.Results);
            combMotorista.SelectedValue = -1;
        }

        private void OnEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(combVeiculo, "Veiculo", "required|numeric|max:11");
                Validate.AddRule(combMotorista, "Motorista", "numeric|max:11");
                Validate.AddRule(combGravidade, "Gravidade", "required|numeric|exact:1");
                Validate.AddRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.AddRule(timeDataOcorrencia, "Data Ocorrencia", "required|date:dd/MM/yyyy");
                Validate.AddRule(timeDataNotificacao, "Data Notificacao", "date:dd/MM/yyyy");
                Validate.AddRule(timeDataVencimento, "Data Vencimento", "date:dd/MM/yyyy");
                Validate.AddRule(textValor, "Valor", "numeric|max:11");
                Validate.AddRule(textDescricao, "Descrição da Infração", "max:500");
                Validate.AddRule(textLocal, "Local da Infração", "max:500");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Multas multas = new Multas();

                    multas.Veiculo = combVeiculo.SelectedValue;
                    multas.Motorista = combMotorista.SelectedValue;
                    multas.Gravidade = combGravidade.SelectedValue;
                    multas.Status = combStatus.SelectedValue;
                    multas.DataOcorrencia = timeDataOcorrencia.Text;
                    multas.DataNotificacao = timeDataNotificacao.Text;
                    multas.DataVencimento = timeDataVencimento.Text;
                    multas.Valor = textValor.Text;
                    multas.Descricao = textDescricao.Text;
                    multas.Local = textLocal.Text;

                    if (Id > 0) {
                        multas.Id = Convert.ToInt32(Id);
                        multas.Update();
                    }
                    else {
                        multas.Create();
                    }

                    if (multas.Success) {
                        DialogResult SuccessBox = MessageBox.Show(multas.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormMultas(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Houver um erro ao salvar a multas (" + multas.Message + ")");
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

        private void OnChangedTextValor(object sender, EventArgs e) {
            MaskedTextBox Text = (MaskedTextBox)sender;
            Converter.OnPressMoeda(ref Text);
        }
    }
}
