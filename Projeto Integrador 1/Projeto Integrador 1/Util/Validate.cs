using Projeto_Integrador_1.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util {
    class Validate {
        Form ValidateForm;
        ErrorProvider ErrorProvider;

        private int contar = 0;

        private dynamic[][] Rules = new dynamic[50][];
        private List<dynamic> Valids = new List<dynamic>();
        private List<dynamic> Errors = new List<dynamic>();
        private int CountErrors = 0;

        public Validate(Form Form = null, ErrorProvider ErrorProvider = null) {
            ValidateForm = Form;
            this.ErrorProvider = ErrorProvider;
        }

        public void addRule(dynamic component, string name, string rule) {
            Rules[contar] = new dynamic[] { component, name, rule };

            contar++;
        }

        private dynamic getValue(dynamic component) {
            if (component.GetType().BaseType.Name == "ComboBox") {
                if (component.SelectedValue == null || component.SelectedValue == -1) {
                    return string.Empty;
                }

                return component.SelectedValue;
            }
            else {
                return component.Text;
            }
        }
        private bool optional(dynamic value, string rules) {
            return (rules.Contains("required") && !string.IsNullOrEmpty(value.ToString())) || !string.IsNullOrEmpty(value.ToString());
        }

        private void validateMin(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                if (value.Length < rule) {
                    Errors.Add(new { Component = component, Message = name + " deve conter no minimo " + rule + " caracteres." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateMax(dynamic component, string name, int rule) {
            dynamic value = this.getValue(component);
            if (value.ToString().Length > rule) {
                Errors.Add(new { Component = component, Message = name + " deve conter no maximo " + rule + " caracteres." });
                CountErrors++;
            }
            else {
                Valids.Add(new { Component = component, Value = value });
            }
        }

        private void validateExact(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                if (value.ToString().Length != rule) {
                    Errors.Add(new { Component = component, Message = name + " deve conter " + rule + " caracteres." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateRegExp(dynamic component, string name, string rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = rule;
                var match = System.Text.RegularExpressions.Regex.Match(value, regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não está em um formato valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateIn(dynamic component, string name, string rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                string[] inRules = rule.Split(',');

                if (!Array.Exists(inRules, array => array.ToLower() == value.ToLower())) {
                    Errors.Add(new { Component = component, Message = name + " não é um valor valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateDate(dynamic component, string name, string rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                DateTime date;

                bool validate = DateTime.TryParseExact(value.ToString(), rule, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);

                if (!validate) {
                    Errors.Add(new { Component = component, Message = name + " não é um fomato de data valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private bool validateRequired(dynamic component, string name) {
            dynamic value = this.getValue(component);
            if (string.IsNullOrEmpty(value.ToString().Trim())) {
                Errors.Add(new { Component = component, Message = name + " deve ser preenchido." });
                CountErrors++;
                return false;
            }
            else {
                Valids.Add(new { Component = component, Value = value });
                return true;
            }
        }

        private void validateEmail(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um endereco de E-mail valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateNumeric(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                Console.WriteLine(name + " >>> " + value);
                var regexp = @"([0-9])";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " deve ser numerico." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCPF(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(\d{3})(\.\d{3})(\.\d{3})(\-\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um número de CPF valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCNPJ(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(\d{2})(\.\d{3}){2}(\/\d{4})(\-\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um número de CNPJ valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateTelefone(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"\(\d{2,}\) \d{4,}\-\d{4}$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um número de Telefone valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateNFE(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(\d{0,3}(\.\d{3}){2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um número de NF-E valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateReais(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(\d{1,3}(\.\d{3})*)(\,\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um valor R$ valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCEP(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^(\d{5})(\-\d{3})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é um número CEP valido." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validatePlaca(dynamic component, string name, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                var regexp = @"^([A-Z]{3})(\-\d\w\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new { Component = component, Message = name + " não é uma Placa valida." });
                    CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        public void Validation() {
            for (var i = 0; i < contar; i++) {
                string[] rules = this.Rules[i][2].Split('|');

                foreach (var divideRule in rules) {
                    if (divideRule.Contains(":")) {
                        string[] rule = divideRule.Split(new char[] { ':' }, 2, StringSplitOptions.None);

                        switch (rule[0]) {
                            case "min":
                                this.validateMin(Rules[i][0], Rules[i][1], Int16.Parse(rule[1]), Rules[i][2]);
                                break;
                            case "max":
                                this.validateMax(Rules[i][0], Rules[i][1], Int16.Parse(rule[1]));
                                break;
                            case "exact":
                                this.validateExact(Rules[i][0], Rules[i][1], Int16.Parse(rule[1]), Rules[i][2]);
                                break;
                            case "regExp":
                                this.validateRegExp(Rules[i][0], Rules[i][1], rule[1], Rules[i][2]);
                                break;
                            case "in":
                                this.validateIn(Rules[i][0], Rules[i][1], rule[1], Rules[i][2]);
                                break;
                            case "date":
                                this.validateDate(Rules[i][0], Rules[i][1], rule[1], Rules[i][2]);
                                break;
                            default:
                                Errors.Add(new { Component = Rules[i][0], Message = Rules[i][1] + " (" + rule[0] + ") não é um regra valida." });
                                CountErrors++;
                                throw new Exception(Rules[i][1] + " (" + rule[0] + ") não é um regra valida.");
                        }
                    }
                    else {
                        switch (divideRule) {
                            case "required":
                                this.validateRequired(Rules[i][0], Rules[i][1]);
                                break;
                            case "numeric":
                                this.validateNumeric(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "email":
                                this.validateEmail(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "cpf":
                                this.validateCPF(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "cnpj":
                                this.validateCNPJ(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "telefone":
                                this.validateTelefone(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "nfe":
                                this.validateNFE(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "reais":
                                this.validateReais(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "cep":
                                this.validateCEP(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            case "placa":
                                this.validatePlaca(Rules[i][0], Rules[i][1], Rules[i][2]);
                                break;
                            default:
                                Errors.Add(new { Component = Rules[i][0], Message = Rules[i][1] + " (" + divideRule + ") não é um regra valida." });
                                CountErrors++;
                                throw new Exception(Rules[i][1] + " (" + divideRule + ") não é um regra valida.");
                        }
                    }
                }
            }
        }

        public bool IsValid() {
            if (CountErrors == 0 && Errors.Count == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<dynamic> getErrors() {
            return Errors;
        }

        private void FindLabel(string labelName) {
            if (labelName != null) {
                System.Windows.Forms.Label label = ValidateForm.Controls.Find(labelName, true).FirstOrDefault() as System.Windows.Forms.Label;
                label.ForeColor = Color.Red;
            }
        }

        public void ErrorProviderShow() {
            if (ErrorProvider != null) {
                Bitmap ErrorIconBit = new Bitmap(Resources.error, 19, 19);

                System.Drawing.Icon ErrorIcon = System.Drawing.Icon.FromHandle(ErrorIconBit.GetHicon());

                ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                ErrorProvider.Icon = ErrorIcon;
                ErrorProvider.Clear();

                foreach (dynamic Erro in getErrors()) {
                    this.ErrorProvider.SetIconPadding(Erro.Component, -26);
                    this.ErrorProvider.SetError(Erro.Component, Erro.Message);
                }
            }
        }

        public void ErrorMessageBox() {
            string ShowMessage = "\n";

            foreach (dynamic Erro in getErrors()) {
                ShowMessage += Erro.Message + "\n\n";
            }

            MessageBox.Show(ShowMessage, "VALIDAÇÃO");
        }
    }
}
