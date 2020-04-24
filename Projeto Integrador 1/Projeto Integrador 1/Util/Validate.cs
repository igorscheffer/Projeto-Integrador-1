using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util
{
    class Validate {
        private int contar = 0;

        private dynamic[][] Rules = new dynamic[50][];
        private List<dynamic> Valids = new List<dynamic>();
        private List<dynamic> Errors = new List<dynamic>();
        private int CountErrors = 0;

        public void addRule(dynamic component, string name, string rule) {
            this.Rules[this.contar] = new dynamic[] { component, name, rule };

            this.contar++;
        }

        private dynamic getValue(dynamic component) {
            if (component.GetType().BaseType.Name == "ComboBox") {
                if (component.SelectedValue == null) {
                    return "";
                }

                return component.SelectedValue;
            }
            else {
                return component.Text;
            }
        }

        private bool optional(dynamic value, string rules) {
            return (rules.Contains("required") && value.ToString().Trim() != "") && (Convert.ToString(value) != Convert.ToString(-1) && value.ToString().Trim().Length > 0);
        }

        private void validateMin(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                if (value.Length < rule)
                {
                    Errors.Add(new { Component = component, Message = name + " deve conter no minimo " + rule + " caracteres." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateMax(dynamic component, string name, int rule) {
            dynamic value = this.getValue(component);
            if (value.ToString().Length > rule)
            {
                Errors.Add(new { Component = component, Message = name + " deve conter no maximo " + rule + " caracteres." });
                this.CountErrors++;
            }
            else {
                Valids.Add(new { Component = component, Value = value });
            }
        }

        private void validateExact(dynamic component, string name, int rule, string rules) {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules)) {
                if (value.ToString().Length != rule)
                {
                    Errors.Add(new { Component = component, Message = name + " deve conter " + rule + " caracteres." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateRegExp(dynamic component, string name, string rule, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = rule;
                var match = System.Text.RegularExpressions.Regex.Match(value, regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não está em um formato valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateIn(dynamic component, string name, string rule, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                string[] inRules = rule.Split(',');

                if (!Array.Exists(inRules, array => array.ToLower() == value.ToLower()))
                {
                    Errors.Add(new { Component = component, Message = name + " não é um valor valido." });
                    this.CountErrors++;
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

                if (!validate)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um fomato de data valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }        

        private bool validateRequired(dynamic component, string name) {
            dynamic value = this.getValue(component);
            if (value.ToString().Trim() == "" || Convert.ToString(value) == Convert.ToString(-1))
            {
                Errors.Add(new { Component = component, Message = name + " deve ser preenchido." });
                this.CountErrors++;
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

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um endereco de E-mail valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateNumeric(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"([0-9])";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " deve ser numerico." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCPF(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^(\d{3})(\.\d{3})(\.\d{3})(\-\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um número de CPF valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCNPJ(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^(\d{2})(\.\d{3}){2}(\/\d{4})(\-\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um número de CNPJ valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateTelefone(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"\(\d{2,}\) \d{4,}\-\d{4}$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um número de Telefone valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateNFE(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^(\d{0,3}(\.\d{3}){2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um número de NF-E valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateReais(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^(\d{1,3}(\.\d{3})*)(\,\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um valor R$ valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validateCEP(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^(\d{5})(\-\d{3})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é um número CEP valido." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        private void validatePlaca(dynamic component, string name, string rules)
        {
            dynamic value = this.getValue(component);
            if (this.optional(value, rules))
            {
                var regexp = @"^([A-Z]{3})(\-\d\w\d{2})$";
                var match = System.Text.RegularExpressions.Regex.Match(value.ToString(), regexp, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    Errors.Add(new { Component = component, Message = name + " não é uma Placa valida." });
                    this.CountErrors++;
                }
                else {
                    Valids.Add(new { Component = component, Value = value });
                }
            }
        }

        public void Validation() {
            for (var i = 0; i < this.contar; i++) {
                string[] rules = this.Rules[i][2].Split('|');

                foreach (var divideRule in rules) {
                    if (divideRule.Contains(":")){
                        string[] rule = divideRule.Split(new char[] {':'}, 2, StringSplitOptions.None);
                        
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
                                this.validateRegExp(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
                                break;
                            case "in":
                                this.validateIn(this.Rules[i][0], this.Rules[i][1], rule[1], this.Rules[i][2]);
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
                            case "email":
                                this.validateEmail(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "cpf":
                                this.validateCPF(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "cnpj":
                                this.validateCNPJ(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "telefone":
                                this.validateTelefone(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "nfe":
                                this.validateNFE(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "reais":
                                this.validateReais(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "cep":
                                this.validateCEP(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            case "placa":
                                this.validatePlaca(this.Rules[i][0], this.Rules[i][1], this.Rules[i][2]);
                                break;
                            default:
                                Errors.Add(new { Component = this.Rules[i][0], Message = this.Rules[i][1] + " " + divideRule + " não é um regra valida." });
                                this.CountErrors++;
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

        public void ErrorMessageBox() {
            string ShowMessage = "\n";

            foreach (dynamic Erro in this.getErrors())
            {
                ShowMessage += Erro.Message + "\n\n";
            }

            MessageBox.Show(ShowMessage, "VALIDAÇÃO");
        }
    }
}
