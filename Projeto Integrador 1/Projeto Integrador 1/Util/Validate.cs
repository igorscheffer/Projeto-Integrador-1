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

        private dynamic[][] Rules = new dynamic[50][];
        private List<dynamic> Errors = new List<dynamic>();
        private int CountErrors = 0;

        public void addRule(dynamic component, string name, string rule) {
            this.Rules[this.contar] = new dynamic[] { component, name, rule };

            this.contar++;
        }

        private dynamic getValue(dynamic component) {
            if (component.GetType().BaseType.Name == "ComboBox") {
                return component.SelectedValue;
            }
            else {
                return component.Text;
            }
        }

        private void validateMin(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if ((rules.Contains("required") && value.ToString().Trim() != "") || value.ToString().Trim().Length > 0) {
                if (value.Length < rule) {
                    Errors.Add(new {Component = component, Message = name + " deve conter no minimo " + rule + " caracteres." });
                    this.CountErrors++;
                }
            }
        }

        private void validateMax(dynamic component, string name, int rule) {
            dynamic value = this.getValue(component);
            if (value.ToString().Length > rule) {
                Errors.Add(new { Component = component, Message = name + " deve conter no maximo " + rule + " caracteres." });
                this.CountErrors++;
            }
        }

        private void validateExact(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if ((rules.Contains("required") && value.ToString().Trim() != "") || value.ToString().Trim().Length > 0) {
                if (value.ToString().Length != rule) {
                    Errors.Add(new { Component = component, Message = name + " deve conter " + rule + " caracteres." });
                    this.CountErrors++;
                }
            }
        }

        private void validateDate(dynamic component, string name, string rule, string rules) {
            dynamic value = this.getValue(component);
            if ((rules.Contains("required") && value.ToString().Trim() != "") || value.ToString().Trim().Length > 0) {
                DateTime date;

                bool validate = DateTime.TryParseExact(value.ToString(), rule, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);

                if (!validate){
                    Errors.Add(new { Component = component, Message = name + " não é um fomato de data valido." });
                    this.CountErrors++;
                }
            }
        }

        private void ValidateRegExp(dynamic component, string name, string rule, string rules) {
            dynamic value = this.getValue(component);
            if ((rules.Contains("required") && value.ToString().Trim() != "") || value.ToString().Trim().Length > 0) {
                var regexp = rule;
                var match = System.Text.RegularExpressions.Regex.Match(value, regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não está em um formato valido." });
                    this.CountErrors++;
                }
            }
        }

        private void validateRequired(dynamic component, string name) {
            dynamic value = this.getValue(component);
            if (value.ToString().Trim() == "") {
                Errors.Add(new { Component = component, Message = name + " deve ser preenchido." });
                this.CountErrors++;
            }
        }

        private void validateNumeric(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if ((rules.Contains("required") && value.ToString().Trim() != "") || value.ToString().Trim().Length > 0) {
                var regexp = @"([0-9])";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " deve ser numerico." });
                    this.CountErrors++;
                }
            }
        }

        public void Validation() {
            for (var i = 0; i < this.contar; i++) {
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
                            case "exact":
                                this.validateExact(this.Rules[i][0], this.Rules[i][1], Int16.Parse(rule[1]), this.Rules[i][2]);
                                break;
                            case "regExp":
                                this.ValidateRegExp(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
                                break;
                            case "date":
                                this.validateDate(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
                                break;
                        }
                    }
                    else {
                        switch (divideRule) {
                            case "required":
                                this.validateRequired(this.Rules[i][0], this.Rules[i][1]);
                                break;
                            case "numeric":
                                this.validateNumeric(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                    break;
                            default:
                                Console.WriteLine("Regra não atribuida > " + divideRule);
                                break;
                        }
                    }
                }
            }
        }

        public bool IsValid() {
            if (this.CountErrors == 0 && this.Errors.Count == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<dynamic> getErrors() {
            return this.Errors;
        }
    }
}
