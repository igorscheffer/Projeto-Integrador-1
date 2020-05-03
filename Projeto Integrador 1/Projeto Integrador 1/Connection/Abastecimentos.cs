using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Abastecimentos : Config {
        public Abastecimentos() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
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
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@viagem", Viagem);
                query.Parameters.AddWithValue("@posto", Posto);
                query.Parameters.AddWithValue("@veiculo", Converter.ToIntDB(Veiculo, true));
                query.Parameters.AddWithValue("@motorista", Converter.ToIntDB(Motorista, true));
                query.Parameters.AddWithValue("@data", DateTime.Parse(Data));
                query.Parameters.AddWithValue("@cupom", Cupom);
                query.Parameters.AddWithValue("@combustivel", Combustivel);
                query.Parameters.AddWithValue("@hodometro", Converter.ToIntDB(Hodometro, true));
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@litros", Litros);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@total", Total);

                query.ExecuteNonQuery();

                Success = true;
                Message = "Abastecimento salvo com sucesso.";

            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `abastecimentos` SET `viagem` = @viagem, `posto` = @posto, `veiculo` = @veiculo, `motorista` = @motorista, `data` = @data, `cupom` = @cupom, `combustivel` = @combustivel, `hodometro` = @hodometro, `status` = @status, `litros` = @litros, `valor` = @valor, `total` = @total WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@viagem", Viagem);
                query.Parameters.AddWithValue("@posto", Posto);
                query.Parameters.AddWithValue("@veiculo", Converter.ToIntDB(Veiculo, true));
                query.Parameters.AddWithValue("@motorista", Converter.ToIntDB(Motorista, true));
                query.Parameters.AddWithValue("@data", DateTime.Parse(Data));
                query.Parameters.AddWithValue("@cupom", Cupom);
                query.Parameters.AddWithValue("@combustivel", Combustivel);
                query.Parameters.AddWithValue("@hodometro", Converter.ToIntDB(Hodometro, true));
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@litros", Litros);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@total", Total);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                Success = true;
                Message = "Abastecimento salvo com sucesso.";

            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT `abastecimentos`.*, `clientes`.`razao_social` AS `posto_nome`, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `abastecimentos` LEFT OUTER JOIN `clientes` ON (`abastecimentos`.`posto` = `clientes`.`id`) LEFT OUTER JOIN `veiculos` ON (`abastecimentos`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`abastecimentos`.`motorista` = `motoristas`.`id`) WHERE `abastecimentos`.`id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(new {
                    Id = data["id"],
                    Viagem = data["viagem"],
                    Posto = data["posto"],
                    Combustivel = data["combustivel"],
                    Veiculo = data["veiculo"],
                    Motorista = data["motorista"],
                    Data = Converter.DateToString(data["data"], "dd/MM/yyyy HH:mm"),
                    Cupom = data["cupom"],
                    Hodometro = data["hodometro"],
                    Status = data["status"],
                    Litros = data["litros"],
                    Valor = data["valor"],
                    Total = data["total"]
                });

                data.Close();

                CloseConnection();

                Success = true;
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT `abastecimentos`.*, `clientes`.`razao_social` AS `posto_nome`, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `abastecimentos` LEFT OUTER JOIN `clientes` ON (`abastecimentos`.`posto` = `clientes`.`id`) LEFT OUTER JOIN `veiculos` ON (`abastecimentos`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`abastecimentos`.`motorista` = `motoristas`.`id`);";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    Results.Add(new {
                        Id = data["id"],
                        Data = Converter.DateToString(data["data"], "dd/MM/yyyy HH:mm"),
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

                CloseConnection();

                Success = true;
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Delete() {
            string sql = "DELETE FROM `abastecimentos` WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Abastecimento excluido com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
