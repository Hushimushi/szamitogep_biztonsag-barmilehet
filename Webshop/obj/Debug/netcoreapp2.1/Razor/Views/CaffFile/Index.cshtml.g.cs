#pragma checksum "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c0049ad4d74889eb9e36483efcb9375dc6dceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Webshop.Pages.CaffFile.Views_CaffFile_Index), @"mvc.1.0.view", @"/Views/CaffFile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CaffFile/Index.cshtml", typeof(Webshop.Pages.CaffFile.Views_CaffFile_Index))]
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
#line 1 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop;

#line default
#line hidden
#line 3 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Data;

#line default
#line hidden
#line 6 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Authorization;

#line default
#line hidden
#line 7 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 8 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\_ViewImports.cshtml"
using Webshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c0049ad4d74889eb9e36483efcb9375dc6dceb", @"/Views/CaffFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d18379911d937ec75815c488f3871f82ee60eeb", @"/Views/_ViewImports.cshtml")]
    public class Views_CaffFile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webshop.Models.CaffFile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
            BeginContext(108, 369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae96aca57ab74fe2a1f7edaa563aad84", async() => {
                BeginContext(146, 123, true);
                WriteLiteral("\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Find by creator: <input type=\"text\" name=\"SearchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 269, "\"", 303, 1);
#line 12 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
WriteAttributeValue("", 277, ViewData["CurrentFilter"], 277, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(304, 95, true);
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(399, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac553bee5d44afd8fa43e2d934c9c1b", async() => {
                    BeginContext(421, 17, true);
                    WriteLiteral("Back to Full List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(442, 28, true);
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(477, 148, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Picture\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(626, 43, false);
#line 25 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(669, 155, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                Uploaded by:\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(873, 62, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 935, "\"", 956, 1);
#line 40 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
WriteAttributeValue("", 941, item.ImagePath, 941, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 123, true);
            WriteLiteral(" style=\"max-width:600px;width:100%\" />\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1081, 42, false);
#line 44 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 84, true);
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1208, 48, false);
#line 48 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 51 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(
                    User, item,
                    CaffFileOperations.Update)).Succeeded)
                    {

#line default
#line hidden
            BeginContext(1489, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1513, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e15771e4eaf943e6bebf6fc6ff90d3c1", async() => {
                BeginContext(1558, 4, true);
                WriteLiteral("Edit");
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
#line 55 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
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
            BeginContext(1566, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1598, 3, true);
            WriteLiteral(" | ");
            EndContext();
#line 56 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
                                        
                    }

#line default
#line hidden
            BeginContext(1633, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 58 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(
                     User, item,
                     CaffFileOperations.Delete)).Succeeded)
                    {

#line default
#line hidden
            BeginContext(1821, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1845, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29010df625894ab380083c8bfdd1b634", async() => {
                BeginContext(1892, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
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
            BeginContext(1902, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1927, 58, true);
            WriteLiteral("                    <text> | </text>\r\n                    ");
            EndContext();
            BeginContext(1985, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5724f69b4004ec5afe194d6a01c60e5", async() => {
                BeginContext(2034, 8, true);
                WriteLiteral("Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
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
            BeginContext(2046, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\Stingx\Desktop\Számítógép biztonság\NagyHf\Code\szamitogep_biztonsag-barmilehet\Webshop\Views\CaffFile\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2101, 24, true);
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
