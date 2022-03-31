#pragma checksum "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44187e480478da0d53152925c80cab91064dfd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BarberShop.Web.Areas.Services.Views.Services.Services.Areas_Services_Views_Services_All), @"mvc.1.0.view", @"/Areas/Services/Views/Services/All.cshtml")]
namespace BarberShop.Web.Areas.Services.Views.Services.Services
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
#line 1 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\_ViewImports.cshtml"
using BarberShop.Web.Areas.Services.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44187e480478da0d53152925c80cab91064dfd0d", @"/Areas/Services/Views/Services/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad131b9864378aa428a19ea1cd32141912fa2293", @"/Areas/Services/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Services_Views_Services_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllServicesViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
  
    ViewData["Title"] = "Services";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- services -->
<section class=""services py-5"" id=""services"" style=""background-color: #222"">
    <div class=""container-fluid"">
        <div class=""heading text-center"">
            <i class=""fas fa-cut""></i>
            <h3 class=""heading mb-sm-5 mb-3 text-uppercase"">Services</h3>
        </div>
        <div class=""row service-grids"">
");
#nullable restore
#line 13 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
             foreach (var service in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-2 col-sm-6 col-12 serviceimage2\"");
            BeginWriteAttribute("style", " style=\"", 560, "\"", 607, 3);
            WriteAttributeValue("", 568, "background-image:url(", 568, 21, true);
#nullable restore
#line 15 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
WriteAttributeValue("", 589, service.ImageUrl, 589, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 606, ")", 606, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-lg-2 col-sm-6 col-12 py-5 px-4 servicetext\">\r\n                    <h4>");
#nullable restore
#line 18 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
                   Write(service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"my-3\">");
#nullable restore
#line 19 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
                               Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"bt text-capitalize\" href=\"#\" role=\"button\">\r\n                        ");
#nullable restore
#line 21 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
                   Write(service.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <i class=\"fas fa-cut\"></i>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 25 "D:\C#-SoftUni\ASP.NET Core\BarberShop\src\BarberShop.Web\Areas\Services\Views\Services\All.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- //services -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllServicesViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591