
using System.Text.RegularExpressions;

namespace BlazorMaskedFields
{
    public class InputChassiBase : InputMaskTemplate
    {
        public override string ApplyMask(string value)
        {
            value = value.ToUpper();
            value = Regex.Replace(value, @"[^A-Za-z0-9]", "");
            value = Regex.Replace(value, @"^(\w{3})(\w)",
                m => $"{m.Groups[1].Value}.{m.Groups[2].Value}");

            value = Regex.Replace(value, @"(\w{3}\.)(\w{6})(\w)",
                    m => $"{m.Groups[1].Value}{m.Groups[2].Value}.{m.Groups[3].Value}");

            value = Regex.Replace(value, @"(\w{3}\.)(\w{6}\.)(\w{2})(\w)",
                    m => $"{m.Groups[1].Value}{m.Groups[2].Value}{m.Groups[3].Value}.{m.Groups[4].Value}");


            return value;
        }
    }
}
