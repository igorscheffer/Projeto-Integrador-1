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
    public partial class FormVeiculos : Form
    {
        public FormVeiculos()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combCategoria.DisplayMember = "Text";
            combCategoria.ValueMember = "Value";
            combCategoria.DataSource = ValuesComb.getVeiculosCategorias();
            combCategoria.SelectedValue = -1;

            combMarca.DisplayMember = "Text";
            combMarca.ValueMember = "Value";
            combMarca.DataSource = ValuesComb.getVeiculosMarcas();
            combMarca.SelectedValue = -1;

            combCarroceria.DisplayMember = "Text";
            combCarroceria.ValueMember = "Value";
            combCarroceria.DataSource = ValuesComb.getVeiculosCarrocerias();
            combCarroceria.SelectedValue = -1;

            combCor.DisplayMember = "Text";
            combCor.ValueMember = "Value";
            combCor.DataSource = ValuesComb.getCores();
            combCor.SelectedValue = -1;

            combCombustivel.DisplayMember = "Text";
            combCombustivel.ValueMember = "Value";
            combCombustivel.DataSource = ValuesComb.getCombustiveis();
            combCombustivel.SelectedValue = -1;

            combAnoFabricacao.DisplayMember = "Text";
            combAnoFabricacao.ValueMember = "Value";
            combAnoFabricacao.DataSource = ValuesComb.getAnos();
            combAnoFabricacao.SelectedValue = -1;

            combAnoModelo.DisplayMember = "Text";
            combAnoModelo.ValueMember = "Value";
            combAnoModelo.DataSource = ValuesComb.getAnos();
            combAnoModelo.SelectedValue = -1;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getVeiculosStatus();
            combStatus.SelectedValue = -1;
        }

        private void onEnviar(object sender, EventArgs e)
        {
            var Validate = new Util.Validate();

            Validate.addRule(textFrota,             "Frota",                "min:20");
            Validate.addRule(textPlaca,             "Placa",                @"required|regExp:^([A-Z]{3})(\-\d\w\d{2})$");
            Validate.addRule(combCategoria,         "Categoria",            "required|numeric|max:2");
            Validate.addRule(combMarca,             "Marca",                "required|numeric|max:2");
            Validate.addRule(combCarroceria,        "Carroceria",           "required|numeric|max:2");
            Validate.addRule(textModelo,            "Modelo",               "required|max:50");
            Validate.addRule(combCor,               "Cor",                  "required|numeric|max:2");
            Validate.addRule(combCombustivel,       "Combustivel",          "required|numeric|max:2");
            Validate.addRule(textMotorizacao,       "Motorizacao",          "max:30");
            Validate.addRule(textRenavam,           "Renavam",              "numeric|max:30");
            Validate.addRule(textChassi,            "Chassi",               "required|max:30");
            Validate.addRule(combAnoFabricacao,     "Ano Fabricação",       "required|numeric|date:yyyy");
            Validate.addRule(combAnoModelo,         "Ano Modelo",           "required|numeric|date:yyyy");
            Validate.addRule(combStatus,            "Status",               "required|numeric|max:2");
            Validate.addRule(textTara,              "Tara",                 "max:20");
            Validate.addRule(textLotacao,           "Lotação",              "max:20");
            Validate.addRule(textPesoBrutoTotal,    "Peso Bruto Total",     "max:20");
            Validate.addRule(textCapacidade,        "Capacidade M³",        "max:20");


            Validate.Validation();

            if (Validate.IsValid())
            {
                Veiculos veiculos = new Connection.Veiculos();

                veiculos.Frota = textFrota.Text;
                veiculos.Placa = textPlaca.Text;
                veiculos.Categoria = combCategoria.SelectedValue.ToString();
                veiculos.Marca = combMarca.SelectedValue.ToString();
                veiculos.Carroceria = combCarroceria.SelectedValue.ToString();
                veiculos.Modelo = textModelo.Text;
                veiculos.Cor = combCor.SelectedValue.ToString();
                veiculos.Combustivel = combCombustivel.SelectedValue.ToString();
                veiculos.Motorizacao = textMotorizacao.Text;
                veiculos.Renavam = textRenavam.Text;
                veiculos.Chassi = textChassi.Text;
                veiculos.AnoFabricacao = combAnoFabricacao.SelectedValue.ToString();
                veiculos.AnoModelo = combAnoModelo.SelectedValue.ToString();
                veiculos.Status = combStatus.SelectedValue.ToString();
                veiculos.Tara = textTara.Text;
                veiculos.Lotacao = textLotacao.Text;
                veiculos.PesoBrutoTotal = textPesoBrutoTotal.Text;
                veiculos.Capacidade = textCapacidade.Text;

                dynamic create = veiculos.create();

                if (create[0]) {
                    MessageBox.Show(create[1]);
                }
                else {
                    MessageBox.Show("Houve um erro ao salvar o veiculo. (" + create[1] + ")");
                }
            }
            else {
                string ShowMessage = "";

                foreach (dynamic Erro in Validate.getErrors()) {
                    ShowMessage += Erro.Message + "\n";
                }

                MessageBox.Show(ShowMessage);
            }
        }
    }
}
