using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrador_1.Util
{
    class Validate {
        private int contar = 0;

        public string[][] Rules = new string[20][];
        private List<string> Errors = new List<string>();
        private int CountErrors = 0;

        public void addRule(string type, string name, string value, string rule) {
    
            this.Rules[this.contar] = new string[] { type, name, value, rule };

            this.contar++;
        }

        private void validateMin(string name, string value, int rule)
        {
            if (value.Length < rule){
                Errors.Add(name + " deve conter no maximo " + rule + " caracteres.");
                this.CountErrors++;
            }
        }

        private void validateMax(string name, string value, int rule) {
            if (value.Length > rule) {
                Errors.Add(name + " deve conter no maximo " + rule + " caracteres.");
                this.CountErrors++;
            }
        }

        private void validateRequired(string name, string value) {
            if (value.Trim() == "") {
                Errors.Add(name + " deve ser preenchido.");
                this.CountErrors++;
            }
        }

        public void Validation() {
            for (var i = 0; i < this.contar; i++) {
                Console.WriteLine(string.Join(", ", this.Rules[i])); // 3
                string[] rules = this.Rules[i][3].Split('|');

                foreach (var divideRule in rules) {
                    if (divideRule.Contains(":")){
                        string[] rule = divideRule.Split(':');

                        switch (rule[0]) {
                            case "min":
                                this.validateMin(this.Rules[i][1], this.Rules[i][2], Int16.Parse(rule[1]));
                                break;
                            case "max":
                                this.validateMax(this.Rules[i][1], this.Rules[i][2], Int16.Parse(rule[1]));
                                break;
                        }
                    }
                    //else if (divideRule.Contains(",")) { }
                    else {
                        switch (divideRule) {
                            case "required":
                                this.validateRequired(this.Rules[i][1], this.Rules[i][2]);
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
            Console.WriteLine("Total de Erros: " + this.CountErrors);
            foreach (string erro in this.Errors) {
                Console.WriteLine(erro);
            }
        }
    }
}
