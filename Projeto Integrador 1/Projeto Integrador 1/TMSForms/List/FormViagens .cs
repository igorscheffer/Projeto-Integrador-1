using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormViagens : Form {

        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormViagens(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaStatus = Listas.ViagemStatus;

                Viagens viagens = new Viagens();
                viagens.GetAll();

                gridViagens.Rows.Clear();

                foreach (dynamic viagem in viagens.Results) {
                    string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(viagem.Status)).Text;
                    gridViagens.Rows.Add(
                        viagem.Id,
                        viagem.CodigoInterno,
                        viagem.DataSaida,
                        viagem.DataChegada,
                        viagem.SaidaCidade + "/" + viagem.SaidaUF,
                        viagem.DestinoCidade + "/" + viagem.DestinoUF,
                        viagem.Placa,
                        viagem.Motorista,
                        status
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridViagens.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridViagens.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir esta Viagem?", "Excluir Viagem", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Viagens viagens = new Viagens();
                        viagens.Id = Id;
                        viagens.Delete();

                        if (viagens.Success) {
                            MessageBox.Show(viagens.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir a viagem. (" + viagens.Message + ")");
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
