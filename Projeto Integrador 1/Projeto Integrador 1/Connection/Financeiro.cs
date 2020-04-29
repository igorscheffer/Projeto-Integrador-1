using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection {
    class Financeiro : Config {

        public Financeiro() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
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
            string sql = "INSERT INTO `financeiro` (`nome`, `tipo`, `centro_custo`, `forma_pagamento`, `status`, `data_emissao`, `data_vencimento`, `valor`, `documento`, `ocorrencia`, `qtd_parcelas`, `parcelas`, `observacoes`) VALUES (@nome, @tipo, @centro_custo, @forma_pagamento, @status, @data_emissao, @data_vencimento, @valor, @documento, @ocorrencia, @qtd_parcelas, @parcelas, @observacoes);";
            
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@nome", this.Nome);
                query.Parameters.AddWithValue("@tipo", this.Tipo);
                query.Parameters.AddWithValue("@centro_custo", this.CentroCusto);
                query.Parameters.AddWithValue("@forma_pagamento", this.FormaPagamento);
                query.Parameters.AddWithValue("@status", this.Status);
                query.Parameters.AddWithValue("@data_emissao", DateTime.Parse(this.DataEmissao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(this.DataVencimento));
                query.Parameters.AddWithValue("@valor", this.Valor);
                query.Parameters.AddWithValue("@documento", this.Documento);
                query.Parameters.AddWithValue("@ocorrencia", this.Ocorrencia);
                query.Parameters.AddWithValue("@qtd_parcelas", this.QtdParcelas);
                query.Parameters.AddWithValue("@parcelas", this.Parcelas);
                query.Parameters.AddWithValue("@observacoes", this.Observacoes);

                query.ExecuteNonQuery();

                Close();

                this.Success = true;
                this.Message = "Financeiro salvo com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `financeiro` SET `nome` = @nome, `tipo` = @tipo, `centro_custo` = @centro_custo, `forma_pagamento` = @forma_pagamento, `status` = @status, `data_emissao` = @data_emissao, `data_vencimento` = @data_vencimento, `valor` = @valor, `documento` = @documento, `ocorrencia` = @ocorrencia, `qtd_parcelas` = @qtd_parcelas, `parcelas` = @parcelas, `observacoes` = @observacoes WHERE `id` = @id LIMIT 1;";

            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@nome", this.Nome);
                query.Parameters.AddWithValue("@tipo", this.Tipo);
                query.Parameters.AddWithValue("@centro_custo", this.CentroCusto);
                query.Parameters.AddWithValue("@forma_pagamento", this.FormaPagamento);
                query.Parameters.AddWithValue("@status", this.Status);
                query.Parameters.AddWithValue("@data_emissao", DateTime.Parse(this.DataEmissao));
                query.Parameters.AddWithValue("@data_vencimento", DateTime.Parse(this.DataVencimento));
                query.Parameters.AddWithValue("@valor", this.Valor);
                query.Parameters.AddWithValue("@documento", this.Documento);
                query.Parameters.AddWithValue("@ocorrencia", this.Ocorrencia);
                query.Parameters.AddWithValue("@qtd_parcelas", this.QtdParcelas);
                query.Parameters.AddWithValue("@parcelas", this.Parcelas);
                query.Parameters.AddWithValue("@observacoes", this.Observacoes);
                query.Parameters.AddWithValue("@id", this.Id);

                query.ExecuteNonQuery();

                Close();

                this.Success = true;
                this.Message = "Financeiro salvo com sucesso.";
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT * FROM `financeiro` WHERE `id` = @id LIMIT 1;";
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", this.Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                this.Results.Add(new {
                    Id = data["id"],
                    Nome = data["nome"],
                    Tipo = data["tipo"],
                    CentroCusto = data["centro_custo"],
                    FormaPagamento = data["forma_pagamento"],
                    Status = data["status"],
                    DataEmissao = Convert.ToDateTime(data["data_emissao"]).ToString("dd/MM/yyyy"),
                    DataVencimento = Convert.ToDateTime(data["data_vencimento"]).ToString("dd/MM/yyyy"),
                    Valor = data["valor"],
                    Documento = data["documento"],
                    Ocorrencia = data["ocorrencia"],
                    QtdParcelas = data["qtd_parcelas"],
                    Parcelas = data["parcelas"],
                    Observacoes = data["observacoes"]
                });

                this.Success = true;
            }
            catch(MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `financeiro`;";
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    this.Results.Add(new {
                        Id = data["id"],
                        Nome = data["nome"],
                        Tipo = data["tipo"],
                        CentroCusto = data["centro_custo"],
                        FormaPagamento = data["forma_pagamento"],
                        Status = data["status"],
                        DataEmissao = Convert.ToDateTime(data["data_emissao"]).ToString("dd/MM/yyyy"),
                        DataVencimento = Convert.ToDateTime(data["data_vencimento"]).ToString("dd/MM/yyyy"),
                        Valor = data["valor"],
                        Documento = data["documento"],
                        Ocorrencia = data["ocorrencia"],
                        QtdParcelas = data["qtd_parcelas"],
                        Parcelas = data["parcelas"],
                        Observacoes = data["observacoes"]
                    });
                }

                this.Success = true;
            }
            catch (MySqlException e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void Delete() {
            string sql = "DELETE FROM `financeiro` WHERE `id` = @id LIMIT 1;";
            try {
                Open();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                Close();

                Success = true;
                Message = "Financeiro excluido com sucesso.";
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
