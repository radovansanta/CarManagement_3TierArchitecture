// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
