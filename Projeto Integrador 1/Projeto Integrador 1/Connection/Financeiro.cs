using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Financeiro : Config {

        public Financeiro() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Referencia { get; set; }
        public string CentroCusto { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
        public string DataEmissao { get; set; }
        public string DataVencimento { get; set; }
        public string Valor { get; set; }
        public string Documento { get; set; }
        public string Ocorrencia { get; set; }
        public string QtdParcelas { get; set; }
        public string Parcelas { get; set; }
        public string Observacoes { get; set; }

        public void Create() {
            string sql = "INSERT INTO `financeiro` (`nome`, `tipo`, `referencia`, `centro_custo`, `forma_pagamento`, `status`, `data_emissao`, `data_vencimento`, `valor`, `documento`, `ocorrencia`, `qtd_parcelas`, `parcelas`, `observacoes`) VALUES (@nome, @tipo, @referencia, @centro_custo, @forma_pagamento, @status, @data_emissao, @data_vencimento, @valor, @documento, @ocorrencia, @qtd_parcelas, @parcelas, @observacoes);";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@tipo", Tipo);
                query.Parameters.AddWithValue("@referencia", Referencia);
                query.Parameters.AddWithValue("@centro_custo", CentroCusto);
                query.Parameters.AddWithValue("@forma_pagamento", FormaPagamento);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@data_emissao", DateTime.Parse(DataEmissao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(DataVencimento));
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@documento", Documento);
                query.Parameters.AddWithValue("@ocorrencia", Ocorrencia);
                query.Parameters.AddWithValue("@qtd_parcelas", Converter.ToIntDB(QtdParcelas, true));
                query.Parameters.AddWithValue("@parcelas", Parcelas);
                query.Parameters.AddWithValue("@observacoes", Observacoes);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Financeiro salvo com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `financeiro` SET `nome` = @nome, `tipo` = @tipo, `referencia` = @referencia, `centro_custo` = @centro_custo, `forma_pagamento` = @forma_pagamento, `status` = @status, `data_emissao` = @data_emissao, `data_vencimento` = @data_vencimento, `valor` = @valor, `documento` = @documento, `ocorrencia` = @ocorrencia, `qtd_parcelas` = @qtd_parcelas, `parcelas` = @parcelas, `observacoes` = @observacoes WHERE `id` = @id LIMIT 1;";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@nome", Nome);
                query.Parameters.AddWithValue("@tipo", Tipo);
                query.Parameters.AddWithValue("@referencia", Referencia);
                query.Parameters.AddWithValue("@centro_custo", CentroCusto);
                query.Parameters.AddWithValue("@forma_pagamento", FormaPagamento);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@data_emissao", DateTime.Parse(DataEmissao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(DataVencimento));
                query.Parameters.AddWithValue("@valor", Valor);
                query.Parameters.AddWithValue("@documento", Documento);
                query.Parameters.AddWithValue("@ocorrencia", Ocorrencia);
                query.Parameters.AddWithValue("@qtd_parcelas", Converter.ToIntDB(QtdParcelas, true));
                query.Parameters.AddWithValue("@parcelas", Parcelas);
                query.Parameters.AddWithValue("@observacoes", Observacoes);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Financeiro salvo com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT * FROM `financeiro` WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(new {
                    Id = data["id"],
                    Nome = data["nome"],
                    Tipo = data["tipo"],
                    Referencia = data["referencia"],
                    CentroCusto = data["centro_custo"],
                    FormaPagamento = data["forma_pagamento"],
                    Status = data["status"],
                    DataEmissao = Converter.DateToString(data["data_emissao"], "dd/MM/yyyy"),
                    DataVencimento = Converter.DateToString(data["data_vencimento"], "dd/MM/yyyy"),
                    Valor = data["valor"],
                    Documento = data["documento"],
                    Ocorrencia = data["ocorrencia"],
                    QtdParcelas = data["qtd_parcelas"],
                    Parcelas = data["parcelas"],
                    Observacoes = data["observacoes"]
                });

                Success = true;
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `financeiro`;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    Results.Add(new {
                        Id = data["id"],
                        Nome = data["nome"],
                        Tipo = data["tipo"],
                        Referencia = data["referencia"],
                        CentroCusto = data["centro_custo"],
                        FormaPagamento = data["forma_pagamento"],
                        Status = data["status"],
                        DataEmissao = Converter.DateToString(data["data_emissao"], "dd/MM/yyyy"),
                        DataVencimento = Converter.DateToString(data["data_vencimento"], "dd/MM/yyyy"),
                        Valor = data["valor"],
                        Documento = data["documento"],
                        Ocorrencia = data["ocorrencia"],
                        QtdParcelas = data["qtd_parcelas"],
                        Parcelas = data["parcelas"],
                        Observacoes = data["observacoes"]
                    });
                }

                Success = true;
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Delete() {
            string sql = "DELETE FROM `financeiro` WHERE `id` = @id LIMIT 1;";
            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Financeiro excluido com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
