using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection {
    class Abastecimentos : Config {
        public Abastecimentos() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();
        public int Viagem { get; set; }
        public dynamic Posto { get; set; }
        public dynamic Combustivel { get; set; }
        public dynamic Veiculo { get; set; }
        public dynamic Motorista { get; set; }
        public string Data { get; set; }
        public string Cupom { get; set; }
        public string Hodometro { get; set; }
        public dynamic Status { get; set; }
        public string Litros { get; set; }
        public string Valor { get; set; }
        public string Total { get; set; }
        public void Create() {
            string sql = "INSERT INTO `abastecimentos`(`viagem`, `posto`, `veiculo`, `motorista`, `data`, `cupom`, `combustivel`, `hodometro`, `status`, `litros`, `valor`, `total`) VALUES (@viagem, @posto, @veiculo, @motorista, @data, @cupom, @combustivel, @hodometro, @status, @litros, @valor, @total);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@viagem", this.Viagem);
                query.Parameters.AddWithValue("@posto", this.Posto);
                query.Parameters.AddWithValue("@veiculo", this.Veiculo);
                query.Parameters.AddWithValue("@motorista", this.Motorista);
                query.Parameters.AddWithValue("@data", DateTime.Parse(this.Data));
                query.Parameters.AddWithValue("@cupom", this.Cupom);
                query.Parameters.AddWithValue("@combustivel", this.Combustivel);
                query.Parameters.AddWithValue("@hodometro", this.Hodometro);
                query.Parameters.AddWithValue("@status", this.Status);
                query.Parameters.AddWithValue("@litros", this.Litros);
                query.Parameters.AddWithValue("@valor", this.Valor);
                query.Parameters.AddWithValue("@total", this.Total);

                query.ExecuteNonQuery();

                this.Success = true;
                this.Message = "Abastecimento salvo com sucesso."; 

            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }
        public void GetAll() {
            string sql = "SELECT `abastecimentos`.*, `clientes`.`razao_social` AS `posto_nome`, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `abastecimentos` LEFT OUTER JOIN `clientes` ON (`abastecimentos`.`posto` = `clientes`.`id`) LEFT OUTER JOIN `veiculos` ON (`abastecimentos`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`abastecimentos`.`motorista` = `motoristas`.`id`);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    this.Results.Add(new {
                        Data = data["data"],
                        Placa = data["veiculo_placa"],
                        Posto = data["posto_nome"],
                        Combustivel = data["combustivel"],
                        Litros = data["litros"],
                        Valor = data["valor"],
                        Total = data["total"],
                        Hodometro = data["hodometro"],
                        Status = data["status"]
                    });
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
