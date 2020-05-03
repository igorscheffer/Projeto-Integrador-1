using MySql.Data.MySqlClient;
using System;

namespace Projeto_Integrador_1.Connection {
    class Config {
        public MySqlConnection Connection;
        private string Host = "localhost";
        private string User = "root";
        private string Pass = "";
        private string Base = "projeto_integrador";
        private bool ServerRemote = false;

        public Config() {
            Initialize();
        }

        public void Initialize() {
            if (ServerRemote) {
                Host = Properties.Settings.Default.RemoteHost;
                User = Properties.Settings.Default.RemoteUser;
                Pass = Properties.Settings.Default.RemotePass;
                Base = Properties.Settings.Default.RemoteBase;
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
