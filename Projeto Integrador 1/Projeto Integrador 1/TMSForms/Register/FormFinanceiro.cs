using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormFinanceiro : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormFinanceiro(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combTipo.DisplayMember = "Text";
            combTipo.ValueMember = "Value";
            combTipo.DataSource = ValuesComb.getFinanceiroTipo();

            combCentroCusto.DisplayMember = "Text";
            combCentroCusto.ValueMember = "Value";
            combCentroCusto.DataSource = ValuesComb.getFinanceiroCentroCusto();

            combFormaPagamento.DisplayMember = "Text";
            combFormaPagamento.ValueMember = "Value";
            combFormaPagamento.DataSource = ValuesComb.getFinanceiroFormaPagamento();

            colFormaPagamento.DisplayMember = "Text";
            colFormaPagamento.ValueMember = "Value";
            colFormaPagamento.DataSource = ValuesComb.getFinanceiroFormaPagamento();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getFinanceiroStatus();

            combOcorrencia.DisplayMember = "Text";
            combOcorrencia.ValueMember = "Value";
            combOcorrencia.DataSource = ValuesComb.getFinanceiroOcorrencia();

            if (Id > 0) {
                this.Text = "Editar Financeiro";
                this.Id = Id;
                this.PreencherDados();
            }
        }

        private void PreencherDados() {
            
        }

        private void OnGerarParcelas(object sender, EventArgs e) {
            Validate Validate = new Validate(this, ErrorProvider);

            Validate.AddRule(textValor, "Valor", "required|numeric");
            Validate.AddRule(textQtdParcelas, "Qtd. Parcelas", "required|numeric");
            Validate.Validation();

            if (Validate.IsValid()) {
                int qtdParcelas = Convert.ToInt32(textQtdParcelas.Text);

                if (qtdParcelas > 0) {
                    var data = Convert.ToDateTime(timeDataEmissao.Text);

                    decimal valorParcelas = Convert.ToInt32(textValor.Text) / Convert.ToDecimal(qtdParcelas);

                    gridParcelas.Rows.Clear();
                    
                    for (var i = 0; i < qtdParcelas; i++) {
                        gridParcelas.Rows.Add(i+1, data.AddMonths(i).ToString("dd/MM/yyyy"), valorParcelas.ToString("F"), combFormaPagamento.SelectedValue, "", (Convert.ToInt32(combStatus.SelectedValue) == 1 ? true : false));
                    }

                    lblInfoPagamento.Visible = true;
                    panelInfoPagamento.Visible = true;
                    gridParcelas.Visible = true;
                }
                else {
                    lblInfoPagamento.Visible = false;
                    panelInfoPagamento.Visible = false;
                    gridParcelas.Visible = false;
                }
            }
            else {
                Validate.ErrorProviderShow();
            }
        }

        private void OnSelectOcorrencia(object sender, EventArgs e) {
            var Selected = combOcorrencia.SelectedValue;

            if (Convert.ToInt32(Selected) == 2) {
                lblQtdParcelas.Visible = true;
                textQtdParcelas.Visible = true;
                btnGerarParcelas.Visible = true;
            }
            else {
                lblQtdParcelas.Visible = false;
                textQtdParcelas.Visible = false;
                btnGerarParcelas.Visible = false;

                textQtdParcelas.ResetText();

                lblInfoPagamento.Visible = false;
                panelInfoPagamento.Visible = false;
                gridParcelas.Visible = false;
                gridParcelas.Rows.Clear();
            }
        }

        private void OnEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(textNome, "Nome", "required|max:30");
                Validate.AddRule(combTipo, "Tipo", "required|numeric|exact:1");
                Validate.AddRule(combCentroCusto, "Centro de Custo", "required|max:2");
                Validate.AddRule(combFormaPagamento, "Forma de Pagamento", "required|max:2");
                Validate.AddRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.AddRule(timeDataEmissao, "Data Emissão", "required|data:dd/MM/yyyy");
                Validate.AddRule(timeDataVencimento, "Data Vencimento", "required|data:dd/MM/yyyy");
                Validate.AddRule(textValor, "Valor", "required|numeric|max:11");
                Validate.AddRule(textDocumento, "Nº Document", "max:30");
                Validate.AddRule(combOcorrencia, "Ocorrencia", "required|numeric|exact:1");
                Validate.AddRule(textQtdParcelas, "Qtd. Parcelas", "max:3");
                Validate.Validation();

                if (Validate.IsValid()) {
                    MessageBox.Show("TUDO OK");
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
