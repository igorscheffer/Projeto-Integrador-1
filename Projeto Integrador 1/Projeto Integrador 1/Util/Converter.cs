using Guna.UI2.WinForms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util {
    class Converter {
        public static void DateReset(object sender, KeyPressEventArgs e) {
            try {
                Guna2DateTimePicker Date = (Guna2DateTimePicker)sender;
                if (e.KeyChar == (char)Keys.Escape || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete) {
                    Date.CustomFormat = " ";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Houve um erro ao resetar a data (" + ex.Message + ")");
            }
        }
        public static void DateValueChanged(object sender, EventArgs e) {
            try {
                Guna2DateTimePicker Date = (Guna2DateTimePicker)sender;
                if (Convert.ToString(Date.Value) != Convert.ToString(DateTime.Now)) {
                    Date.CustomFormat = "dd/MM/yyyy";
                }
                else {
                    Date.CustomFormat = " ";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Houve um erro ao converter a data (" + ex.Message + ")");
            }
        }
        public static void DateTimeValueChanged(object sender, EventArgs e) {
            try {
                Guna2DateTimePicker Date = (Guna2DateTimePicker)sender;
                if (Convert.ToString(Date.Value) != Convert.ToString(DateTime.Now)) {
                    Date.CustomFormat = "dd/MM/yyyy HH:mm";
                }
                else {
                    Date.CustomFormat = " ";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Houve um erro ao converter a data (" + ex.Message + ")");
            }
        }
        public static string DateToString(dynamic Date, string Format) {
            if (!string.IsNullOrWhiteSpace(Convert.ToString(Date))) {
                return Convert.ToDateTime(Date).ToString(Format);
            }
            else {
                return string.Empty;
            }
        }
        public static void OnlyNumber(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
        public static void OnPressMoeda(ref Guna2TextBox ToConvert) {
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
        public static void OnPressQtd(ref Guna2TextBox ToConvert) {
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

        public static void OnPressPeso(ref Guna2TextBox ToConvert) {
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

        public static dynamic ToDecimal(string ToDecimal, bool ConvertToString = false) {
            try {
                string Decimal = "0";

                if (!string.IsNullOrWhiteSpace(ToDecimal)) {
                    //Decimal = String.Format("{0:#}", ToDecimal);
                    Decimal = Convert.ToString(decimal.Parse(ToDecimal, NumberStyles.AllowCurrencySymbol | NumberStyles.Number));
                }
                else {
                    throw new Exception("Não foi possivel converter o valor.");
                }

                if (ConvertToString == false) {
                    return Convert.ToDecimal(Decimal);
                }
                else {
                    return Decimal;
                }
            }
            catch (Exception e) {
                if (ConvertToString == false) {
                    return Convert.ToDecimal(0);
                }
                else {
                    return string.Empty;
                }
            }
        }

        public static string ToReais(dynamic ToString) {
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
                Console.WriteLine(e.Message);
                return string.Empty;
            }
        }

        public static string ToQuantidade(dynamic ToString) {
            try {
                string Reais = "";

                if (!string.IsNullOrWhiteSpace(Convert.ToString(ToString))) {
                    ToString = Convert.ToDecimal(ToString);
                    Reais = String.Format("{0:F}", ToString);
                }
                else {
                    throw new Exception("Não foi Possivel converter Decimal para String.");
                }

                return Reais;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return string.Empty;
            }
        }
        public static dynamic ToIntDB(dynamic input, bool RBDNull = false) {
            if (!string.IsNullOrWhiteSpace(Convert.ToString(input))) {
                if (Convert.ToInt32(input) > 0) {
                    return Convert.ToInt32(input);
                }
                else {
                    if (RBDNull) {
                        return DBNull.Value;
                    }
                    else {
                        return 0;
                    }
                }
            }
            else {
                if (RBDNull) {
                    return DBNull.Value;
                }
                else {
                    return 0;
                }
            }
        }
    }
}
