#pragma checksum "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356449845f254760f443eca1227bdcc681a6559b"
// <auto-generated/>
#pragma warning disable 1591
namespace Car3TierSystem_1stTier.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Car3TierSystem_1stTier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/_Imports.razor"
using Car3TierSystem_1stTier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
using Car3TierSystem_1stTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
using Car3TierSystem_1stTier.Services;

#line default
#line hidden
#nullable disable
    public partial class AddCar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 100%; min-height: 100%");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "<h4>Create a new car</h4>\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                          _car

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                                                Add

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.AddAttribute(12, "style", "margin-bottom: 10px");
                __builder2.AddMarkupContent(13, "<div class=\"col-xs-3 col-sm-3 col-md-3 col-lg-3 col-xl-3\"><p>License plate:</p></div>\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-xs-5 col-sm-5 col-md-5 col-lg-5 col-xl-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "XX00123");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                                                                                       _car.LicensePlate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.LicensePlate = __value, _car.LicensePlate))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.LicensePlate));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.AddAttribute(25, "style", "margin-bottom: 10px");
                __builder2.AddMarkupContent(26, "<div class=\"col-xs-3 col-sm-3 col-md-3 col-lg-3 col-xl-3\"><p>Enter brand:</p></div>\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-xs-5 col-sm-5 col-md-5 col-lg-5 col-xl-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "Audi");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                                                                                    _car.Brand

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Brand = __value, _car.Brand))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.Brand));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "row");
                __builder2.AddAttribute(38, "style", "margin-bottom: 10px");
                __builder2.AddMarkupContent(39, "<div class=\"col-xs-3 col-sm-3 col-md-3 col-lg-3 col-xl-3\"><p>Enter model:</p></div>\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-xs-5 col-sm-5 col-md-5 col-lg-5 col-xl-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "placeholder", "A1 Hatchback");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                                                                                            _car.Model

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Model = __value, _car.Model))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.Model));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row");
                __builder2.AddAttribute(51, "style", "margin-bottom: 10px");
                __builder2.AddMarkupContent(52, "<div class=\"col-xs-3 col-sm-3 col-md-3 col-lg-3 col-xl-3\"><p>Power in HP:</p></div>\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-xs-5 col-sm-5 col-md-5 col-lg-5 col-xl-5");
                __Blazor.Car3TierSystem_1stTier.Components.AddCar.TypeInference.CreateInputNumber_0(__builder2, 55, 56, "form-control", 57, "135", 58, 
#nullable restore
#line 39 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
                                                                                     _car.Power

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Power = __value, _car.Power)), 60, () => _car.Power);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.AddMarkupContent(62, "<button type=\"submit\" class=\"btn btn-success\">Add car</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\n        ");
            __builder.AddContent(64, 
#nullable restore
#line 44 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
         _error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/radovansanta/RiderProjects/Car3TierSystem_1stTier/Car3TierSystem_1stTier/Components/AddCar.razor"
       
    private Car _car = new();
    private string _error;

    private async void Add()
    {
        try
        {
            Console.Write("Model je :" + _car.Model);
            await _carServices.AddCar(_car);
            _navigationManager.NavigateTo("/",true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            _error = "Car already exist";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarServices _carServices { get; set; }
    }
}
namespace __Blazor.Car3TierSystem_1stTier.Components.AddCar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591