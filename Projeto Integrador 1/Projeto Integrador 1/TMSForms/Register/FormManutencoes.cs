using Projeto_Integrador_1.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Integrador_1.Util;
using Newtonsoft.Json;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormManutencoes : Form
    {
        private string jsonItens;
        public FormManutencoes()
        {
            InitializeComponent();

            this.LoadVeiculos();
            this.LoadMotoristas();
            this.LoadClientes();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combTipoManutencao.DisplayMember = "Text";
            combTipoManutencao.ValueMember = "Value";
            combTipoManutencao.DataSource = ValuesComb.getManutencaoTipo();

            combTipoPreventiva.DisplayMember = "Text";
            combTipoPreventiva.ValueMember = "Value";
            combTipoPreventiva.DataSource = ValuesComb.getManutencaoPreventiva();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getManutencaoStatus();
        }

        private void LoadClientes()
        {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            combFornecedor.DisplayMember = "RazaoSocial";
            combFornecedor.ValueMember = "Id";
            combFornecedor.DataSource = new List<dynamic>(clientes.Results);
            combFornecedor.SelectedValue = -1;
        }
        private void LoadVeiculos()
        {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
            combVeiculo.SelectedValue = -1;
        }
        private void LoadMotoristas()
        {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotorista.DisplayMember = "Nome";
            combMotorista.ValueMember = "Id";
            combMotorista.DataSource = new List<dynamic>(motoristas.Results);
            combMotorista.SelectedValue = -1;
        }

        private void RefreshValorTotal() {
            int ValorTotalItens = 0;
            foreach (DataGridViewRow item in gridItens.Rows)
            {
                ValorTotalItens += (Convert.ToInt32(item.Cells[3].Value) * Convert.ToInt32(item.Cells[2].Value));
            }

            textValor.Text = Convert.ToString(ValorTotalItens);
        }

        private void onCadastrarCliente(object sender, EventArgs e)
        {
            Form formClientes = new TMSForms.Register.FormClientes();

            formClientes.StartPosition = FormStartPosition.CenterScreen;
            formClientes.FormBorderStyle = FormBorderStyle.FixedSingle;
            formClientes.ControlBox = true;
            formClientes.MaximizeBox = false;
            formClientes.MinimizeBox = false;

            formClientes.Closed += (s, ea) => this.LoadClientes();

            formClientes.ShowDialog();
        }

        private void onCadastrarVeiculo(object sender, EventArgs e)
        {
            Form formVeiculo = new TMSForms.Register.FormVeiculos();

            formVeiculo.StartPosition = FormStartPosition.CenterScreen;
            formVeiculo.FormBorderStyle = FormBorderStyle.FixedSingle;
            formVeiculo.ControlBox = true;
            formVeiculo.MaximizeBox = false;
            formVeiculo.MinimizeBox = false;

            formVeiculo.Closed += (s, ea) => this.LoadVeiculos();

            formVeiculo.ShowDialog();
        }

        private void onCadastrarMotorista(object sender, EventArgs e)
        {
            Form formMotoristas = new TMSForms.Register.FormMotoristas();

            formMotoristas.StartPosition = FormStartPosition.CenterScreen;
            formMotoristas.FormBorderStyle = FormBorderStyle.FixedSingle;
            formMotoristas.ControlBox = true;
            formMotoristas.MaximizeBox = false;
            formMotoristas.MinimizeBox = false;

            formMotoristas.Closed += (s, ea) => this.LoadMotoristas();

            formMotoristas.ShowDialog();
        }

        private void onEnviar(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(combTipoManutencao,        "Tipo Manuteção",               "required|numeric|exact:1");
                Validate.addRule(combTipoPreventiva,        "Tipo Preventiva",              "numeric|exact:1");
                Validate.addRule(combVeiculo,               "Veiculo",                      "required|numeric|max:11");
                Validate.addRule(combStatus,                "Status",                       "required|numeric|exact:1");
                Validate.addRule(combMotorista,             "Motorista",                    "required|numeric|max:11");
                Validate.addRule(timeDataAgendada,          "Data Agendada",                "required|date:dd/MM/yyyy HH:mm");
                Validate.addRule(timeDataRealizada,         "Data Realizada",               "date:dd/MM/yyyy HH:mm");
                Validate.addRule(textHodometroAgendado,     "Hodômetro Agendado",           "required|numeric|max:20");
                Validate.addRule(textHodometroRealizado,    "Hodômetro Realizado",          "numeric|max:20");
                Validate.addRule(textObservacoes,           "Motivo/Observações",           "max:1000");
                Validate.addRule(textOrdemServico,          "Ordem Servico",                "max:20");
                Validate.addRule(combFornecedor,            "Concessionaria/Fornecedor",    "numeric|max:11");
                Validate.addRule(textMaoObra,               "Mão de Obra",                  "numeric|max:20");
                Validate.addRule(textDesconto,              "Desconto",                     "numeric|max:20");
                Validate.addRule(textAcrecimo,              "Acrécimo",                     "numeric|max:20");
                Validate.addRule(textValor,                 "Valor Total",                  "numeric|max:20");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    this.PreencherJson();

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
                    manutencoes.MaoObra = textMaoObra.Text;
                    manutencoes.Desconto = textDesconto.Text;
                    manutencoes.Acrecimo = textAcrecimo.Text;
                    manutencoes.Valor = textValor.Text;
                    manutencoes.Itens = this.jsonItens;

                    manutencoes.Create();

                    if (manutencoes.Success)
                    {
                        MessageBox.Show(manutencoes.Message);
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar a manutenção (" + manutencoes.Message + ")");
                    }
                }
                else
                {
                    Validate.ErrorMessageBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PreencherJson()
        {
            List<object> Itens = new List<object>();

            foreach (DataGridViewRow carga in gridItens.Rows)
            {
                Itens.Add(new
                {
                    NFE = carga.Cells[0].Value,
                    Descricao = carga.Cells[1].Value,
                    Peso = carga.Cells[2].Value,
                    Valor = carga.Cells[3].Value
                });
            }
            this.jsonItens = JsonConvert.SerializeObject(Itens);
        }

        private void onSelectTipoManutencao(object sender, EventArgs e)
        {
            var Selected = combTipoManutencao.SelectedValue;

            if (Convert.ToInt32(Selected) == 2)
            {
                combTipoPreventiva.Enabled = true;
            }
            else {
                combTipoPreventiva.SelectedValue = -1;
                combTipoPreventiva.Enabled = false;
            }
        }

        private void OnAddItem(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(textItemCodigo, "Codigo", "required|max:10");
                Validate.addRule(textItemDescricao, "Descrição", "required|max:60");
                Validate.addRule(textItemQtd, "Qtd", "required|numeric|max:20");
                Validate.addRule(textItemValor, "Valor", "required|numeric|max:20");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    int valorTotal = Int32.Parse(textItemValor.Text) * Int32.Parse(textItemQtd.Text);

                    gridItens.Rows.Add(textItemCodigo.Text, textItemDescricao.Text, textItemQtd.Text, textItemValor.Text, valorTotal);

                    textItemCodigo.ResetText();
                    textItemDescricao.ResetText();
                    textItemQtd.ResetText();
                    textItemValor.ResetText();

                    this.RefreshValorTotal();
                }
                else
                {
                    Validate.ErrorMessageBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
