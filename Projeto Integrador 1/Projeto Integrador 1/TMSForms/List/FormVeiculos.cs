using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List
{
    public partial class FormVeiculos : Form
    {

        FormPrincipal fmPrincipal;

        public FormVeiculos(FormPrincipal Principal)
        {
            InitializeComponent();
            fmPrincipal = Principal;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos());
        }
    }
}
