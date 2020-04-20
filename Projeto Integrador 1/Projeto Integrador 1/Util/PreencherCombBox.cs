﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Util
{
    class PreencherCombBox
    {
        public List<dynamic> getEstados()
        {
            List<dynamic> estados = new List<dynamic> {
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

        public List<dynamic> getCores()
        {
            List<dynamic> cores = new List<dynamic> {
                new { Value = 1, Text = "Preto" },
                new { Value = 2, Text = "Branco" },
                new { Value = 3, Text = "Azul" },
                new { Value = 4, Text = "Vermelho" },
                new { Value = 5, Text = "Cinza" }
            };
            return cores;
        }

        public List<dynamic> getCombustiveis()
        {
            List<dynamic> combustiveis = new List<dynamic> {
                new { Value = 1, Text = "Gasolina" },
                new { Value = 2, Text = "Etanol" },
                new { Value = 3, Text = "Diesel" },
                new { Value = 4, Text = "Disel S-10" },
                new { Value = 5, Text = "Flex" },
                new { Value = 99, Text = "N/A" }
            };
            return combustiveis;
        }

        public List<int> getAnos()
        {
            DateTime date = DateTime.Now.Date;
            int a = date.Year;

            List<int> anos = new List<int>();

            for (var i = a; i >= (a - 50); i--)
            {
                anos.Add(i);
            }

            return anos;
        }

        public List<dynamic> getVeiculosCategorias() {
            List<dynamic> categorias = new List<dynamic> {
                new { Value = 1, Text = "Carro" },
                new { Value = 2, Text = "Moto" },
                new { Value = 3, Text = "Caminhão" },
                new { Value = 4, Text = "Caminhonete" }
            };
            return categorias;
        }

        public List<dynamic> getVeiculosMarcas() {
            List<dynamic> marcas = new List<dynamic> {
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
                new { Value = 1, Text = "Finalizada" },
                new { Value = 2, Text = "Agendada" },
                new { Value = 3, Text = "Em Andamento" },
                new { Value = 4, Text = "Cancelada" }
            };
            return status;
        }
    }
}