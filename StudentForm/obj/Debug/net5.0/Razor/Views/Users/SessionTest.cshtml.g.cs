#pragma checksum "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e47de4fb2ccbc79ae7fc6a68ecc4ad7342fae376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_SessionTest), @"mvc.1.0.view", @"/Views/Users/SessionTest.cshtml")]
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
#line 1 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\_ViewImports.cshtml"
using StudentForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\_ViewImports.cshtml"
using StudentForm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e47de4fb2ccbc79ae7fc6a68ecc4ad7342fae376", @"/Views/Users/SessionTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcec68bcbd95a7689618b7ebc09d167077984809", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_SessionTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Session Test</h1>
<table>
    <thead>
        <tr>
            <th>No</th>
            <th>UserName</th>
            <th>Email</th>
            <!-- Add more table headers as per your DataTable columns -->
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml"
         foreach (System.Data.DataRow row in Model.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml"
               Write(row["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml"
               Write(row["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml"
               Write(row["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\GICM\Desktop\C#\TestingProjects\StudentForm\StudentForm\Views\Users\SessionTest.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591