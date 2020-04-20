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

            Validate.addRule("int", "Frota", "F", "required|min:20|max:100");
            Validate.addRule("int", "Placa", "GDV-1280", "required|max:100");

            Validate.Validation();

            Validate.ShowErrors();
        }
    }
}
