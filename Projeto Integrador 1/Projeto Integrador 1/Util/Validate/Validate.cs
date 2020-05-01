using Projeto_Integrador_1.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util.Validate {
    class Validate {
        Form ValidateForm;
        ErrorProvider ErrorProvider;

        private List<Rules> Rules = new List<Rules>();
        private List<Valid> Valid = new List<Valid>();
        private List<Errors> Errors = new List<Errors>();

        public Validate(Form Form = null, ErrorProvider ErrorProvider = null) {
            ValidateForm = Form;
            this.ErrorProvider = ErrorProvider;
        }

        public void AddRule(dynamic Component, string Name, string Rule) {
            Rules.Add(new Rules { Component = Component, Name = Name, Rule = Rule });
        }

        private void ValidateMin(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                if (Rules.Value.Length < Convert.ToInt16(RuleValue)) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
            }
        }

        private void ValidateMax(Rules Rules, string Rule, string RuleValue) {
            if (Rules.Value.Length > Convert.ToInt16(RuleValue)) {
                Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
            }
            else {
                Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
            }
        }

        private void ValidateExact(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                if (Rules.Value.Length != Convert.ToInt16(RuleValue)) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
            }
        }

        private void ValidateRegExp(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                var regexp = RuleValue;
                var match = Regex.Match(RuleValue, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
            }
        }

        private void ValidateIn(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                string[] inRules = RuleValue.Split(',');

                if (!Array.Exists(inRules, find => find.ToLower() == Rules.Value.ToLower())) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
            }
        }

        private void ValidateDate(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                DateTime date;

                bool validate = DateTime.TryParseExact(Rules.Value, RuleValue, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date);

                if (!validate) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule, RuleValue = RuleValue });
                }
            }
        }

        private void ValidateRequired(Rules Rules, string Rule) {
            if (string.IsNullOrWhiteSpace(Rules.Value)) {
                Errors.Add(new Errors { Rules = Rules, Rule = Rule });
            }
            else {
                Valid.Add(new Valid { Rules = Rules, Rule = Rule });
            }
        }

        private void ValidateRequiredIf(Rules Rules, string Rule, string RuleValue) {
            string[] inRules = RuleValue.Split(',');

            Rules RequiredIfComponent = this.Rules.Find(find => find.Component.Name == inRules[0]);

            if (RequiredIfComponent != null) {
                if (RuleValue.Contains(",")) {
                    if (Array.Exists(inRules, find => find.ToLower() == RequiredIfComponent.Value.ToLower())) {
                        ValidateRule(Rules, true);
                    }
                }
                else {
                    if (!string.IsNullOrWhiteSpace(RequiredIfComponent.Value)) {
                        ValidateRule(Rules, true);
                    }
                }
            }
        }

        private void ValidateMatch(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                Rules Match = this.Rules.Find(find => find.Component.Name == RuleValue);

                if (Rules.Value != Match.Value) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = Match.Name });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateDifferent(Rules Rules, string Rule, string RuleValue) {
            if (!Rules.Optional) {
                Rules Different = this.Rules.Find(find => find.Component.Name == RuleValue);

                if (Rules.Value == Different.Value) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule, RuleValue = Different.Name });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateEmail(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateNumeric(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^([0-9]*)$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateCPF(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(\d{3})([\.\,]\d{3})([\.\,]\d{3})(\-\d{2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateCNPJ(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(\d{2})([\.\,]\d{3}){2}(\/\d{4})(\-\d{2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateTelefone(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                Console.WriteLine("VALIDATE = >" + Rules.Value + "<");
                var regexp = @"\(\d{2,}\) \d{4,}\-\d{4}$";
                var match = Regex.Match(Rules.Value.Trim(), regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateNFE(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(\d{0,3}([\.\,]\d{3}){2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateReais(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(\d{1,3}(\.\d{3})*)(\,\d{2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateQuantidade(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^\d+(\,\d{2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidatePeso(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^\d+(\.\d{3})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateCEP(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^(\d{5})(\-\d{3})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidatePlaca(Rules Rules, string Rule) {
            if (!Rules.Optional) {
                var regexp = @"^([A-Z]{3})(\-\d\w\d{2})$";
                var match = Regex.Match(Rules.Value, regexp, RegexOptions.IgnoreCase);

                if (!match.Success) {
                    Errors.Add(new Errors { Rules = Rules, Rule = Rule });
                }
                else {
                    Valid.Add(new Valid { Rules = Rules, Rule = Rule });
                }
            }
        }

        private void ValidateRule(Rules Rule, bool ForceRequired = false) {
            if (!string.IsNullOrWhiteSpace(Rule.Rule)) {
                if (ForceRequired) ValidateRequired(Rule, "required");

                string[] split_rules = Rule.Rule.Split('|');

                foreach (string split_rule in split_rules) {
                    if (split_rule.Contains(':')) {
                        string[] sub_split_rules = split_rule.Split(new char[] { ':' }, 2, StringSplitOptions.None);

                        switch (sub_split_rules[0]) {
                            case "required_if": if (!ForceRequired) { ValidateRequiredIf(Rule, sub_split_rules[0], sub_split_rules[1]); } break;
                            case "match": ValidateMatch(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "different": ValidateDifferent(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "min": ValidateMin(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "max": ValidateMax(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "exact": ValidateExact(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "regExp": ValidateRegExp(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "in": ValidateIn(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                            case "date": ValidateDate(Rule, sub_split_rules[0], sub_split_rules[1]); break;
                        }
                    }
                    else {
                        switch (split_rule) {
                            case "required": ValidateRequired(Rule, split_rule); break;
                            case "numeric": ValidateNumeric(Rule, split_rule); break;
                            case "email": ValidateEmail(Rule, split_rule); break;
                            case "cpf": ValidateCPF(Rule, split_rule); break;
                            case "cnpj": ValidateCNPJ(Rule, split_rule); break;
                            case "telefone": ValidateTelefone(Rule, split_rule); break;
                            case "nfe": ValidateNFE(Rule, split_rule); break;
                            case "reais": ValidateReais(Rule, split_rule); break;
                            case "quantidade": ValidateQuantidade(Rule, split_rule); break;
                            case "peso": ValidatePeso(Rule, split_rule); break;
                            case "cep": ValidateCEP(Rule, split_rule); break;
                            case "placa": ValidatePlaca(Rule, split_rule); break;
                        }
                    }
                }
            }
        }

        public void Validation() {
            foreach (Rules Rule in Rules) {
                if (!string.IsNullOrWhiteSpace(Rule.Rule)) {
                    ValidateRule(Rule);
                }
            }
        }

        public bool IsValid() {
            if (Errors.Count() == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        public List<Valid> GetValid() {
            return Valid;
        }

        public List<Errors> GetErrors() {
            return Errors;
        }

        public void ErrorProviderShow(int Width = 20, int Height = 20, int Padding = -26) {
            if (ErrorProvider != null) {
                Bitmap ErrorIconBit = new Bitmap(Resources.error, Width, Height);

                System.Drawing.Icon ErrorIcon = System.Drawing.Icon.FromHandle(ErrorIconBit.GetHicon());

                ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                ErrorProvider.Icon = ErrorIcon;
                ErrorProvider.Clear();

                foreach (Errors Erro in GetErrors()) {
                    this.ErrorProvider.SetIconPadding(Erro.Rules.Component, Padding);
                    this.ErrorProvider.SetError(Erro.Rules.Component, Erro.Message);
                }
            }
        }

        public void ErrorMessageBox() {
            string ShowMessage = "\n";

            foreach (Errors Erro in GetErrors()) {
                ShowMessage += Erro.Message + "\n\n";
            }

            MessageBox.Show(ShowMessage, "VALIDAÇÃO");
        }
    }
}
