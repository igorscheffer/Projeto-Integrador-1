using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Clientes : Config {

        public Clientes() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
        public dynamic TipoCadastro { get; set; }
        public dynamic TipoPessoa { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public bool Isento { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string N { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public dynamic Estado { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }

        public void Create() {
            try {
                string sql = "INSERT INTO `clientes` (`tipo_cadastro`, `tipo_pessoa`, `cnpj`, `razao_social`, `nome_fantasia`, `inscricao_municipal`, `inscricao_estadual`, `isento`, `cep`, `endereco`, `n`, `bairro`, `complemento`, `cidade`, `estado`, `nome`, `telefone`, `ramal`, `celular`, `email`, `observacoes`) VALUES (@tipo_cadastro, @tipo_pessoa, @cnpj, @razao_social, @nome_fantasia, @inscricao_municipal, @inscricao_estadual, @isento, @cep, @endereco, @n, @bairro, @complemento, @cidade, @estado, @nome, @telefone, @ramal, @celular, @email, @observacoes);";

                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@tipo_cadastro", TipoCadastro);
                query.Parameters.AddWithValue("@tipo_pessoa", TipoPessoa);
                query.Parameters.AddWithValue("@cnpj", CNPJ);
                query.Parameters.AddWithValue("@razao_social", RazaoSocial);
                query.Parameters.AddWithValue("@nome_fantasia", NomeFantasia);
                query.Parameters.AddWithValue("@inscricao_municipal", InscricaoMunicipal);
                query.Parameters.AddWithValue("@inscricao_estadual", InscricaoEstadual);
                query.Parameters.AddWithValue("@isento", Isento);
                query.Parameters.AddWithValue("@cep", CEP);
                query.Parameters.AddWithValue("@endereco", Endereco);
                query.Parameters.AddWithValue("@n", N);
                query.Parameters.AddWithValue("@bairro", Bairro);
                query.Parameters.AddWithValue("@complemento", Complemento);
                query.Parameters.AddWithValue("@cidade", Cidade);
                query.Parameters.AddWithValue("@estado", Estado);
                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@telefone", Telefone);
                query.Parameters.AddWithValue("@ramal", Ramal);
                query.Parameters.AddWithValue("@celular", Celular);
                query.Parameters.AddWithValue("@email", Email);
                query.Parameters.AddWithValue("@observacoes", Observacoes);

                query.ExecuteNonQuery();

                Close();

                Success = true;
                Message = "Cliente salvo com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            try {
                string sql = "UPDATE `clientes` SET `tipo_cadastro` = @tipo_cadastro, `tipo_pessoa` = @tipo_pessoa, `cnpj` = @cnpj, `razao_social` = @razao_social, `nome_fantasia` = @nome_fantasia, `inscricao_municipal` = @inscricao_municipal, `inscricao_estadual` = @inscricao_estadual, `isento` = @isento, `cep` = @cep, `endereco` = @endereco, `n` = @n, `bairro` = @bairro, `complemento` = @complemento, `cidade` = @cidade, `estado` = @estado, `nome` = @nome, `telefone` = @telefone, `ramal` = @ramal, `celular` = @celular, `email` = @email, `observacoes` = @observacoes WHERE `id` = @id LIMIT 1;";

                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@tipo_cadastro", TipoCadastro);
                query.Parameters.AddWithValue("@tipo_pessoa", TipoPessoa);
                query.Parameters.AddWithValue("@cnpj", CNPJ);
                query.Parameters.AddWithValue("@razao_social", RazaoSocial);
                query.Parameters.AddWithValue("@nome_fantasia", NomeFantasia);
                query.Parameters.AddWithValue("@inscricao_municipal", InscricaoMunicipal);
                query.Parameters.AddWithValue("@inscricao_estadual", InscricaoEstadual);
                query.Parameters.AddWithValue("@isento", Isento);
                query.Parameters.AddWithValue("@cep", CEP);
                query.Parameters.AddWithValue("@endereco", Endereco);
                query.Parameters.AddWithValue("@n", N);
                query.Parameters.AddWithValue("@bairro", Bairro);
                query.Parameters.AddWithValue("@complemento", Complemento);
                query.Parameters.AddWithValue("@cidade", Cidade);
                query.Parameters.AddWithValue("@estado", Estado);
                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@telefone", Telefone);
                query.Parameters.AddWithValue("@ramal", Ramal);
                query.Parameters.AddWithValue("@celular", Celular);
                query.Parameters.AddWithValue("@email", Email);
                query.Parameters.AddWithValue("@observacoes", Observacoes);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                Close();

                Success = true;
                Message = "Cliente salvo com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT * FROM `clientes` WHERE `id` = @id lIMIT 1;";
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(new {
                    Id = data["id"],
                    TipoCadastro = data["tipo_cadastro"],
                    TipoPessoa = data["tipo_pessoa"],
                    CNPJ = data["cnpj"],
                    RazaoSocial = data["razao_social"],
                    NomeFantasia = data["nome_fantasia"],
                    InscricaoMunicipal = data["inscricao_municipal"],
                    InscricaoEstadual = data["inscricao_estadual"],
                    Isento = data["isento"],
                    CEP = data["cep"],
                    Endereco = data["endereco"],
                    N = data["n"],
                    Bairro = data["bairro"],
                    Complemento = data["complemento"],
                    Cidade = data["cidade"],
                    Estado = data["estado"],
                    Nome = data["nome"],
                    Telefone = data["telefone"],
                    Ramal = data["ramal"],
                    Celular = data["celular"],
                    Email = data["email"],
                    Observacoes = data["observacoes"]
                });

                data.Close();

                Close();

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `clientes`;";

            try {
                if (Open()) {
                    MySqlCommand query = new MySqlCommand(sql, Connection);
                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read()) {
                        Results.Add(
                            new {
                                Id = data["id"],
                                TipoCadastro = data["tipo_cadastro"],
                                TipoPessoa = data["tipo_pessoa"],
                                CNPJ = data["cnpj"],
                                RazaoSocial = data["razao_social"],
                                Cidade = data["cidade"],
                                UF = data["estado"]
                            }
                        );
                    }

                    data.Close();

                    Close();
                }

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Delete() {
            string sql = "DELETE FROM `clientes` WHERE `id` = @id LIMIT 1;";
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                Close();

                Success = true;
                Message = "Cliente excluido com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
