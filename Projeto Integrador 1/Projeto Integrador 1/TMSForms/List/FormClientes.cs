using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormClientes : Form {

        FormPrincipal fmPrincipal;

        public FormClientes(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaTipoCadastro = ValuesComb.getClienteTipoCadastro();
            List<dynamic> ListaTipoPessoa = ValuesComb.getClienteTipoPessoa();

            Clientes clientes = new Clientes();
            clientes.GetAll();

            foreach (dynamic cliente in clientes.Results) {
                string tipoCadastro = ListaTipoCadastro.Find(find => Convert.ToString(find.Value) == Convert.ToString(cliente.TipoCadastro)).Text;
                string tipoPessoa = ListaTipoPessoa.Find(find => Convert.ToString(find.Value) == Convert.ToString(cliente.TipoPessoa)).Text;
                gridClientes.Rows.Add(
                    cliente.Id,
                    tipoCadastro,
                    tipoPessoa,
                    cliente.CNPJ,
                    cliente.RazaoSocial
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormClientes(fmPrincipal));
        }

        private void OnSelectItem(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridClientes.Rows[e.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormClientes(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
    }
}
