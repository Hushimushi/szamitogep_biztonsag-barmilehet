#pragma checksum "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "975a3c101cf9d8aa9641f7882db42c4071e2bb3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Webshop.Pages.CaffFile.Views_CaffFile_List), @"mvc.1.0.view", @"/Views/CaffFile/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaffFile/List.cshtml", typeof(Webshop.Pages.CaffFile.Views_CaffFile_List))]
namespace Webshop.Pages.CaffFile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop;

#line default
#line hidden
#line 3 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Data;

#line default
#line hidden
#line 6 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Authorization;

#line default
#line hidden
#line 7 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 8 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"975a3c101cf9d8aa9641f7882db42c4071e2bb3f", @"/Views/CaffFile/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d18379911d937ec75815c488f3871f82ee60eeb", @"/Views/_ViewImports.cshtml")]
    public class Views_CaffFile_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webshop.Models.CaffFile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(87, 165, true);
            WriteLiteral("\r\n<h2>List</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Picture\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 43, false);
#line 16 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(296, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(416, 52, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 468, "\"", 489, 1);
#line 26 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
WriteAttributeValue("", 474, item.ImagePath, 474, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 95, true);
            WriteLiteral(" style=\"max-width:600px;width:100%\" />\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(586, 42, false);
#line 30 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(628, 53, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n");
            EndContext();
#line 34 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(
              User, item,
              CaffFileOperations.Update)).Succeeded)
                {

#line default
#line hidden
            BeginContext(847, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(867, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b987207462bf411d93c73aaea8111fe2", async() => {
                BeginContext(912, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(920, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(948, 3, true);
            WriteLiteral(" | ");
            EndContext();
#line 39 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                                    
                }

#line default
#line hidden
            BeginContext(979, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 41 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                 if ((await AuthorizationService.AuthorizeAsync(
               User, item,
               CaffFileOperations.Delete)).Succeeded)
                {

#line default
#line hidden
            BeginContext(1147, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1167, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f4e3e1685346d1998755eb935848f0", async() => {
                BeginContext(1214, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1224, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                }

#line default
#line hidden
            BeginContext(1245, 50, true);
            WriteLiteral("                <text> | </text>\r\n                ");
            EndContext();
            BeginContext(1295, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f724c0af3147eea2dde4ec060d3141", async() => {
                BeginContext(1344, 8, true);
                WriteLiteral("Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1356, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\playm\Desktop\MSc\szamitogep_biztonsag\akos\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\List.cshtml"
}

#line default
#line hidden
            BeginContext(1397, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webshop.Models.CaffFile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
