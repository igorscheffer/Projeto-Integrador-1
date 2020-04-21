using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Connection
{
    class Veiculos : Config {
        
        public Veiculos() {
        
        }

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

        public dynamic[] create() {
            try {
                string sql = "INSERT INTO `veiculos` (`frota`, `placa`, `categoria`, `marca`, `carroceria`, `modelo`, `cor`, `combustivel`, `motorizacao`, `renavam`, `chassi`, `ano_fabricacao`, `ano_modelo`, `status`, `tara`, `lotacao`, `peso_bruto_total`, `capacidade`) VALUES (':frota', ':placa', ':categoria', ':marca', ':carroceria', ':modelo', ':cor', ':combustivel', ':motorizacao', ':renavam', ':chassi', ':ano_fabricacao', ':ano_modelo', ':status', ':tara', ':lotacao', ':peso_bruto_total', ':capacidade');";
                
                sql = sql.Replace(":frota", this.Frota);
                sql = sql.Replace(":placa", this.Placa);
                sql = sql.Replace(":categoria", this.Categoria);
                sql = sql.Replace(":marca", this.Marca);
                sql = sql.Replace(":carroceria", this.Carroceria);
                sql = sql.Replace(":modelo", this.Modelo);
                sql = sql.Replace(":cor", this.Cor);
                sql = sql.Replace(":combustivel", this.Combustivel);
                sql = sql.Replace(":motorizacao", this.Motorizacao);
                sql = sql.Replace(":renavam", this.Renavam);
                sql = sql.Replace(":chassi", this.Chassi);
                sql = sql.Replace(":ano_fabricacao", this.AnoFabricacao);
                sql = sql.Replace(":ano_modelo", this.AnoModelo);
                sql = sql.Replace(":status", this.Status);
                sql = sql.Replace(":tara", this.Tara);
                sql = sql.Replace(":lotacao", this.Lotacao);
                sql = sql.Replace(":peso_bruto_total", this.PesoBrutoTotal);
                sql = sql.Replace(":capacidade", this.Capacidade);

                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand(sql, connection);

                    query.ExecuteNonQuery();

                    closeConnection();
                }

                return new dynamic[] { true, "Veiculo salvo com sucesso." };
            }
            catch (Exception e) {
                return new dynamic[] { false, e.Message };
            }
        }

        public List<dynamic> getAll() {
            List<dynamic> list = new List<dynamic>();

            try {
                if (openConnection()) {
                    MySqlCommand query = new MySqlCommand("SELECT * FROM `teste`", connection);
                    MySqlDataReader data = query.ExecuteReader();

                    while (data.Read()) {
                        list.Add(
                            new { Id = data["id"], Text = data["teste"] }    
                        );
                    }

                    data.Close();

                    closeConnection();
                }

                return list;
            }
            catch (Exception e) {
                Console.Write(e.Message);
                return list;
            }
        }
    }
}
