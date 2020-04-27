using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Motoristas : Config {

        public Motoristas() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public dynamic Status { get; set; }
        public string CNH { get; set; }
        public string Vencimento { get; set; }
        public dynamic Categoria { get; set; }
        public dynamic Sexo { get; set; }
        public dynamic EstadoCivil { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string N { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public dynamic Estado { get; set; }
        public dynamic Cargo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public void Create() {
            string sql = "INSERT INTO `motoristas` (`nome`, `cpf`, `rg`, `status`, `cnh`, `vencimento`, `categoria`, `sexo`, `estado_civil`, `cep`, `endereco`, `n`, `bairro`, `complemento`, `cidade`, `estado`, `cargo`, `telefone`, `celular`, `email`) VALUES (@nome, @cpf, @rg, @status, @cnh, @vencimento, @categoria, @sexo, @estado_civil, @cep, @endereco, @n, @bairro, @complemento, @cidade, @estado, @cargo, @telefone, @celular, @email);";

            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@cpf", CNH);
                query.Parameters.AddWithValue("@rg", RG);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@cnh", CNH);
                query.Parameters.AddWithValue("@vencimento", DateTime.Parse(Vencimento));
                query.Parameters.AddWithValue("@categoria", Categoria);
                query.Parameters.AddWithValue("@sexo", Sexo);
                query.Parameters.AddWithValue("@estado_civil", EstadoCivil);
                query.Parameters.AddWithValue("@cep", CEP);
                query.Parameters.AddWithValue("@endereco", Endereco);
                query.Parameters.AddWithValue("@n", N);
                query.Parameters.AddWithValue("@bairro", Bairro);
                query.Parameters.AddWithValue("@complemento", Complemento);
                query.Parameters.AddWithValue("@cidade", Cidade);
                query.Parameters.AddWithValue("@estado", Estado);
                query.Parameters.AddWithValue("@cargo", Cargo);
                query.Parameters.AddWithValue("@telefone", Telefone);
                query.Parameters.AddWithValue("@celular", Celular);
                query.Parameters.AddWithValue("@email", Email);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Motorista salvo com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `motoristas` SET `nome` = @nome, `cpf` = @cpf, `rg` = @rg, `status` = @status, `cnh` = @cnh, `vencimento` = @vencimento, `categoria` = @categoria, `sexo` = @sexo, `estado_civil` = @estado_civil, `cep` = @cep, `endereco` = @endereco, `n` = @n, `bairro` = @bairro, `complemento` = @complemento, `cidade` = @cidade, `estado` = @estado, `cargo` = @cargo, `telefone` = @telefone, `celular` = @celular, `email` = @email WHERE `id` = @id LIMIT 1;";

            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@cpf", CPF);
                query.Parameters.AddWithValue("@rg", RG);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@cnh", CNH);
                query.Parameters.AddWithValue("@vencimento", DateTime.Parse(Vencimento));
                query.Parameters.AddWithValue("@categoria", Categoria);
                query.Parameters.AddWithValue("@sexo", Sexo);
                query.Parameters.AddWithValue("@estado_civil", EstadoCivil);
                query.Parameters.AddWithValue("@cep", CEP);
                query.Parameters.AddWithValue("@endereco", Endereco);
                query.Parameters.AddWithValue("@n", N);
                query.Parameters.AddWithValue("@bairro", Bairro);
                query.Parameters.AddWithValue("@complemento", Complemento);
                query.Parameters.AddWithValue("@cidade", Cidade);
                query.Parameters.AddWithValue("@estado", Estado);
                query.Parameters.AddWithValue("@cargo", Cargo);
                query.Parameters.AddWithValue("@telefone", Telefone);
                query.Parameters.AddWithValue("@celular", Celular);
                query.Parameters.AddWithValue("@email", Email);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Motorista salvo com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT * FROM `motoristas` WHERE `id` = @id LIMIT 1;";

            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(
                    new {
                        Id = data["id"],
                        Nome = data["nome"],
                        CPF = data["cpf"],
                        RG = data["rg"],
                        Status = data["status"],
                        CNH = data["cnh"],
                        Vencimento = Convert.ToDateTime(data["vencimento"]).ToString("dd/MM/yyyy"),
                        Categoria = data["categoria"],
                        Sexo = data["sexo"],
                        EstadoCivil = data["estado_civil"],
                        CEP = data["cep"],
                        Endereco = data["endereco"],
                        N = data["n"],
                        Bairro = data["bairro"],
                        Complemento = data["complemento"],
                        Cidade = data["cidade"],
                        Estado = data["estado"],
                        Cargo = data["cargo"],
                        Telefone = data["telefone"],
                        Celular = data["celular"],
                        Email = data["email"]
                    }
                );

                data.Close();

                closeConnection();

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `motoristas`;";

            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    Results.Add(
                        new {
                            Id = data["id"],
                            Nome = data["nome"],
                            RG = data["RG"],
                            CPF = data["CPF"],
                            CNH = data["cnh"],
                            Categoria = data["categoria"],
                            Vencimento = Convert.ToDateTime(data["vencimento"]).ToString("dd/MM/yyyy")
                        }
                    );
                }

                data.Close();

                closeConnection();

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
