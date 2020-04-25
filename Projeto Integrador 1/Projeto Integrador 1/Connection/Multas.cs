using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection {
    class Multas : Config{
        public Multas() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

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

                query.Parameters.AddWithValue("@veiculo", this.Veiculo);
                query.Parameters.AddWithValue("@motorista", this.Motorista);
                query.Parameters.AddWithValue("@gravidade", this.Gravidade);
                query.Parameters.AddWithValue("@status", this.Status);
                query.Parameters.AddWithValue("@data_ocorrencia", DateTime.Parse(this.DataOcorrencia));
                query.Parameters.AddWithValue("@data_notificacao", DateTime.Parse(this.DataNotificacao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(this.DataVencimento));
                query.Parameters.AddWithValue("@valor", this.Valor);
                query.Parameters.AddWithValue("@descricao", this.Descricao);
                query.Parameters.AddWithValue("@local", this.Local);

                query.ExecuteNonQuery();

                closeConnection();

                this.Success = true;
                this.Message = "Multa salva com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT `multas`.*, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `multas` LEFT OUTER JOIN `veiculos` ON (`multas`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`multas`.`motorista` = `motoristas`.`id`);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    this.Results.Add(
                        new {
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

                this.Success = true;
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }
    }
}
