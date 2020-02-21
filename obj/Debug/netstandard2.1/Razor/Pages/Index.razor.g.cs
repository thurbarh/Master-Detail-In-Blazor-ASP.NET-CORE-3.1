#pragma checksum "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e104fa56e3c98e96a19cb1e9c33e3e1df8eb89bb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Customer Orders</h1>\r\n");
            __builder.AddMarkupContent(1, "<div>\r\n    <a class=\"btn btn-primary\" href=\"create\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Create</a>\r\n    <p></p>\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
 if (orders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-bordered");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Order No.</th>\r\n                <th>Customer</th>\r\n                <th>Payment Method</th>\r\n                <th>Order Date</th>\r\n                <th>Total</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 27 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
             foreach (var order in orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n                       ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "oi" + " " + (
#nullable restore
#line 31 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                        order.DetailIcon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "aria-hidden", "true");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                                                                         ()=>ChangeDetailState(order)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "&nbsp;\r\n                       ");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                        order.OrderNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 34 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                         order.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 35 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                         order.PaymentMethod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 36 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                         order.DateCreated.ToString("ddd, MMM dd yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 37 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                         order.Total.ToString("#,##0.00;(#,##0.00)")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 39 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                if (order.OrderDetails.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                    ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "colspan", "5");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 43 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                             if (order.ShowDetail)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                                    ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "class", "table table-bordered");
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.AddMarkupContent(47, @"<thead>
                                            <tr>
                                                <th>Item</th>
                                                <th>Quantity</th>
                                                <th>Price</th>
                                            </tr>
                                        </thead>
                                        ");
            __builder.OpenElement(48, "tbody");
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 54 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                             foreach (var detail in order.OrderDetails)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                                                ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                                                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 57 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                                         detail.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                                    ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 58 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                                         detail.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 59 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                                         detail.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 61 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 64 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 67 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 71 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
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