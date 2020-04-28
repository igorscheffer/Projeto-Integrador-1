﻿using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.List {
    public partial class FormAbastecimentos : Form {

        FormPrincipal fmPrincipal;

        public FormAbastecimentos(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;

            List<dynamic> ListaCombustiveis = Listas.Combustiveis;
            List<dynamic> ListaStatus = Listas.AbastecimentosStatus;

            Abastecimentos abastecimentos = new Abastecimentos();
            abastecimentos.GetAll();

            foreach (dynamic abastecimento in abastecimentos.Results) {
                string combustivel = ListaCombustiveis.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(abastecimento.Combustivel)).Text;
                string status = ListaStatus.Find(find => Convert.ToInt32(find.Value) == Convert.ToInt32(abastecimento.Status)).Text;
                gridAbastecimentos.Rows.Add(
                    abastecimento.Id,
                    abastecimento.Data,
                    abastecimento.Placa,
                    abastecimento.Posto,
                    combustivel,
                    abastecimento.Litros,
                    "R$ " + (abastecimento.Valor + " (R$ " + abastecimento.Total + ")"),
                    abastecimento.Hodometro,
                    status
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormAbastecimentos(fmPrincipal));
        }

        private void OnSelectItem(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                int Id = Convert.ToInt32(gridAbastecimentos.Rows[e.RowIndex].Cells[0].Value);
                fmPrincipal.AtivarForm(new TMSForms.Register.FormAbastecimentos(fmPrincipal, Convert.ToInt32(Id)));
            }
        }
    }
}
