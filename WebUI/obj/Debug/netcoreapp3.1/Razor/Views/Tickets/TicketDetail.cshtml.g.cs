#pragma checksum "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b6382f754f5634dbdda3e1102ea8ca778793c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_TicketDetail), @"mvc.1.0.view", @"/Views/Tickets/TicketDetail.cshtml")]
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
#nullable restore
#line 5 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b6382f754f5634dbdda3e1102ea8ca778793c8", @"/Views/Tickets/TicketDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493d55409fdd4b52daacfb95d8befa8b443a52d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_TicketDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebUI.Models.TicketsTicketDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ticketDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ticketDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Bir mesaj yaz."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Files", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6b6382f754f5634dbdda3e1102ea8ca778793c86215", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b6382f754f5634dbdda3e1102ea8ca778793c87313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 5 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
  
    ViewData["Title"] = "Kayıt Detayı";
    var userId = Context.Session.GetInt32("UserId");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"main_section\">\n    <div class=\"container\">\n        <div class=\"card card-default\">\n            <div class=\"card-header\">\n                <h3 class=\"card-title\">");
#nullable restore
#line 15 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                  Write(Model.Ticket.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <br />\n                <h3 class=\"card-title\">");
#nullable restore
#line 17 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                  Write(Model.Ticket.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <div class=""card-tools"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                </div>
            </div>
            <!-- /.card-header -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Oluşturulma Zamanı</label>
                            <br />
                            <label>");
#nullable restore
#line 31 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                              Write(Model.Ticket.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        </div>
                        <!-- /.form-group -->
                    </div>
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Oluşturan Kullanıcı</label>
                            <br />
                            <label>");
#nullable restore
#line 39 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                              Write(Model.Ticket.CreatedUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                                             Write(Model.Ticket.CreatedUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        </div>
                        <!-- /.form-group -->
                    </div>
                    <!-- /.col -->
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Üstlenen Kullanıcı</label>
                            <br />
                            <label>");
#nullable restore
#line 48 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                              Write(Model.Ticket.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                                       Write(Model.Ticket.Owner.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        </div>
                        <!-- /.form-group -->
                    </div>
                    <!-- /.col -->
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Kayıt Durumu</label>
                            <br />
                            <label>");
#nullable restore
#line 57 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                              Write(Model.Ticket.TicketStatus.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        </div>
                        <!-- /.form-group -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.card-body -->
        </div>

        <div class=""chat_container"">
            <div class=""col-sm-12 message_section"">
                <div class=""row"">
                    <div class=""new_message_head "">
                    </div><!--new_message_head-->

                    <div class=""chat_area"">
                        <ul class=""list-unstyled"">
");
#nullable restore
#line 76 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                             foreach (var item in Model.TicketMessages)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                 if (userId != item.CreatedUserId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""left clearfix"">
                                        <span class=""chat-img1 float-left"">
                                            <img src=""https://g.hizliresim.com/lila-orkide"" alt=""User Avatar"" class=""img-circle"">
                                        </span>
                                        <div class=""chat-body1 clearfix"">
                                            <p>
                                                ");
#nullable restore
#line 86 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                           Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </p>\n\n                                            <div class=\"chat_time float-right\"> ");
#nullable restore
#line 89 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                                                           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n                                        </div>\n                                    </li>\n");
#nullable restore
#line 93 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""left clearfix admin_chat"">
                                        <span class=""chat-img1 float-right"">
                                            <img src=""https://g.hizliresim.com/lila-orkide"" alt=""User Avatar"" class=""img-circle"">
                                        </span>
                                        <div class=""chat-body1 clearfix"">
                                            <p>
                                                ");
#nullable restore
#line 102 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                           Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </p>\n                                            <div class=\"chat_time float-left\">");
#nullable restore
#line 104 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                                                         Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                        </div>\n                                    </li>\n");
#nullable restore
#line 107 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </ul>\n                    </div><!--chat_area-->\n                    <div class=\"col-md-12\">\n\n                    </div>\n                    <!-- /.card -->\n\n");
#nullable restore
#line 118 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                     using (Html.BeginForm("Send", "Tickets", FormMethod.Post, new { enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message_write\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b6382f754f5634dbdda3e1102ea8ca778793c817873", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 121 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SendMessage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""clearfix""></div>
                            <div class=""chat_bottom"">
                                <div id=""actions"" class=""row"">
                                    <div class=""col-lg-6"">
                                        <p>Upload one or more files using this form:</p>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6b6382f754f5634dbdda3e1102ea8ca778793c819855", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 127 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Files);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row col-lg-12"">
                                    <button type=""submit"" class=""btn btn-success"">
                                        Gönder
                                    </button>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 137 "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/Views/Tickets/TicketDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div> <!--message_section-->
        </div>
    </div>
</div>


<script>$(function () {
    // BS-Stepper Init
    document.addEventListener('DOMContentLoaded', function () {
        window.stepper = new Stepper(document.querySelector('.bs-stepper'))
    })

    // DropzoneJS Demo Code Start
    Dropzone.autoDiscover = false

    // Get the template HTML and remove it from the doumenthe template HTML and remove it from the doument
    var previewNode = document.querySelector(""#template"")
    previewNode.id = """"
    var previewTemplate = previewNode.parentNode.innerHTML
    previewNode.parentNode.removeChild(previewNode)

    var myDropzone = new Dropzone(document.body, { // Make the whole body a dropzone
        url: ""/target-url"", // Set the url
        thumbnailWidth: 80,
        thumbnailHeight: 80,
        parallelUploads: 20,
        previewTemplate: previewTemplate,
        autoQueue: false, // Make sure the files aren't queued until manually added
        previewsCo");
            WriteLiteral(@"ntainer: ""#previews"", // Define the container to display the previews
        clickable: "".fileinput-button"" // Define the element that should be used as click trigger to select files.
    })

    myDropzone.on(""addedfile"", function (file) {
        // Hookup the start button
        file.previewElement.querySelector("".start"").onclick = function () { myDropzone.enqueueFile(file) }
    })

    // Update the total progress bar
    myDropzone.on(""totaluploadprogress"", function (progress) {
        document.querySelector(""#total-progress .progress-bar"").style.width = progress + ""%""
    })

    myDropzone.on(""sending"", function (file) {
        // Show the total progress bar when upload starts
        document.querySelector(""#total-progress"").style.opacity = ""1""
        // And disable the start button
        file.previewElement.querySelector("".start"").setAttribute(""disabled"", ""disabled"")
    })

    // Hide the total progress bar when nothing's uploading anymore
    myDropzone.on(""queuecomplete"", function (progre");
            WriteLiteral(@"ss) {
        document.querySelector(""#total-progress"").style.opacity = ""0""
    })

    // Setup the buttons for all transfers
    // The ""add files"" button doesn't need to be setup because the config
    // `clickable` has already been specified.
    document.querySelector(""#actions .start"").onclick = function () {
        myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED))
    }
    document.querySelector(""#actions .cancel"").onclick = function () {
        myDropzone.removeAllFiles(true)
}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Models.TicketsTicketDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
