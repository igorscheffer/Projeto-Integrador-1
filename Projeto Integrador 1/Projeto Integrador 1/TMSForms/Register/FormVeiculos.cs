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

            combMarca.DisplayMember = "Text";
            combMarca.ValueMember = "Value";
            combMarca.DataSource = ValuesComb.getVeiculosMarcas();

            combCarroceria.DisplayMember = "Text";
            combCarroceria.ValueMember = "Value";
            combCarroceria.DataSource = ValuesComb.getVeiculosCarrocerias();

            combCor.DisplayMember = "Text";
            combCor.ValueMember = "Value";
            combCor.DataSource = ValuesComb.getCores();

            combCombustivel.DisplayMember = "Text";
            combCombustivel.ValueMember = "Value";
            combCombustivel.DataSource = ValuesComb.getCombustiveis();

            combAnoFabricacao.DisplayMember = "Text";
            combAnoFabricacao.ValueMember = "Value";
            combAnoFabricacao.DataSource = ValuesComb.getAnos();

            combAnoModelo.DisplayMember = "Text";
            combAnoModelo.ValueMember = "Value";
            combAnoModelo.DataSource = ValuesComb.getAnos();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getVeiculosStatus();
        }

        private void onEnviar(object sender, EventArgs e)
        {
            var Validate = new Util.Validate();

            Validate.addRule(textFrota,             "Frota",                "min:20");
            Validate.addRule(textPlaca,             "Placa",                @"required|exact:8|regExp:^([A-Z]{3})(\-\d\w\d{2})$");
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
                MessageBox.Show("Cadastro Efetuado com sucesso.");
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
