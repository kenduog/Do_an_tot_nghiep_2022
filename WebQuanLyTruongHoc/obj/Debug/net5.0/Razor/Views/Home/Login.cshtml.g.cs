#pragma checksum "D:\DOANTOTNGHIEP\WebQuanLyTruongHoc\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de15b50a8c614d88e4d23533a5791214d02194df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\DOANTOTNGHIEP\WebQuanLyTruongHoc\Views\_ViewImports.cshtml"
using WebQuanLyTruongHoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOANTOTNGHIEP\WebQuanLyTruongHoc\Views\_ViewImports.cshtml"
using WebQuanLyTruongHoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de15b50a8c614d88e4d23533a5791214d02194df", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ff361631970c679531e9f0ad0a1f2bc2557f9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-theme bg-theme9"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DOANTOTNGHIEP\WebQuanLyTruongHoc\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Đăng nhập";
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de15b50a8c614d88e4d23533a5791214d02194df4048", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 319, "\"", 329, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 358, "\"", 368, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
    <title>QUẢN LÝ TRƯỜNG HỌC</title>
    <!-- loader-->
    <link href=""/assets/css/pace.min.css"" rel=""stylesheet"" />
    <script src=""/assets/js/pace.min.js""></script>
    <!--favicon-->
    <link rel=""icon"" href=""/assets/images/favicon.ico"" type=""image/x-icon"">
    <!-- Bootstrap core CSS-->
    <link href=""/assets/css/bootstrap.min.css"" rel=""stylesheet"" />
    <!-- animate CSS-->
    <link href=""/assets/css/animate.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Icons CSS-->
    <link href=""/assets/css/icons.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Custom Style-->
    <link href=""/assets/css/app-style.css"" rel=""stylesheet"" />

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de15b50a8c614d88e4d23533a5791214d02194df6296", async() => {
                WriteLiteral(@"

    <!-- start loader -->
    <div id=""pageloader-overlay"" class=""visible incoming""><div class=""loader-wrapper-outer""><div class=""loader-wrapper-inner""><div class=""loader""></div></div></div></div>
    <!-- end loader -->
    <!-- Start wrapper-->
    <div id=""wrapper"">

        <div class=""loader-wrapper""><div class=""lds-ring""><div></div><div></div><div></div><div></div></div></div>
        <div class=""card card-authentication1 mx-auto my-5"">
            <div class=""card-body"">
                <div class=""card-content p-2"">
                    <div class=""text-center"">
                        <img src=""/assets/images/logo-icon.png"" alt=""logo icon"">
                    </div>
                    <div class=""card-title text-uppercase text-center py-3"">Đăng Nhập</div>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de15b50a8c614d88e4d23533a5791214d02194df7395", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""exampleInputUsername"" class=""sr-only"">Mã Nhân Viên</label>
                            <div class=""position-relative has-icon-right"">
                                <input type=""text"" id=""exampleInputUsername"" class=""form-control input-shadow"" placeholder=""Tên Đăng Nhập"">
                                <div class=""form-control-position"">
                                    <i class=""icon-user""></i>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword"" class=""sr-only"">Mật Khẩu</label>
                            <div class=""position-relative has-icon-right"">
                                <input type=""password"" id=""exampleInputPassword"" class=""form-control input-shadow"" placeholder=""Mật Khẩu"">
                                <div class=""form-cont");
                    WriteLiteral(@"rol-position"">
                                    <i class=""icon-lock""></i>
                                </div>
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-6"">
                                <div class=""icheck-material-white"">
                                    <input type=""checkbox"" id=""user-checkbox""");
                    BeginWriteAttribute("checked", " checked=\"", 3368, "\"", 3378, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                                    <label for=""user-checkbox"">Nhớ</label>
                                </div>
                            </div>
                        </div>
                        <button type=""button"" class=""btn btn-light btn-block""");
                    BeginWriteAttribute("onclick", " onclick=\"", 3645, "\"", 3698, 3);
                    WriteAttributeValue("", 3655, "location.href=\'", 3655, 15, true);
#nullable restore
#line 73 "D:\DOANTOTNGHIEP\WebQuanLyTruongHoc\Views\Home\Login.cshtml"
WriteAttributeValue("", 3670, Url.Action("Index","Home"), 3670, 27, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3697, "\'", 3697, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(">Đăng Nhập</button>\r\n                        <div class=\"text-center mt-3\">\r\n                            <a href=\"reset-password.html\">Thay Đổi Mật Khẩu</a>\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>

        <!--Start Back To Top Button-->
        <a href=""javaScript:void();"" class=""back-to-top""><i class=""fa fa-angle-double-up""></i> </a>
        <!--End Back To Top Button-->

    </div><!--wrapper-->
    <!-- Bootstrap core JavaScript-->
    <script src=""/assets/js/jquery.min.js""></script>
    <script src=""/assets/js/popper.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>

    <!-- sidebar-menu js -->
    <script src=""/assets/js/sidebar-menu.js""></script>

    <!-- Custom scripts -->
    <script src=""/assets/js/app-script.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
