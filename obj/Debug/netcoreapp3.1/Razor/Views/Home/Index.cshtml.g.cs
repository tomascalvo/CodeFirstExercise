#pragma checksum "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520705c88369b72278e3d66d342c5776413ac656"
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
#nullable restore
#line 1 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\_ViewImports.cshtml"
using CodeFirstExercise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\_ViewImports.cshtml"
using CodeFirstExercise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
using CodeFirstExercise.Context;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520705c88369b72278e3d66d342c5776413ac656", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0f63ad314c05704b8a914696505c176d6872a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CodeFirstExercise.Context.TrapSample>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
 foreach(CodeFirstExercise.Context.TrapSample t in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 7 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
  Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Location: ");
#nullable restore
#line 8 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
            Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Collector: ");
#nullable restore
#line 9 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
             Write(t.Collector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Analyst: ");
#nullable restore
#line 10 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
           Write(t.Analyst);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\tomas\Documents\Grand Circus\Class Exercises\CodeFirstExercise\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CodeFirstExercise.Context.TrapSample>> Html { get; private set; }
    }
}
#pragma warning restore 1591
