using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormAbastecimentos : Form {

        FormPrincipal fmPrincipal;

        List<dynamic> ListaDados;

        private DataGridViewCellEventArgs mouseLocation;

        public FormAbastecimentos(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaCombustiveis = Listas.Combustiveis;
                List<dynamic> ListaStatus = Listas.AbastecimentosStatus;

                Abastecimentos abastecimentos = new Abastecimentos();
                abastecimentos.GetAll();

                ListaDados = abastecimentos.Results;

                gridDados.Rows.Clear();

                foreach (dynamic abastecimento in ListaDados) {
                    string combustivel = ListaCombustiveis.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(abastecimento.Combustivel)).Text;
                    string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(abastecimento.Status)).Text;
                    gridDados.Rows.Add(
                        abastecimento.Id,
                        abastecimento.Data,
                        abastecimento.Placa,
                        abastecimento.Posto,
                        combustivel,
                        abastecimento.Litros,
                        "R$ " + (abastecimento.Valor + " (R$ " + abastecimento.Total + ")"),
                        abastecimento.Hodometro,
                        status
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormAbastecimentos(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormAbastecimentos(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir esta Abastecimento?", "Excluir Abastecimento", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Abastecimentos abastecimentos = new Abastecimentos();
                        abastecimentos.Id = Id;
                        abastecimentos.Delete();

                        if (abastecimentos.Success) {
                            MessageBox.Show(abastecimentos.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir o abastecimento. (" + abastecimentos.Message + ")");
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

                if (Button.Tag == "conta_pagar") {
                    if (Data.valor > 0) {
                        ModalFinanceiro.ModalLancarConta(Id, 5, 2, Data.Valor);
                    }
                    else {
                        throw new Exception("Abastecimento deve ter um valor para ser lançada no financeiro.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
