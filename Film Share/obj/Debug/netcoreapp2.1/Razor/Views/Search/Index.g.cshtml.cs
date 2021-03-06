#pragma checksum "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3521da029761ff42bd52552fd911229f621490bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
#line 1 "D:\Programs\Film Share\Film Share\Views\_ViewImports.cshtml"
using Film_Share;

#line default
#line hidden
#line 2 "D:\Programs\Film Share\Film Share\Views\_ViewImports.cshtml"
using Film_Share.Models;

#line default
#line hidden
#line 1 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
using FilmShare.ViewModels;

#line default
#line hidden
#line 3 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521da029761ff42bd52552fd911229f621490bb", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad6d31f0ca4cbe5bcc8f40e5b4456554ce2a652", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmShare.ViewModels.TabViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Friends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SwitchTabs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Actors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tabname", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
  
    ViewData["Title"] = Localizer["Search"];
    Layout = "~/Views/Shared/_LayoutMenu.cshtml";
    var isAuthorized = User.Identity.Name != null;

    var action = "";
    switch (Model.ActiveTab)
    {
        case Tab.Friends:
            action = "friends()";
            break;
        case Tab.Actors:
            action = "actors()";
            break;
        case Tab.Films:
            action = "films()";
            break;
    }


#line default
#line hidden
            BeginContext(619, 99, true);
            WriteLiteral("\r\n\r\n<div class=\"col-md-6 col-md-offset-3 profileWrap\">\r\n    <div class=\"text-center\">\r\n        <h2>");
            EndContext();
            BeginContext(719, 19, false);
#line 30 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
       Write(Localizer["Search"]);

#line default
#line hidden
            EndContext();
            BeginContext(738, 127, true);
            WriteLiteral("</h2>\r\n\r\n        <ul id=\"navbar\" class=\"nav nav-tabs\" style=\"margin-top: 20px!important; margin-bottom:20px\">\r\n            <li>");
            EndContext();
            BeginContext(865, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3e372237aa84d61aa3934b65ca34b9d", async() => {
                BeginContext(990, 20, false);
#line 33 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                                                                       Write(Localizer["Friends"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 875, Model.ActiveTab == Tab.Friends ? "btn active" : "btn tab", 875, 60, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1014, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(1037, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c779200eb6264f319ae3c6bfb11cf7ba", async() => {
                BeginContext(1160, 19, false);
#line 34 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                                                                     Write(Localizer["Actors"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 1047, Model.ActiveTab == Tab.Actors ? "btn active" : "btn tab", 1047, 59, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1183, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(1206, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5e8498b4bf48768dea105c16c9d9e4", async() => {
                BeginContext(1327, 18, false);
#line 35 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                                                                   Write(Localizer["Films"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
AddHtmlAttributeValue("", 1216, Model.ActiveTab == Tab.Films ? "btn active" : "btn tab", 1216, 58, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tabname", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tabname"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 62, true);
            WriteLiteral("</li>\r\n        </ul>\r\n\r\n        <input id=\"filter\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("onkeyup", " onkeyup=\"", 1411, "\"", 1428, 1);
#line 38 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
WriteAttributeValue("", 1421, action, 1421, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 25, true);
            WriteLiteral(" class=\"filterBar\" />\r\n\r\n");
            EndContext();
#line 40 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
         switch (Model.ActiveTab)
    {
            case Tab.Friends:
                

#line default
#line hidden
            BeginContext(1544, 70, false);
#line 43 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
           Write(await Component.InvokeAsync("FilmShare.ViewComponents.Search.Friends"));

#line default
#line hidden
            EndContext();
#line 43 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                       ;
                break;
            case Tab.Actors:
                

#line default
#line hidden
            BeginContext(1688, 69, false);
#line 46 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
           Write(await Component.InvokeAsync("FilmShare.ViewComponents.Search.Actors"));

#line default
#line hidden
            EndContext();
#line 46 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                      ;
                break;
            case Tab.Films:
                

#line default
#line hidden
            BeginContext(1830, 68, false);
#line 49 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
           Write(await Component.InvokeAsync("FilmShare.ViewComponents.Search.Films"));

#line default
#line hidden
            EndContext();
#line 49 "D:\Programs\Film Share\Film Share\Views\Search\Index.cshtml"
                                                                                     ;
                break;
        }

#line default
#line hidden
            BeginContext(1936, 793, true);
            WriteLiteral(@"

    </div>
</div>

<script>
    $(document).ready(function () {
        $(""#searchSub"").css(""background"", ""#47a7cc"")
        $(""#searchText"").css(""color"", ""white"")
    })

    function friends() {
        var container = $(""#friendsContainer"");
        $.get(""/Search/FriendsComponent?filter="" + $(""#filter"").val(), function (data) { container.html(data); });
    }

    function actors() {
        var container = $(""#actorsContainer"");
        $.get(""/Search/ActorsComponent?filter="" + $(""#filter"").val(), function (data) { container.html(data); });
    }

    function films() {
        var container = $(""#filmsContainer"");
        $.get(""/Search/FilmsComponent?filter="" + $(""#filter"").val(), function (data) { container.html(data); });
    }
    
</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmShare.ViewModels.TabViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
