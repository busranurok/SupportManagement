#pragma checksum "/Users/hbo/Projects/SupportManagement/WebUI/Views/Users/UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d2af6f09e1c240a5e86d9dd1217027eaeb7ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserList), @"mvc.1.0.view", @"/Views/Users/UserList.cshtml")]
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
#line 1 "/Users/hbo/Projects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hbo/Projects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hbo/Projects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hbo/Projects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d2af6f09e1c240a5e86d9dd1217027eaeb7ffa", @"/Views/Users/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4f0e801946e5c34baf0e0facf37922724ab8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("enhanced-results.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-select2-id", new global::Microsoft.AspNetCore.Html.HtmlString("23"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--MainContent-->\n<section class=\"content\" data-select2-id=\"25\">\n    <div class=\"container-fluid\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d2af6f09e1c240a5e86d9dd1217027eaeb7ffa4267", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""input-group input-group-lg"">
                    <input type=""search"" class=""form-control form-control-lg"" placeholder=""Type your keywords here"" value=""Aranacak kelimeyi giriniz."">
                    <div class=""input-group-append"">
                        <button type=""submit"" class=""btn btn-lg btn-default"">
                            <i class=""fa fa-search""></i>
                        </button>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""row mt-3"">
            <!-- Default box -->
            <div class=""card"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Kullanıcılar Listesi</h3>

                    <div class=""card-tools"">
                        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                            <i class=""fas fa-minus""></i>
                        </button>
                        <a class=""btn btn-primary btn-sm"" href=""#"">
                            <i class=""fas fa-plus"">
                            </i>
                            Ekle
                        </a>
                    </div>
                </div>
                <div class=""card-body p-0"">
                    <table class=""table table-striped projects"">
                        <thead>
                            <tr>
                                <th style=""width: 10%"">
                                    #
                                </");
            WriteLiteral(@"th>
                                <th style=""width: 15%"">
                                    Kullanıcı Adı
                                </th>
                                <th style=""width: 8%"">
                                    Oluşturma Tarihi
                                </th>
                                <th style=""width: 15%"">
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            <img alt=""Avatar"" class=""table-avatar"" src=""../../dist/img/avatar3.png"">
                                        </li>
                                    </ul>
                                </td>
                                <td>
                                    Hasan Basri OK
     ");
            WriteLiteral(@"                           </td>
                                <td>
                                    01.01.2019
                                </td>
                                <td class=""project-actions text-right"">
                                    <a class=""btn btn-primary btn-sm"" href=""#"">
                                        <i class=""fas fa-folder"">
                                        </i>
                                        Detay
                                    </a>
                                    <a class=""btn btn-info btn-sm"" href=""#"">
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                        Düzenle
                                    </a>
                                    <a class=""btn btn-danger btn-sm"" href=""#"">
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Sil
     ");
            WriteLiteral(@"                               </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            <img alt=""Avatar"" class=""table-avatar"" src=""../../dist/img/avatar.png"">
                                        </li>
                                    </ul>
                                </td>
                                <td>
                                    Büşra Nur OK
                                </td>
                                <td>
                                    01.01.2019
                                </td>
                                <td class=""project-actions text-right"">
                                    <a class=""btn btn-primary btn-sm"" href=""#"">
                                        <i class=""fas fa-folder"">
         ");
            WriteLiteral(@"                               </i>
                                        Detay
                                    </a>
                                    <a class=""btn btn-info btn-sm"" href=""#"">
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                        Düzenle
                                    </a>
                                    <a class=""btn btn-danger btn-sm"" href=""#"">
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Sil
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            <img alt=""Avatar"" class=""tabl");
            WriteLiteral(@"e-avatar"" src=""../../dist/img/avatar.png"">
                                        </li>
                                    </ul>
                                </td>
                                <td>
                                    Duman Can OK
                                </td>
                                <td>
                                    01.01.2019
                                </td>
                                <td class=""project-actions text-right"">
                                    <a class=""btn btn-primary btn-sm"" href=""#"">
                                        <i class=""fas fa-folder"">
                                        </i>
                                        Detay
                                    </a>
                                    <a class=""btn btn-info btn-sm"" href=""#"">
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                        Düzenle
                   ");
            WriteLiteral(@"                 </a>
                                    <a class=""btn btn-danger btn-sm"" href=""#"">
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Sil
                                    </a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""card-footer clearfix"">
                    <ul class=""pagination pagination-sm m-0 float-right"">
                        <li class=""page-item""><a class=""page-link"" href=""#"">«</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">»</a></li>
           ");
            WriteLiteral("         </ul>\n                </div>\n                <!-- /.card-body -->\n            </div>\n            <!-- /.card -->\n        </div>\n    </div>\n</section>\n<!--/.content-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
