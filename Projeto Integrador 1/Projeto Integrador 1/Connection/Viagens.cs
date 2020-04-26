using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Viagens : Config {
        public Viagens() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public dynamic Remetente { get; set; }
        public dynamic Destinatario { get; set; }
        public dynamic Tomador { get; set; }
        public string CodigoInterno { get; set; }
        public dynamic TipoViagem { get; set; }
        public dynamic Veiculo { get; set; }
        public dynamic Reboque { get; set; }
        public dynamic Motorista { get; set; }
        public string SaidaCidade { get; set; }
        public dynamic SaidaUF { get; set; }
        public string DestinoCidade { get; set; }
        public dynamic DestinoUF { get; set; }
        public dynamic Status { get; set; }
        public string DataSaida { get; set; }
        public string DataEntrega { get; set; }
        public string DataChegada { get; set; }
        public string HodometroSaida { get; set; }
        public string HodometroEntrega { get; set; }
        public string HodometroChegada { get; set; }
        public string HodometroPercorrido { get; set; }
        public string Valor { get; set; }
        public string InformacoesComplementares { get; set; }
        public string Cargas { get; set; }
        public string Custos { get; set; }
        public string Abastecimentos { get; set; }

        public void Create() {
            string sql = "INSERT INTO `viagens` (`remetente`, `destinatario`, `tomador`, `codigo_interno`, `tipo_viagem`, `veiculo`, `reboque`, `motorista`, `saida_cidade`, `saida_uf`, `destino_cidade`, `destino_uf`, `status`, `data_saida`, `data_entrega`, `data_chegada`, `hodometro_saida`, `hodometro_entrega`, `hodometro_percorrido`, `valor`, `informacoes_complementares`, `cargas`, `custos`, `abastecimentos`) VALUES (@remetente, @destinatario, @tomador, @codigo_interno, @tipo_viagem, @veiculo, @reboque, @motorista, @saida_cidade, @saida_uf, @destino_cidade, @destino_uf, @status, @data_saida, @data_entrega, @data_chegada, @hodometro_saida, @hodometro_entrega, @hodometro_percorrido, @valor, @informacoes_complementares, @cargas, @custos, @abastecimentos);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@remetente", Remetente);
                query.Parameters.AddWithValue("@destinatario", Destinatario);
                query.Parameters.AddWithValue("@tomador", Tomador);
                query.Parameters.AddWithValue("@codigo_interno", CodigoInterno);
                query.Parameters.AddWithValue("@tipo_viagem", TipoViagem);
                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@reboque", Reboque);
                query.Parameters.AddWithValue("@motorista", Motorista);
                query.Parameters.AddWithValue("@saida_cidade", SaidaCidade);
                query.Parameters.AddWithValue("@saida_uf", SaidaUF);
                query.Parameters.AddWithValue("@destino_cidade", DestinoCidade);
                query.Parameters.AddWithValue("@destino_uf", DestinoUF);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@data_saida", DateTime.Parse(DataSaida));
                query.Parameters.AddWithValue("@data_entrega", DateTime.Parse(DataEntrega));
                query.Parameters.AddWithValue("@data_chegada", DateTime.Parse(DataChegada));
                query.Parameters.AddWithValue("@hodometro_saida", HodometroSaida);
                query.Parameters.AddWithValue("@hodometro_entrega", HodometroEntrega);
                query.Parameters.AddWithValue("@hodometro_percorrido", HodometroPercorrido);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@informacoes_complementares", InformacoesComplementares);
                query.Parameters.AddWithValue("@cargas", Cargas);
                query.Parameters.AddWithValue("@custos", Custos);
                query.Parameters.AddWithValue("@abastecimentos", Abastecimentos);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Viagem salva com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT `viagens`.*, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `viagens` LEFT OUTER JOIN `veiculos` ON (`viagens`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`viagens`.`motorista` = `motoristas`.`id`);";

            try {
                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);

                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read()) {
                        Results.Add(new {
                            Id = data["id"],
                            CodigoInterno = data["codigo_interno"],
                            DataSaida = data["data_saida"],
                            DataChegada = data["data_chegada"],
                            SaidaCidade = data["saida_cidade"],
                            SaidaUF = data["saida_uf"],
                            DestinoCidade = data["destino_cidade"],
                            DestinoUF = data["destino_uf"],
                            Placa = data["veiculo_placa"],
                            Motorista = data["motorista_nome"],
                            Status = data["status"]
                        }
                        );
                    }

                    data.Close();

                    closeConnection();
                }

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
