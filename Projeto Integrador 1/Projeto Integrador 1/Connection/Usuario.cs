using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection {
    class Usuario : Config {

        public bool Success;
        public string Message;

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Acesso { get; set; }
        public bool SalvarSenha { get; set; }
        
        public Usuario() { }

        private string CriptografarSenha(string login, string senha) {
            try {
                if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(senha)) {
                    MD5 md5hash = MD5.Create();

                    byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(login+senha));

                    StringBuilder sBuilder = new StringBuilder();

                    for (int i = 0; i < data.Length; i++) {
                        sBuilder.Append(data[i].ToString("x2"));
                    }

                    return sBuilder.ToString();
                }
                else {
                    throw new Exception("Login ou Senha não preenchida.");
                }
            }
            catch (Exception e) {
                throw e;
            }
        }

        private bool VerificarSenha(string login, string senha, string senhadb) {
            try {
                if (CriptografarSenha(login, senha) == senhadb) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception e) {
                throw e;
            }
        }

        public void Logar() {
            string sql = "SELECT * FROM `usuarios` WHERE `login` = @login AND `senha` = @senha LIMIT 1;";
            string sqlUltimoAcesso = "UPDATE `usuarios` SET `ultimo_acesso` = CURRENT_TIMESTAMP() WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                string SenhaCriptografada = CriptografarSenha(Login, Senha);

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@login", Login);
                query.Parameters.AddWithValue("@senha", SenhaCriptografada);
                query.ExecuteNonQuery();

                MySqlDataReader data = query.ExecuteReader();
                data.Read();
                int Id = Convert.ToInt32(data["id"]);

                CloseConnection();
                
                if (Id > 0) {
                    OpenConnection();

                    MySqlCommand queryUpdateUltimoAcesso = new MySqlCommand(sqlUltimoAcesso, Connection);
                    queryUpdateUltimoAcesso.Parameters.AddWithValue("@id", Id);
                    queryUpdateUltimoAcesso.ExecuteNonQuery();

                    CloseConnection();

                    if (SalvarSenha) {
                        Properties.Settings.Default.login = Login;
                        Properties.Settings.Default.senha = Senha;
                        Properties.Settings.Default.salvarSenha = true;
                        Properties.Settings.Default.Save();
                    }
                    else {
                        Properties.Settings.Default.login = string.Empty;
                        Properties.Settings.Default.senha = string.Empty;
                        Properties.Settings.Default.salvarSenha = false;
                        Properties.Settings.Default.Save();
                    }

                    Success = true;
                    Message = "Login efetuado com sucesso.";

                    Console.WriteLine("Login efetuado com sucesso.");
                }
                else {
                    throw new Exception("Usuario ou Senha invalido.");
                }
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
                Console.WriteLine("Houve um erro ao efetuar o login (" + e.Message + ").");
            }
        }
    }
}
