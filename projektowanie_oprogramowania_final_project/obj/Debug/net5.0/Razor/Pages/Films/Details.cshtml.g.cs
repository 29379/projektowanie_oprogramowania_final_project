#pragma checksum "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0779c6ea862f0ad8a2a5f7337ce4752716f4fe5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(projektowanie_oprogramowania_final_project.Pages.Films.Pages_Films_Details), @"mvc.1.0.razor-page", @"/Pages/Films/Details.cshtml")]
namespace projektowanie_oprogramowania_final_project.Pages.Films
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\_ViewImports.cshtml"
using projektowanie_oprogramowania_final_project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0779c6ea862f0ad8a2a5f7337ce4752716f4fe5d", @"/Pages/Films/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc7cc31f535353fbc0dfba8db5006c598b7bcfec", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Films_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Film</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.RunningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.RunningTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayFor(model => model.Film.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Film.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dd class = \"col-sm-10\">\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
                 if (Model.Film.ImagePath == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/images/no-image.jpg\"/>\r\n");
#nullable restore
#line 56 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 1890, "\"", 1918, 2);
            WriteAttributeValue("", 1896, "/", 1896, 1, true);
#nullable restore
#line 59 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
WriteAttributeValue("", 1897, Model.Film.ImagePath, 1897, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 60 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n\r\n    </dl>\r\n    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 2000, "\"", 2053, 1);
#nullable restore
#line 64 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
WriteAttributeValue("", 2006, Html.DisplayFor(modelItem => Model.Film.Image), 2006, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"detail_thumbnail\"/>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 67 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
     if (User.IsInRole("Admin") || (User.IsInRole("Employee")))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0779c6ea862f0ad8a2a5f7337ce4752716f4fe5d11655", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
                               WriteLiteral(Model.Film.FilmId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Lenovo\source\repos\projektowanie_oprogramowania_final_project\projektowanie_oprogramowania_final_project\Pages\Films\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0779c6ea862f0ad8a2a5f7337ce4752716f4fe5d14130", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projektowanie_oprogramowania_final_project.Pages.Films.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<projektowanie_oprogramowania_final_project.Pages.Films.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<projektowanie_oprogramowania_final_project.Pages.Films.DetailsModel>)PageContext?.ViewData;
        public projektowanie_oprogramowania_final_project.Pages.Films.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
