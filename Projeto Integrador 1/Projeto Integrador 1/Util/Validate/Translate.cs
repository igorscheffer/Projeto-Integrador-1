using System.Collections.Generic;

namespace Projeto_Integrador_1.Util.Validate {
    class Translate {
        private string _Message;

        public dynamic Rules { get; set; }
        public string Rule { get; set; }
        public string RuleValue { get; set; }
        public string Message {
            get {
                GenerateMessage();
                return _Message;
            }
        }

        public void GenerateMessage() {
            string name = Rules.Name;
            string rule = Rule;
            string ruleValue = RuleValue ?? string.Empty;

            string Message = DefaultMessage[rule];
            Message = Message.Replace("{name}", name);
            Message = Message.Replace("{ruleValue}", ruleValue);

            _Message = Message;
        }

        public Dictionary<string, string> DefaultMessage = new Dictionary<string, string>() {
            { "required",       "{name} deve ser preenchido." },
            { "match",          "{name} deve combinar com o campo {ruleValue}" },
            { "different",      "{name} deve ter um valor diferente do campo {ruleValue}" },
            { "numeric",        "{name} deve ser definido para um número" },
            { "email",          "{name} deve ser um E-Mail válido" },
            { "cpf",            "{name} deve ser um número de CPF válido" },
            { "cnpj",           "{name} deve ser um número de CNPJ válido" },
            { "telefone",       "{name} deve ser um numero de telefone válido" },
            { "nfe",            "{name} deve ser um numero de nf-e válida" },
            { "reais",          "{name} deve ser um valor válido dentro do padrão 0.000,00" },
            { "cep",            "{name} deve ser um CEP válida" },
            { "placa",          "{name} deve ser uma Placa válida" },
            { "min",            "{name} deve ser pelo menos {ruleValue} caracteres" },
            { "max",            "{name} não pode ser mais longo do que {ruleValue} caracteres" },
            { "exact",          "{name} deve ser exatamente {ruleValue} caracteres" },
            { "regExp",         "{name} não está formatado corretamente" },
            { "in",             "{name} deve ter exatamente {ruleValue}" },
            { "date",           "{name} deve ser uma data válida" }
        };
    }
}
