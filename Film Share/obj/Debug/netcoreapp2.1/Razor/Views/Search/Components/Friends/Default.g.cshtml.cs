#pragma checksum "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d72ff5f3ff13e06bad73502e318911256d80bbec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Components_Friends_Default), @"mvc.1.0.view", @"/Views/Search/Components/Friends/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Components/Friends/Default.cshtml", typeof(AspNetCore.Views_Search_Components_Friends_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72ff5f3ff13e06bad73502e318911256d80bbec", @"/Views/Search/Components/Friends/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f8e1974d42f1f7e109d7c60e3318b5107dc99", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Components_Friends_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FilmShare.ViewModels.ProfileModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 31, true);
            WriteLiteral("\r\n<div id=\"friendsContainer\">\r\n");
            EndContext();
#line 4 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(106, 40, true);
            WriteLiteral("    <label>No users were found</label>\r\n");
            EndContext();
#line 7 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
}

#line default
#line hidden
#line 8 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
 foreach (var profile in Model)
{

#line default
#line hidden
            BeginContext(185, 137, true);
            WriteLiteral("    <div class=\"smallProfileInfo\">\r\n        <div class=\"leftProfile\">\r\n            <div class=\"smallAvatarUserBox\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 322, "", 345, 1);
#line 13 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
WriteAttributeValue("", 327, profile.PhotoPath, 327, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(345, 140, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(485, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69bf3823a6e441c297b2e2f96433edbf", async() => {
                BeginContext(597, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(601, 12, false);
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
                                                                                                                          Write(profile.Name);

#line default
#line hidden
                EndContext();
                BeginContext(613, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 492, "name", 492, 4, true);
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
AddHtmlAttributeValue(" ", 496, profile.UserId, 497, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-profileId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
                                                                                             WriteLiteral(profile.ProfileId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["profileId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-profileId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["profileId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(621, 17, true);
            WriteLiteral("\r\n            <p>");
            EndContext();
            BeginContext(639, 39, false);
#line 18 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
          Write(profile.DateOfBirth.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(678, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(700, 13, false);
#line 19 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
          Write(profile.Email);

#line default
#line hidden
            EndContext();
            BeginContext(713, 29, true);
            WriteLiteral("</p>\r\n            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 742, "\"", 778, 3);
            WriteAttributeValue("", 752, "addFriend(", 752, 10, true);
#line 20 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
WriteAttributeValue("", 762, profile.UserId, 762, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 777, ")", 777, 1, true);
            EndWriteAttribute();
            BeginContext(779, 49, true);
            WriteLiteral(">Add to Friends</a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 23 "D:\Programs\Film Share\Film Share\Views\Search\Components\Friends\Default.cshtml"
}

#line default
#line hidden
            BeginContext(831, 2002, true);
            WriteLiteral(@"</div>

<script>
    function addFriend(id) {
        $.ajax({
            url: '/api/friendship/' + id,
            type: 'PUT',
            success: function (result) {
                var friendName = document.getElementById('name ' + id).innerText
                Push.create(""A Friend was added"", {
                    body: friendName + "" is your friend now"",
                    timeout: 3000,
                    onClick: function () {
                        window.focus();
                        this.close();
                    }
                });

                getData();
            }
        });
    }

    function getData() {
        $.ajax({
            type: 'POST',
            url: '/Search/Friends/',
            success: function (data) {
                $('#friendsContainer').empty();
                console.log(data)

                if (data.length > 0) {
                    $.each(data, function (key, item) {
                        var dateFormat = (ne");
            WriteLiteral(@"w Date(item.dateOfBirth)).toLocaleDateString()

                        $('<div class=""smallProfileInfo""><div class= ""leftProfile""><div class=""smallAvatarUserBox""><img src=""'
                            + item.photoPath + '"" style=""height: 100%; width: 100%; object-fit: contain""></div></div><div class=""form-group""><a href=""/Profile?profileId='
                            + item.profileId + '"" id=""name ' + item.userId +'""><b>'
                            + item.name + '</b></a><p>' + dateFormat + '</p><p>' + item.email + '</p><a href=""#"" onclick=""addFriend('
                            + item.userId + ')"">Add to Friends</a></div></div >').appendTo($('#friendsContainer'));
                    });
                }

                else {
                    const container = $('#friendsContainer');
                    $('#friendsContainer').append($('<label>No users were found</label>'));
                }

            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FilmShare.ViewModels.ProfileModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591