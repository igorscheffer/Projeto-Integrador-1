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
    public partial class FormMotoristas : Form
    {

        public FormMotoristas()
        {
            InitializeComponent();

            var Estados = new Estados();

            foreach (string estado in Estados.getEstados()) {
                combEstados.Items.Add(estado);
            }
        }
    }
}
