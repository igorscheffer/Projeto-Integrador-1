using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormViagens : Form {

        FormPrincipal fmPrincipal;

        List<dynamic> ListaDados;

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

                ListaDados = viagens.Results;

                gridDados.Rows.Clear();

                foreach (dynamic viagem in ListaDados) {
                    string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(viagem.Status)).Text;
                    gridDados.Rows.Add(
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
        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal));
        }
        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }
        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);

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

        private void OnClickLancarConta(object sender, EventArgs e) {
            try {
                int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);
                dynamic Data = ListaDados.Find(find => Convert.ToInt32(find.Id) == Id);

                ToolStripMenuItem Button = (ToolStripMenuItem)sender;

                List.FormFinanceiro ModalFinanceiro = new FormFinanceiro(null);

                if (Button.Tag == "conta_receber") {
                    if (Data.Valor > 0) {
                        ModalFinanceiro.ModalLancarConta(Id, 3, 1, Data.Valor);
                    }
                    else {
                        throw new Exception("Viagem deve ter um valor para ser lançada no financeiro.");
                    }
                }
                else if (Button.Tag == "conta_pagar") {
                    if (Data.TotalCustos > 0) {
                        ModalFinanceiro.ModalLancarConta(Id, 3, 2, Data.TotalCustos);
                    }
                    else {
                        throw new Exception("Custos da Viagem deve ter um valor para ser lançada no financeiro.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
