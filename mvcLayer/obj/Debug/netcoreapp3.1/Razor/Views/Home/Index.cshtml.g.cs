#pragma checksum "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e8bd253a3ea100cdee948bb7b8ed76744d4d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\_ViewImports.cshtml"
using mvcLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\_ViewImports.cshtml"
using mvcLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e8bd253a3ea100cdee948bb7b8ed76744d4d09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b083d3c83baad64772ff3a2f986c4dc08c42786f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <!DOCTYPE html>\r\n  \r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e8bd253a3ea100cdee948bb7b8ed76744d4d093397", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n     <title>Книжковий магазин</title>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e8bd253a3ea100cdee948bb7b8ed76744d4d094471", async() => {
                WriteLiteral("\r\n     <div>\r\n         <h3>База даних СБУ</h3>\r\n         <table>\r\n             <tr>\r\n                 <td><p>Ім\'я</p></td>\r\n                 <td><p>Прізвище</p></td>\r\n                 <td><p>Вік</p></td>\r\n                 <td></td>\r\n             </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
              foreach (var b in ViewBag.Users)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <tr>\r\n\r\n                     <td><p>");
#nullable restore
#line 26 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
                       Write(b.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 27 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
                       Write(b.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 28 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
                       Write(b.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p><a");
                BeginWriteAttribute("href", " href=\"", 718, "\"", 744, 2);
                WriteAttributeValue("", 725, "/Home/Details/", 725, 14, true);
#nullable restore
#line 29 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
WriteAttributeValue("", 739, b.Id, 739, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Переглянути</a></p></td>\r\n                 </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("             </table>\r\n         </div>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
