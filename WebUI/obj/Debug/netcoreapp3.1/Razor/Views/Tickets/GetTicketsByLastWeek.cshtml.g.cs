#pragma checksum "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49af304242e33201be1834fefba28ccde625e131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_GetTicketsByLastWeek), @"mvc.1.0.view", @"/Views/Tickets/GetTicketsByLastWeek.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49af304242e33201be1834fefba28ccde625e131", @"/Views/Tickets/GetTicketsByLastWeek.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4f0e801946e5c34baf0e0facf37922724ab8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_GetTicketsByLastWeek : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Models.TicketsTicketsByLastWeekViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
  
    ViewData["Title"] = "Son Bir Hafta Açılan Kayıtlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
 foreach (var item in Model.TicketsByLastWeek)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 12 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 14 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 16 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/GetTicketsByLastWeek.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Models.TicketsTicketsByLastWeekViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
