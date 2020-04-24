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

namespace Projeto_Integrador_1.TMSForms.List
{
    public partial class FormVeiculos : Form
    {

        FormPrincipal fmPrincipal;

        public FormVeiculos(FormPrincipal Principal)
        {
            InitializeComponent();
            fmPrincipal = Principal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaCores = ValuesComb.getCores();
            List<dynamic> ListaStatus = ValuesComb.getVeiculosStatus();

            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            foreach (dynamic veiculo in veiculos.Results)
            {
                string cor = ListaCores.Find(find => Convert.ToString(find.Value) == Convert.ToString(veiculo.Cor)).Text;
                string status = ListaStatus.Find(find => Convert.ToString(find.Value) == Convert.ToString(veiculo.Status)).Text;
                gridVeiculos.Rows.Add(
                    veiculo.Frota,
                    veiculo.Placa,
                    veiculo.Veiculo,
                    cor,
                    status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos());
        }
    }
}
