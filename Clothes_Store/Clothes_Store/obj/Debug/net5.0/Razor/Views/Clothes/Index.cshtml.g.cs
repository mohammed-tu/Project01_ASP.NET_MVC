#pragma checksum "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e735c46a6968b8303fca8b5e9a5ddf7c700dfb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clothes_Index), @"mvc.1.0.view", @"/Views/Clothes/Index.cshtml")]
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
#line 1 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\_ViewImports.cshtml"
using Clothes_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\_ViewImports.cshtml"
using Clothes_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e735c46a6968b8303fca8b5e9a5ddf7c700dfb4", @"/Views/Clothes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7f14554e3ab91fc48f9abcd75dbab036dc15f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Clothes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
  
    var prds = (List<ClotheModel>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>All Clothes </h2>\r\n<hr />\r\n<div class=\"d-flex flex-wrap\" >\r\n");
#nullable restore
#line 7 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
     foreach (var prd in prds)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card border-secondary mb-3\" style=\"width: 20rem; margin:20px;\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=", 281, "", 294, 1);
#nullable restore
#line 10 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 286, prd.img, 286, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 294, "", 308, 1);
#nullable restore
#line 10 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 299, prd.Name, 299, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                              Write(prd.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">Price : ");
#nullable restore
#line 13 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                                    Write(prd.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
              if (prd.gender == "Male")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text\">Gender : ");
#nullable restore
#line 16 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                                             Write(prd.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 637, 3);
            WriteAttributeValue("", 608, "/Clothes/DetailsMens/", 608, 21, true);
#nullable restore
#line 17 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 629, prd.Id, 629, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 636, "", 637, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">");
#nullable restore
#line 17 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                                                                               Write(prd.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 18 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text\">Gender : ");
#nullable restore
#line 21 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                                             Write(prd.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 865, 3);
            WriteAttributeValue("", 834, "/Clothes/DetailsWomens/", 834, 23, true);
#nullable restore
#line 22 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 857, prd.Id, 857, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 864, "", 865, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">");
#nullable restore
#line 22 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                                                                                 Write(prd.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 23 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Clothes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
