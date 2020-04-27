using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Multa {
        public int Id { get; set; }
        public int Veiculo { get; set; }
        public int Motorista { get; set; }
        public int Gravidade { get; set; }
        public int Status { get; set; }
        public string DataOcorrencia { get; set; }
        public string DataNotificacao { get; set; }
        public string DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
    }
    class Multas : Config {
        public Multas() { }

        public bool Success;
        public string Message;
        public List<object> Results = new List<dynamic>();

        public int Id { get; set; }
        public dynamic Veiculo { get; set; }
        public dynamic Motorista { get; set; }
        public dynamic Gravidade { get; set; }
        public dynamic Status { get; set; }
        public string DataOcorrencia { get; set; }
        public string DataNotificacao { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }

        public void Create() {
            string sql = "INSERT INTO `multas`(`veiculo`, `motorista`, `gravidade`, `status`, `data_ocorrencia`, `data_notificacao`, `data_vencimento`, `valor`, `descricao`, `local`) VALUES (@veiculo, @motorista, @gravidade, @status, @data_ocorrencia, @data_notificacao, @data_vencimento, @valor, @descricao, @local);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@motorista", Motorista);
                query.Parameters.AddWithValue("@gravidade", Gravidade);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@data_ocorrencia", DateTime.Parse(DataOcorrencia));
                query.Parameters.AddWithValue("@data_notificacao", DateTime.Parse(DataNotificacao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(DataVencimento));
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@descricao", Descricao);
                query.Parameters.AddWithValue("@local", Local);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Multa salva com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `multas` SET `veiculo` = @veiculo, `motorista` = @motorista, `gravidade` = @gravidade, `status` = @status, `data_ocorrencia` = @data_ocorrencia, `data_notificacao` = @data_notificacao, `data_vencimento` = @data_vencimento, `valor` = @valor, `descricao` = @descricao, `local` = @local WHERE `id` = @id LIMIT 1;";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@motorista", Motorista);
                query.Parameters.AddWithValue("@gravidade", Gravidade);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@data_ocorrencia", DateTime.Parse(DataOcorrencia));
                query.Parameters.AddWithValue("@data_notificacao", DateTime.Parse(DataNotificacao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(DataVencimento));
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@descricao", Descricao);
                query.Parameters.AddWithValue("@local", Local);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Multa salva com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT `multas`.*, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `multas` LEFT OUTER JOIN `veiculos` ON (`multas`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`multas`.`motorista` = `motoristas`.`id`) WHERE `multas`.`id` = @id LIMIT 1;";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(
                    new {
                        Id = data["id"],
                        Veiculo = data["veiculo"],
                        Motorista = data["motorista"],
                        Gravidade = data["gravidade"],
                        Status = data["status"],
                        DataOcorrencia = Convert.ToDateTime(data["data_ocorrencia"]).ToString("dd/MM/yyyy"),
                        DataNotificacao = Convert.ToDateTime(data["data_notificacao"]).ToString("dd/MM/yyyy"),
                        DataVencimento = Convert.ToDateTime(data["data_vencimento"]).ToString("dd/MM/yyyy"),
                        Valor = data["valor"],
                        Descricao = data["descricao"],
                        Local = data["local"]
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
            string sql = "SELECT `multas`.*, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `multas` LEFT OUTER JOIN `veiculos` ON (`multas`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`multas`.`motorista` = `motoristas`.`id`);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    Results.Add(
                        new {
                            Id = data["id"],
                            DataOcorrencia = Convert.ToDateTime(data["data_ocorrencia"]).ToString("dd/MM/yyyy"),
                            Placa = data["veiculo_placa"],
                            Motorista = data["motorista_nome"],
                            Descricao = data["descricao"],
                            Gravidade = data["gravidade"],
                            Valor = data["valor"],
                            DataVencimento = Convert.ToDateTime(data["data_vencimento"]).ToString("dd/MM/yyyy"),
                            Status = data["status"]
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
