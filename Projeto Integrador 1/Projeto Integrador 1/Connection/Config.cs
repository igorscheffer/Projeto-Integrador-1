using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Connection {
    class Config {
        public MySqlConnection Connection;
        private string Host = "localhost";
        private string User = "root";
        private string Pass = "";
        private string Base = "projeto_integrador";

        public Config() {
            Initialize();
        }

        public void Initialize() {
            Connection = new MySqlConnection("SERVER=" + Host + ";DATABASE=" + Base + ";UID=" + User + ";PASSWORD=" + Pass + ";Convert Zero Datetime=True;");
        }

        public bool OpenConnection() {
            try {
                Connection.Open();

                Console.WriteLine("Conexão com banco de dados aberta.");

                return true;
            }
            catch (MySqlException e) {
                MessageBox.Show(e.Message);

                return false;
            }
        }

        public bool CloseConnection() {
            try {
                Connection.Close();

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
