#pragma checksum "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fac5d5273591c5ecdec84cd55f4df168b005fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
#line 1 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fac5d5273591c5ecdec84cd55f4df168b005fb3", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af67743b08e927ccb6b78e076f98d4e760bf906", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Ekle</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control", placeholder = "Kategori Adı" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Açıklaması"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, new { @class = "form-control", placeholder = "Kategori Açıklaması", rows = 10 }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Kaydet</button>\r\n");
#nullable restore
#line 20 "C:\Users\tarik\Documents\GitHub\DotNetCoreKampi\CoreDemo\CoreDemo\Areas\Admin\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
