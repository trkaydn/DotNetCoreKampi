#pragma checksum "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70738472ab3680a4a314cbc428cfe75d1674cd8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotification), @"mvc.1.0.view", @"/Views/Notification/AllNotification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70738472ab3680a4a314cbc428cfe75d1674cd8e", @"/Views/Notification/AllNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Notification_AllNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
  
    ViewData["Title"] = "AllNotification";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bildirimler</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Bildirim</th>\r\n        <th>Tarih</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
             if (item.NotificationDate.Date == DateTime.Today)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 22 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
                Write((DateTime.Now.TimeOfDay - item.NotificationDate.TimeOfDay).Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" saat önce</td>\r\n");
#nullable restore
#line 23 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 26 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
               Write(item.NotificationDate.ToString("dd.MM.yy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Views\Notification\AllNotification.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
