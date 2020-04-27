using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormVeiculos : Form {

        FormPrincipal fmPrincipal;

        public FormVeiculos(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaCores = ValuesComb.getCores();
            List<dynamic> ListaStatus = ValuesComb.getVeiculosStatus();

            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            foreach (dynamic veiculo in veiculos.Results) {
                string cor = ListaCores.Find(find => Convert.ToString(find.Value) == Convert.ToString(veiculo.Cor)).Text;
                string status = ListaStatus.Find(find => Convert.ToString(find.Value) == Convert.ToString(veiculo.Status)).Text;
                gridVeiculos.Rows.Add(
                    veiculo.Id,
                    veiculo.Frota,
                    veiculo.Placa,
                    veiculo.Veiculo,
                    cor,
                    status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos(fmPrincipal));
        }

        private void OnSelectItem(object sender, DataGridViewCellEventArgs e) {
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridVeiculos.Rows[e.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
    }
}
