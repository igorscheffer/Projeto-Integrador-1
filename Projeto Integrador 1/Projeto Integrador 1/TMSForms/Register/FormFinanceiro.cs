using Projeto_Integrador_1.Util;
using System;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;
using Newtonsoft.Json;
using System.Collections.Generic;
using Guna.UI2.WinForms;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormFinanceiro : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;
        private int Referencia;

        private string jsonParcelas;

        public FormFinanceiro(FormPrincipal fmPrincipal = null, int Id = 0, dynamic LancarFinanceiro = null) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            textValor.KeyPress += Converter.OnlyNumber;

            timeDataEmissao.KeyPress += Converter.DateReset;
            timeDataEmissao.ValueChanged += Converter.DateValueChanged;

            timeDataVencimento.KeyPress += Converter.DateReset;
            timeDataVencimento.ValueChanged += Converter.DateValueChanged;

            combTipo.DisplayMember = "Text";
            combTipo.ValueMember = "Value";
            combTipo.DataSource = Listas.FinanceiroTipos;

            combCentroCusto.DisplayMember = "Text";
            combCentroCusto.ValueMember = "Value";
            combCentroCusto.DataSource = Listas.FinanceiroCentroCustos;

            combFormaPagamento.DisplayMember = "Text";
            combFormaPagamento.ValueMember = "Value";
            combFormaPagamento.DataSource = Listas.FinanceiroFormasPagamentos;

            colFormaPagamento.DisplayMember = "Text";
            colFormaPagamento.ValueMember = "Value";
            colFormaPagamento.DataSource = Listas.FinanceiroFormasPagamentos;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = Listas.FinanceiroStatus;

            combOcorrencia.DisplayMember = "Text";
            combOcorrencia.ValueMember = "Value";
            combOcorrencia.DataSource = Listas.FinanceiroOcorrencias;

            if (Id > 0) {
                Text = "Editar Financeiro";
                this.Id = Id;
                PreencherDados();
            }

            if (LancarFinanceiro != null) {
                if (LancarFinanceiro.Tipo == 1 || LancarFinanceiro.Tipo == 2) {
                    combTipo.SelectedValue = LancarFinanceiro.Tipo;
                    combTipo.Enabled = false;
                }

                if (LancarFinanceiro.Valor > 0) {
                    textValor.Text = Converter.ToReais(Convert.ToDecimal(LancarFinanceiro.Valor));
                    textValor.Enabled = false;
                }
                else {
                    textValor.Text = "";
                }

                combCentroCusto.SelectedValue = LancarFinanceiro.CentroCusto;
                combCentroCusto.Enabled = false;

                Referencia = LancarFinanceiro.Id;
            }

        }

        private void PreencherGrids(string json) {
            if (!string.IsNullOrWhiteSpace(json)) {
                List<dynamic> Parcelas = JsonConvert.DeserializeObject<List<dynamic>>(json);

                if (Parcelas.Count > 0) {
                    foreach (var parcela in Parcelas) {
                        gridParcelas.Rows.Add(
                            parcela.Parcela,
                            parcela.Data,
                            Converter.ToReais(parcela.Valor),
                            Convert.ToInt32(parcela.FormaPagamento),
                            parcela.Observacoes,
                            parcela.Pago
                        );
                    }

                    lblInfoPagamento.Visible = true;
                    panelInfoPagamento.Visible = true;
                    gridParcelas.Visible = true;
                }
            }
        }

        private void PreencherDados() {
            try {
                Connection.Financeiro financeiro = new Connection.Financeiro();
                financeiro.Id = Id;
                financeiro.Get();

                dynamic fin = financeiro.Results[0];

                textNome.Text = fin.Nome;
                combTipo.SelectedValue = Convert.ToInt32(fin.Tipo);
                combCentroCusto.SelectedValue = Convert.ToInt32(fin.CentroCusto);
                combFormaPagamento.SelectedValue = Convert.ToInt32(fin.FormaPagamento);
                combStatus.SelectedValue = Convert.ToInt32(fin.Status);
                timeDataEmissao.Text = fin.DataEmissao;
                timeDataVencimento.Text = fin.DataVencimento;
                textValor.Text = Converter.ToReais(fin.Valor);
                textDocumento.Text = fin.Documento;
                combOcorrencia.SelectedValue = Convert.ToInt32(fin.Ocorrencia);
                textQtdParcelas.Text = Convert.ToString(fin.QtdParcelas);

                PreencherGrids(Convert.ToString(fin.Parcelas));

                if (!string.IsNullOrEmpty(Convert.ToString(fin.Referencia)) && fin.Referencia > 0) {
                    combTipo.Enabled = false;
                    combCentroCusto.Enabled = false;
                    Referencia = fin.Id;
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
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
                Validate.AddRule(textValor, "Valor", "required|reais|max:11");
                Validate.AddRule(textDocumento, "Nº Document", "max:30");
                Validate.AddRule(combOcorrencia, "Ocorrencia", "required|numeric|exact:1");
                Validate.AddRule(textQtdParcelas, "Qtd. Parcelas", "required_if:combOcorrencia,2|max:3");
                Validate.Validation();

                if (Validate.IsValid()) {
                    PreencherJson();

                    Connection.Financeiro financeiro = new Connection.Financeiro();

                    financeiro.Nome = textNome.Text;
                    financeiro.Tipo = combTipo.SelectedValue.ToString();
                    financeiro.Referencia = Referencia;
                    financeiro.CentroCusto = combCentroCusto.SelectedValue.ToString();
                    financeiro.FormaPagamento = combFormaPagamento.SelectedValue.ToString();
                    financeiro.Status = combStatus.SelectedValue.ToString();
                    financeiro.DataEmissao = timeDataEmissao.Text;
                    financeiro.DataVencimento = timeDataVencimento.Text;
                    financeiro.Valor = Converter.ToDecimal(textValor.Text, true);
                    financeiro.Documento = textDocumento.Text;
                    financeiro.Ocorrencia = combOcorrencia.SelectedValue.ToString();
                    financeiro.QtdParcelas = textQtdParcelas.Text;
                    financeiro.Parcelas = jsonParcelas;

                    if (Id > 0) {
                        financeiro.Id = Convert.ToInt32(Id);
                        financeiro.Update();
                    }
                    else {
                        financeiro.Create();
                    }

                    if (financeiro.Success) {
                        DialogResult SuccessBox = MessageBox.Show(financeiro.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormFinanceiro(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar o financeiro (" + financeiro.Message + ")");
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

        private void PreencherJson() {
            List<object> Parcelas = new List<object>();

            foreach (DataGridViewRow parcela in gridParcelas.Rows) {
                Parcelas.Add(new {
                    Parcela = parcela.Cells[0].Value,
                    Data = parcela.Cells[1].Value,
                    Valor = Convert.ToDecimal(parcela.Cells[2].Value),
                    FormaPagamento = parcela.Cells[3].Value,
                    Observacoes = parcela.Cells[4].Value,
                    Pago = parcela.Cells[5].Value
                });
            }
            jsonParcelas = JsonConvert.SerializeObject(Parcelas);
        }

        private void OnClickGerarParcela(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(timeDataEmissao, "Data Emissão", "required|data:dd/MM/yyyy");
                Validate.AddRule(textValor, "Valor", "required|reais");
                Validate.AddRule(textQtdParcelas, "Qtd. Parcelas", "required|numeric");
                Validate.Validation();

                if (Validate.IsValid()) {
                    int qtdParcelas = Convert.ToInt32(textQtdParcelas.Text);

                    if (qtdParcelas > 0) {
                        var data = Convert.ToDateTime(timeDataEmissao.Text);

                        decimal valorParcelas = Convert.ToDecimal(textValor.Text) / Convert.ToInt32(qtdParcelas);

                        gridParcelas.Rows.Clear();

                        for (var i = 0; i < qtdParcelas; i++) {
                            gridParcelas.Rows.Add(
                                i + 1,
                                data.AddMonths(i).ToString("dd/MM/yyyy"),
                                valorParcelas.ToString("F"),
                                combFormaPagamento.SelectedValue,
                                "",
                                (Convert.ToInt32(combStatus.SelectedValue) == 1 ? true : false)
                            );
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
            catch (Exception ex) {
                MessageBox.Show("Houve um erro ao gerar as parcelas. (" + ex.Message + ")");
            }
        }

        private void OnChangedTextValor(object sender, EventArgs e) {
            Guna2TextBox Text = (Guna2TextBox)sender;
            Converter.OnPressMoeda(ref Text);
        }
    }
}
