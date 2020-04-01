
using System.Text.RegularExpressions;

namespace BlazorMaskedFields
{
    public class InputCEPBase : InputMaskTemplate
    {
        protected override string ApplyMask(string value)
        {
            value = Regex.Replace(value, @"\D", "");
            value = Regex.Replace(value, @"^(\d{5})(\d)",
                m => $"{m.Groups[1].Value}-{m.Groups[2].Value}");


            return value;
        }
    }
}
