#pragma checksum "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b224da7aede162c18ce778f3114a62a604ac610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_ViewImports.cshtml"
using Licenta.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_ViewImports.cshtml"
using Licenta.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b224da7aede162c18ce778f3114a62a604ac610", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740dfabed43ae04c1feef6d5e6ec67ff34d3ac6f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_AuthLayout.cshtml"
   Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""login-main-container"">
        <div class=""login-container"">
            <div class=""col-md @*offset-md-3*@"">
                <div class=""card login-logout-tab"">
                    <div class=""card-header"">
                        <ul class=""nav nav-tabs card-header-tabs"">
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""/Identity/Account/Login"">Autentificare</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""/Identity/Account/Register"">Inregistrare</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""card-header"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                ");
#nullable restore
#line 20 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_AuthLayout.cshtml"
                           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""carousel-container"">
            <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img class=""d-block w-100 carousel-img"" src=""/Images/img1.jpg"" alt=""First slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block w-100 carousel-img"" src=""/Images/2.jfif"" alt=""Second slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block w-100 carousel-img"" src=""/Images/3.jfif"" alt=""Third slide"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            ");
            WriteLiteral(@"        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
    </div>
    

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n            ");
#nullable restore
#line 54 "C:\Users\EliteBook\Documents\GitHub\newLicenta\Facultate\Licenta\Licenta\Areas\Identity\Pages\_AuthLayout.cshtml"
       Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<script>
 $(function () {
    var current = location.pathname;
    $('.nav-tabs li a').each(function () {
       var $this = $(this);
        if (current.indexOf($this.attr('href')) !== -1) {
             $this.addClass('active');
         }
     })
  })
</script>
        ");
            }
            );
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