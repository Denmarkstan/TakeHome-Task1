#pragma checksum "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\Pages\Invoices.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cde49c13e401f46dd504a0800f20a95e41586a"
// <auto-generated/>
#pragma warning disable 1591
namespace TakeHomeTask.InvoiceManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nedu\Projects\TakeHomeTask\TakeHomeTask.InvoiceManager\_Imports.razor"
using TakeHomeTask.InvoiceManager.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/invoices")]
    public partial class Invoices : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TakeHomeTask.InvoiceManager.Pages.TabControl>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<TakeHomeTask.InvoiceManager.Pages.TabPage>(2);
                __builder2.AddAttribute(3, "Text", "Invoices");
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<TakeHomeTask.InvoiceManager.Pages.InvoiceList>(5);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\t");
                __builder2.OpenComponent<TakeHomeTask.InvoiceManager.Pages.TabPage>(7);
                __builder2.AddAttribute(8, "Text", "Create New Invoice");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<TakeHomeTask.InvoiceManager.Pages.EditInvoice>(10);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\t");
                __builder2.OpenComponent<TakeHomeTask.InvoiceManager.Pages.TabPage>(12);
                __builder2.AddAttribute(13, "Text", "Settings");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "<div>Settings </div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591