
using System.Text.RegularExpressions;

namespace BlazorMaskedFields
{
    public class InputCPFBase : InputMaskTemplate
    {
        public override string ApplyMask(string value)
        {
            value = Regex.Replace(value, @"\D", "");
            value = Regex.Replace(value, @"^(\d{3})(\d)",
                m => $"{m.Groups[1].Value}.{m.Groups[2].Value}");

            value = Regex.Replace(value, @"(\d{3}\.)(\d{3})(\d)",
                    m => $"{m.Groups[1].Value}{m.Groups[2].Value}.{m.Groups[3].Value}");

            value = Regex.Replace(value, @"(\d{3})(\d{1,2})$",
                    m => $"{m.Groups[1].Value}-{m.Groups[2].Value}");


            return value;
        }
    }
}
