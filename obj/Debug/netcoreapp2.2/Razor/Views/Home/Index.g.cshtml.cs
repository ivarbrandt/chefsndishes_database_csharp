#pragma checksum "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f510d45b07447dd2e6db9113cc2f96cabcde51a"
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
#line 1 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/_ViewImports.cshtml"
using chefsndishes;

#line default
#line hidden
#line 2 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/_ViewImports.cshtml"
using chefsndishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f510d45b07447dd2e6db9113cc2f96cabcde51a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ba7a60c68383fd41db25449a6c7fece97c2002", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddChefPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(21, 272, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col justify-content-center"">
        <a class=""btn btn-link"" href=""/"">Chefs</a>
        <a class=""btn btn-link"" href=""/dishes"">Dishes</a>
    </div>
</div>

<h2>Check out our roster of Chefs!</h2>
<div class=""float-right"">

  ");
            EndContext();
            BeginContext(293, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f510d45b07447dd2e6db9113cc2f96cabcde51a4131", async() => {
                BeginContext(342, 10, true);
                WriteLiteral("Add A Chef");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(356, 195, true);
            WriteLiteral("\r\n</div>\r\n\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">Name</th>\r\n      <th scope=\"col\">Age</th>\r\n      <th scope=\"col\"># of Dishes</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 26 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"
       foreach(Chef chef in Model)
      {

#line default
#line hidden
            BeginContext(596, 32, true);
            WriteLiteral("          <tr>\r\n            <td>");
            EndContext();
            BeginContext(629, 14, false);
#line 29 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"
           Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(643, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(645, 13, false);
#line 29 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"
                           Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(658, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(682, 8, false);
#line 30 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"
           Write(chef.Age);

#line default
#line hidden
            EndContext();
            BeginContext(690, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(714, 24, false);
#line 31 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"
           Write(chef.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(738, 24, true);
            WriteLiteral("</td>\r\n          </tr>\r\n");
            EndContext();
#line 33 "/Users/ivar/Desktop/Bootcamp/C#/chefsndishes/Views/Home/Index.cshtml"

      }

#line default
#line hidden
            BeginContext(773, 20, true);
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
