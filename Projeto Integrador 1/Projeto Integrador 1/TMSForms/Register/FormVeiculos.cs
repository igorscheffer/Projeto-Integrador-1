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

            Validate.addRule("int", "Frota", textFrota.Text, "required|min:20|max:100");
            Validate.addRule("int", "Placa", textPlaca.Text, @"required|max:100|regExp:^([A-Z]{3})(\-\d\w\d{2})$");

            Validate.Validation();

            Validate.ShowErrors();
        }
    }
}
