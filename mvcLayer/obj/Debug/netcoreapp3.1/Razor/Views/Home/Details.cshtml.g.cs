#pragma checksum "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30763de55a4fd714cdc5f5080753cb9b223186d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30763de55a4fd714cdc5f5080753cb9b223186d6", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b083d3c83baad64772ff3a2f986c4dc08c42786f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n<html>\r\n <!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30763de55a4fd714cdc5f5080753cb9b223186d63409", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n     <title>Лабораторна робота 6</title>\r\n ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30763de55a4fd714cdc5f5080753cb9b223186d64486", async() => {
                WriteLiteral("\r\n     <div>\r\n         <h3>Сторінка деталей</h3>\r\n         <h3>Інформація про користувача:</h3>\r\n         <p>Імя: ");
#nullable restore
#line 16 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
            Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n         <p>Прізвище: ");
#nullable restore
#line 17 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                 Write(ViewBag.User.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n         <p>Вік: ");
#nullable restore
#line 18 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
            Write(ViewBag.User.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n         <p>Стать: ");
#nullable restore
#line 19 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
              Write(ViewBag.User.Sex);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

         <h3>Інформація про його повідомлення:</h3>
         <p><a href=""/Home/CreateMessage"">Створити повідомлення</a></p>
         <table>
             <tr>
                 <td><p>Текст</p></td>
                 <td><p>Автор</p></td>
                 <td><p>Статус</p></td>
             </tr>
");
#nullable restore
#line 29 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
              foreach (var b in ViewBag.User.Messages)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <tr>\r\n                     <td><p>");
#nullable restore
#line 32 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Message.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 33 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Message.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 34 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Message.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p><a");
                BeginWriteAttribute("href", " href=\"", 1075, "\"", 1113, 2);
                WriteAttributeValue("", 1082, "/Home/EditMessage/", 1082, 18, true);
#nullable restore
#line 35 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
WriteAttributeValue("", 1100, b.ID_MESSAGE, 1100, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редагувати</a></p></td>\r\n                 </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         </table>
         <h3>Інформація про його права:</h3>
         <table>
             <tr>
                 <td><p>Текст</p></td>
                 <td><p>Вік від</p></td>
                 <td><p>Від до</p></td>
                 <td><p>Категорія</p></td>
             </tr>
");
#nullable restore
#line 47 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
              foreach (var b in ViewBag.User.Rights)
             {

#line default
#line hidden
#nullable disable
                WriteLiteral("                 <tr>\r\n                     <td><p>");
#nullable restore
#line 50 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Right.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 51 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Right.AgeFrom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 52 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Right.AgeTo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p>");
#nullable restore
#line 53 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
                       Write(b.Right.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n                     <td><p><a");
                BeginWriteAttribute("href", " href=\"", 1808, "\"", 1841, 2);
                WriteAttributeValue("", 1815, "/Home/EditRight/", 1815, 16, true);
#nullable restore
#line 54 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
WriteAttributeValue("", 1831, b.RightID, 1831, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редагувати</a></p></td>\r\n                 </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Andrii\source\repos\Lab6\mvcLayer\Views\Home\Details.cshtml"
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("         </table>\r\n     </div>\r\n ");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
