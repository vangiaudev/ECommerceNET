#pragma checksum "D:\ECommerceNETCore\ECommerceNET\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f11bbf4d6f11cf09edd91109e42e8ff7e47a01", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd15b5cb071331f73ecf8a0ea081827a67aeea", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ECommerceNETCore\ECommerceNET\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "YAN Store";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Login Start -->
<div class=""login"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""register-form"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>Họ</label>
                            <input class=""form-control"" id=""houser"" type=""text"" placeholder=""Họ"">
                        </div>
                        <div class=""col-md-6"">
                            <label>Tên</label>
                            <input class=""form-control"" id=""tenuser"" type=""text"" placeholder=""Tên"">
                        </div>
                        <div class=""col-md-6"">
                            <label>E-mail</label>
                            <input class=""form-control"" id=""emailuser"" type=""text"" placeholder=""E-mail"">
                        </div>
                        <div class=""col-md-6"">
                            <label>Số điện thoại</label>
 ");
            WriteLiteral(@"                           <input class=""form-control"" id=""sdtuser"" type=""text"" placeholder=""Số điện thoại"">
                        </div>

                        <div class=""col-md-6"">
                            <label style=""display:block"">Ngày sinh</label>

                            <select class=""form-control"" id=""ngaysinh"" style=""width:73px;display:inline"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a015997", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <script>
                                    var i;
                                    // Lặp 10 lần từ 0 -> 9
                                    // Bước nhảy là i++ nên sau mỗi lần lặp i tăng lên 1 đơn vị
                                    for (i = 2; i <= 31; i++) {
                                        document.write('<option value=""' + i + '"" >' + i + '</option>');
                                    }
                                </script>
                            </select>


                            <select class=""form-control"" id=""thangsinh"" style=""width:122px;display:inline"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a017924", async() => {
                WriteLiteral("Tháng 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <script>
                                    var i;
                                    // Lặp 10 lần từ 0 -> 9
                                    // Bước nhảy là i++ nên sau mỗi lần lặp i tăng lên 1 đơn vị
                                    for (i = 2; i <= 12; i++) {
                                        document.write('<option value=""' + i + '"" >Tháng ' + i + '</option>');
                                    }
                                </script>
                            </select>

                            <select class=""form-control"" id=""namsinh"" style=""width:90px;display:inline"">


                                <script>

                                    var i;
                                    // Lặp 10 lần từ 0 -> 9
                                    // Bước nhảy là i++ nên sau mỗi lần lặp i tăng lên 1 đơn vị
                                    for (i = 2005; i >= 1950; i--) {
                                        document.w");
            WriteLiteral(@"rite('<option value=""' + i + '"" selected=""selected"">' + i + '</option>');
                                    }
                                </script>
                            </select>
                        </div>


                        <div class=""col-md-6"">
                            <label>Giới tính</label>
                            <select class=""form-control"" id=""gioiTinh"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a0110677", async() => {
                WriteLiteral("Không xác định");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a0111960", async() => {
                WriteLiteral("Nam");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9f11bbf4d6f11cf09edd91109e42e8ff7e47a0113149", async() => {
                WriteLiteral("Nữ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>

                        <div class=""col-md-6"">
                            <label>Mật khẩu</label>
                            <input  class=""form-control"" type=""password"" id=""pwuser"" placeholder=""Mật khẩu"">
                        </div>
                        <div class=""col-md-6"">
                            <label>Nhập lại mật khẩu</label>
                            <input class=""form-control"" type=""password"" id=""repwuser"" placeholder=""Nhập lại mật khẩu"">
                        </div>
                        <div class=""col-md-12"">
                            <button class=""btn"" id=""dky"">Đăng ký</button>
                        </div>
                        <div class=""col-md-12"" id=""kqua2"" style=""color:red"">
                           
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""login-form"">");
            WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <label>E-mail / Số điện thoại</label>
                            <input class=""form-control"" id=""emaillogin"" type=""text"" placeholder=""E-mail / Số điện thoại"">
                        </div>
                        <div class=""col-md-6"">
                            <label>Mật khẩu</label>
                            <input class=""form-control"" id=""mkhaulogin"" type=""password"" placeholder=""Mật khẩu"">
                        </div>
                        <div class=""col-md-12"">
                            
                                <a href=""/Login/QuenMatKhau/"" >Quên mật khẩu</a>
                           
                        </div>
                        <p></p>
                        <div class=""col-md-12"">
                            <button type=""submit"" id=""submitlogin"" class=""btn"">Đăng nhập</button>

                        </div>
                        <div id");
            WriteLiteral("=\"kqua\" class=\"col-md-12\" style=\"margin-top:5px;color:red;\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<!-- Login End -->");
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
