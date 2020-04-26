using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Connection {
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
            connection = new MySqlConnection("SERVER=" + Host + ";DATABASE=" + Base + ";UID=" + User + ";PASSWORD=" + Pass + ";Convert Zero Datetime=True;");
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
