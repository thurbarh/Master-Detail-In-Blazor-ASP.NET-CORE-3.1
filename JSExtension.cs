using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterDetailCRUD
{
    public static class JSExtension
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeAsync<bool>("confirm", message);
        }
        public static ValueTask Alert(this IJSRuntime jSRuntime,string message)
        {
            return jSRuntime.InvokeVoidAsync("alert", message);
        }
    }
}
