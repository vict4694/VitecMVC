#pragma checksum "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9700c1e189b0189a0211ef9e38fe3fbdf7bfe4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Produkter), @"mvc.1.0.view", @"/Views/Home/Produkter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Produkter.cshtml", typeof(AspNetCore.Views_Home_Produkter))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\_ViewImports.cshtml"
using VitecMVC;

#line default
#line hidden
#line 2 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\_ViewImports.cshtml"
using VitecMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9700c1e189b0189a0211ef9e38fe3fbdf7bfe4d2", @"/Views/Home/Produkter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17edae27d7be85ad6ab9e4960791c698542c4541", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Produkter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
  
    ViewData["Title"] = "Produkter";
    

#line default
#line hidden
            BeginContext(79, 19, true);
            WriteLiteral("<h1 align=\"center\">");
            EndContext();
            BeginContext(99, 17, false);
#line 5 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(116, 1324, true);
            WriteLiteral(@"</h1>

<p align=""center"">Her kan du se vores sortiment af produkter:</p>

<div class=""row"">
    <div class=""col-sm-6"" style=""width:18rem;"">
        <img class=""card-img-top"" src=""https://api.fleekframework.com/sites/CDORD.png"" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 align=""center"" class=""card-title"">CD-ORD</h5>
            <p align=""center"" class=""card-text"">12 måneders abonnement<br />Køb nu og spar 40%<br />Nu KUN 420,-</p>
            <a align=""center"" href=""#"" class=""btn btn-primary"">Bestil nu</a>
        </div>
    </div>

    <div class=""col-sm-6"" style=""width:18rem;"">
        <img class=""card-img-top"" src=""https://api.fleekframework.com/sites/INTOWORDS.png"" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 align=""center"" class=""card-title"">IntoWords</h5>
            <p align=""center"" class=""card-text"">12 måneders abonnement<br />Køb nu og spar 40%<br />Nu KUN 420,-</p>
            <a href=""#"" class=""btn btn-primary"">Bestil nu</a>
   ");
            WriteLiteral(@"     </div>
    </div>

</div>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Product Description</th>
            <th scope=""col"">Price</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 40 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
         foreach (var product in @Model)
        {

#line default
#line hidden
            BeginContext(1493, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1524, 10, false);
#line 43 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
           Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1534, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1558, 13, false);
#line 44 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
           Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1595, 26, false);
#line 45 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
           Write(product.ProductDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1645, 13, false);
#line 46 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1658, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1699, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9700c1e189b0189a0211ef9e38fe3fbdf7bfe4d28012", async() => {
                BeginContext(1782, 100, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\"> Køb </button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
                                                            WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1889, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\Ander\Documents\GitHub\VitecMVC\VitecMVC\VitecMVC\Views\Home\Produkter.cshtml"
        }

#line default
#line hidden
            BeginContext(1936, 30, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
