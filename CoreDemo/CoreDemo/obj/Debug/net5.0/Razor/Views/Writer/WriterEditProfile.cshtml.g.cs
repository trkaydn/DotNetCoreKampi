#pragma checksum "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "908888c92863ca5d13a1b25f1a07f37983e890ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterEditProfile), @"mvc.1.0.view", @"/Views/Writer/WriterEditProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"908888c92863ca5d13a1b25f1a07f37983e890ae", @"/Views/Writer/WriterEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
  
    ViewData["Title"] = "WriterEditProfile";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">Profil Bilgilerim</h4>\r\n            <br />\r\n");
#nullable restore
#line 13 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
             using (Html.BeginForm("WriterEditProfile", "Writer", FormMethod.Post, new { @class = "forms-sample" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
           Write(Html.HiddenFor(x => x.WriterID));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Ad Soyad</label>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.ValidationMessageFor(x => x.WriterName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>E-Posta</label>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.ValidationMessageFor(x => x.WriterMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Şifre</label>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.ValidationMessageFor(x => x.WriterPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Şifre (Tekrar)</label>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.PasswordFor(x => x.WriterPasswordConfirm, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.ValidationMessageFor(x => x.WriterPasswordConfirm, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.HiddenFor(x=>x.WriterImage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <label>Fotoğraf Yükle</label>
                    <input type=""file"" name=""img[]"" class=""file-upload-default"">
                    <div class=""input-group col-xs-12"">
                        <input type=""text"" class=""form-control file-upload-info""");
            BeginWriteAttribute("disabled", " disabled=\"", 2129, "\"", 2140, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Fotoğraf Yükle"">
                        <span class=""input-group-append"">
                            <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Dosya Seç</button>
                        </span>
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""exampleTextarea1"">Hakkımda</label>
                    ");
#nullable restore
#line 49 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.TextAreaFor(x => x.WriterAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
               Write(Html.ValidationMessageFor(x => x.WriterAbout, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Kaydet</button>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2887, "\"", 2926, 1);
#nullable restore
#line 53 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
WriteAttributeValue("", 2894, Url.Action("Index","Dashboard"), 2894, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">İptal</a>\r\n");
#nullable restore
#line 54 "C:\Users\Tarik Aydin\Desktop\Projects\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Writer\WriterEditProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
