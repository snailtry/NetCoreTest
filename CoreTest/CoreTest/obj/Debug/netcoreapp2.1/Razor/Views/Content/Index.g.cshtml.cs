#pragma checksum "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6181f8524c9db71c15924f62c92512005496c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 1 "E:\桌面\CoreTest\CoreTest\Views\_ViewImports.cshtml"
using CoreTest;

#line default
#line hidden
#line 2 "E:\桌面\CoreTest\CoreTest\Views\_ViewImports.cshtml"
using CoreTest.Models;

#line default
#line hidden
#line 2 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6181f8524c9db71c15924f62c92512005496c78", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801770f841f4765b131e12874622c8aa4ac4b8d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";

#line default
#line hidden
            BeginContext(84, 80, true);
            WriteLiteral("\r\n<<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(165, 17, false);
#line 8 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 314, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>

");
            EndContext();
#line 21 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(554, 150, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(705, 7, false);
#line 27 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(712, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(740, 10, false);
#line 28 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
               Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(750, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(778, 12, false);
#line 29 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
               Write(item.content);

#line default
#line hidden
            EndContext();
            BeginContext(790, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(818, 24, false);
#line 30 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
               Write(item.add_time.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(842, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "E:\桌面\CoreTest\CoreTest\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(879, 26, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591