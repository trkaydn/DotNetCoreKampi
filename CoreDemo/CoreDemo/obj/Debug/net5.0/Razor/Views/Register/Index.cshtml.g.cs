#pragma checksum "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a02d38f43870e3c787d4fa4eb6ea090c6e84ddea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02d38f43870e3c787d4fa4eb6ea090c6e84ddea", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterCityViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a02d38f43870e3c787d4fa4eb6ea090c6e84ddea3770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Yazar Kayıt Sayfası</h3>
        <div class=""inner-sec"">
            <div class=""login p-5 bg-light mx-auto mw-100"">
");
#nullable restore
#line 13 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Ad Soyad:</label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Writer.WriterName, new { @class = "form-control", placeholder = "Ad Soyad" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Writer.WriterName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">E-Posta</label>\r\n                            ");
#nullable restore
#line 23 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Writer.WriterMail, new { @class = "form-control", placeholder = "E-Posta" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Writer.WriterMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Şifre</label>
                            ");
#nullable restore
#line 30 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Writer.WriterPassword, new { @class = "form-control", placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 31 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Writer.WriterPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Şifre (Tekrar)</label>\r\n                            ");
#nullable restore
#line 35 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Writer.WriterPasswordConfirm, new { @class = "form-control", placeholder = "Şifre (Tekrar)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Writer.WriterPasswordConfirm, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n");
            WriteLiteral("                            <label for=\"validationCustom01\">Görsel Dosya Yolu:</label>\r\n                            ");
#nullable restore
#line 41 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Writer.WriterImage, new { @class = "form-control", placeholder = "Görsel Dosya Yolu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Writer.WriterImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Şehir</label>\r\n                                ");
#nullable restore
#line 46 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                           Write(Html.DropDownList("city", Model.Cities, "Şehir Seçin", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol</button>
                    <p>
                        <a href=""#"" id=""btn1""><strong>Tüm şartları okudum ve onaylıyorum.</strong></a>
                    </p>
");
#nullable restore
#line 53 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<script>
    $(""#btn1"").on(""click"", function () {
        swal(""KVKK AYDINLATMA METNİ"", ""6698 sayılı Kişisel Verilerin Korunması Kanunu (“KVKK”) uyarınca, Şirketimiz tarafından, Veri Sorumlusu sıfatıyla, kişisel verileriniz, iş amaçlarıyla bağlı olarak, aşağıda açıklandığı çerçevede kullanılmak, kaydedilmek, saklanmak, güncellenmek, aktarılmak ve/veya sınıflandırılmak suretiyle işlenecektir.  Bu kapsamda Şirketimiz tarafından başta özel hayatın gizliliği olmak üzere, kişilerin temel hak ve özgürlüklerini korumak ve kişisel verilerin korunması amacıyla düzenlenen Kanun ve Yönetmelikler gereğince Şirketimiz, kişisel verilerinizin hukuka aykırı olarak işlenmesini önleme, hukuka aykırı olarak erişilmesini önleme ve muhafazasını sağlama amacıyla, uygun güvenlik düzeyini temin etmeye yönelik tüm teknik ve idari tedbirleri almaktadır."")
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterCityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
