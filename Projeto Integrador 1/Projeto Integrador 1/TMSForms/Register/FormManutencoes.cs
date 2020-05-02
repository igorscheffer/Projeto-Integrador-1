using Projeto_Integrador_1.Connection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Integrador_1.Util;
using Newtonsoft.Json;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormManutencoes : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        private string jsonItens;
        public FormManutencoes(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            LoadVeiculos();
            LoadMotoristas();
            LoadClientes();

            combTipoManutencao.DisplayMember = "Text";
            combTipoManutencao.ValueMember = "Value";
            combTipoManutencao.DataSource = Listas.ManutencoesTipos;

            combTipoPreventiva.DisplayMember = "Text";
            combTipoPreventiva.ValueMember = "Value";
            combTipoPreventiva.DataSource = Listas.ManutencoesPreventivas;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = Listas.ManutencoesStatus;

            if (Id > 0) {
                Text = "Editar Manutenção";
                this.Id = Id;
                PreencherDados();
            }
        }

        private void PreencherGrids(string json) {
            if (!string.IsNullOrWhiteSpace(json)) {
                List<dynamic> Itens = JsonConvert.DeserializeObject<List<dynamic>>(json);
                foreach (var item in Itens) {
                    gridItens.Rows.Add(
                        item.Codigo,
                        item.Descricao,
                        Converter.ToQuantidade(item.Qtd),
                        Converter.ToReais(item.Valor),
                        Converter.ToReais(item.Total)
                    );
                }
            }
        }

        private void PreencherDados() {
            try {
                Manutencoes manutencoes = new Manutencoes();
                manutencoes.Id = Id;
                manutencoes.Get();

                dynamic manutencao = manutencoes.Results[0];

                combTipoManutencao.SelectedValue = manutencao.Tipo;
                combTipoPreventiva.SelectedValue = manutencao.Preventiva;
                combVeiculo.SelectedValue = manutencao.Veiculo;
                combStatus.SelectedValue = manutencao.Status;
                combMotorista.SelectedValue = manutencao.Motorista;
                timeDataAgendada.Text = manutencao.DataAgendada;
                timeDataRealizada.Text = manutencao.DataRealizada;
                textHodometroAgendado.Text = Convert.ToString(manutencao.HodometroAgendado);
                textHodometroRealizado.Text = Convert.ToString(manutencao.HodometroRealizado);
                textObservacoes.Text = manutencao.Observacoes;
                textOrdemServico.Text = manutencao.OrdemServico;
                combFornecedor.SelectedValue = manutencao.Fornecedor;
                textMaoObra.Text = Converter.ToReais(manutencao.MaoObra);
                textDesconto.Text = Converter.ToReais(manutencao.Desconto);
                textAcrecimo.Text = Converter.ToReais(manutencao.Acrecimo);
                textValor.Text = Converter.ToReais(manutencao.Valor);

                PreencherGrids(Convert.ToString(manutencao.Itens));
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
            }
        }

        private void LoadClientes() {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            if (clientes.Results.Count > 0) {
                combFornecedor.DisplayMember = "RazaoSocial";
                combFornecedor.ValueMember = "Id";
                combFornecedor.DataSource = new List<dynamic>(clientes.Results);
                combFornecedor.SelectedValue = -1;
            }
        }
        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            if (veiculos.Results.Count > 0) {
                combVeiculo.DisplayMember = "Veiculo";
                combVeiculo.ValueMember = "Id";
                combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
                combVeiculo.SelectedValue = -1;
            }
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            if (motoristas.Results.Count > 0) {
                combMotorista.DisplayMember = "Nome";
                combMotorista.ValueMember = "Id";
                combMotorista.DataSource = new List<dynamic>(motoristas.Results);
                combMotorista.SelectedValue = -1;
            }
        }

        private void RefreshValorTotal() {
            try {
                decimal ValorTotalItens = 0;

                foreach (DataGridViewRow item in gridItens.Rows) {
                    ValorTotalItens += Convert.ToDecimal(item.Cells[4].Value);
                }

                ValorTotalItens += Converter.ToDecimal(textMaoObra.Text);
                ValorTotalItens += Converter.ToDecimal(textAcrecimo.Text);
                ValorTotalItens -= Converter.ToDecimal(textDesconto.Text);

                textValor.Text = Convert.ToString(ValorTotalItens);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                textValor.Text = Convert.ToString(0);
            }
        }

        private void onCadastrarCliente(object sender, EventArgs e) {
            Form formClientes = new TMSForms.Register.FormClientes();

            formClientes.StartPosition = FormStartPosition.CenterScreen;
            formClientes.FormBorderStyle = FormBorderStyle.FixedSingle;
            formClientes.ControlBox = true;
            formClientes.MaximizeBox = false;
            formClientes.MinimizeBox = false;

            formClientes.Closed += (s, ea) => LoadClientes();

            formClientes.ShowDialog();
        }

        private void onCadastrarVeiculo(object sender, EventArgs e) {
            Form formVeiculo = new TMSForms.Register.FormVeiculos();

            formVeiculo.StartPosition = FormStartPosition.CenterScreen;
            formVeiculo.FormBorderStyle = FormBorderStyle.FixedSingle;
            formVeiculo.ControlBox = true;
            formVeiculo.MaximizeBox = false;
            formVeiculo.MinimizeBox = false;

            formVeiculo.Closed += (s, ea) => LoadVeiculos();

            formVeiculo.ShowDialog();
        }

        private void onCadastrarMotorista(object sender, EventArgs e) {
            Form formMotoristas = new TMSForms.Register.FormMotoristas();

            formMotoristas.StartPosition = FormStartPosition.CenterScreen;
            formMotoristas.FormBorderStyle = FormBorderStyle.FixedSingle;
            formMotoristas.ControlBox = true;
            formMotoristas.MaximizeBox = false;
            formMotoristas.MinimizeBox = false;

            formMotoristas.Closed += (s, ea) => LoadMotoristas();

            formMotoristas.ShowDialog();
        }

        private void onEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(combTipoManutencao, "Tipo Manuteção", "required|numeric|exact:1");
                Validate.AddRule(combTipoPreventiva, "Tipo Preventiva", "numeric|exact:1");
                Validate.AddRule(combVeiculo, "Veiculo", "required|numeric|max:11");
                Validate.AddRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.AddRule(combMotorista, "Motorista", "required|numeric|max:11");
                Validate.AddRule(timeDataAgendada, "Data Agendada", "required|date:dd/MM/yyyy HH:mm");
                Validate.AddRule(timeDataRealizada, "Data Realizada", "date:dd/MM/yyyy HH:mm");
                Validate.AddRule(textHodometroAgendado, "Hodômetro Agendado", "required|numeric|max:20");
                Validate.AddRule(textHodometroRealizado, "Hodômetro Realizado", "numeric|max:20");
                Validate.AddRule(textObservacoes, "Motivo/Observações", "max:1000");
                Validate.AddRule(textOrdemServico, "Ordem Servico", "max:20");
                Validate.AddRule(combFornecedor, "Concessionaria/Fornecedor", "numeric|max:11");
                Validate.AddRule(textMaoObra, "Mão de Obra", "reais|max:20");
                Validate.AddRule(textDesconto, "Desconto", "reais|max:20");
                Validate.AddRule(textAcrecimo, "Acrécimo", "reais|max:20");
                Validate.AddRule(textValor, "Valor Total", "reais|max:20");

                Validate.Validation();

                if (Validate.IsValid()) {
                    PreencherJson();

                    Manutencoes manutencoes = new Manutencoes();

                    manutencoes.Tipo = combTipoManutencao.SelectedValue;
                    manutencoes.Preventiva = combTipoPreventiva.SelectedValue;
                    manutencoes.Veiculo = combVeiculo.SelectedValue;
                    manutencoes.Status = combStatus.SelectedValue;
                    manutencoes.Motorista = combMotorista.SelectedValue;
                    manutencoes.DataAgendada = timeDataAgendada.Text;
                    manutencoes.DataRealizada = timeDataRealizada.Text;
                    manutencoes.HodometroAgendado = textHodometroAgendado.Text;
                    manutencoes.HodometroRealizado = textHodometroRealizado.Text;
                    manutencoes.Observacoes = textObservacoes.Text;
                    manutencoes.OrdemServico = textOrdemServico.Text;
                    manutencoes.Fornecedor = combFornecedor.SelectedValue;
                    manutencoes.MaoObra = Converter.ToDecimal(textMaoObra.Text, true);
                    manutencoes.Desconto = Converter.ToDecimal(textDesconto.Text, true);
                    manutencoes.Acrecimo = Converter.ToDecimal(textAcrecimo.Text, true);
                    manutencoes.Valor = Converter.ToDecimal(textValor.Text, true);
                    manutencoes.Itens = jsonItens;

                    if (Id > 0) {
                        manutencoes.Id = Convert.ToInt32(Id);
                        manutencoes.Update();
                    }
                    else {
                        manutencoes.Create();
                    }

                    if (manutencoes.Success) {
                        DialogResult SuccessBox = MessageBox.Show(manutencoes.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormManutencoes(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar a manutenção (" + manutencoes.Message + ")");
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
            List<object> Itens = new List<object>();

            foreach (DataGridViewRow carga in gridItens.Rows) {
                Itens.Add(new {
                    Codigo = carga.Cells[0].Value,
                    Descricao = carga.Cells[1].Value,
                    Qtd = Convert.ToDecimal(carga.Cells[2].Value),
                    Valor = Convert.ToDecimal(carga.Cells[3].Value),
                    Total = Convert.ToDecimal(carga.Cells[4].Value)
                });
            }
            jsonItens = JsonConvert.SerializeObject(Itens);
        }

        private void onSelectTipoManutencao(object sender, EventArgs e) {
            var Selected = combTipoManutencao.SelectedValue;

            if (Convert.ToInt32(Selected) == 2) {
                combTipoPreventiva.Enabled = true;
            }
            else {
                combTipoPreventiva.SelectedValue = -1;
                combTipoPreventiva.Enabled = false;
            }
        }

        private void OnAddItem(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(textItemCodigo, "Codigo", "required|max:10");
                Validate.AddRule(textItemDescricao, "Descrição", "required|max:60");
                Validate.AddRule(textItemQtd, "Qtd", "required|quantidade|max:20");
                Validate.AddRule(textItemValor, "Valor", "required|reais|max:20");

                Validate.Validation();

                if (Validate.IsValid()) {
                    decimal valorTotal = Converter.ToDecimal(textItemValor.Text) * Convert.ToDecimal(textItemQtd.Text);

                    gridItens.Rows.Add(
                        textItemCodigo.Text,
                        textItemDescricao.Text,
                        textItemQtd.Text,
                        Converter.ToReais(textItemValor.Text),
                        Converter.ToReais(valorTotal)
                    );

                    textItemCodigo.ResetText();
                    textItemDescricao.ResetText();
                    textItemQtd.ResetText();
                    textItemValor.ResetText();

                    RefreshValorTotal();
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

        private void OnChangedTextQtd(object sender, EventArgs e) {
            MaskedTextBox Text = (MaskedTextBox)sender;
            Converter.OnPressQtd(ref Text);
        }

        private void OnAtualizarTotal(object sender, KeyEventArgs e) {
            RefreshValorTotal();
        }
    }
}
