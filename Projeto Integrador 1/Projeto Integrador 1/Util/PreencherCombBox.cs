using System;
using System.Collections.Generic;

namespace Projeto_Integrador_1.Util {
    class PreencherCombBox {
        public List<dynamic> getEstados() {
            List<dynamic> estados = new List<dynamic> {
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
            return estados;
        }

        public List<dynamic> getCores() {
            List<dynamic> cores = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Preto" },
                new { Value = 2, Text = "Branco" },
                new { Value = 3, Text = "Azul" },
                new { Value = 4, Text = "Vermelho" },
                new { Value = 5, Text = "Cinza" }
            };
            return cores;
        }

        public List<dynamic> getCombustiveis() {
            List<dynamic> combustiveis = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Gasolina" },
                new { Value = 2, Text = "Etanol" },
                new { Value = 3, Text = "Diesel" },
                new { Value = 4, Text = "Disel S-10" },
                new { Value = 5, Text = "Flex" },
                new { Value = 99, Text = "N/A" }
            };
            return combustiveis;
        }

        public List<int> getAnos() {
            DateTime date = DateTime.Now.Date;
            int a = date.Year;

            List<int> anos = new List<int>();

            for (var i = a; i >= (a - 50); i--) {
                anos.Add(i);
            }

            return anos;
        }

        public List<dynamic> getSexo() {
            List<dynamic> sexo = new List<dynamic> {
                new { Value = string.Empty, Text = "---" },
                new { Value = "H", Text = "Homem" },
                new { Value = "M", Text = "Mulher" }
            };

            return sexo;
        }

        public List<dynamic> getEstadoCivil() {
            List<dynamic> estadoCivil = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Solteiro(a)" },
                new { Value = 2, Text = "Casado(a)" },
                new { Value = 3, Text = "Divorciado(a)" },
                new { Value = 4, Text = "Viúvo(a)" }
            };

