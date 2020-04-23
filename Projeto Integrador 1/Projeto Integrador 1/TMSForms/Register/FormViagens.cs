using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormViagens : Form
    {

        List<dynamic> ListaCargas = new List<dynamic>();

        public FormViagens()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            this.LoadClientes();
            this.LoadVeiculos();
            this.LoadMotoristas();

            combTomador.DisplayMember = "Text";
            combTomador.ValueMember = "Value";
            combTomador.DataSource = ValuesComb.getViagemTomador();
            combTomador.SelectedValue = -1;

            combTipoViagem.DisplayMember = "Text";
            combTipoViagem.ValueMember = "Value";
            combTipoViagem.DataSource = ValuesComb.getViagemTipo();
            combTipoViagem.SelectedValue = -1;

            combSaidaUF.DisplayMember = "Text";
            combSaidaUF.ValueMember = "Value";
            combSaidaUF.DataSource = ValuesComb.getEstados();
            combSaidaUF.SelectedValue = -1;

            combDestinoUF.DisplayMember = "Text";
            combDestinoUF.ValueMember = "Value";
            combDestinoUF.DataSource = ValuesComb.getEstados();
            combDestinoUF.SelectedValue = -1;

            combAbastecimentoCombustivel.DisplayMember = "Text";
            combAbastecimentoCombustivel.ValueMember = "Value";
            combAbastecimentoCombustivel.DataSource = ValuesComb.getCombustiveis();
            combAbastecimentoCombustivel.SelectedValue = -1;

            combGridAbastecimentoCombustivel.DisplayMember = "Text";
            combGridAbastecimentoCombustivel.ValueMember = "Value";
            combGridAbastecimentoCombustivel.DataSource = ValuesComb.getCombustiveis();
            //combGridAbastecimentoCombustivel.SelectedValue = -1;
        }

        private void LoadClientes() {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            combRemetente.DisplayMember = "RazaoSocial";
            combRemetente.ValueMember = "Id";
            combRemetente.DataSource = clientes.Results;
            combRemetente.SelectedValue = -1;

            combDestinatario.DisplayMember = "RazaoSocial";
            combDestinatario.ValueMember = "Id";
            combDestinatario.DataSource = clientes.Results;
            combDestinatario.SelectedValue = -1;

            combAbastecimentoPosto.DisplayMember = "RazaoSocial";
            combAbastecimentoPosto.ValueMember = "Id";
            combAbastecimentoPosto.DataSource = clientes.Results;
            combAbastecimentoPosto.SelectedValue = -1;

            combGridAbastecimentoPosto.DisplayMember = "RazaoSocial";
            combGridAbastecimentoPosto.ValueMember = "Id";
            combGridAbastecimentoPosto.DataSource = clientes.Results;
            //combGridAbastecimentoPosto.SelectedValue = -1;
        }
        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = veiculos.Results;
            combVeiculo.SelectedValue = -1;

            combReboque.DisplayMember = "Veiculo";
            combReboque.ValueMember = "Id";
            combReboque.DataSource = veiculos.Results;
            combReboque.SelectedValue = -1;
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotorista.DisplayMember = "Nome";
            combMotorista.ValueMember = "Id";
            combMotorista.DataSource = motoristas.Results;
            combMotorista.SelectedValue = -1;
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

        private void PreencherGridCargas() {
            foreach (dynamic item in this.ListaCargas) {
                gridCargas.Rows.Add(item.NFE, item.Descricao, item.Peso, item.Valor);
            }
        }

        private void onAddCarga(object sender, EventArgs e)
        {
            try {
                Validate Validate = new Util.Validate();

                Validate.addRule(textCargaNFE, "NF-E", "required|nfe");
                Validate.addRule(textCargaDescricao, "Descrição", "required|max:100");
                Validate.addRule(textCargaPeso, "Peso", "required|numeric|max:20");
                Validate.addRule(textCargaValor, "Valor", "required|reais");

                Validate.Validation();

                if (Validate.IsValid()) {
                    gridCargas.Rows.Add(textCargaNFE.Text, textCargaDescricao.Text, textCargaPeso.Text, textCargaValor.Text);

                    textCargaNFE.ResetText();
                    textCargaDescricao.ResetText();
                    textCargaPeso.ResetText();
                    textCargaValor.ResetText();
                }
                else {
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

        private void onAddCusto(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(timeCustoData, "Data", "required|date:dd/MM/yyyy");
                Validate.addRule(textCustoDescricao, "Descrição", "required|max:100");
                Validate.addRule(textCustoQTD, "Qtd", "required|numeric|max:20");
                Validate.addRule(textCustoValor, "Valor", "required|reais");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    int valorTotal = Int32.Parse(textCustoValor.Text) * Int32.Parse(textCustoQTD.Text);

                    gridCustos.Rows.Add(timeCustoData.Text, textCustoDescricao.Text, textCustoQTD.Text, textCustoValor.Text, valorTotal);

                    timeCustoData.ResetText();
                    textCustoDescricao.ResetText();
                    textCustoQTD.ResetText();
                    textCustoValor.ResetText();
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

        private void onAddAbastecimento(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(timeAbastecimentoData, "Data", "required|date:dd/MM/yyyy H:mm");
                Validate.addRule(combAbastecimentoPosto, "Posto", "required|numeric");
                Validate.addRule(combAbastecimentoCombustivel, "Combustivel", "required|numeric");
                Validate.addRule(textAbastecimentoLitros, "Litros", "required|numeric|max:20");
                Validate.addRule(textAbastecimentoValor, "Valor", "required");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    int valorTotal = Int32.Parse(textAbastecimentoValor.Text) * Int32.Parse(textAbastecimentoLitros.Text);

                    gridAbastecimentos.Rows.Add(timeAbastecimentoData.Text, combAbastecimentoPosto.SelectedValue, combAbastecimentoCombustivel.SelectedValue, textAbastecimentoLitros.Text, textAbastecimentoValor.Text, valorTotal);

                    timeAbastecimentoData.ResetText();
                    combAbastecimentoPosto.SelectedValue = -1;
                    combAbastecimentoCombustivel.SelectedValue = -1;
                    textAbastecimentoLitros.ResetText();
                    textAbastecimentoValor.ResetText();
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

        private void OnSalvar(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(combRemetente,                     "Remetente",                    "required|numeric|max:11");
                Validate.addRule(combDestinatario,                  "Destinatario",                 "required|numeric|max:11");
                Validate.addRule(combTomador,                       "Tomador",                      "required|numeric|exact:1");
                Validate.addRule(textCodigoInterno,                 "Codigo Interno",               "max:10");
                Validate.addRule(combTipoViagem,                    "Tipo Viagem",                  "required|numeric|exact:1");
                Validate.addRule(combVeiculo,                       "Veiculo",                      "required|numeric|max:11");
                Validate.addRule(combReboque,                       "Reboque",                      "numeric|max:11");
                Validate.addRule(combMotorista,                     "Motorista",                    "required|numeric|max:11");
                Validate.addRule(textSaidaCidade,                   "Cidade Saida",                 "max:100");
                Validate.addRule(combSaidaUF,                       "UF Saida",                     "exact:2");
                Validate.addRule(textDestinoCidade,                 "Cidade Destino",               "max:100");
                Validate.addRule(combDestinoUF,                     "UF Destino",                   "exact:2");
                Validate.addRule(combStatus,                        "Status",                       "required|numeric|max:11");
                Validate.addRule(timeDataSaida,                     "Data Saida",                   "date:dd/MM/yyyy HH:mm");
                Validate.addRule(timeDataEntrega,                   "Data Entrega",                 "date:dd/MM/yyyy HH:mm");
                Validate.addRule(timeDataChegada,                   "Data Chegada",                 "date:dd/MM/yyyy HH:mm");
                Validate.addRule(textHodometroSaida,                "KM Saida",                     "numeric|max:20");
                Validate.addRule(textHodometroEntrega,              "KM Entrega",                   "numeric|max:20");
                Validate.addRule(textHodometroChegada,              "KM Chegada",                   "numeric|max:20");
                Validate.addRule(textHodometroPercorrido,           "KM Percorrido",                "numeric|max:11");
                Validate.addRule(textValor,                         "Valor do Frete",               "numeric|11");
                Validate.addRule(textInformacoesComplementares,     "Informações Complementares",   "max:1000");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    Viagens viagens = new Viagens();

                    viagens.Remetente = combRemetente.SelectedValue;
                    viagens.Destinatario = combDestinatario.SelectedValue;
                    viagens.Tomador = combTomador.SelectedValue;
                    viagens.CodigoInterno = textCodigoInterno.Text;
                    viagens.TipoViagem = combTipoViagem.SelectedValue;
                    viagens.Veiculo = combVeiculo.SelectedValue;
                    viagens.Reboque = combTipoViagem.SelectedValue;
                    viagens.Motorista = combMotorista.SelectedValue;
                    viagens.SaidaCidade = textSaidaCidade.Text;
                    viagens.SaidaUF = combSaidaUF.SelectedValue;
                    viagens.DestinoCidade = textDestinoCidade.Text;
                    viagens.DestinoUF = combDestinoUF.SelectedValue;
                    viagens.Status = combStatus.SelectedValue;
                    viagens.DataSaida = timeDataSaida.Text;
                    viagens.DataEntrega = timeDataEntrega.Text;
                    viagens.DataChegada = timeDataChegada.Text;
                    viagens.HodometroSaida = textHodometroSaida.Text;
                    viagens.HodometroEntrega = textHodometroEntrega.Text;
                    viagens.HodometroChegada = textHodometroChegada.Text;
                    viagens.Valor = textValor.Text;
                    viagens.InformacoesComplementares = textInformacoesComplementares.Text;
                    viagens.Cargas = "";
                    viagens.Custos = "";
                    viagens.Abastecimentos = "";
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

        private void PreencherJsons() {
            List<object> Cargas = new List<object>();
            List<object> Custos = new List<object>();
            List<object> Abastecimentos = new List<object>();

            Console.Write("\nCargas");
            foreach (DataGridViewRow carga in gridCargas.Rows)
            {
                Cargas.Add(new
                {
                    NFE = carga.Cells[0].Value,
                    Descricao = carga.Cells[1].Value,
                    Peso = carga.Cells[2].Value,
                    Valor = carga.Cells[3].Value
                });
            }

            Console.Write("\nCustos");
            foreach (DataGridViewRow custos in gridCustos.Rows)
            {
                Custos.Add(new
                {
                    Data = custos.Cells[0].Value,
                    Descricao = custos.Cells[1].Value,
                    QTD = custos.Cells[2].Value,
                    Valor = custos.Cells[3].Value
                });
            }

            Console.Write("\nAbastecimentos");
            foreach (DataGridViewRow abastecimentos in gridAbastecimentos.Rows)
            {
                Abastecimentos.Add(new
                {
                    Data = abastecimentos.Cells[0].Value,
                    Posto = abastecimentos.Cells[1].Value,
                    Combustivel = abastecimentos.Cells[2].Value,
                    Litros = abastecimentos.Cells[3].Value,
                    Valor = abastecimentos.Cells[4].Value
                });
            }

            string json = JsonConvert.SerializeObject(Abastecimentos, Formatting.Indented);

            Console.Write(json);
        }
    }
}
