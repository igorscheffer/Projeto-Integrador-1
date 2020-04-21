using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Connection
{
    class Config {
        protected MySqlConnection connection;
        private string Host = "localhost";
        private string User = "root";
        private string Pass = "";
        private string Base = "projeto_integrador";

        public Config() {
            Initialize();
        }

        private void Initialize() {
            connection = new MySqlConnection("SERVER=" + this.Host + ";DATABASE=" + this.Base + ";UID=" + this.User + ";PASSWORD=" + this.Pass + ";");
        }

        protected bool openConnection() {
            try {
                connection.Open();

                Console.WriteLine("Conexão com banco de dados aberta.");

                return true;
            }
            catch (MySqlException e) {
                MessageBox.Show(e.Message);

                return false;
            }
        }

        protected bool closeConnection() {
            try {
                connection.Close();

                Console.WriteLine("Conexão com banco de dados fechada.");

                return true;
            }
            catch (MySqlException e) {
                MessageBox.Show(e.Message);

                return false;
            }
        }
    }
}
