using Guna.UI.WinForms;
using Projeto_Integrador_1.Connection;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.Register {
    public partial class FormMultas : Form {
        ErrorProvider ErrorProvider = new ErrorProvider();
        public FormMultas() {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            this.LoadVeiculos();
            this.LoadMotoristas();

            combGravidade.DisplayMember = "Text";
            combGravidade.ValueMember = "Value";
            combGravidade.DataSource = ValuesComb.getMultaGravidade();

            combStatus.DisplayMember = "Text";
            combStatus.ValueMember = "Value";
            combStatus.DataSource = ValuesComb.getMultaStatus();
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

        private void OnEnviar(object sender, EventArgs e) {
            try {
                Validate Validate = new Util.Validate(this, ErrorProvider);

                Validate.addRule(combVeiculo, "Veiculo", "required|numeric|max:11");
                Validate.addRule(combMotorista, "Motorista", "numeric|max:11");
                Validate.addRule(combGravidade, "Gravidade", "required|numeric|exact:1");
                Validate.addRule(combStatus, "Status", "required|numeric|exact:1");
                Validate.addRule(timeDataOcorrencia, "Data Ocorrencia", "required|date:dd/MM/yyyy");
                Validate.addRule(timeDataNotificacao, "Data Notificacao", "date:dd/MM/yyyy");
                Validate.addRule(timeDataVencimento, "Data Vencimento", "date:dd/MM/yyyy");
                Validate.addRule(textValor, "Valor", "numeric|max:11");
                Validate.addRule(textDescricao, "Descrição da Infração", "max:500");
                Validate.addRule(textLocal, "Local da Infração", "max:500");

                Validate.Validation();

                if (Validate.IsValid()) {
                    Multas multas = new Multas();

                    multas.Veiculo = combVeiculo.SelectedValue;
                    multas.Motorista = combMotorista.SelectedValue;
                    multas.Gravidade = combGravidade.SelectedValue;
                    multas.Status = combStatus.SelectedValue;
                    multas.DataOcorrencia = timeDataOcorrencia.Text;
                    multas.DataNotificacao = timeDataNotificacao.Text;
                    multas.DataVencimento = timeDataVencimento.Text;
                    multas.Valor = textValor.Text;
                    multas.Descricao = textDescricao.Text;
                    multas.Local = textLocal.Text;

                    multas.Create();

                    if (multas.Success) {
                        MessageBox.Show(multas.Message);
                    }
                    else {
                        MessageBox.Show("Houver um erro ao salvar a multas (" + multas.Message + ")");
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
