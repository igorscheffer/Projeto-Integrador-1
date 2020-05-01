using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util {
    class Converter {
        public static void OnPressMoeda(ref MaskedTextBox ToConvert) {
            string numero = string.Empty;
            double valor = 0;

            try {
                numero = ToConvert.Text.Replace(",", "").Replace(".", "");

                if (numero.Equals("")) {
                    numero = "";
                }

                numero = numero.PadLeft(3, '0');

                if (numero.Length > 3 & numero.Substring(0, 1) == "0") {
                    numero = numero.Substring(1, numero.Length - 1);
                }

                valor = Convert.ToDouble(numero) / 100;

                ToConvert.Text = string.Format("{0:N}", valor);
                ToConvert.SelectionStart = ToConvert.Text.Length;
            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void OnPressQtd(ref MaskedTextBox ToConvert) {
            string numero = string.Empty;
            double valor = 0;

            try {
                numero = ToConvert.Text.Replace(",", "").Replace(".", "");

                if (numero.Equals("")) {
                    numero = "";
                }

                numero = numero.PadLeft(3, '0');

                if (numero.Length > 3 & numero.Substring(0, 1) == "0") {
                    numero = numero.Substring(1, numero.Length - 1);
                }

                valor = Convert.ToDouble(numero) / 100;

                ToConvert.Text = string.Format("{0:F}", valor);
                ToConvert.SelectionStart = ToConvert.Text.Length;
            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static void OnPressPeso(ref MaskedTextBox ToConvert) {
            string numero = string.Empty;
            double valor = 0;

            try {
                numero = ToConvert.Text.Replace(",", "").Replace(".", "");

                if (numero.Equals("")) {
                    numero = "";
                }

                numero = numero.PadLeft(3, '0');

                if (numero.Length > 3 & numero.Substring(0, 1) == "0") {
                    numero = numero.Substring(1, numero.Length - 1);
                }

                valor = Convert.ToDouble(numero);

                ToConvert.Text = string.Format("{0:n0}", valor);
                ToConvert.SelectionStart = ToConvert.Text.Length;
            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public static decimal ToDecimal(string ToDecimal) {
            string Decimal;

            if (!string.IsNullOrWhiteSpace(ToDecimal)) {
                Decimal = String.Format("{0:#}", ToDecimal);
            }
            else {
                throw new Exception("Não foi possivel converter o valor.");
            }

            return Convert.ToDecimal(Decimal);
        }

        public static string ToReais(dynamic ToString) {
            // pegar dinamico e gerencias a extensao
            try {
                string Reais = "";

                if (!string.IsNullOrWhiteSpace(Convert.ToString(ToString))) {
                    ToString = Convert.ToDecimal(ToString);
                    Reais = String.Format("{0:N}", ToString);
                }
                else {
                    throw new Exception("Não foi Possivel converter Decimal para String.");
                }

                return Reais;
            }
            catch (Exception e) {
                throw;
            }
        }
    }
}
