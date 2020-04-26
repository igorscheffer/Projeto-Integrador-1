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

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaTipos = ValuesComb.getManutencaoTipo();
            List<dynamic> ListaStatus = ValuesComb.getManutencaoStatus();

            Manutencoes manutencoes = new Manutencoes();
            manutencoes.GetAll();

            foreach (dynamic manutencao in manutencoes.Results) {
                string tipo = ListaTipos.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Tipo)).Text;
                string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(manutencao.Status)).Text;
                gridManutencoes.Rows.Add(
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
            fmPrincipal.AtivarForm(new TMSForms.Register.FormManutencoes());
        }
    }
}
