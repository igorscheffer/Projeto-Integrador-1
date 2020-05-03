using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormFinanceiro : Form {

        FormPrincipal fmPrincipal;

        List<dynamic> ListaDados;

        private DataGridViewCellEventArgs mouseLocation;

        public FormFinanceiro(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaTipos = Listas.FinanceiroTipos;
                List<dynamic> ListaFormaPagamentos = Listas.FinanceiroFormasPagamentos;
                List<dynamic> ListaStatus = Listas.FinanceiroStatus;

                Financeiro financeiro = new Financeiro();
                financeiro.GetAll();

                ListaDados = financeiro.Results;

                gridDados.Rows.Clear();

                foreach (dynamic fin in ListaDados) {
                    string Tipo = ListaTipos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.Tipo)).Text;
                    string FormaPagamento = ListaFormaPagamentos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.FormaPagamento)).Text;
                    string Status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.Status)).Text;
                    gridDados.Rows.Add(
                        fin.Id,
                        Tipo,
                        fin.DataEmissao,
                        fin.DataVencimento,
                        fin.Nome,
                        FormaPagamento,
                        "R$ " + Converter.ToReais(fin.Valor),
                        Status
                    );
                }
            }
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormFinanceiro(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormFinanceiro(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridDados.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir este Financeiro?", "Excluir Financeiro", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Connection.Financeiro financeiro = new Connection.Financeiro();
                        financeiro.Id = Id;
                        financeiro.Delete();

                        if (financeiro.Success) {
                            MessageBox.Show(financeiro.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir o financeiro. (" + financeiro.Message + ")");
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModalLancarConta(int Id, int CentroCusto, int Tipo, decimal Valor) {
            /*
                Centro de Custo
                    0 Outros
                    1 Motorista
                    2 Veiculo
                    3 Viagem
                    4 Manutenção
                    5 Abastecimento
                    6 Multa
                    7 Cliente

                Tipo
                    1 Conta a Receber
                    2 Conta a Pagar
            */
            try {
                Form formFinanceiro;

                object SendFinanceiro = new {
                    CentroCusto = CentroCusto,
                    Tipo = Tipo,
                    Valor = Valor,
                    Id = Id
                };

                formFinanceiro = new TMSForms.Register.FormFinanceiro(null, 0, SendFinanceiro);

                formFinanceiro.StartPosition = FormStartPosition.CenterScreen;
                formFinanceiro.FormBorderStyle = FormBorderStyle.FixedSingle;
                formFinanceiro.ControlBox = true;
                formFinanceiro.MaximizeBox = false;
                formFinanceiro.MinimizeBox = false;

                formFinanceiro.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
