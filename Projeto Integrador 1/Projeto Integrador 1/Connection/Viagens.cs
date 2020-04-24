using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection
{
    class Viagens : Config
    {
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

                query.Parameters.AddWithValue("@remetente", this.Remetente);
                query.Parameters.AddWithValue("@destinatario", this.Destinatario);
                query.Parameters.AddWithValue("@tomador", this.Tomador);
                query.Parameters.AddWithValue("@codigo_interno", this.CodigoInterno);
                query.Parameters.AddWithValue("@tipo_viagem", this.TipoViagem);
                query.Parameters.AddWithValue("@veiculo", this.Veiculo);
                query.Parameters.AddWithValue("@reboque", this.Reboque);
                query.Parameters.AddWithValue("@motorista", this.Motorista);
                query.Parameters.AddWithValue("@saida_cidade", this.SaidaCidade);
                query.Parameters.AddWithValue("@saida_uf", this.SaidaUF);
                query.Parameters.AddWithValue("@destino_cidade", this.DestinoCidade);
                query.Parameters.AddWithValue("@destino_uf", this.DestinoUF);
                query.Parameters.AddWithValue("@status", this.Status);
                query.Parameters.AddWithValue("@data_saida", DateTime.Parse(this.DataSaida));
                query.Parameters.AddWithValue("@data_entrega", DateTime.Parse(this.DataEntrega));
                query.Parameters.AddWithValue("@data_chegada", DateTime.Parse(this.DataChegada));
                query.Parameters.AddWithValue("@hodometro_saida", this.HodometroSaida);
                query.Parameters.AddWithValue("@hodometro_entrega", this.HodometroEntrega);
                query.Parameters.AddWithValue("@hodometro_percorrido", this.HodometroPercorrido);
                query.Parameters.AddWithValue("@valor", this.Valor);
                query.Parameters.AddWithValue("@informacoes_complementares", this.InformacoesComplementares);
                query.Parameters.AddWithValue("@cargas", this.Cargas);
                query.Parameters.AddWithValue("@custos", this.Custos);
                query.Parameters.AddWithValue("@abastecimentos", this.Abastecimentos);

                query.ExecuteNonQuery();

                closeConnection();

                this.Success = true;
                this.Message = "Viagem salva com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void GetAll()
        {
            string sql = "SELECT `viagens`.*, `veiculos`.`placa` AS `veiculo_placa`, `motoristas`.`nome` AS `motorista_nome` FROM `viagens` LEFT OUTER JOIN `veiculos` ON (`viagens`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`viagens`.`motorista` = `motoristas`.`id`);";

            try
            {
                if (openConnection())
                {
                    MySqlCommand query = new MySqlCommand(sql, connection);
                    
                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read())
                    {
                        this.Results.Add(
                            new
                            {
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

                this.Success = true;
            }
            catch (MySqlException e)
            {
                this.Success = false;
                this.Message = e.Message;
            }
        }
    }
}
