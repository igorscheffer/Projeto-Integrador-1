using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection
{
    class Motoristas : Config{

        public Motoristas() { }

        public bool Success;
        public string Message;
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
            try
            {
                string sql = "INSERT INTO `motoristas` (`nome`, `cpf`, `rg`, `status`, `cnh`, `vencimento`, `categoria`, `sexo`, `estado_civil`, `cep`, `endereco`, `n`, `bairro`, `complemento`, `cidade`, `estado`, `cargo`, `telefone`, `celular`, `email`) VALUES (@nome, @cpf, @rg, @status, @cnh, @vencimento, @categoria, @sexo, @estado_civil, @cep, @endereco, @n, @bairro, @complemento, @cidade, @estado, @cargo, @telefone, @celular, @email);";

                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);

                    query.Parameters.AddWithValue("@nome", this.Nome);
                    query.Parameters.AddWithValue("@cpf", this.CNH);
                    query.Parameters.AddWithValue("@rg", this.RG);
                    query.Parameters.AddWithValue("@status", this.Status);
                    query.Parameters.AddWithValue("@cnh", this.CNH);
                    query.Parameters.AddWithValue("@vencimento", this.Vencimento);
                    query.Parameters.AddWithValue("@categoria", this.Categoria);
                    query.Parameters.AddWithValue("@sexo", this.Sexo);
                    query.Parameters.AddWithValue("@estado_civil", this.EstadoCivil);
                    query.Parameters.AddWithValue("@cep", this.CEP);
                    query.Parameters.AddWithValue("@endereco", this.Endereco);
                    query.Parameters.AddWithValue("@n", this.N);
                    query.Parameters.AddWithValue("@bairro", this.Bairro);
                    query.Parameters.AddWithValue("@complemento", this.Complemento);
                    query.Parameters.AddWithValue("@cidade", this.Cidade);
                    query.Parameters.AddWithValue("@estado", this.Estado);
                    query.Parameters.AddWithValue("@cargo", this.Cargo);
                    query.Parameters.AddWithValue("@telefone", this.Telefone);
                    query.Parameters.AddWithValue("@celular", this.Celular);
                    query.Parameters.AddWithValue("@email", this.Email);

                    query.ExecuteNonQuery();

                    closeConnection();
                }

                this.Success = true;
                this.Message = "Motorista salvo com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }
    }
}
