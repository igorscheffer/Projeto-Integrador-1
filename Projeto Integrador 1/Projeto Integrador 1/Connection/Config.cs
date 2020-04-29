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

        public bool Open() {
            try {
                Connection.Open();
                return true;
            }
            catch (MySqlException e) {
                Console.WriteLine("Não foi possivel abrir um conexão com banco de dados. (" + e.Message + ")");

                return false;
            }
        }

        public bool Close() {
            try {
                Connection.Close();
                return true;
            }
            catch (MySqlException e) {
                Console.WriteLine("Não foi possivel fechar a conexão com banco de dados. (" + e.Message + ")");

                return false;
            }
        }
    }
}
