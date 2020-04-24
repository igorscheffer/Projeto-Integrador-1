using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection
{
    class Clientes : Config {

        public Clientes() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

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

                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@tipo_cadastro", this.TipoCadastro);
                query.Parameters.AddWithValue("@tipo_pessoa", this.TipoPessoa);
                query.Parameters.AddWithValue("@cnpj", this.CNPJ);
                query.Parameters.AddWithValue("@razao_social", this.RazaoSocial);
                query.Parameters.AddWithValue("@nome_fantasia", this.NomeFantasia);
                query.Parameters.AddWithValue("@inscricao_municipal", this.InscricaoMunicipal);
                query.Parameters.AddWithValue("@inscricao_estadual", this.InscricaoEstadual);
                query.Parameters.AddWithValue("@isento", this.Isento);
                query.Parameters.AddWithValue("@cep", this.CEP);
                query.Parameters.AddWithValue("@endereco", this.Endereco);
                query.Parameters.AddWithValue("@n", this.N);
                query.Parameters.AddWithValue("@bairro", this.Bairro);
                query.Parameters.AddWithValue("@complemento", this.Complemento);
                query.Parameters.AddWithValue("@cidade", this.Cidade);
                query.Parameters.AddWithValue("@estado", this.Estado);
                query.Parameters.AddWithValue("@nome", this.Nome);
                query.Parameters.AddWithValue("@telefone", this.Telefone);
                query.Parameters.AddWithValue("@ramal", this.Ramal);
                query.Parameters.AddWithValue("@celular", this.Celular);
                query.Parameters.AddWithValue("@email", this.Email);
                query.Parameters.AddWithValue("@observacoes", this.Observacoes);

                query.ExecuteNonQuery();

                closeConnection();

                this.Success = true;
                this.Message = "Cliente salvo com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `clientes`;";

            try {
                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);
                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read()) {
                        this.Results.Add(
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

                    closeConnection();
                }

                this.Success = true;
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }
    }
}
