using System;

namespace Projeto_Integrador_1.Util.Validate {
    class Rules {
        public dynamic Component { get; set; }
        public string Name { get; set; }
        public string Rule { get; set; }
        public string Value {
            get {
                if (Component.GetType().BaseType.Name == "ComboBox") {
                    if (Component.SelectedValue == null || Component.SelectedValue == -1) {
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
            get {
                return (Rule.Contains("required") && !string.IsNullOrEmpty(Value)) || !string.IsNullOrEmpty(Value);
            }
        }

        public void AddRule(Func<Rules, bool> p) {
            Console.WriteLine("Adicionou");
        }
    }
}
