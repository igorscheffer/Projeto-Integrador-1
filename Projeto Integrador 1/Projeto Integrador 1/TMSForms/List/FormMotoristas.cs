using Projeto_Integrador_1.Connection;
using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormMotoristas : Form {
        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormMotoristas(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;
            LoadList();
        }

        private void LoadList() {
            try {
                Motoristas motoristas = new Motoristas();
                motoristas.GetAll();

                gridMotoristas.Rows.Clear();

                foreach (dynamic motorista in motoristas.Results) {
                    gridMotoristas.Rows.Add(
                        motorista.Id,
                        motorista.Nome,
                        motorista.RG,
                        motorista.CPF,
                        motorista.CNH,
                        motorista.Categoria,
                        motorista.Vencimento
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMotoristas(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridMotoristas.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormMotoristas(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridMotoristas.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir este Motorista?", "Excluir Motorista", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Motoristas motoristas = new Motoristas();
                        motoristas.Id = Id;
                        motoristas.Delete();

                        if (motoristas.Success) {
                            MessageBox.Show(motoristas.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir o motorista. (" + motoristas.Message + ")");
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
