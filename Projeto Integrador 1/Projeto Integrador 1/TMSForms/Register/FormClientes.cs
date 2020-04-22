using Correios.CEP;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();

            PreencherCombBox ValuesComb = new Util.PreencherCombBox();

            combEstado.DisplayMember = "Text";
            combEstado.ValueMember = "Value";
            combEstado.DataSource = ValuesComb.getEstados();
            combEstado.SelectedValue = -1;
        }

        private void onBuscarCEP(object sender, EventArgs e)
        {
            try
            {
                cepConsulta endereco = correiosCEP.GetAddress(textCEP.Text);

                textEndereco.Text = endereco.Rua;
                textN.Focus();
                textBairro.Text = endereco.Bairro;
                textComplemento.Text = "";
                textCidade.Text = endereco.Cidade;
                combEstado.SelectedValue = endereco.UF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
