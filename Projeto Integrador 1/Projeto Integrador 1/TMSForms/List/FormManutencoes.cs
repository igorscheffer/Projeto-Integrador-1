using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormManutencoes : Form {

        FormPrincipal fmPrincipal;

        public FormManutencoes(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            Listas ValuesComb = new Util.Listas();

            List<dynamic> ListaTipos = Listas.ManutencoesTipos;
            List<dynamic> ListaStatus = Listas.ManutencoesStatus;

            Manutencoes manutencoes = new Manutencoes();
            manutencoes.GetAll();

            foreach (dynamic manutencao in manutencoes.Results) {
                string tipo = ListaTipos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Tipo)).Text;
                string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Status)).Text;
                gridManutencoes.Rows.Add(
                    manutencao.Id,
                    manutencao.DataAgendada,
                    manutencao.DataRealizada,
                    tipo,
                    manutencao.Placa,
                    manutencao.Fornecedor,
                    manutencao.Valor,
                    status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes(fmPrincipal));
        }

        private void OnSelectItem(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridManutencoes.Rows[e.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
    }
}
