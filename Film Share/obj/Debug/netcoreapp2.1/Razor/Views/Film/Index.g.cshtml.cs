#pragma checksum "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abc724d0d5fb833793f1d05b4d360baad8c24236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Index), @"mvc.1.0.view", @"/Views/Film/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Film/Index.cshtml", typeof(AspNetCore.Views_Film_Index))]
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
#line 1 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc724d0d5fb833793f1d05b4d360baad8c24236", @"/Views/Film/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad6d31f0ca4cbe5bcc8f40e5b4456554ce2a652", @"/Views/_ViewImports.cshtml")]
    public class Views_Film_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmShare.ViewModels.FilmModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmActors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reviewRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::FilmShare.TagHelpers.RatingTagHelper __FilmShare_TagHelpers_RatingTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
  
    ViewData["Title"] = Model.FilmName;
    Layout = "~/Views/Shared/_LayoutMenu.cshtml";

#line default
#line hidden
            BeginContext(222, 97, true);
            WriteLiteral("\r\n<div class=\"col-md-6 col-md-offset-3 profileWrap\">\r\n    <div class=\"text-center\">\r\n        <h2>");
            EndContext();
            BeginContext(320, 14, false);
#line 13 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
       Write(Model.FilmName);

#line default
#line hidden
            EndContext();
            BeginContext(334, 146, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"profileInfo\">\r\n        <div class=\"leftProfile\">\r\n            <div class=\"avatarUserBox\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 480, "", 502, 1);
#line 18 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
WriteAttributeValue("", 485, Model.PosterPath, 485, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(502, 166, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(669, 18, false);
#line 24 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
              Write(Localizer["YEAR:"]);

#line default
#line hidden
            EndContext();
            BeginContext(687, 5, true);
            WriteLiteral(" </b>");
            EndContext();
            BeginContext(693, 10, false);
#line 24 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                      Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(703, 56, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(760, 21, false);
#line 27 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
              Write(Localizer["COUNTRY:"]);

#line default
#line hidden
            EndContext();
            BeginContext(781, 5, true);
            WriteLiteral(" </b>");
            EndContext();
            BeginContext(787, 13, false);
#line 27 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                         Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(800, 56, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(857, 26, false);
#line 30 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
              Write(Localizer["AVERAGE RANK:"]);

#line default
#line hidden
            EndContext();
            BeginContext(883, 41, true);
            WriteLiteral(" </b>\r\n                <span id=\"rank\">\r\n");
            EndContext();
#line 32 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                     if (Model.AverageRank == 0)
                    {
                        

#line default
#line hidden
            BeginContext(1022, 32, false);
#line 34 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                   Write(Localizer["No ranks were found"]);

#line default
#line hidden
            EndContext();
#line 34 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                                         
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1128, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1154, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1156, 17, false);
#line 38 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                      Write(Model.AverageRank);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(1222, 59, true);
            WriteLiteral("                    </span>\r\n            </p>\r\n            ");
            EndContext();
            BeginContext(1281, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57545d81ffc46e1b99d9e8a3a7c550f", async() => {
                BeginContext(1364, 29, false);
#line 42 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                                                                         Write(Localizer["Show Film Actors"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filmId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                                                   WriteLiteral(Model.FilmId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filmId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 75, true);
            WriteLiteral("\r\n</div>\r\n    </div>\r\n\r\n    <div class=\"reviewInputContainer\">\r\n        <p>");
            EndContext();
            BeginContext(1473, 24, false);
#line 47 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
      Write(Localizer["New review:"]);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 106, true);
            WriteLiteral("</p>\r\n        <div style=\"margin-left: 5%\">\r\n            <p style=\"display: inline; vertical-align: top;\">");
            EndContext();
            BeginContext(1604, 20, false);
#line 49 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
                                                        Write(Localizer["Rating:"]);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 19, true);
            WriteLiteral(" </p>\r\n            ");
            EndContext();
            BeginContext(1643, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6376dcb33b8040e0b726669de630e6db", async() => {
            }
            );
            __FilmShare_TagHelpers_RatingTagHelper = CreateTagHelper<global::FilmShare.TagHelpers.RatingTagHelper>();
            __tagHelperExecutionContext.Add(__FilmShare_TagHelpers_RatingTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 122, true);
            WriteLiteral("\r\n        </div>\r\n        <textarea id=\"reviewText\" rows=\"4\" class=\"reviewInput\"></textarea>\r\n        <input type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1800, "\"", 1834, 3);
            WriteAttributeValue("", 1810, "addReview(", 1810, 10, true);
#line 53 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
WriteAttributeValue("", 1820, Model.FilmId, 1820, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1833, ")", 1833, 1, true);
            EndWriteAttribute();
            BeginContext(1835, 19, true);
            WriteLiteral(" title=\"Add review\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1854, "\"", 1886, 1);
#line 53 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
WriteAttributeValue("", 1862, Localizer["Add review"], 1862, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1887, 85, true);
            WriteLiteral(" class=\"btn reviewButton\" />\r\n    </div>\r\n\r\n    <div id=\"reviewsContainer\">\r\n        ");
            EndContext();
            BeginContext(1973, 95, false);
#line 57 "D:\Programs\Film Share\Film Share\Views\Film\Index.cshtml"
   Write(await Component.InvokeAsync("FilmShare.Components.Film.Reviews", new { filmId = Model.FilmId }));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2092, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21a99501d5244b4b94371abd9961b2cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2153, 1882, true);
            WriteLiteral(@"
<script>
    ""use strict"";

    var connection = new signalR.HubConnectionBuilder().withUrl(""/review"").build();

    connection.on(""ReceiveReview"", function (responce) {
        console.log(responce);
        if (!responce.item1) alert(""Error in adding the review"");

        document.getElementById(""rank"").innerHTML = responce.item3;

        let review = responce.item2;

        var reviewClass = ""review"";
        if (review.rating >= 8) {
            reviewClass += "" good"";
        }
        else if (review.rating <= 4) {
            reviewClass += "" bad"";
        }

        let date = new Date(review.reviewDate)
        let dateFormat = date.toLocaleDateString() + ' ' + date.toLocaleTimeString();

        let html = '<div class=""' + reviewClass + '""><div><img width=""46"" class=""reviewProfilePhoto"" src=""' + review.userPhotoPath +
            '""><div><p class=""profile_name""><s></s><a href=""/' + review.profileId + '""><b>' + review.userName + '</b></a></p></div></div><table><tbody><tr");
            WriteLiteral(@"><td><div><p><span>'
            + review.text + '</span><br><br><span>Rating: ' + review.rating + '</span></p></div></td></tr></tbody></table><span class=""reviewDate"">' + dateFormat + '</span></div>';

        $(""#reviewsContainer"").html(html + $(""#reviewsContainer"").html())
    });

    connection.start().catch(function (err) {
        return console.error(err.toString());
    });

    function addReview(id) {
        if (!$.trim($(""#reviewText"").val())) { alert(""No review was writen. Can't add the review.""); return; }
        var ratingDDL = document.getElementById(""reviewRating"");
        var rating = ratingDDL.options[ratingDDL.selectedIndex].value;

        connection.invoke(""AddReview"", id, rating, $('#reviewText').val()).catch(function (err) {
            return console.error(err.toString());
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmShare.ViewModels.FilmModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
