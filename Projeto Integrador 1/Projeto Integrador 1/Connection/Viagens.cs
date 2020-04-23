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
        public string Valor { get; set; }
        public string InformacoesComplementares { get; set; }
        public string Cargas { get; set; }
        public string Custos { get; set; }
        public string Abastecimentos { get; set; }
    }
}
