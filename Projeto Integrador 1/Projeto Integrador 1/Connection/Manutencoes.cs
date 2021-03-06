﻿using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Manutencoes : Config {

        public Manutencoes() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
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
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@tipo", Tipo);
                query.Parameters.AddWithValue("@preventiva", Converter.ToIntDB(Preventiva, true));
                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@motorista", Converter.ToIntDB(Motorista, true));
                query.Parameters.AddWithValue("@data_agendada", DateTime.Parse(DataAgendada));
                query.Parameters.AddWithValue("@data_realizada", (!string.IsNullOrWhiteSpace(DataRealizada) ? (object)DateTime.Parse(DataRealizada) : DBNull.Value));
                query.Parameters.AddWithValue("@hodometro_agendado", HodometroAgendado);
                query.Parameters.AddWithValue("@hodometro_realizado", Converter.ToIntDB(HodometroRealizado, true));
                query.Parameters.AddWithValue("@observacoes", Observacoes);
                query.Parameters.AddWithValue("@ordem_servico", OrdemServico);
                query.Parameters.AddWithValue("@fornecedor", Converter.ToIntDB(Fornecedor, true));
                query.Parameters.AddWithValue("@mao_obra", MaoObra);
                query.Parameters.AddWithValue("@desconto", Desconto);
                query.Parameters.AddWithValue("@acrecimo", Acrecimo);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@itens", Itens);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Manutenção salva com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `manutencoes` SET `tipo` = @tipo, `preventiva` = @preventiva, `veiculo` = @veiculo, `status` = @status, `motorista` = @motorista, `data_agendada` = @data_agendada, `data_realizada` = @data_realizada, `hodometro_agendado` = @hodometro_agendado, `hodometro_realizado` = @hodometro_realizado, `observacoes` = @observacoes, `ordem_servico` = @ordem_servico, `fornecedor` = @fornecedor, `mao_obra` = @mao_obra, `desconto` = @desconto, `acrecimo` = @acrecimo, `valor` = @valor, `itens` = @itens WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@tipo", Tipo);
                query.Parameters.AddWithValue("@preventiva", Converter.ToIntDB(Preventiva, true));
                query.Parameters.AddWithValue("@veiculo", Veiculo);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@motorista", Motorista);
                query.Parameters.AddWithValue("@data_agendada", DateTime.Parse(DataAgendada));
                query.Parameters.AddWithValue("@data_realizada", (!string.IsNullOrWhiteSpace(DataRealizada) ? (object)DateTime.Parse(DataRealizada) : DBNull.Value));
                query.Parameters.AddWithValue("@hodometro_agendado", HodometroAgendado);
                query.Parameters.AddWithValue("@hodometro_realizado", Converter.ToIntDB(HodometroRealizado, true));
                query.Parameters.AddWithValue("@observacoes", Observacoes);
                query.Parameters.AddWithValue("@ordem_servico", OrdemServico);
                query.Parameters.AddWithValue("@fornecedor", Converter.ToIntDB(Fornecedor, true));
                query.Parameters.AddWithValue("@mao_obra", MaoObra);
                query.Parameters.AddWithValue("@desconto", Desconto);
                query.Parameters.AddWithValue("@acrecimo", Acrecimo);
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@itens", Itens);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Manutenção salva com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT `manutencoes`.*, `veiculos`.`placa` AS `veiculo_placa`, `veiculos`.`marca` AS `veiculo_marca`, `veiculos`.`modelo` AS `veiculo_modelo`, `motoristas`.`nome` AS `motorista_nome`, `clientes`.`razao_social` AS `fornecedor_nome` FROM `manutencoes` LEFT OUTER JOIN `veiculos` ON (`manutencoes`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`manutencoes`.`motorista` = `motoristas`.`id`) LEFT OUTER JOIN `clientes` ON (`manutencoes`.`fornecedor` = `clientes`.`id`) WHERE `manutencoes`.`id` = @id LIMIT 1;";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(
                    new {
                        Id = data["id"],
                        Tipo = data["tipo"],
                        Preventiva = data["preventiva"],
                        Veiculo = data["veiculo"],
                        Status = data["status"],
                        Motorista = data["motorista"],
                        DataAgendada = Converter.DateToString(data["data_agendada"], "dd/MM/yyyy HH:mm"),
                        DataRealizada = Converter.DateToString(data["data_realizada"], "dd/MM/yyyy HH:mm"),
                        HodometroAgendado = data["hodometro_agendado"],
                        HodometroRealizado = data["hodometro_realizado"],
                        Observacoes = data["observacoes"],
                        OrdemServico = data["ordem_servico"],
                        Fornecedor = data["fornecedor"],
                        MaoObra = data["mao_obra"],
                        Desconto = data["desconto"],
                        Acrecimo = data["acrecimo"],
                        Valor = data["valor"],
                        Itens = data["itens"]
                    }
                );

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
            string sql = "SELECT `manutencoes`.*, `veiculos`.`placa` AS `veiculo_placa`, `veiculos`.`marca` AS `veiculo_marca`, `veiculos`.`modelo` AS `veiculo_modelo`, `motoristas`.`nome` AS `motorista_nome`, `clientes`.`razao_social` AS `fornecedor_nome` FROM `manutencoes` LEFT OUTER JOIN `veiculos` ON (`manutencoes`.`veiculo` = `veiculos`.`id`) LEFT OUTER JOIN `motoristas` ON (`manutencoes`.`motorista` = `motoristas`.`id`) LEFT OUTER JOIN `clientes` ON (`manutencoes`.`fornecedor` = `clientes`.`id`);";

            List<dynamic> ListaMarcas = Listas.VeiculosMarcas;

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    string marca = string.Empty;

                    if (!string.IsNullOrEmpty(Convert.ToString(data["veiculo_placa"]))) {
                        marca = ListaMarcas.Find(item => item.Value == Int16.Parse(data["veiculo_marca"].ToString())).Text;
                    }

                    Results.Add(
                        new {
                            Id = data["id"],
                            DataAgendada = Converter.DateToString(data["data_agendada"], "dd/MM/yyyy HH:mm"),
                            DataRealizada = Converter.DateToString(data["data_realizada"], "dd/MM/yyyy HH:mm"),
                            Tipo = data["tipo"],
                            Placa = data["veiculo_placa"],
                            Veiculo = (data["veiculo_placa"] + " - " + data["veiculo_placa"] + " " + marca + " " + data["veiculo_modelo"]).ToUpper(),
                            Fornecedor = data["fornecedor_nome"],
                            Valor = data["valor"],
                            Status = data["status"]
                        }
                    );
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
            string sql = "DELETE FROM `manutencoes` WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Manutenção excluida com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
