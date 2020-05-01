using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormViagens : Form {

        FormPrincipal fmPrincipal;

        List<dynamic> ListaViagens;

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

                ListaViagens = viagens.Results;

                gridViagens.Rows.Clear();

                foreach (dynamic viagem in ListaViagens) {
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
        private void OnClickCadastrar(object sender, EventArgs e) {
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
        private void OnClickLancarConta(object sender, EventArgs e) {
            try {
                int Id = Convert.ToInt32(gridViagens.Rows[mouseLocation.RowIndex].Cells[0].Value);

                dynamic Data = ListaViagens.Find(find => Convert.ToInt32(find.Id) == Id);

                ToolStripMenuItem Button = (ToolStripMenuItem)sender;

                Form formFinanceiro;

                if (Button.Tag == "conta_pagar") {
                    object SendFinanceiro = new {
                        CentroCusto = 3,
                        Tipo = 1,
                        Valor = Data.TotalCustos,
                        Id = Id
                    };
                    formFinanceiro = new TMSForms.Register.FormFinanceiro(null, 0, SendFinanceiro);
                }
                else if (Button.Tag == "conta_receber") {
                    if (Data.Valor > 0) {
                        object SendFinanceiro = new {
                            CentroCusto = 3,
                            Tipo = 1,
                            Valor = Data.Valor,
                            Id = Id
                        };
                        formFinanceiro = new TMSForms.Register.FormFinanceiro(null, 0, SendFinanceiro);
                    }
                    else {
                        throw new Exception("Não tem valor a ser recebido para lançar no Financeiro.");
                    }
                }
                else {
                    throw new Exception("Função não reconhecida.");
                }

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
