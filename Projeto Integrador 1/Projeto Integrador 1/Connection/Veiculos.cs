using MySql.Data.MySqlClient;
using Projeto_Integrador_1.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection
{
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
               
                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);

                    query.Parameters.AddWithValue("@frota", this.Frota);
                    query.Parameters.AddWithValue("@placa", this.Placa);
                    query.Parameters.AddWithValue("@categoria", this.Categoria);
                    query.Parameters.AddWithValue("@marca", this.Marca);
                    query.Parameters.AddWithValue("@carroceria", this.Carroceria);
                    query.Parameters.AddWithValue("@modelo", this.Modelo);
                    query.Parameters.AddWithValue("@cor", this.Cor);
                    query.Parameters.AddWithValue("@combustivel", this.Combustivel);
                    query.Parameters.AddWithValue("@motorizacao", this.Motorizacao);
                    query.Parameters.AddWithValue("@renavam", this.Renavam);
                    query.Parameters.AddWithValue("@chassi", this.Chassi);
                    query.Parameters.AddWithValue("@ano_fabricacao", this.AnoFabricacao);
                    query.Parameters.AddWithValue("@ano_modelo", this.AnoModelo);
                    query.Parameters.AddWithValue("@status", this.Status);
                    query.Parameters.AddWithValue("@tara", this.Tara);
                    query.Parameters.AddWithValue("@lotacao", this.Lotacao);
                    query.Parameters.AddWithValue("@peso_bruto_total", this.PesoBrutoTotal);
                    query.Parameters.AddWithValue("@capacidade", this.Capacidade);

                    query.ExecuteNonQuery();

                    closeConnection();
                }

                this.Success = true;
                this.Message = "Veiculo salvo com sucesso.";
            }
            catch (Exception e) {
                this.Success = false;
                this.Message = e.Message;
            }
        }

        public void GetAll()
        {
            string sql = "SELECT * FROM `veiculos`;";

            PreencherCombBox preValues = new Util.PreencherCombBox();
            List<dynamic> marcas = preValues.getVeiculosMarcas();

            try
            {
                if (openConnection())
                {
                    MySqlCommand query = new MySqlCommand(sql, connection);
                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read())
                    {
                        dynamic marca = marcas.Find(item => item.Value == Int16.Parse(data["marca"].ToString()));

                        this.Results.Add(
                            new
                            {
                                Id = data["id"],
                                Frota = data["frota"],
                                Placa = data["placa"],
                                Veiculo = (data["placa"] + " " + marca.Text + " " + data["modelo"]).ToUpper()
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
