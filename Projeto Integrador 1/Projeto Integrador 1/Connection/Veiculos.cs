using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Connection {
    class Veiculos : Config {

        public Veiculos() { }

        public bool Success;
        public string Message;
        public List<dynamic> Results = new List<dynamic>();

        public int Id { get; set; }
        public string Frota { get; set; }
        public string Placa { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Carroceria { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public string Motorizacao { get; set; }
        public string Renavam { get; set; }
        public string Chassi { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
        public string Status { get; set; }
        public string Tara { get; set; }
        public string Lotacao { get; set; }
        public string PesoBrutoTotal { get; set; }
        public string Capacidade { get; set; }

        public void Create() {
            string sql = "INSERT INTO `veiculos` (`frota`, `placa`, `categoria`, `marca`, `carroceria`, `modelo`, `cor`, `combustivel`, `motorizacao`, `renavam`, `chassi`, `ano_fabricacao`, `ano_modelo`, `status`, `tara`, `lotacao`, `peso_bruto_total`, `capacidade`) VALUES (@frota, @placa, @categoria, @marca, @carroceria, @modelo, @cor, @combustivel, @motorizacao, @renavam, @chassi, @ano_fabricacao, @ano_modelo, @status, @tara, @lotacao, @peso_bruto_total, @capacidade);";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@frota", Frota);
                query.Parameters.AddWithValue("@placa", Placa);
                query.Parameters.AddWithValue("@categoria", Categoria);
                query.Parameters.AddWithValue("@marca", Marca);
                query.Parameters.AddWithValue("@carroceria", Carroceria);
                query.Parameters.AddWithValue("@modelo", Modelo);
                query.Parameters.AddWithValue("@cor", Cor);
                query.Parameters.AddWithValue("@combustivel", Combustivel);
                query.Parameters.AddWithValue("@motorizacao", Motorizacao);
                query.Parameters.AddWithValue("@renavam", Renavam);
                query.Parameters.AddWithValue("@chassi", Chassi);
                query.Parameters.AddWithValue("@ano_fabricacao", AnoFabricacao);
                query.Parameters.AddWithValue("@ano_modelo", AnoModelo);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@tara", Tara);
                query.Parameters.AddWithValue("@lotacao", Lotacao);
                query.Parameters.AddWithValue("@peso_bruto_total", PesoBrutoTotal);
                query.Parameters.AddWithValue("@capacidade", Capacidade);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Veiculo salvo com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Update() {
            string sql = "UPDATE `veiculos` SET `frota` = @frota, `placa` = @placa, `categoria` = @categoria, `marca` = @marca, `carroceria` = @carroceria, `modelo` = @modelo, `cor` = @cor, `combustivel` = @combustivel, `motorizacao` = @motorizacao, `renavam` = @renavam, `chassi` = @chassi, `ano_fabricacao` = @ano_fabricacao, `ano_modelo` = @ano_modelo, `status` = @status, `tara` = @tara, `lotacao` = @lotacao, `peso_bruto_total` = @peso_bruto_total, `capacidade` = @capacidade WHERE `id` = @id LIMIT 1;";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);

                query.Parameters.AddWithValue("@frota", Frota);
                query.Parameters.AddWithValue("@placa", Placa);
                query.Parameters.AddWithValue("@categoria", Categoria);
                query.Parameters.AddWithValue("@marca", Marca);
                query.Parameters.AddWithValue("@carroceria", Carroceria);
                query.Parameters.AddWithValue("@modelo", Modelo);
                query.Parameters.AddWithValue("@cor", Cor);
                query.Parameters.AddWithValue("@combustivel", Combustivel);
                query.Parameters.AddWithValue("@motorizacao", Motorizacao);
                query.Parameters.AddWithValue("@renavam", Renavam);
                query.Parameters.AddWithValue("@chassi", Chassi);
                query.Parameters.AddWithValue("@ano_fabricacao", AnoFabricacao);
                query.Parameters.AddWithValue("@ano_modelo", AnoModelo);
                query.Parameters.AddWithValue("@status", Status);
                query.Parameters.AddWithValue("@tara", Tara);
                query.Parameters.AddWithValue("@lotacao", Lotacao);
                query.Parameters.AddWithValue("@peso_bruto_total", PesoBrutoTotal);
                query.Parameters.AddWithValue("@capacidade", Capacidade);
                query.Parameters.AddWithValue("@id", Id);

                query.ExecuteNonQuery();

                CloseConnection();

                Success = true;
                Message = "Veiculo salvo com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void Get() {
            string sql = "SELECT * FROM `veiculos` WHERE `id` = @id LIMIT 1;";

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                query.Parameters.AddWithValue("@id", Id);

                MySqlDataReader data = query.ExecuteReader();
                data.Read();

                Results.Add(
                    new {
                        Id = data["id"],
                        Frota = data["frota"],
                        Placa = data["placa"],
                        Categoria = data["categoria"],
                        Marca = data["marca"],
                        Carroceria = data["carroceria"],
                        Modelo = data["modelo"],
                        Cor = data["cor"],
                        Combustivel = data["combustivel"],
                        Motorizacao = data["motorizacao"],
                        Renavam = data["renavam"],
                        Chassi = data["chassi"],
                        AnoFabricacao = data["ano_fabricacao"],
                        AnoModelo = data["ano_modelo"],
                        Status = data["status"],
                        Tara = data["tara"],
                        Lotacao = data["lotacao"],
                        PesoBrutoTotal = data["peso_bruto_total"],
                        Capacidade = data["capacidade"]
                    }
                );

                data.Close();

                CloseConnection();

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `veiculos`;";

            Listas preValues = new Util.Listas();
            List<dynamic> marcas = preValues.getVeiculosMarcas();

            try {
                OpenConnection();

                MySqlCommand query = new MySqlCommand(sql, Connection);
                MySqlDataReader data = query.ExecuteReader();

                while (data.Read()) {
                    dynamic marca = marcas.Find(item => item.Value == Int16.Parse(data["marca"].ToString()));

                    Results.Add(
                        new {
                            Id = data["id"],
                            Frota = data["frota"],
                            Placa = data["placa"],
                            Veiculo = (data["placa"] + " " + marca.Text + " " + data["modelo"]).ToUpper(),
                            Cor = data["cor"],
                            Status = data["status"]
                        }
                    );
                }

                data.Close();

                CloseConnection();

                Success = true;
            }
            catch (MySqlException e) {
                Success = false;
                Message = e.Message;
            }
        }
    }
}
