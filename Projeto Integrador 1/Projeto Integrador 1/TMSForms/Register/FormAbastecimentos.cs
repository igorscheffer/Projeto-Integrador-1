﻿using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;
using Guna.UI2.WinForms;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormAbastecimentos : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormAbastecimentos(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            textLitros.KeyPress += Converter.OnlyNumber;
            textValor.KeyPress += Converter.OnlyNumber;

            timeData.KeyPress += Converter.DateReset;
            timeData.ValueChanged += Converter.DateTimeValueChanged;

            LoadClientes();
            LoadVeiculos();
            LoadMotoristas();

            combCombustivel.DisplayMember = "Text";
            combCombustivel.ValueMember = "Value";
            combCombustivel.DataSource = Listas.Combustiveis;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = Listas.AbastecimentosStatus;

            if (Id > 0) {
                Text = "Editar Abastecimento";
                this.Id = Id;
                PreencherDados();
            }
        }

        private void PreencherDados() {
            try {
                Abastecimentos abastecimentos = new Abastecimentos();
                abastecimentos.Id = Id;
                abastecimentos.Get();

                dynamic abastecimento = abastecimentos.Results[0];

                timeData.Text = abastecimento.Data;
                textCupom.Text = abastecimentos.Cupom;
                combPosto.SelectedValue = abastecimento.Posto;
                combCombustivel.SelectedValue = abastecimento.Combustivel;
                combVeiculo.SelectedValue = abastecimento.Veiculo;
                combMotorista.SelectedValue = abastecimento.Motorista;
                textHodometro.Text = Convert.ToString(abastecimento.Hodometro);
                combStatus.SelectedValue = abastecimento.Status;
                textLitros.Text = Converter.ToQuantidade(abastecimento.Litros);
                textValor.Text = Converter.ToReais(abastecimento.Valor);
                textTotal.Text = Converter.ToReais(abastecimento.Total);
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
            }
        }

        private void LoadClientes() {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            if (clientes.Results.Count > 0) {
                combPosto.DisplayMember = "RazaoSocial";
                combPosto.ValueMember = "Id";
                combPosto.DataSource = new List<dynamic>(clientes.Results);
                combPosto.SelectedValue = -1;
            }
        }
        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            if (veiculos.Results.Count > 0) {
                combVeiculo.DisplayMember = "Veiculo";
                combVeiculo.ValueMember = "Id";
                combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
                combVeiculo.SelectedValue = -1;
            }
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            if (motoristas.Results.Count > 0) {
                combMotorista.DisplayMember = "Nome";
                combMotorista.ValueMember = "Id";
                combMotorista.DataSource = new List<dynamic>(motoristas.Results);
                combMotorista.SelectedValue = -1;
            }
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

                Validate.AddRule(timeData, "Data", "required|date:dd/MM/yyyy HH:mm");
                Validate.AddRule(textCupom, "Cupom", "max:20");
                Validate.AddRule(combPosto, "Posto", "required|numeric|max:11");
                Validate.AddRule(combCombustivel, "Combustivel", "required|numeric|exact:1");
                Validate.AddRule(combVeiculo, "Veiculo", "numeric|max:11");
                Validate.AddRule(combMotorista, "Motorista", "numeric|max:11");
                Validate.AddRule(textHodometro, "Hodômetro", "numeric|max:22");
                Validate.AddRule(combStatus, "Status", "required|numeric|max:22");
                Validate.AddRule(textLitros, "Litros", "required|quantidade|max:11");
                Validate.AddRule(textValor, "Valor", "required|reais|max:11");
                Validate.AddRule(textTotal, "Total", "required|reais|max:11");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Abastecimentos abastecimentos = new Abastecimentos();

                    decimal total = (Convert.ToDecimal(textValor.Text) * Convert.ToDecimal(textLitros.Text));

                    abastecimentos.Data = timeData.Text;
                    abastecimentos.Cupom = textCupom.Text;
                    abastecimentos.Posto = combPosto.SelectedValue;
                    abastecimentos.Combustivel = combCombustivel.SelectedValue;
                    abastecimentos.Veiculo = combVeiculo.SelectedValue;
                    abastecimentos.Motorista = combMotorista.SelectedValue;
                    abastecimentos.Hodometro = textHodometro.Text;
                    abastecimentos.Status = combStatus.SelectedValue;
                    abastecimentos.Litros = Converter.ToDecimal(textLitros.Text, true);
                    abastecimentos.Valor = Converter.ToDecimal(textValor.Text, true);
                    abastecimentos.Total = Converter.ToDecimal(textTotal.Text, true);

                    if (Id > 0) {
                        abastecimentos.Id = Convert.ToInt32(Id);
                        abastecimentos.Update();
                    }
                    else {
                        abastecimentos.Create();
                    }

                    if (abastecimentos.Success) {
                        DialogResult SuccessBox = MessageBox.Show(abastecimentos.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormAbastecimentos(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
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
                decimal Valor = Converter.ToDecimal(textValor.Text);
                decimal Litros = Converter.ToDecimal(textLitros.Text);

                decimal Total = (Valor * Litros);

                textTotal.Text = Converter.ToReais(Total);
            }
            catch {
                textTotal.Text = Convert.ToString(0);
            }
        }

        private void OnChangedTextValor(object sender, EventArgs e) {
            Guna2TextBox Text = (Guna2TextBox)sender;
            Converter.OnPressMoeda(ref Text);
        }

        private void OnChangedTextQtd(object sender, EventArgs e) {
            Guna2TextBox Text = (Guna2TextBox)sender;
            Converter.OnPressQtd(ref Text);
        }
    }
}
