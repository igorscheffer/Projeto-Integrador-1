using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormMultas : Form {

        FormPrincipal fmPrincipal;

        public FormMultas(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            List<dynamic> ListaGravidade = ValuesComb.getMultaGravidade();
            List<dynamic> ListaStatus = ValuesComb.getMultaStatus();

            Multas multas = new Multas();
            multas.GetAll();

            foreach (dynamic multa in multas.Results) {
                string gravidade = ListaGravidade.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(multa.Gravidade)).Text;
                string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(multa.Status)).Text;
                gridMultas.Rows.Add(
                    multa.DataOcorrencia,
                    multa.Placa.ToString().ToUpper(),
                    multa.Motorista,
                    multa.Descricao,
                    gravidade,
                    multa.Valor,
                    multa.DataVencimento,
                    status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMultas());
        }
    }
}
