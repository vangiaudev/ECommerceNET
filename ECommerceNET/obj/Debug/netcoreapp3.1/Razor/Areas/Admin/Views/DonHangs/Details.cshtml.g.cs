#pragma checksum "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e456e71c8539d1f13d9df1e3829feaffa8b2002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DonHangs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/DonHangs/Details.cshtml")]
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
#line 1 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerceNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e456e71c8539d1f13d9df1e3829feaffa8b2002", @"/Areas/Admin/Views/DonHangs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd15b5cb071331f73ecf8a0ea081827a67aeea", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DonHangs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerceNET.Entities.ChiTietDonHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_BackEndAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"content-wrapper\" class=\"d-flex flex-column\" style=\"padding:20px\">\r\n    <h1>Chi tiết đơn hàng</h1>\r\n    <hr />\r\n    <h4>Ngày đặt: ");
#nullable restore
#line 10 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
             Write(ViewBag.ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Trạng thái: ");
#nullable restore
#line 11 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
               Write(ViewBag.trangthai);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

    <hr />


    <table class=""table"">
        <thead>
            <tr>

                <th>
                    Hình
                </th>

                <th>
                    Tên sản phẩm
                </th>
                <th>
                    Đơn giá
                </th>
                <th>
                    Số lượng
                </th>
                <th>
                    Thành tiền
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 40 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e456e71c8539d1f13d9df1e3829feaffa8b20025323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1022, "~/images/sanpham/", 1022, 17, true);
#nullable restore
#line 45 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
AddHtmlAttributeValue("", 1039, Html.DisplayFor(modelItem => item.hinhSP), 1039, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.tenSP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.donGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.soLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.thanhTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <hr />\r\n    <h4>Tổng tiền hàng: ");
#nullable restore
#line 65 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                   Write(ViewBag.tth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Giảm giá: ");
#nullable restore
#line 66 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
             Write(ViewBag.magg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Tổng cộng: ");
#nullable restore
#line 67 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
              Write(ViewBag.tongcong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n\r\n    <h2>Thông tin người nhận</h2>\r\n    <h4>Họ tên: ");
#nullable restore
#line 71 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
           Write(ViewBag.hodh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 71 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
                         Write(ViewBag.tendh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Địa chỉ: ");
#nullable restore
#line 72 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
            Write(ViewBag.diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Email: ");
#nullable restore
#line 73 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
          Write(ViewBag.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>SĐT\" ");
#nullable restore
#line 74 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
        Write(ViewBag.sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Ghi chú: ");
#nullable restore
#line 75 "D:\ECommerceNETCore\ECommerceNET\Areas\Admin\Views\DonHangs\Details.cshtml"
            Write(ViewBag.ghichu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n<hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerceNET.Entities.ChiTietDonHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
