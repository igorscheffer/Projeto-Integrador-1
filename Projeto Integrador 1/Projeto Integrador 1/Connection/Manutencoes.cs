using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Manutencoes : Config {

        public Manutencoes() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public dynamic Tipo { get; set; }
        public dynamic Preventiva { get; set; }
        public dynamic Veiculo { get; set; }
        public dynamic Status { get; set; }
        public dynamic Motorista { get; set; }
        public string DataAgendada { get; set; }
        public string DataRealizada { get; set; }
        public string HodometroAgendado { get; set; }
        public string HodometroRealizado { get; set; }
        public string Observacoes { get; set; }
        public string OrdemServico { get; set; }
        public dynamic Fornecedor { get; set; }
        public string MaoObra { get; set; }
        public string Desconto { get; set; }
        public string Acrecimo { get; set; }
        public string Valor { get; set; }
        public string Itens { get; set; }

        public void Create() {
            string sql = "INSERT INTO `manutencoes`(`tipo`, `preventiva`, `veiculo`, `status`, `motorista`, `data_agendada`, `data_realizada`, `hodometro_agendado`, `hodometro_realizado`, `observacoes`, `ordem_servico`, `fornecedor`, `mao_obra`, `desconto`, `acrecimo`, `valor`, `itens`) VALUES (@tipo, @preventiva, @veiculo, @status, @motorista, @data_agendada, @data_realizada, @hodometro_agendado, @hodometro_realizado, @observacoes, @ordem_servico, @fornecedor, @mao_obra, @desconto, @acrecimo, @valor, @itens);";
            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

                query.Parameters.AddWithValue("@tipo", Tipo);
                query.Parameters.AddWithValue("@preventiva", Preventiva);
                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@motorista", Motorista);
                query.Parameters.AddWithValue("@data_agendada", DateTime.Parse(DataAgendada));
                query.Parameters.AddWithValue("@data_realizada", DateTime.Parse(DataRealizada));
                query.Parameters.AddWithValue("@hodometro_agendado", HodometroAgendado);
                query.Parameters.AddWithValue("@hodometro_realizado", HodometroRealizado);
                query.Parameters.AddWithValue("@observacoes", Observacoes);
                query.Parameters.AddWithValue("@ordem_servico", OrdemServico);
                query.Parameters.AddWithValue("@fornecedor", Fornecedor);
                query.Parameters.AddWithValue("@mao_obra", MaoObra);
                query.Parameters.AddWithValue("@desconto", Desconto);
                query.Parameters.AddWithValue("@acrecimo", Acrecimo);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@itens", Itens);

                query.ExecuteNonQuery();

                closeConnection();

                Success = true;
                Message = "Manutenção salva com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT `manutencoes`.*, `veiculos`.`placa` AS `veiculo_placa`, `veiculos`.`marca` AS `veiculo_marca`, `veiculos`.`modelo` AS `veiculo_modelo`, `motoristas`.`nome` AS `motorista_nome`, `clientes`.`razao_social` AS `fornecedor_nome` FROM `manutencoes` LEFT OUTER JOIN `veiculos` ON (`manutencoes`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`manutencoes`.`motorista` = `motoristas`.`id`) LEFT OUTER JOIN `clientes` ON (`manutencoes`.`fornecedor` = `clientes`.`id`);";

            PreencherCombBox preValues = new Util.PreencherCombBox();
            List<dynamic> marcas = preValues.getVeiculosMarcas();

            try {
                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    dynamic marca = marcas.Find(item => item.Value == Int16.Parse(data["veiculo_marca"].ToString()));

                    Results.Add(
                        new {
                            Id = data["id"],
                            DataAgendada = data["data_agendada"],
                            DataRealizada = data["data_realizada"],
                            Tipo = data["tipo"],
                            Placa = data["veiculo_placa"],
                            Veiculo = (data["veiculo_placa"] + " - " + data["veiculo_placa"] + " " + marca.Text + " " + data["veiculo_modelo"]).ToUpper(),
                            Fornecedor = data["fornecedor_nome"],
                            Valor = data["valor"],
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
