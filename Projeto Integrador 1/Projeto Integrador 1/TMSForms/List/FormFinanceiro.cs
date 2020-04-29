using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormFinanceiro : Form {

        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormFinanceiro(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;


            List<dynamic> ListaTipos = Listas.FinanceiroTipos;
            List<dynamic> ListaFormaPagamentos = Listas.FinanceiroFormasPagamentos;
            List<dynamic> ListaStatus = Listas.FinanceiroStatus;

            Financeiro financeiro = new Financeiro();
            financeiro.GetAll();

            foreach (dynamic fin in financeiro.Results) {
                string Tipo = ListaTipos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.Tipo)).Text;
                string FormaPagamento = ListaFormaPagamentos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.FormaPagamento)).Text;
                string Status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(fin.Status)).Text;
                gridFinanceiro.Rows.Add(
                    fin.Id,
                    Tipo,
                    fin.DataEmissao,
                    fin.DataVencimento,
                    fin.Nome,
                    FormaPagamento,
                    fin.Valor,
                    Status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormFinanceiro(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridFinanceiro.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormFinanceiro(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }
    }
}
