using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Threading.Tasks;

namespace BlazorMaskedFields
{
    public abstract class InputMaskTemplate: InputBase<string>
    {
        [Parameter] public string Id { get; set; }
        [Parameter] public string Name { get; set; }


        private FieldIdentifier _fieldIdentifier;

        protected override void OnInitialized()
        {
            _fieldIdentifier = FieldIdentifier.Create(ValueExpression);
        }

        protected async Task HandleInput(ChangeEventArgs args)
        {
            var value = args.Value.ToString();

            value = ApplyMask(value);

            await ValueChanged.InvokeAsync(value);
            EditContext?.NotifyFieldChanged(_fieldIdentifier);
        }

        protected abstract string ApplyMask(string value);

        protected override bool TryParseValueFromString(string value, out string result, out string validationErrorMessage)
        {
            result = value;
            validationErrorMessage = null;

            return true;
        }
    }
}
