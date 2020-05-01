using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormVeiculos : Form {

        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormVeiculos(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaCores = Listas.Cores;
                List<dynamic> ListaStatus = Listas.VeiculosStatus;

                Veiculos veiculos = new Veiculos();
                veiculos.GetAll();

                gridVeiculos.Rows.Clear();

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
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridVeiculos.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormVeiculos(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridVeiculos.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir este Veiculo?", "Excluir Veiculo", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Veiculos veiculos = new Veiculos();
                        veiculos.Id = Id;
                        veiculos.Delete();

                        if (veiculos.Success) {
                            MessageBox.Show(veiculos.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir o veiculo. (" + veiculos.Message + ")");
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
