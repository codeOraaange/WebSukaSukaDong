#pragma checksum "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe45337d1071eb9c8957b7977140b98094e539c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe45337d1071eb9c8957b7977140b98094e539c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4>Twilight</h4>       \r\n<!-- cs itu sintaks c#, ada sintaks lajor? (at 2) -->\r\n\r\n\r\n");
#nullable restore
#line 5 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
  
    
    string name = "Jonggol";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
 if(name == "Johngol"){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Hello Johngol</h1>\r\n");
#nullable restore
#line 12 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h8>Kamu bukan ");
#nullable restore
#line 13 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
              Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h8>\r\n");
#nullable restore
#line 14 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>inihana1");
            WriteLiteral("@gmail.com</p>\r\n<h3> Hy ");
#nullable restore
#line 17 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<p>Tanggal : ");
#nullable restore
#line 18 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
        Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\'", 332, "\'", 366, 1);
#nullable restore
#line 20 "D:\Hana Hasanah\per dotnet an\Copy of part .net\WebSukaSuka\Views\Home\Index.cshtml"
WriteAttributeValue("", 339, Url.Action("About","Home"), 339, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">About<br><br><br></a>       <!-- kebalik -->\r\n<button>Button</button>");
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