            return estadoCivil;
        }

        public List<dynamic> getVeiculosCategorias() {
            List<dynamic> categorias = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Carro" },
                new { Value = 2, Text = "Moto" },
                new { Value = 3, Text = "Caminhão" },
                new { Value = 4, Text = "Caminhonete" }
            };
            return categorias;
        }

        public List<dynamic> getVeiculosMarcas() {
            List<dynamic> marcas = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Scania" },
                new { Value = 2, Text = "Volvo" },
                new { Value = 3, Text = "Ford" },
                new { Value = 4, Text = "Jeep" },
                new { Value = 5, Text = "Chevrolet" }
            };
            return marcas;
        }


        public List<dynamic> getVeiculosCarrocerias() {
            List<dynamic> carrocerias = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Baú" },
                new { Value = 2, Text = "Carga Seca" },
                new { Value = 3, Text = "Plancha" },
                new { Value = 4, Text = "Plataforma" },
                new { Value = 5, Text = "N/A" }
            };
            return carrocerias;
        }

        public List<dynamic> getVeiculosStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Finalizada" },
                new { Value = 2, Text = "Agendada" },
                new { Value = 3, Text = "Em Andamento" },
                new { Value = 0, Text = "Cancelada" }
            };
            return status;
        }

        public List<dynamic> getMotoristaStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Ativo" },
                new { Value = 0, Text = "Inativo" }
            };

            return status;
        }

        public List<dynamic> getCategoriasCNH() {
            List<dynamic> categorias = new List<dynamic> {
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

            return categorias;
        }

        public List<dynamic> getMotoristaCargos() {
            List<dynamic> cargos = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Motorista" },
                new { Value = 2, Text = "Ajudante" }
            };

            return cargos;
        }

        public List<dynamic> getClienteTipoCadastro() {
            List<dynamic> tipoCadastro = new List<dynamic> {
                new { Value = string.Empty, Text = "---" },
                new { Value = "C", Text = "Cliente" },
                new { Value = "F", Text = "Fornecedor" },
                new { Value = "A", Text = "Ambos" }
            };

            return tipoCadastro;
        }

        public List<dynamic> getClienteTipoPessoa() {
            List<dynamic> tipoPessoa = new List<dynamic> {
                new { Value = string.Empty, Text = "---" },
                new { Value = "PF", Text = "Pessoa Fisica" },
                new { Value = "PJ", Text = "Pessoa Juridica" }
            };

            return tipoPessoa;
        }

        public List<dynamic> getViagemTomador() {
            List<dynamic> tomador = new List<dynamic>
            {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Remetente" },
                new { Value = 2, Text = "Destinatario" }
            };

            return tomador;
        }

        public List<dynamic> getViagemTipo() {
            List<dynamic> tipo = new List<dynamic>
            {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Normal" },
                new { Value = 2, Text = "Subcontratação" },
                new { Value = 3, Text = "Redespacho" },
                new { Value = 4, Text = "Redespacho Intermediario" },
                new { Value = 5, Text = "Multimodal" }
            };

            return tipo;
        }

        public List<dynamic> getViagemStatus() {
            List<dynamic> status = new List<dynamic>
            {
                new { Value = -1, Text = "---" },
                new { Value = 0, Text = "Cancelada" },
                new { Value = 1, Text = "Agendada" },
                new { Value = 2, Text = "Em Andamento" },
                new { Value = 9, Text = "Finalizada" }
            };

            return status;
        }

        public List<dynamic> getManutencaoTipo() {
            List<dynamic> tipo = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Corretiva" },
                new { Value = 2, Text = "Preventiva" }
            };

            return tipo;
        }

        public List<dynamic> getManutencaoPreventiva() {
            List<dynamic> preventiva = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Por Hodômetro (KM)" },
                new { Value = 2, Text = "Por Tempo" }
            };

            return preventiva;
        }

        public List<dynamic> getManutencaoStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 0, Text = "Cancelada" },
                new { Value = 1, Text = "Concluida" },
                new { Value = 2, Text = "Agendada" }
            };

            return status;
        }

        public List<dynamic> getAbastecimentosStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 0, Text = "Em Aberto" },
                new { Value = 1, Text = "Pago" }
            };

            return status;
        }

        public List<dynamic> getMultaGravidade() {
            List<dynamic> gravidade = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 7, Text = "7 - Gravissima" },
                new { Value = 5, Text = "5 - Grave" },
                new { Value = 4, Text = "4 - Média" },
                new { Value = 2, Text = "2 - Leve" }
            };

            return gravidade;
        }

        public List<dynamic> getMultaStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 0, Text = "Vencida" },
                new { Value = 1, Text = "Paga" },
                new { Value = 2, Text = "Em aberto" },
                new { Value = 3, Text = "Recorrida" }
            };

            return status;
        }

        public List<dynamic> getFinanceiroTipo() {
            List<dynamic> tipo = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Conta à Receber" },
                new { Value = 2, Text = "Conta à Pagar" }
            };

            return tipo;
        }

        public List<dynamic> getFinanceiroContaBancaria() {
            List<dynamic> conta = new List<dynamic> {
                new { Value = 1, Text = "Conta Padrão" }
            };

            return conta;
        }

        public List<dynamic> getFinanceiroCentroCusto() {
            List<dynamic> centro = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 0, Text = "Outros" },
                new { Value = 1, Text = "Motorista" },
                new { Value = 2, Text = "Veiculo" },
                new { Value = 3, Text = "Viagem" },
                new { Value = 4, Text = "Manutenção" },
                new { Value = 5, Text = "Abastecimento" },
                new { Value = 6, Text = "Multa" }
            };

            return centro;
        }

        public List<dynamic> getFinanceiroFormaPagamento() {
            List<dynamic> forma = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Transferencia" },
                new { Value = 2, Text = "Boleto" },
                new { Value = 3, Text = "Cartão de Credito" },
                new { Value = 4, Text = "Cartão de Debito" },
                new { Value = 5, Text = "Dinheiro" }
            };

            return forma;
        }

        public List<dynamic> getFinanceiroStatus() {
            List<dynamic> status = new List<dynamic> {
                new { Value = 0, Text = "Em Aberto" },
                new { Value = 1, Text = "Pago" }
            };

            return status;
        }

        public List<dynamic> getFinanceiroOcorrencia() {
            List<dynamic> status = new List<dynamic> {
                new { Value = -1, Text = "---" },
                new { Value = 1, Text = "Única" },
                new { Value = 2, Text = "Parcelada" }
            };

            return status;
        }
    }
}
