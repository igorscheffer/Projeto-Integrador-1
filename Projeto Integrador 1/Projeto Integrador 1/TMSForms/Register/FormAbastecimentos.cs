﻿using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormAbastecimentos : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();
        public FormAbastecimentos() {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            LoadClientes();
            LoadVeiculos();
            LoadMotoristas();

            combCombustivel.DisplayMember = "Text";
            combCombustivel.ValueMember = "Value";
            combCombustivel.DataSource = ValuesComb.getCombustiveis();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getAbastecimentosStatus();
        }
        private void LoadClientes() {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            combPosto.DisplayMember = "RazaoSocial";
            combPosto.ValueMember = "Id";
            combPosto.DataSource = new List<dynamic>(clientes.Results);
            combPosto.SelectedValue = -1;
        }
        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
            combVeiculo.SelectedValue = -1;
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotorista.DisplayMember = "Nome";
            combMotorista.ValueMember = "Id";
            combMotorista.DataSource = new List<dynamic>(motoristas.Results);
            combMotorista.SelectedValue = -1;
        }
        private void onCadastrarCliente(object sender, EventArgs e) {
            Form formClientes = new TMSForms.Register.FormClientes();

            formClientes.StartPosition = FormStartPosition.CenterScreen;
            formClientes.FormBorderStyle = FormBorderStyle.FixedSingle;
            formClientes.ControlBox = true;
            formClientes.MaximizeBox = false;
            formClientes.MinimizeBox = false;

            formClientes.Closed += (s, ea) => LoadClientes();

            formClientes.ShowDialog();
        }

        private void onCadastrarVeiculo(object sender, EventArgs e) {
            Form formVeiculo = new TMSForms.Register.FormVeiculos();

            formVeiculo.StartPosition = FormStartPosition.CenterScreen;
            formVeiculo.FormBorderStyle = FormBorderStyle.FixedSingle;
            formVeiculo.ControlBox = true;
            formVeiculo.MaximizeBox = false;
            formVeiculo.MinimizeBox = false;

            formVeiculo.Closed += (s, ea) => LoadVeiculos();

            formVeiculo.ShowDialog();
        }

        private void onCadastrarMotorista(object sender, EventArgs e) {
            Form formMotoristas = new TMSForms.Register.FormMotoristas();

            formMotoristas.StartPosition = FormStartPosition.CenterScreen;
            formMotoristas.FormBorderStyle = FormBorderStyle.FixedSingle;
            formMotoristas.ControlBox = true;
            formMotoristas.MaximizeBox = false;
            formMotoristas.MinimizeBox = false;

            formMotoristas.Closed += (s, ea) => LoadMotoristas();

            formMotoristas.ShowDialog();
        }

        private void OnEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                //Validate.addRule(ViagemId, "Viagem", "numeric|max:11");
                Validate.AddRule(timeData, "Data", "required|date:dd/MM/yyyy HH:mm");
                Validate.AddRule(textCupom, "Cupom", "max:20");
                Validate.AddRule(combPosto, "Posto", "required|numeric|max:11");
                Validate.AddRule(combCombustivel, "Combustivel", "required|numeric|exact:1");
                Validate.AddRule(combVeiculo, "Veiculo", "numeric|max:11");
                Validate.AddRule(combMotorista, "Motorista", "numeric|max:11");
                Validate.AddRule(textHodometro, "Hodômetro", "numeric|max:22");
                Validate.AddRule(combStatus, "Status", "required|numeric|max:22");
                Validate.AddRule(textLitros, "Litros", "required|numeric|max:11");
                Validate.AddRule(textValor, "Valor", "required|numeric|max:11");
                Validate.AddRule(textTotal, "Total", "required|numeric|max:11");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Abastecimentos abastecimentos = new Abastecimentos();

                    int total = (Convert.ToInt32(textValor.Text) * Convert.ToInt32(textLitros.Text));

                    abastecimentos.Data = timeData.Text;
                    abastecimentos.Cupom = textCupom.Text;
                    abastecimentos.Posto = combPosto.SelectedValue;
                    abastecimentos.Combustivel = combCombustivel.SelectedValue;
                    abastecimentos.Veiculo = combVeiculo.SelectedValue;
                    abastecimentos.Motorista = combMotorista.SelectedValue;
                    abastecimentos.Hodometro = textHodometro.Text;
                    abastecimentos.Status = combStatus.SelectedValue;
                    abastecimentos.Litros = textLitros.Text;
                    abastecimentos.Valor = textValor.Text;
                    abastecimentos.Total = Convert.ToString(total);

                    abastecimentos.Create();

                    if (abastecimentos.Success) {
                        MessageBox.Show(abastecimentos.Message);
                    }
                    else {
                        throw new Exception("Houve um erro ao salvar o abastecimento (" + abastecimentos.Message + ")");
                    }
                }
                else {
                    Validate.ErrorProviderShow();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcularValorTotal(object sender, KeyEventArgs e) {
            try {
                int Valor = Int16.Parse(textValor.Text);
                int Litros = Int16.Parse(textLitros.Text);

                int Total = (Valor * Litros);

                textTotal.Text = Convert.ToString(Total);
            }
            catch {
                textTotal.Text = Convert.ToString(0);
            }
        }
    }
}
