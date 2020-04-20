using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util
{
    class Validate {
        private int contar = 0;

        public dynamic[][] Rules = new dynamic[50][];
        private List<string> Errors = new List<string>();
        private int CountErrors = 0;

        public void addRule(Control component, string name, string rule) {
    
            this.Rules[this.contar] = new dynamic[] { component, name, rule };

            this.contar++;
        }

        private void validateMin(Control component, string name, int rule, string rules)
        {
            if (rules.Contains("required") || component.Text.Trim().Length > 0) {
                if (component.Text.Length < rule) {
                    Errors.Add(name + " deve conter no minimo " + rule + " caracteres.");
                    this.CountErrors++;
                }
            }
        }

        private void validateMax(Control component, string name, int rule) {
            if (component.Text.Length > rule) {
                Errors.Add(name + " deve conter no maximo " + rule + " caracteres.");
                this.CountErrors++;
            }
        }

        private void validateDate(Control component, string name, string rule, string rules)
        {
            if (rules.Contains("required") || component.Text.Trim().Length > 0)
            {
                DateTime date;

                bool validate = DateTime.TryParseExact(component.Text, rule, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);

                if (!validate)
                {
                    Errors.Add(name + " não é um fomato de data valido.");
                    this.CountErrors++;
                }
            }
        }

        private void ValidateRegExp(Control component, string name, string rule, string rules)
        {
            if (rules.Contains("required") || component.Text.Trim().Length > 0) {
                var regexp = rule;
                var match = System.Text.RegularExpressions.Regex.Match(component.Text, regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(name + " não está em um formato valido.");
                    this.CountErrors++;
                }
            }
        }

        private void validateRequired(Control component, string name) {
            if (component.Text.Trim() == "") {
                Errors.Add(name + " deve ser preenchido.");
                this.CountErrors++;
            }
        }

        private void validateNumeric(Control component, string name, string rules)
        {
            if (rules.Contains("required") || component.Text.Trim().Length > 0) {
                var regexp = @"([0-9])";
                var match = System.Text.RegularExpressions.Regex.Match(component.Text, regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(name + " deve ser numerico.");
                    this.CountErrors++;
                }
            }
        }

        public void Validation() {
            //Console.Clear();
            for (var i = 0; i < this.contar; i++) {
                Console.WriteLine(string.Join(", ", this.Rules[i])); // 3
                string[] rules = this.Rules[i][2].Split('|');

                foreach (var divideRule in rules) {
                    if (divideRule.Contains(":")){
                        string[] rule = divideRule.Split(':');

                        switch (rule[0]) {
                            case "min":
                                this.validateMin(this.Rules[i][0], this.Rules[i][1], Int16.Parse(rule[1]), this.Rules[i][2]);
                                break;
                            case "max":
                                this.validateMax(this.Rules[i][0], this.Rules[i][1], Int16.Parse(rule[1]));
                                break;
                            case "regExp":
                                this.ValidateRegExp(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
                                break;
                            case "date":
                                this.validateDate(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
                                break;
                        }
                    }
                    //else if (divideRule.Contains(",")) { }
                    else {
                        switch (divideRule) {
                            case "required":
                                this.validateRequired(this.Rules[i][0], this.Rules[i][1]);
                                break;
                            case "numeric":
                                this.validateNumeric(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                    break;
                            default:
                                Console.WriteLine("NO VALID > " + divideRule);
                                break;
                        }
                    }
                }
            }
        }

        public void ShowErrors() {
            //Console.Clear();
            Console.WriteLine("Total de Erros: " + this.CountErrors);
            foreach (string erro in this.Errors) {
                Console.WriteLine(erro);
            }
        }
    }
}
