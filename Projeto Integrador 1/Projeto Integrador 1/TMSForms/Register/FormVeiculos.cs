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

            Validate.addRule("", "Frota", textFrota.Text, "min:20");
            Validate.addRule("", "Placa", textPlaca.Text, @"required|regExp:^([A-Z]{3})(\-\d\w\d{2})$");
            Validate.addRule("", "Categoria", combCategoria.Text, "required|max:50");
            Validate.addRule("", "Marca", combMarca.Text, "required|max:50");
            Validate.addRule("", "Carroceria", combCarroceria.Text, "required|max:50");
            Validate.addRule("", "Modelo", textModelo.Text, "required|max:50");
            Validate.addRule("", "Cor", combCor.Text, "required|max:20");
            Validate.addRule("", "Combustivel", combCombustivel.Text, "required|max:20");
            Validate.addRule("", "Motorizacao", textMotorizacao.Text, "max:30");
            Validate.addRule("", "Renavam", textRenavam.Text, "max:30");
            Validate.addRule("", "Chassi", textRenavam.Text, "required|max:30");
            Validate.addRule("", "Ano Fabricação", combAnoFabricacao.Text, "required|date:yyyy");
            Validate.addRule("", "Ano Modelo", combAnoModelo.Text, "required|date:yyyy");
            Validate.addRule("", "Status", combStatus.Text, "required");
            Validate.addRule("", "Tara", textTara.Text, "max:20");
            Validate.addRule("", "Lotação", textLotacao.Text, "max:20");
            Validate.addRule("", "Peso Bruto Total", textPesoBrutoTotal.Text, "max:20");
            Validate.addRule("", "Capacidade M³", textCapacidade.Text, "max:20");


            Validate.Validation();

            Validate.ShowErrors();
        }
    }
}
