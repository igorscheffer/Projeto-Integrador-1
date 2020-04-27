using System;

namespace Projeto_Integrador_1.Util.Validate {
    class Rules {
        private bool _Optional;

        public dynamic Component { get; set; }
        public string Name { get; set; }
        public string Rule { get; set; }
        public string Value {
            get {
                if (Component.GetType().BaseType.Name == "ComboBox") {
                    if (Component.SelectedValue == null || Convert.ToString(Component.SelectedValue) == Convert.ToString(-1)) {
                        return string.Empty;
                    }
                    else {
                        return Convert.ToString(Component.SelectedValue);
                    }
                }
                else {
                    return Component.Text;
                }
            }
        }
        public bool Optional {
            get => _Optional;
            set {
                if (!string.IsNullOrEmpty(Convert.ToString(value))) {
                    _Optional = value;
                }
                else {
                    _Optional = !((Rule.Contains("required") && !Rule.Contains("required_if")) && !string.IsNullOrEmpty(Value)) || !string.IsNullOrEmpty(Value);
                }
            }
        }

        public void AddRule(Func<Rules, bool> p) {
            Console.WriteLine("Adicionou");
        }
    }
}
