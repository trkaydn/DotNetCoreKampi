#pragma checksum "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e258edfc1191769a7b530a25271e0dd5969b1a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Inbox), @"mvc.1.0.view", @"/Views/Message/Inbox.cshtml")]
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
#line 1 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e258edfc1191769a7b530a25271e0dd5969b1a2", @"/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Gönderen</th>\r\n        <th>Tarih</th>\r\n        <th>Devamını Oku</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
            Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 632, "\"", 678, 2);
            WriteAttributeValue("", 639, "/Message/MessageDetails/", 639, 24, true);
#nullable restore
#line 25 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"
WriteAttributeValue("", 663, item.MessageID, 663, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Devamını Oku</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Message\Inbox.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Message/SendMessage\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591