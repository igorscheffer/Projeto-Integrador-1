using Projeto_Integrador_1.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Integrador_1.Util;

namespace Projeto_Integrador_1.TMSForms.Register
{
    public partial class FormManutencoes : Form
    {
        public FormManutencoes()
        {
            InitializeComponent();

            this.LoadVeiculos();
            this.LoadMotoristas();
            this.LoadClientes();
        }

        private void LoadClientes()
        {
            Clientes clientes = new Clientes();
            clientes.GetAll();

            combFornecedor.DisplayMember = "RazaoSocial";
            combFornecedor.ValueMember = "Id";
            combFornecedor.DataSource = new List<dynamic>(clientes.Results);
            combFornecedor.SelectedValue = -1;
        }
        private void LoadVeiculos()
        {
            Veiculos veiculos = new Veiculos();
            veiculos.GetAll();

            combVeiculo.DisplayMember = "Veiculo";
            combVeiculo.ValueMember = "Id";
            combVeiculo.DataSource = new List<dynamic>(veiculos.Results);
            combVeiculo.SelectedValue = -1;
        }
        private void LoadMotoristas()
        {
            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            combMotorista.DisplayMember = "Nome";
            combMotorista.ValueMember = "Id";
            combMotorista.DataSource = new List<dynamic>(motoristas.Results);
            combMotorista.SelectedValue = -1;
        }

        private void RefreshValorTotal() {
            int ValorTotalItens = 0;
            foreach (DataGridViewRow item in gridItens.Rows)
            {
                ValorTotalItens += (Convert.ToInt32(item.Cells[3].Value) * Convert.ToInt32(item.Cells[2].Value));
            }

            textValor.Text = Convert.ToString(ValorTotalItens);
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

        private void OnAddItem(object sender, EventArgs e)
        {
            try
            {
                Validate Validate = new Util.Validate();

                Validate.addRule(textItemCodigo, "Codigo", "required|max:10");
                Validate.addRule(textItemDescricao, "Descrição", "required|max:60");
                Validate.addRule(textItemQtd, "Qtd", "required|numeric|max:20");
                Validate.addRule(textItemValor, "Valor", "required|numeric|max:20");

                Validate.Validation();

                if (Validate.IsValid())
                {
                    int valorTotal = Int32.Parse(textItemValor.Text) * Int32.Parse(textItemQtd.Text);

                    gridItens.Rows.Add(textItemCodigo.Text, textItemDescricao.Text, textItemQtd.Text, textItemValor.Text, valorTotal);

                    textItemCodigo.ResetText();
                    textItemDescricao.ResetText();
                    textItemQtd.ResetText();
                    textItemValor.ResetText();

                    this.RefreshValorTotal();
                }
                else
                {
                    Validate.ErrorMessageBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
