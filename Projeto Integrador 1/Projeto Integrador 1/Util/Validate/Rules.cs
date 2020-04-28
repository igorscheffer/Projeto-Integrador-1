using System;
using System.Windows.Forms;

namespace Projeto_Integrador_1.Util.Validate {
    class Rules {
        private bool? _Optional = null;

        public dynamic Component { get; set; }
        public string Name { get; set; }
        public string Rule { get; set; }
        public string Value {
            get {
                if (Component.GetType().Name == "ComboBox" || Component.GetType().BaseType.Name == "ComboBox") {
                    if (Component.SelectedValue == null || Convert.ToString(Component.SelectedValue) == Convert.ToString(-1)) {
                        return string.Empty;
                    }
                    else {
                        return Convert.ToString(Component.SelectedValue);
                    }
                }
                else if (Component.GetType().Name == "MaskedTextBox" || Component.GetType().BaseType.Name == "MaskedTextBox") {
                    MaskedTextBox UnMask = Component;
                    UnMask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (string.IsNullOrWhiteSpace(UnMask.Text)) {
                        return string.Empty;
                    }
                    else {
                        UnMask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        return Component.Text;
                    }
                }
                else {
                    return Component.Text;
                }
            }
        }
        public bool Optional {
            get {
                if (_Optional == null) {
                    return !(((Rule.Contains("required") && !Rule.Contains("required_if")) && !string.IsNullOrEmpty(Value)) || !string.IsNullOrEmpty(Value));
                }
                else {
                    return Convert.ToBoolean(_Optional);
                }
            }
            set {
                _Optional = value;
            }
        }

        public void AddRule(Func<Rules, bool> p) {
            Console.WriteLine("Adicionou");
        }
    }
}
