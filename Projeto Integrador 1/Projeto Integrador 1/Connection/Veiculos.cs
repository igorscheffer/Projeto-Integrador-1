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

        public string Frota { set; get; }
        public string Placa { set; get; }
        public string Categoria { set; get; }
        public string Marca { set; get; }
        public string Carroceria { set; get; }
        public string Modelo { set; get; }
        public string Cor { set; get; }
        public string Combustivel { set; get; }
        public string Motorizacao { set; get; }
        public string Renavam { set; get; }
        public string Chassi { set; get; }
        public string AnoFabricacao { set; get; }
        public string AnoModelo { set; get; }
        public string Status { set; get; }
        public string Tara { set; get; }
        public string Lotacao { set; get; }
        public string PesoBrutoTotal { set; get; }
        public string Capacidade { set; get; }

        public void Create() {

            try {
                string sql = "INSERT INTO `veiculos` (`frota`, `placa`, `categoria`, `marca`, `carroceria`, `modelo`, `cor`, `combustivel`, `motorizacao`, `renavam`, `chassi`, `ano_fabricacao`, `ano_modelo`, `status`, `tara`, `lotacao`, `peso_bruto_total`, `capacidade`) VALUES (@frota, @placa, @categoria, @marca, @carroceria, @modelo, @cor, @combustivel, @motorizacao, @renavam, @chassi, @ano_fabricacao, @ano_modelo, @status, @tara, @lotacao, @peso_bruto_total, @capacidade);";

                openConnection();

                MySqlCommand query = new MySqlCommand(sql, connection);

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

                closeConnection();

                Success = true;
                Message = "Veiculo salvo com sucesso.";
            }
            catch (Exception e) {
                Success = false;
                Message = e.Message;
            }
        }

        public void GetAll() {
            string sql = "SELECT * FROM `veiculos`;";

            PreencherCombBox preValues = new Util.PreencherCombBox();
            List<dynamic> marcas = preValues.getVeiculosMarcas();

            try {
                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);
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
