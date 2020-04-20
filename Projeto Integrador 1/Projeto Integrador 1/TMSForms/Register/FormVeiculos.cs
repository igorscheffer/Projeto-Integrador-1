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
        }

        private void onEnviar(object sender, EventArgs e)
        {
            var Validate = new Util.Validate();

            Validate.addRule(textFrota,             "Frota",                "min:20");
            Validate.addRule(textPlaca,             "Placa",                @"required|regExp:^([A-Z]{3})(\-\d\w\d{2})$");
            Validate.addRule(combCategoria,         "Categoria",            "required|max:50");
            Validate.addRule(combMarca,             "Marca",                "required|max:50");
            Validate.addRule(combCarroceria,        "Carroceria",           "required|max:50");
            Validate.addRule(textModelo,            "Modelo",               "required|max:50");
            Validate.addRule(combCor,               "Cor",                  "required|max:20");
            Validate.addRule(combCombustivel,       "Combustivel",          "required|max:20");
            Validate.addRule(textMotorizacao,       "Motorizacao",          "max:30");
            Validate.addRule(textRenavam,           "Renavam",              "numeric|max:30");
            Validate.addRule(textChassi,            "Chassi",               "required|max:30");
            Validate.addRule(combAnoFabricacao,     "Ano Fabricação",       "required|date:yyyy");
            Validate.addRule(combAnoModelo,         "Ano Modelo",           "required|date:yyyy");
            Validate.addRule(combStatus,            "Status",               "required");
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
