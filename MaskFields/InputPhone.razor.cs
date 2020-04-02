
using System.Text.RegularExpressions;

namespace BlazorMaskedFields
{
    public class InputPhoneBase : InputMaskTemplate
    {
        public override string ApplyMask(string value)
        {
            value = Regex.Replace(value, @"\D", "");
            value = Regex.Replace(value, @"^(\d\d)(\d)",
                m => $"({m.Groups[1].Value}) {m.Groups[2].Value}");

            value = Regex.Replace(value, @"^(\(\d{2}\)\s\d{5})(\d)",
                    m => $"{m.Groups[1].Value}-{m.Groups[2].Value}");

            return value;

        }

    }
}
