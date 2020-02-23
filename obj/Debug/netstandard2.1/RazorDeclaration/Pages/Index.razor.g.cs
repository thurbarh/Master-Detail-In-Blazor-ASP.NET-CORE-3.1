#pragma checksum "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67bc9d291aa31002a0ccc50ce9b3ee37930f77b2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MasterDetailCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using MasterDetailCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using MasterDetailCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\_Imports.razor"
using MasterDetailCRUD.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
       
    private List<OrderViewModel> orders;
    protected override async Task OnInitializedAsync()
    {
        orders = await Http.GetJsonAsync<List<OrderViewModel>>("orders");
    }
    void ChangeDetailState(OrderViewModel order)
    {
        order.ShowDetail = !order.ShowDetail;
        if (order.ShowDetail) order.DetailIcon = "oi-caret-bottom";
        else order.DetailIcon = "oi-caret-right";

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
