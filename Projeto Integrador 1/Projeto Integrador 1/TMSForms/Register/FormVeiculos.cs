using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Windows.Forms;
using Projeto_Integrador_1.Util.Validate;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormVeiculos : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();

        FormPrincipal fmPrincipal;

        private int Id;

        public FormVeiculos(FormPrincipal fmPrincipal = null, int Id = 0) {
            InitializeComponent();
            this.fmPrincipal = fmPrincipal;

            if (Id > 0) {
                Text = "Editar Veiculo";
                this.Id = Id;
            }

            combCategoria.DisplayMember = "Text";
            combCategoria.ValueMember = "Value";
            combCategoria.DataSource = Listas.VeiculosCategorias;

            combMarca.DisplayMember = "Text";
            combMarca.ValueMember = "Value";
            combMarca.DataSource = Listas.VeiculosMarcas;

            combCarroceria.DisplayMember = "Text";
            combCarroceria.ValueMember = "Value";
            combCarroceria.DataSource = Listas.VeiculosCarrocerias;

            combCor.DisplayMember = "Text";
            combCor.ValueMember = "Value";
            combCor.DataSource = Listas.Cores;

            combCombustivel.DisplayMember = "Text";
            combCombustivel.ValueMember = "Value";
            combCombustivel.DataSource = Listas.Combustiveis;

            combAnoFabricacao.DisplayMember = "Text";
            combAnoFabricacao.ValueMember = "Value";
            combAnoFabricacao.DataSource = Listas.Anos;

            combAnoModelo.DisplayMember = "Text";
            combAnoModelo.ValueMember = "Value";
            combAnoModelo.DataSource = Listas.Anos;

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = Listas.VeiculosStatus;

            if (Id > 0) {
                Text = "Editar Veiculo";
                this.Id = Id;
                PreencherDados();
            }
        }

        private void PreencherDados() {
            try {
                Veiculos veiculos = new Veiculos();
                veiculos.Id = Id;
                veiculos.Get();

                dynamic veiculo = veiculos.Results[0];

                textFrota.Text = veiculo.Frota;
                textPlaca.Text = veiculo.Placa;
                combCategoria.SelectedValue = veiculo.Categoria;
                combMarca.SelectedValue = veiculo.Marca;
                combCarroceria.SelectedValue = veiculo.Carroceria;
                textModelo.Text = veiculo.Modelo;
                combCor.SelectedValue = veiculo.Cor;
                combCombustivel.SelectedValue = veiculo.Combustivel;
                textMotorizacao.Text = veiculo.Motorizacao;
                textRenavam.Text = veiculo.Renavam;
                textChassi.Text = veiculo.Chassi;
                combAnoFabricacao.SelectedItem = veiculo.AnoFabricacao;
                combAnoModelo.SelectedItem = veiculo.AnoModelo;
                combStatus.SelectedValue = veiculo.Status;
                textTara.Text = Convert.ToString(veiculo.Tara);
                textLotacao.Text = Convert.ToString(veiculo.Lotacao);
                textPesoBrutoTotal.Text = Convert.ToString(veiculo.PesoBrutoTotal);
                textCapacidade.Text = Convert.ToString(veiculo.Capacidade);
            }
            catch (Exception e) {
                MessageBox.Show("Houve um erro ao preencher os dados (" + e.Message + ").");
            }
        }

        private void onEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Validate(this, ErrorProvider);

                Validate.AddRule(textFrota, "Frota", "max:20");
                Validate.AddRule(textPlaca, "Placa", "required|placa");
                Validate.AddRule(combCategoria, "Categoria", "required|numeric|max:2");
                Validate.AddRule(combMarca, "Marca", "required|numeric|max:2");
                Validate.AddRule(combCarroceria, "Carroceria", "required|numeric|max:2");
                Validate.AddRule(textModelo, "Modelo", "required|max:50");
                Validate.AddRule(combCor, "Cor", "required|numeric|max:2");
                Validate.AddRule(combCombustivel, "Combustivel", "required|numeric|max:2");
                Validate.AddRule(textMotorizacao, "Motorizacao", "max:30");
                Validate.AddRule(textRenavam, "Renavam", "numeric|max:30");
                Validate.AddRule(textChassi, "Chassi", "required|max:30");
                Validate.AddRule(combAnoFabricacao, "Ano Fabricação", "required|numeric|date:yyyy");
                Validate.AddRule(combAnoModelo, "Ano Modelo", "required|numeric|date:yyyy");
                Validate.AddRule(combStatus, "Status", "required|numeric|max:2");
                Validate.AddRule(textTara, "Tara", "peso|max:20");
                Validate.AddRule(textLotacao, "Lotação", "peso|max:20");
                Validate.AddRule(textPesoBrutoTotal, "Peso Bruto Total", "peso|max:20");
                Validate.AddRule(textCapacidade, "Capacidade M³", "quantidade|max:20");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Veiculos veiculos = new Veiculos();

                    veiculos.Frota = textFrota.Text;
                    veiculos.Placa = textPlaca.Text;
                    veiculos.Categoria = combCategoria.SelectedValue.ToString();
                    veiculos.Marca = combMarca.SelectedValue.ToString();
                    veiculos.Carroceria = combCarroceria.SelectedValue.ToString();
                    veiculos.Modelo = textModelo.Text;
                    veiculos.Cor = combCor.SelectedValue.ToString();
                    veiculos.Combustivel = combCombustivel.SelectedValue.ToString();
                    veiculos.Motorizacao = textMotorizacao.Text;
                    veiculos.Renavam = textRenavam.Text;
                    veiculos.Chassi = textChassi.Text;
                    veiculos.AnoFabricacao = combAnoFabricacao.SelectedValue.ToString();
                    veiculos.AnoModelo = combAnoModelo.SelectedValue.ToString();
                    veiculos.Status = combStatus.SelectedValue.ToString();
                    veiculos.Tara = textTara.Text;
                    veiculos.Lotacao = textLotacao.Text;
                    veiculos.PesoBrutoTotal = textPesoBrutoTotal.Text;
                    veiculos.Capacidade = textCapacidade.Text;

                    if (Id > 0) {
                        veiculos.Id = Convert.ToInt32(Id);
                        veiculos.Update();
                    }
                    else {
                        veiculos.Create();
                    }

                    if (veiculos.Success) {
                        DialogResult SuccessBox = MessageBox.Show(veiculos.Message, "CADASTRADO");
                        if (SuccessBox == DialogResult.OK) {
                            if (fmPrincipal != null) {
                                fmPrincipal.AtivarForm(new TMSForms.List.FormVeiculos(fmPrincipal));
                            }
                            else {
                                Close();
                            }
                        }
                    }
                    else {
                        MessageBox.Show("Houve um erro ao salvar o veiculo. (" + veiculos.Message + ")");
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
    }
}
