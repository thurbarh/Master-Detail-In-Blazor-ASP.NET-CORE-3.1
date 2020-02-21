#pragma checksum "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\DetailDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11a527ca8ca0b782a94bd2b118a74c621dc569f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class DetailDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Solutions\Blazor\Projects\MasterDetails\MasterDetailCRUD\Shared\DetailDialog.razor"
       
    Dictionary<string, decimal> PriceList = new Dictionary<string, decimal>()
    {
        {"",0.00m },
        {"Apple Watch",130.00m },
        {"Google Pixel",290.20m },
        {"IphoneX Max",783.10m },
        {"Samsung S10",310.00m },
        {"Oppo Reno 8",400.30m },
    };
    public string SelectedValue
    {
        get { return orderDetail.Item; }
        set
        {
            orderDetail.Item = value;
            SelectChange();
        }
    }
    [Parameter] public OrderDetail orderDetail { get; set; }
    [Parameter] public List<OrderDetail> orderDetails { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public string BtnText { get; set; }
    private void AddToList()
    {
        if (string.IsNullOrEmpty(orderDetail.Item) || orderDetail.Price <= 0 || orderDetail.Quantity <= 0) return;
        if (orderDetail.OrderDetailId > 0)
        {
            var data = orderDetails.FirstOrDefault(m => m.OrderDetailId == orderDetail.OrderDetailId);
            data.Price = orderDetail.Price;
            data.Quantity = orderDetail.Quantity;
            data.Item = orderDetail.Item;
        }
        else
        {
            var data = orderDetails.FirstOrDefault(m => m.Item == orderDetail.Item);
            if (data != null)
            {
                data.Quantity += orderDetail.Quantity;
            }else
                orderDetails.Add(new OrderDetail()
                {
                    Item = orderDetail.Item,
                    Price = orderDetail.Price,
                    Quantity = orderDetail.Quantity,
                    OrderDetailId = (orderDetails.Count > 0 ? orderDetails.Select(m => m.OrderDetailId).Max() : 0) + 1
                });
        }
        Reset();
        StateHasChanged();
    }
    private void Reset()
    {
        orderDetail = new OrderDetail();
    }

    private void SelectChange()
    {
        orderDetail.Price = PriceList[orderDetail.Item];
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591