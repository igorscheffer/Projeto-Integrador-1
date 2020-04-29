using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.TMSForms {
    public partial class FormHome : Form {

        FormPrincipal fmPrincipal;

        public FormHome(FormPrincipal Principal) {
            InitializeComponent();
            fmPrincipal = Principal;
        }
    }
}
