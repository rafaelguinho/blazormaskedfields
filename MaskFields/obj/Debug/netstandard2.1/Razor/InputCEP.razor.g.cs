#pragma checksum "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6470811fc27d90682b0b61f67ce79bdf29ec448"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMaskedFields
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class InputCEP : InputCEPBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "placeholder", "99999-999");
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 4 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
                                                   CssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "name", 
#nullable restore
#line 5 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
              Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "maxlength", "9");
            __builder.AddAttribute(6, "id", 
#nullable restore
#line 8 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
            Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
                          HandleInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
                OnBlur

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\rafae\OneDrive\Documentos\coding\dotnet\MaskFields\MaskFields\InputCEP.razor"
              CurrentValueAsString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValueAsString = __value, CurrentValueAsString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
