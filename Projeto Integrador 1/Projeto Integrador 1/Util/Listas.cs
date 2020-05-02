using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Util {
    class Listas {
        public static List<dynamic> Estados = new List<dynamic> {
            new { Value = string.Empty, Text = "---" },
            new { Value = "AC", Text = "Acre (AC)" },
            new { Value = "AL", Text = "Alagoas (AL)" },
            new { Value = "AP", Text = "Amapá (AP)" },
            new { Value = "AM", Text = "Amazonas (AM)" },
            new { Value = "BA", Text = "Bahia (BA)" },
            new { Value = "CE", Text = "Ceará (CE)" },
            new { Value = "DF", Text = "Distrito Federal (DF)" },
            new { Value = "ES", Text = "Espírito Santo (ES)" },
            new { Value = "GO", Text = "Goiás (GO)" },
            new { Value = "MA", Text = "Maranhão (MA)" },
            new { Value = "MT", Text = "Mato Grosso (MT)" },
            new { Value = "MS", Text = "Mato Grosso do Sul (MS)" },
            new { Value = "MG", Text = "Minas Gerais (MG)" },
            new { Value = "PA", Text = "Pará (PA)" },
            new { Value = "PB", Text = "Paraíba (PB)" },
            new { Value = "PR", Text = "Paraná (PR)" },
            new { Value = "PE", Text = "Pernambuco (PE)" },
            new { Value = "PI", Text = "Piauí (PI)" },
            new { Value = "RJ", Text = "Rio de Janeiro (RJ)" },
            new { Value = "RN", Text = "Rio Grande do Norte (RN)" },
            new { Value = "RS", Text = "Rio Grande do Sul (RS)" },
            new { Value = "RO", Text = "Rondônia (RO)" },
            new { Value = "RR", Text = "Roraima (RR)" },
            new { Value = "SC", Text = "Santa Catarina (SC)" },
            new { Value = "SP", Text = "São Paulo (SP)" },
            new { Value = "SE", Text = "Sergipe (SE)" },
            new { Value = "TO", Text = "Tocantins (TO)" }
        };

        public static List<dynamic> Cores = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Preto" },
            new { Value = 2, Text = "Branco" },
            new { Value = 3, Text = "Azul" },
            new { Value = 4, Text = "Vermelho" },
            new { Value = 5, Text = "Cinza" }
        };

        public static List<dynamic> Combustiveis = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Gasolina" },
            new { Value = 2, Text = "Etanol" },
            new { Value = 3, Text = "Diesel" },
            new { Value = 4, Text = "Disel S-10" },
            new { Value = 5, Text = "Flex" },
            new { Value = 99, Text = "N/A" }
        };

        public static List<dynamic> Anos {
            get {
                DateTime date = DateTime.Now.Date;
                int currentYear = date.Year;

                List<dynamic> Year = new List<dynamic>();

                Year.Add(new { Value = -1, Text = "---" });

                for (var i = currentYear; i >= (currentYear - 50); i--) {
                    Year.Add(i);
                }

                return Year;
            }
        }

        public static List<dynamic> Sexos = new List<dynamic> {
            new { Value = string.Empty, Text = "---" },
            new { Value = "H", Text = "Homem" },
            new { Value = "M", Text = "Mulher" }
        };

        public static List<dynamic> EstadoCivil = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Solteiro(a)" },
            new { Value = 2, Text = "Casado(a)" },
            new { Value = 3, Text = "Divorciado(a)" },
            new { Value = 4, Text = "Viúvo(a)" }
        };

        public static List<dynamic> VeiculosCategorias = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Carro" },
            new { Value = 2, Text = "Moto" },
            new { Value = 3, Text = "Caminhão" },
            new { Value = 4, Text = "Caminhonete" }
        };

        public static List<dynamic> VeiculosMarcas = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Scania" },
            new { Value = 2, Text = "Volvo" },
            new { Value = 3, Text = "Ford" },
            new { Value = 4, Text = "Jeep" },
            new { Value = 5, Text = "Chevrolet" }
        };


        public static List<dynamic> VeiculosCarrocerias = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Baú" },
            new { Value = 2, Text = "Carga Seca" },
            new { Value = 3, Text = "Plancha" },
            new { Value = 4, Text = "Plataforma" },
            new { Value = 5, Text = "N/A" }
        };

        public static List<dynamic> VeiculosStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Finalizada" },
            new { Value = 2, Text = "Agendada" },
            new { Value = 3, Text = "Em Andamento" },
            new { Value = 0, Text = "Cancelada" }
        };

        public static List<dynamic> MotoristasStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Ativo" },
            new { Value = 0, Text = "Inativo" }
        };

        public static List<dynamic> CNHCategorias = new List<dynamic> {
            new { Value = string.Empty, Text = "---" },
            new { Value = "A", Text = "A" },
            new { Value = "B", Text = "B" },
            new { Value = "C", Text = "C" },
            new { Value = "D", Text = "D" },
            new { Value = "AB", Text = "AB" },
            new { Value = "AC", Text = "AC" },
            new { Value = "AD", Text = "AD" },
            new { Value = "AE", Text = "AE" }
        };

        public static List<dynamic> MotoristasCargos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Motorista" },
            new { Value = 2, Text = "Ajudante" }
        };

        public static List<dynamic> ClientesTipoCadastros = new List<dynamic> {
            new { Value = string.Empty, Text = "---" },
            new { Value = "C", Text = "Cliente" },
            new { Value = "F", Text = "Fornecedor" },
            new { Value = "A", Text = "Ambos" }
        };

        public static List<dynamic> ClientesTipoPessoas = new List<dynamic> {
            new { Value = string.Empty, Text = "---" },
            new { Value = "PF", Text = "Pessoa Fisica" },
            new { Value = "PJ", Text = "Pessoa Juridica" }
        };

        public static List<dynamic> ViagemTomador = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Remetente" },
            new { Value = 2, Text = "Destinatario" }
        };

        public static List<dynamic> ViagemTipos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Normal" },
            new { Value = 2, Text = "Subcontratação" },
            new { Value = 3, Text = "Redespacho" },
            new { Value = 4, Text = "Redespacho Intermediario" },
            new { Value = 5, Text = "Multimodal" }
        };

        public static List<dynamic> ViagemStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 0, Text = "Cancelada" },
            new { Value = 1, Text = "Agendada" },
            new { Value = 2, Text = "Em Andamento" },
            new { Value = 9, Text = "Finalizada" }
        };

        public static List<dynamic> ManutencoesTipos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Corretiva" },
            new { Value = 2, Text = "Preventiva" }
        };

        public static List<dynamic> ManutencoesPreventivas = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Por Hodômetro (KM)" },
            new { Value = 2, Text = "Por Tempo" }
        };

        public static List<dynamic> ManutencoesStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 0, Text = "Cancelada" },
            new { Value = 1, Text = "Concluida" },
            new { Value = 2, Text = "Agendada" }
        };

        public static List<dynamic> AbastecimentosStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 0, Text = "Em Aberto" },
            new { Value = 1, Text = "Pago" }
        };

        public static List<dynamic> MultasGravidades = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 7, Text = "7 - Gravissima" },
            new { Value = 5, Text = "5 - Grave" },
            new { Value = 4, Text = "4 - Média" },
            new { Value = 2, Text = "2 - Leve" }
        };

        public static List<dynamic> MultasStatus = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 0, Text = "Vencida" },
            new { Value = 1, Text = "Paga" },
            new { Value = 2, Text = "Em aberto" },
            new { Value = 3, Text = "Recorrida" }
        };

        public static List<dynamic> FinanceiroTipos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Conta à Receber" },
            new { Value = 2, Text = "Conta à Pagar" }
        };

        public static List<dynamic> FinanceiroContas = new List<dynamic> {
            new { Value = 1, Text = "Conta Padrão" }
        };

        public static List<dynamic> FinanceiroCentroCustos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 0, Text = "Outros" },
            new { Value = 1, Text = "Motorista" },
            new { Value = 2, Text = "Veiculo" },
            new { Value = 3, Text = "Viagem" },
            new { Value = 4, Text = "Manutenção" },
            new { Value = 5, Text = "Abastecimento" },
            new { Value = 6, Text = "Multa" },
            new { Value = 7, Text = "Cliente" }
        };

        public static List<dynamic> FinanceiroFormasPagamentos = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Transferencia" },
            new { Value = 2, Text = "Boleto" },
            new { Value = 3, Text = "Cartão de Credito" },
            new { Value = 4, Text = "Cartão de Debito" },
            new { Value = 5, Text = "Dinheiro" }
        };

        public static List<dynamic> FinanceiroStatus = new List<dynamic> {
            new { Value = 0, Text = "Em Aberto" },
            new { Value = 1, Text = "Pago" }
        };

        public static List<dynamic> FinanceiroOcorrencias = new List<dynamic> {
            new { Value = -1, Text = "---" },
            new { Value = 1, Text = "Única" },
            new { Value = 2, Text = "Parcelada" }
        };
    }
}
