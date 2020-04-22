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
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormViagens : Form
    {

        List<dynamic> ListaCargas = new List<dynamic>();

        public FormViagens()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            this.LoadClientes();
            this.LoadVeiculos();
            this.LoadMotoristas();

            combTomador.DisplayMember = "Text";
            combTomador.ValueMember = "Value";
            combTomador.DataSource = ValuesComb.getViagemTomador();
            combTomador.SelectedValue = -1;

            combTipoViagem.DisplayMember = "Text";
            combTipoViagem.ValueMember = "Value";
            combTipoViagem.DataSource = ValuesComb.getViagemTipo();
            combTipoViagem.SelectedValue = -1;

            combSaidaUF.DisplayMember = "Text";
            combSaidaUF.ValueMember = "Value";
            combSaidaUF.DataSource = ValuesComb.getEstados();
            combSaidaUF.SelectedValue = -1;

            combDestinoUF.DisplayMember = "Text";
            combDestinoUF.ValueMember = "Value";
            combDestinoUF.DataSource = ValuesComb.getEstados();
            combDestinoUF.SelectedValue = -1;
        }

        private void LoadClientes() {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            combRemetente.DisplayMember = "RazaoSocial";
            combRemetente.ValueMember = "Id";
            combRemetente.DataSource = clientes.Results;
            combRemetente.SelectedValue = -1;

            combDestinatario.DisplayMember = "RazaoSocial";
            combDestinatario.ValueMember = "Id";
            combDestinatario.DataSource = clientes.Results;
            combDestinatario.SelectedValue = -1;
        }
        private void LoadVeiculos() {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = veiculos.Results;
            combVeiculo.SelectedValue = -1;

            combReboque.DisplayMember = "Veiculo";
            combReboque.ValueMember = "Id";
            combReboque.DataSource = veiculos.Results;
            combReboque.SelectedValue = -1;
        }
        private void LoadMotoristas() {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotoristas.DisplayMember = "Nome";
            combMotoristas.ValueMember = "Id";
            combMotoristas.DataSource = motoristas.Results;
            combMotoristas.SelectedValue = -1;
        }

        private void onCadastrarCliente(object sender, EventArgs e)
        {
            Form formClientes = new TMSForms.Register.FormClientes();

            formClientes.StartPosition = FormStartPosition.CenterScreen;
            formClientes.FormBorderStyle = FormBorderStyle.FixedSingle;
            formClientes.ControlBox = true;
            formClientes.MaximizeBox = false;
            formClientes.MinimizeBox = false;

            formClientes.Closed += (s, ea) => this.LoadClientes();

            formClientes.ShowDialog();
        }

        private void onCadastrarVeiculo(object sender, EventArgs e)
        {
            Form formVeiculo = new TMSForms.Register.FormVeiculos();

            formVeiculo.StartPosition = FormStartPosition.CenterScreen;
            formVeiculo.FormBorderStyle = FormBorderStyle.FixedSingle;
            formVeiculo.ControlBox = true;
            formVeiculo.MaximizeBox = false;
            formVeiculo.MinimizeBox = false;

            formVeiculo.Closed += (s, ea) => this.LoadVeiculos();

            formVeiculo.ShowDialog();
        }

        private void onCadastrarMotorista(object sender, EventArgs e)
        {
            Form formMotoristas = new TMSForms.Register.FormMotoristas();

            formMotoristas.StartPosition = FormStartPosition.CenterScreen;
            formMotoristas.FormBorderStyle = FormBorderStyle.FixedSingle;
            formMotoristas.ControlBox = true;
            formMotoristas.MaximizeBox = false;
            formMotoristas.MinimizeBox = false;

            formMotoristas.Closed += (s, ea) => this.LoadMotoristas();

            formMotoristas.ShowDialog();
        }

        private void PreencherGridCargas() {
            foreach (dynamic item in this.ListaCargas) {
                gridCargas.Rows.Add(item.NFE, item.Descricao, item.Peso, item.Valor);
            }
        }

        private void onAddCarga(object sender, EventArgs e)
        {
            try {
                Validate Validate = new Util.Validate();

                Validate.addRule(textCargaNFE, "NF-E", "required|nfe");
                Validate.addRule(textCargaDescricao, "Descrição", "required|max:100");
                Validate.addRule(textCargaPeso, "Peso", "required|numeric|max:20");
                Validate.addRule(textCargaValor, "Valor", "required|reais");

                Validate.Validation();

                if (Validate.IsValid()) {
                    gridCargas.Rows.Add(textCargaNFE.Text, textCargaDescricao.Text, textCargaPeso.Text, textCargaValor.Text);

                    textCargaNFE.ResetText();
                    textCargaDescricao.ResetText();
                    textCargaPeso.ResetText();
                    textCargaValor.ResetText();
                }
                else {
                    string ShowMessage = "";

                    foreach (dynamic Erro in Validate.getErrors())
                    {
                        ShowMessage += Erro.Message + "\n";
                    }

                    MessageBox.Show(ShowMessage);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
