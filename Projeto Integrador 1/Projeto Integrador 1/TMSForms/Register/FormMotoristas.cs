﻿using System;
using System.Windows.Forms;
using Correios.CEP;
using FontAwesome.Sharp;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormMotoristas : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormMotoristas(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getMotoristaStatus();

            combCategoriaCNH.DisplayMember = "Text";
            combCategoriaCNH.ValueMember = "Value";
            combCategoriaCNH.DataSource = ValuesComb.getCategoriasCNH();

            combSexo.DisplayMember = "Text";
            combSexo.ValueMember = "Value";
            combSexo.DataSource = ValuesComb.getSexo();

            combEstadoCivil.DisplayMember = "Text";
            combEstadoCivil.ValueMember = "Value";
            combEstadoCivil.DataSource = ValuesComb.getEstadoCivil();

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = ValuesComb.getEstados();

            combCargo.DisplayMember = "Text";
            combCargo.ValueMember = "Value";
            combCargo.DataSource = ValuesComb.getMotoristaCargos();

            timeVencimentoCNH.ResetText();

            if (Id > 0) {
                this.Text = "Editar Motorista";
                this.Id = Id;
                this.PreencherDados();
            }
        }

        private void PreencherDados() {
            try {
                Motoristas motoristas = new Motoristas();
                motoristas.Id = this.Id;
                motoristas.Get();

                dynamic motorista = motoristas.Results[0];

                textNome.Text = motorista.Nome;
                textCPF.Text = motorista.CPF;
                textRG.Text = Convert.ToString(motorista.RG);
                combStatus.SelectedValue = motorista.Status;
                textCNH.Text = Convert.ToString(motorista.CNH);
                timeVencimentoCNH.Text = motorista.Vencimento;
                combCategoriaCNH.SelectedValue = motorista.Categoria;
                combSexo.SelectedValue = motorista.Sexo;
                combEstadoCivil.SelectedValue = motorista.EstadoCivil;
                textCEP.Text = motorista.CEP;
                textEndereco.Text = motorista.Endereco;
                textN.Text = Convert.ToString(motorista.N);
                textBairro.Text = motorista.Bairro;
                textComplemento.Text = motorista.Complemento;
                textCidade.Text = motorista.Cidade;
                combEstado.SelectedValue = motorista.Estado;
                combCargo.SelectedValue = motorista.Cargo;
                textTelefone.Text = motorista.Telefone;
                textCelular.Text = motorista.Celular;
                textEmail.Text = motorista.Email;
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
            }
        }

        private void onBuscarCEP(object sender, EventArgs e) {
            IconButton button = (IconButton)sender;

            IconChar defaultIcon = button.IconChar;

            button.IconChar = IconChar.Spinner;

            try {
                cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                textEndereco.Text = endereco.Rua;
                textN.Focus();
                textBairro.Text = endereco.Bairro;
                textComplemento.Text = "";
                textCidade.Text = endereco.Cidade;
                combEstado.SelectedValue = endereco.UF;

                button.IconChar = defaultIcon;
            }
            catch (Exception ex) {
                button.IconChar = defaultIcon;
                MessageBox.Show(ex.Message);
            }
        }

        private void onEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(textNome, "Nome Completo", "required|max:100");
                Validate.AddRule(textCPF, "CPF", "required|cpf");
                Validate.AddRule(textRG, "RG", "numeric|max:12");
                Validate.AddRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.AddRule(textCNH, "CNH", "numeric|max:12");
                Validate.AddRule(timeVencimentoCNH, "Vencimento", "date:dd/MM/yyyy");
                Validate.AddRule(combCategoriaCNH, "Categoria", "min:1|max:2");
                Validate.AddRule(combSexo, "Sexo", "required|in:h,m");
                Validate.AddRule(combEstadoCivil, "Estado Civil", "required|numeric|exact:1");
                Validate.AddRule(textCEP, "CEP", "cep");
                Validate.AddRule(textEndereco, "Endereco", "max:100");
                Validate.AddRule(textN, "Nº", "max:10");
                Validate.AddRule(textBairro, "Bairro", "max:60");
                Validate.AddRule(textComplemento, "Complemento", "max:100");
                Validate.AddRule(textCidade, "Cidade", "max:100");
                Validate.AddRule(combEstado, "Estado", "exact:2");
                Validate.AddRule(combCargo, "Cargo", "numeric|exact:1");
                Validate.AddRule(textTelefone, "Telefone", "telefone");
                Validate.AddRule(textCelular, "Celular", "telefone");
                Validate.AddRule(textEmail, "Email", "email|max:100");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Motoristas motoristas = new Motoristas();

                    motoristas.Nome = textNome.Text;
                    motoristas.CPF = textCPF.Text;
                    motoristas.RG = textRG.Text;
                    motoristas.Status = combStatus.SelectedValue;
                    motoristas.CNH = textCNH.Text;
                    motoristas.Vencimento = timeVencimentoCNH.Text;
                    motoristas.Categoria = combCategoriaCNH.SelectedValue;
                    motoristas.Sexo = combSexo.SelectedValue;
                    motoristas.EstadoCivil = combEstadoCivil.SelectedValue;
                    motoristas.CEP = textCEP.Text;
                    motoristas.Endereco = textEndereco.Text;
                    motoristas.N = textN.Text;
                    motoristas.Bairro = textBairro.Text;
                    motoristas.Complemento = textComplemento.Text;
                    motoristas.Cidade = textCidade.Text;
                    motoristas.Estado = combEstado.SelectedValue;
                    motoristas.Cargo = combCargo.SelectedValue;
                    motoristas.Telefone = textTelefone.Text;
                    motoristas.Celular = textCelular.Text;
                    motoristas.Email = textEmail.Text;

                    if (this.Id > 0) {
                        motoristas.Id = Convert.ToInt32(this.Id);
                        motoristas.Update();
                    }
                    else {
                        motoristas.Create();
                    }

                    if (motoristas.Success) {
                        DialogResult SuccessBox = MessageBox.Show(motoristas.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormMotoristas(fmPrincipal));
                            }
                            else {
                                this.Close();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Houver um erro ao salvar o motorista (" + motoristas.Message + ")");
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

        private void textCelular_TextChanged(object sender, EventArgs e) {

        }

        private void panel5_Paint(object sender, PaintEventArgs e) {

        }
    }
}
