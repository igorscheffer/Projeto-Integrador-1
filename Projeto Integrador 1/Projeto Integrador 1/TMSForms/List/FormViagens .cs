using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormViagens : Form {

        FormPrincipal fmPrincipal;

        public FormViagens(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaStatus = ValuesComb.getViagemStatus();

            Viagens viagens = new Viagens();
            viagens.GetAll();

            foreach (dynamic viagem in viagens.Results) {
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

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal));
        }

        private void OnSelectItem(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridViagens.Rows[e.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormViagens(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
    }
}
