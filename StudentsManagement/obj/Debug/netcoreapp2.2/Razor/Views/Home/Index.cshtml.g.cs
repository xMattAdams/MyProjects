#pragma checksum "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfa9588a8f2bb62496e054b053cb4c51366e808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfa9588a8f2bb62496e054b053cb4c51366e808", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentsManagement.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
   
    
    ViewBag.Title = "Student List";

#line default
#line hidden
            BeginContext(112, 281, true);
            WriteLiteral(@"        
    <table>
        <thead>
            <tr>
                <th>ID</th>               
                <th>Name</th>               
                <th>Surname</th>             
                <th>Class</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
          foreach (var student in Model)
         {

#line default
#line hidden
            BeginContext(447, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(486, 10, false);
#line 21 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
               Write(student.Id);

#line default
#line hidden
            EndContext();
            BeginContext(496, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(524, 12, false);
#line 22 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
               Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(536, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(564, 15, false);
#line 23 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
               Write(student.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(579, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(607, 13, false);
#line 24 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
               Write(student.Class);

#line default
#line hidden
            EndContext();
            BeginContext(620, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 27 "C:\Users\matix\source\repos\StudentsManagement\Views\Home\Index.cshtml"
         }

#line default
#line hidden
            BeginContext(660, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentsManagement.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
