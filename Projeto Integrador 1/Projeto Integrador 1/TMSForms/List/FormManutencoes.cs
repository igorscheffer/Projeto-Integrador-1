using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormManutencoes : Form {

        FormPrincipal fmPrincipal;

        List<dynamic> ListaDados;

        private DataGridViewCellEventArgs mouseLocation;

        public FormManutencoes(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaTipos = Listas.ManutencoesTipos;
                List<dynamic> ListaStatus = Listas.ManutencoesStatus;

                Manutencoes manutencoes = new Manutencoes();
                manutencoes.GetAll();

                ListaDados = manutencoes.Results;

                gridDados.Rows.Clear();

                foreach (dynamic manutencao in ListaDados) {
                    string tipo = ListaTipos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Tipo)).Text;
                    string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Status)).Text;
                    gridDados.Rows.Add(
                        manutencao.Id,
                        manutencao.DataAgendada,
                        manutencao.DataRealizada,
                        tipo,
                        manutencao.Placa,
                        manutencao.Fornecedor,
                        Converter.ToReais(manutencao.Valor),
                        status
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir esta Manutenção?", "Excluir Manutenção", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Manutencoes manutencoes = new Manutencoes();
                        manutencoes.Id = Id;
                        manutencoes.Delete();

                        if (manutencoes.Success) {
                            MessageBox.Show(manutencoes.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir a manutenção. (" + manutencoes.Message + ")");
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
                    if (Data.Valor > 0) {
                        ModalFinanceiro.ModalLancarConta(Id, 4, 2, Converter.ToDecimal(Data.Valor));
                    }
                    else {
                        throw new Exception("Manutenção deve ter um valor para ser lançada no financeiro.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
