#pragma checksum "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c4b5eb4f57a30f8445e04948e7c8cdb8822ac1"
// <auto-generated/>
#pragma warning disable 1591
namespace MasterDetailCRUD.Shared
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
    public partial class CreateDetailTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-bordered");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<thead>\r\n        <tr>\r\n            <th>Item</th>\r\n            <th>Price</th>\r\n            <th>Quantity</th>\r\n            <th>#</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 12 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
         foreach (var order_Detail in orderDetails)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
                     order_Detail.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
                     order_Detail.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
                     order_Detail.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
                                                                       ()=>EditItem(order_Detail)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "|\r\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
                                                                      () => RemoveItem(order_Detail)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 23 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\CreateDetailTable.razor"
       
    [Parameter] public List<OrderDetail> orderDetails { get; set; }
    [Parameter] public OrderDetail orderDetail { get; set; }
    [Parameter] public EventCallback<OrderDetail> _EditItem { get; set; }
    private async void RemoveItem(OrderDetail detail)
    {
        if (await JS.Confirm($"Remove {detail.Item} from your order?"))
        {
            orderDetails.Remove(detail);
            await JS.Alert($"You Removed {detail.Item} from your order");
        }
    }
    private void EditItem(OrderDetail detail)
    {
        _EditItem.InvokeAsync(detail);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
