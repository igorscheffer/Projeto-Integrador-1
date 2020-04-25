using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms
{
    public partial class FormHome : Form
    {

        FormPrincipal fmPrincipal;

        public FormHome(FormPrincipal Principal)
        {
            InitializeComponent();
            fmPrincipal = Principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMotoristas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormClientes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormAbastecimentos());
        }

        private void button7_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMultas());
        }
    }
}
