using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormMultas : Form {

        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormMultas(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaGravidades = Listas.MultasGravidades;
                List<dynamic> ListaStatus = Listas.MultasStatus;

                Multas multas = new Multas();
                multas.GetAll();

                gridMultas.Rows.Clear();

                foreach (dynamic multa in multas.Results) {
                    string gravidade = ListaGravidades.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(multa.Gravidade)).Text;
                    string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(multa.Status)).Text;
                    gridMultas.Rows.Add(
                        multa.Id,
                        multa.DataOcorrencia,
                        multa.Placa.ToString().ToUpper(),
                        multa.Motorista,
                        multa.Descricao,
                        gravidade,
                        multa.Valor,
                        multa.DataVencimento,
                        status
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMultas(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridMultas.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormMultas(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridMultas.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir esta Multa?", "Excluir Multa", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Multas multas = new Multas();
                        multas.Id = Id;
                        multas.Delete();

                        if (multas.Success) {
                            MessageBox.Show(multas.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir a multa. (" + multas.Message + ")");
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
