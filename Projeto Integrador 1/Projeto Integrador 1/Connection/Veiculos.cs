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

                    return list;
                }
            }
            catch (Exception e) {
                Console.Write(e.Message);
            }

            return list;
        }
    }
}
