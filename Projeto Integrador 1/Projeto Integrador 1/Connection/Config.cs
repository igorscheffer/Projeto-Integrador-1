using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Connection {
    class Config {
        public MySqlConnection Connection;
        private string Host = "projet_001.mysql.dbaas.com.br";
        private string User = "projet_001";
        private string Pass = "ProjetSisu01I";
        private string Base = "projet_001";
        private bool ServerLocal = false;

        public Config() {
            Initialize();
        }

        public void Initialize() {
            if (ServerLocal) {
                Host = "localhost";
                User = "root";
                Pass = "";
                Base = "projeto_integrador";
            }

            Connection = new MySqlConnection("SERVER=" + Host + ";DATABASE=" + Base + ";UID=" + User + ";PASSWORD=" + Pass + ";Convert Zero Datetime=True;");
        }

        public bool OpenConnection() {
            try {
                Connection.Open();
                return true;
            }
            catch (MySqlException e) {
                Console.WriteLine("Não foi possivel abrir um conexão com banco de dados. (" + e.Message + ")");
                return false;
            }
        }

        public bool CloseConnection() {
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
