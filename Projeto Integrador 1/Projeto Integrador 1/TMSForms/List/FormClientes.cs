using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormClientes : Form {

        FormPrincipal fmPrincipal;

        private DataGridViewCellEventArgs mouseLocation;

        public FormClientes(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            LoadList();
        }

        private void LoadList() {
            try {
                List<dynamic> ListaTipoCadastro = Listas.ClientesTipoCadastros;
                List<dynamic> ListaTipoPessoa = Listas.ClientesTipoPessoas;

                Clientes clientes = new Clientes();
                clientes.GetAll();

                gridClientes.Rows.Clear();

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
            catch (Exception e) {
                MessageBox.Show("Houver um erro ao carregar a lista. (" + e.Message + ")");
            }
        }

        private void OnClickCadastrar(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormClientes(fmPrincipal));
        }

        private void OnSelectEditar(object sender, EventArgs e) {
            if (mouseLocation.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridClientes.Rows[mouseLocation.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormClientes(fmPrincipal, Convert.ToInt32(Id)));
            }
        }

        private void OnMouseEnterCell(object sender, DataGridViewCellEventArgs e) {
            mouseLocation = e;
        }

        private void OnSelectExcluir(object sender, EventArgs e) {
            try {
                if (mouseLocation.RowIndex >= 0) {
                    int Id = Convert.ToInt32(gridClientes.Rows[mouseLocation.RowIndex].Cells[0].Value);

                    DialogResult Excluir = MessageBox.Show("Tem certeza que excluir este Cliente?", "Excluir Cliente", MessageBoxButtons.YesNo);

                    if (Excluir == DialogResult.Yes) {
                        Clientes clientes = new Clientes();
                        clientes.Id = Id;
                        clientes.Delete();

                        if (clientes.Success) {
                            MessageBox.Show(clientes.Message);
                            LoadList();
                        }
                        else {
                            throw new Exception("Houver um erro ao excluir o cliente. (" + clientes.Message + ")");
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
