#pragma checksum "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "188ddac477948f0ceaf3fe4983440164756f2cff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188ddac477948f0ceaf3fe4983440164756f2cff", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd15b5cb071331f73ecf8a0ea081827a67aeea", @"/Views/_ViewImports.cshtml")]
    public class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SSGioHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
  
    ViewData["Title"] = "Giỏ Hàng";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Cart Start -->
<div class=""cart-page"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""cart-page-inner"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>Tên sản phẩm</th>
                                    <th>Giá</th>
                                    <th>Số lượng</th>
                                    <th>Thành tiền</th>
                                    <th>Xóa</th>
                                </tr>
                            </thead>
                            <tbody class=""align-middle"">
");
#nullable restore
#line 24 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n\r\n                                        <td>\r\n\r\n                                            <div class=\"img\">\r\n                                                <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "188ddac477948f0ceaf3fe4983440164756f2cff5856", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1265, "~/images/sanpham/", 1265, 17, true);
#nullable restore
#line 33 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
AddHtmlAttributeValue("", 1282, item.hinhAnh, 1282, 13, false);

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
            WriteLiteral("</a>\r\n                                                <p>");
#nullable restore
#line 34 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
                                              Write(item.tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 37 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
                                       Write(item.giasp);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</td>
                                        <td>
                                            <div class=""qty"">
                                                <!--<button class=""btn-minus""><i class=""fa fa-minus""></i></button>-->
                                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1840, "\"", 1861, 1);
#nullable restore
#line 41 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 1848, item.soLuong, 1848, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                <!--   <button class=""btn-plus""><i class=""fa fa-plus""></i></button>-->
                                            </div>
                                        </td>
                                        <td>");
#nullable restore
#line 45 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
                                       Write(item.thanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2200, "\"", 2233, 3);
            WriteAttributeValue("", 2207, "/giohang/xoasp/", 2207, 15, true);
#nullable restore
#line 47 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
WriteAttributeValue("", 2222, item.idSP, 2222, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2232, "/", 2232, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash\"></i></a></td>\r\n\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 51 "D:\ECommerceNETCore\ECommerceNET\Views\GioHang\Index.cshtml"
                               
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""cart-page-inner"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""coupon"">
                                <input id=""vlmgg"" type=""text"" placeholder=""Coupon Code"">
                                <button id=""checkmgg"">Apply Code</button>
                            </div>
                            <div style=""color:red"" id=""kquamgg"">

                            </div>
                        </div>
                      

                        <div class=""col-md-12"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "188ddac477948f0ceaf3fe4983440164756f2cff10964", async() => {
                WriteLiteral(@"
                                <input hidden id=""mggvlcode"" value=""0"" name=""mggvlcode"" />
                                <div class=""cart-summary"">
                                    <div class=""cart-content"">
                                        <h1>Giá trị giỏ hàng</h1>
                                        <p>Tổng tiền hàng<span id=""tth1"">0 đ</span></p>
                                        <p>Giảm giá<span id=""mgg1"">0 đ</span></p>
                                        <input hidden id=""tth"" value=""0"" name=""tth"" />
                                        <input hidden id=""mggvl"" value=""0"" name=""mggvl"" />
                                        <input hidden id=""tongcong"" value=""0"" name=""tongcong"" />
                                        <p>Phí giao hàng<span>FREE</span></p>
                                        <h2>Tổng cộng<span id=""tongcong1"">0</span></h2>
                                    </div>
                                    <div class=""cart-btn"">
                 ");
                WriteLiteral("                       <!--   <button>Update Cart</button>-->\r\n                                        <button>Checkout</button>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                       \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Cart End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SSGioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
