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

namespace Projeto_Integrador_1.TMSForms.List
{
    public partial class FormMotoristas : Form
    {
        FormPrincipal fmPrincipal;

        public FormMotoristas(FormPrincipal Principal)
        {
            InitializeComponent();
            fmPrincipal = Principal;

            Motoristas motoristas = new Motoristas();
            motoristas.GetAll();

            foreach (dynamic motorista in motoristas.Results)
            {
                gridClientes.Rows.Add(
                    motorista.Nome,
                    motorista.RG,
                    motorista.CPF,
                    motorista.CNH,
                    motorista.Categoria,
                    motorista.Vencimento
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fmPrincipal.AtivarForm(new TMSForms.Register.FormMotoristas());
        }
    }
}
