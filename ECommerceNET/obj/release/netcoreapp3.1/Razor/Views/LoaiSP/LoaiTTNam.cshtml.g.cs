#pragma checksum "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4be123c50180ee61c9083c2bff075179d697878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoaiSP_LoaiTTNam), @"mvc.1.0.view", @"/Views/LoaiSP/LoaiTTNam.cshtml")]
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
#line 1 "D:\ECommerceNETCore\ECommerceNET\Views\_ViewImports.cshtml"
using ECommerceNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ECommerceNETCore\ECommerceNET\Views\_ViewImports.cshtml"
using ECommerceNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4be123c50180ee61c9083c2bff075179d697878", @"/Views/LoaiSP/LoaiTTNam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd15b5cb071331f73ecf8a0ea081827a67aeea", @"/Views/_ViewImports.cshtml")]
    public class Views_LoaiSP_LoaiTTNam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerceNET.Entities.LoaiSP>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
  
    ViewData["Title"] = "LoaiTTNam";
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 156, "\"", 251, 4);
            WriteAttributeValue("", 163, "/SanPham/LoaiSP/", 163, 16, true);
#nullable restore
#line 9 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
WriteAttributeValue("", 179, SlugGenerator.SlugGenerator.GenerateSlug(item.tenLoaiSP), 179, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 236, "-", 236, 1, true);
#nullable restore
#line 9 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
WriteAttributeValue("", 237, item.idLoaiSP, 237, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">");
#nullable restore
#line 9 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.tenLoaiSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "D:\ECommerceNETCore\ECommerceNET\Views\LoaiSP\LoaiTTNam.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerceNET.Entities.LoaiSP>> Html { get; private set; }
    }
}
#pragma warning restore 1591