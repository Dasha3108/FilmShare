#pragma checksum "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7b8d1d0cdf0acf072e841bdd1cbdf697523ad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Index.cshtml", typeof(AspNetCore.Views_Profile_Index))]
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
#line 1 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7b8d1d0cdf0acf072e841bdd1cbdf697523ad6", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ad6d31f0ca4cbe5bcc8f40e5b4456554ce2a652", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmShare.ViewModels.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updatePhotoForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePhoto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = Localizer["Profile"];
    Layout = "~/Views/Shared/_LayoutMenu.cshtml";

#line default
#line hidden
            BeginContext(232, 97, true);
            WriteLiteral("\r\n<div class=\"col-md-6 col-md-offset-3 profileWrap\">\r\n    <div class=\"text-center\">\r\n        <h2>");
            EndContext();
            BeginContext(330, 25, false);
#line 13 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
       Write(Localizer["User Profile"]);

#line default
#line hidden
            EndContext();
            BeginContext(355, 19, true);
            WriteLiteral("</h2>\r\n    </div>\r\n");
            EndContext();
#line 15 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
     if (ViewBag.isCurrentUser)
    {

#line default
#line hidden
            BeginContext(414, 110, true);
            WriteLiteral("        <div class=\"col-md-12\" style=\"padding: 10px\">\r\n            <div class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(524, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580c90a87e4f48dfb50b61fb67f27e85", async() => {
                BeginContext(570, 102, true);
                WriteLiteral("\r\n                    <button class=\"btn btn-theme btn-block\" type=\"button\"><i class=\"fa fa-lock\"></i>");
                EndContext();
                BeginContext(673, 27, false);
#line 20 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                                                                               Write(Localizer["Change Profile"]);

#line default
#line hidden
                EndContext();
                BeginContext(700, 27, true);
                WriteLiteral("</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(731, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 24 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(776, 127, true);
            WriteLiteral("    <div class=\"profileInfo\">\r\n        <div class=\"leftProfile\">\r\n            <div class=\"avatarUserBox\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 903, "", 924, 1);
#line 28 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
WriteAttributeValue("", 908, Model.PhotoPath, 908, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(924, 80, true);
            WriteLiteral(" style=\'height: 100%; width: 100%; object-fit: contain\'>\r\n            </div>\r\n\r\n");
            EndContext();
#line 31 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
             if (ViewBag.isCurrentUser)
            {

#line default
#line hidden
            BeginContext(1060, 73, true);
            WriteLiteral("                <div class=\"centerButtonContainer\">\r\n                    ");
            EndContext();
            BeginContext(1133, 423, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dfc6a0afd114fa88d47fbb2d8b5b6ee", async() => {
                BeginContext(1229, 262, true);
                WriteLiteral(@"
                        <input type=""file"" id=""selectedFile"" style=""display: none;"" name=""photo"" accept=""image/*"" />
                        <input class=""btn-theme"" type=""button"" onclick=""document.getElementById('selectedFile').click();"" title=""Update photo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1491, "\"", 1525, 1);
#line 36 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1499, Localizer["Update photo"], 1499, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1526, 23, true);
                WriteLiteral(">\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1556, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 39 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1597, 88, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(1686, 18, false);
#line 44 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
              Write(Localizer["NAME:"]);

#line default
#line hidden
            EndContext();
            BeginContext(1704, 40, true);
            WriteLiteral("</b>\r\n                <span id=\"name\">\r\n");
            EndContext();
#line 46 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                      
                        if (Model != null)
                        {
                            

#line default
#line hidden
            BeginContext(1868, 10, false);
#line 49 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                       Write(Model.Name);

#line default
#line hidden
            EndContext();
#line 49 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                       ;
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1965, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1995, 16, true);
            WriteLiteral("No information\r\n");
            EndContext();
#line 54 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2061, 79, true);
            WriteLiteral("                </span>\r\n            </p>\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(2141, 27, false);
#line 59 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
              Write(Localizer["DATE OF BIRTH:"]);

#line default
#line hidden
            EndContext();
            BeginContext(2168, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
#line 60 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                  
                    if (Model != null)
                    {
                        

#line default
#line hidden
            BeginContext(2282, 37, false);
#line 63 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                   Write(Model.DateOfBirth.ToShortDateString());

#line default
#line hidden
            EndContext();
#line 63 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                                              
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2393, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2419, 16, true);
            WriteLiteral("No information\r\n");
            EndContext();
#line 68 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2477, 54, true);
            WriteLiteral("            </p>\r\n            <p>\r\n                <b>");
            EndContext();
            BeginContext(2532, 19, false);
#line 72 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
              Write(Localizer["EMAIL:"]);

#line default
#line hidden
            EndContext();
            BeginContext(2551, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
#line 73 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                  
                    if (Model != null)
                    {
                        

#line default
#line hidden
            BeginContext(2665, 11, false);
#line 76 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                   Write(Model.Email);

#line default
#line hidden
            EndContext();
#line 76 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                    ;
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2751, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2777, 16, true);
            WriteLiteral("No information\r\n");
            EndContext();
#line 81 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2835, 18, true);
            WriteLiteral("            </p>\r\n");
            EndContext();
#line 84 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
             if (!ViewBag.isCurrentUser)
            {

#line default
#line hidden
            BeginContext(2910, 45, true);
            WriteLiteral("                <div id=\"friendsContainer\">\r\n");
            EndContext();
#line 87 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                     if (ViewBag.areFriends)
                    {

#line default
#line hidden
            BeginContext(3024, 35, true);
            WriteLiteral("                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3059, "\"", 3096, 3);
            WriteAttributeValue("", 3069, "removeFriend(", 3069, 13, true);
#line 89 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
WriteAttributeValue("", 3082, Model.UserId, 3082, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3095, ")", 3095, 1, true);
            EndWriteAttribute();
            BeginContext(3097, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3099, 32, false);
#line 89 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                                                     Write(Localizer["Remove from Friends"]);

#line default
#line hidden
            EndContext();
            BeginContext(3131, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 90 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3209, 35, true);
            WriteLiteral("                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3244, "\"", 3278, 3);
            WriteAttributeValue("", 3254, "addFriend(", 3254, 10, true);
#line 93 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
WriteAttributeValue("", 3264, Model.UserId, 3264, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3277, ")", 3277, 1, true);
            EndWriteAttribute();
            BeginContext(3279, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3281, 27, false);
#line 93 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                                                  Write(Localizer["Add to Friends"]);

#line default
#line hidden
            EndContext();
            BeginContext(3308, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 94 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3337, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 96 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3376, 191, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div style=\"margin-top:15px; border-top-width:1px; border-top-color: #424a5d; border-top-style: solid;\">\r\n        <p style=\"margin-top:5px; font-size:22px;\">");
            EndContext();
            BeginContext(3568, 26, false);
#line 101 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                              Write(Localizer["User Reviews:"]);

#line default
#line hidden
            EndContext();
            BeginContext(3594, 14, true);
            WriteLiteral("</p>\r\n        ");
            EndContext();
            BeginContext(3609, 98, false);
#line 102 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
   Write(await Component.InvokeAsync("FilmShare.Components.Profile.Reviews", new { userId = Model.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(3707, 34, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n");
            EndContext();
#line 107 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
     if (ViewBag.isCurrentUser) {
        

#line default
#line hidden
            BeginContext(3790, 312, true);
            WriteLiteral(@"
            $(document).ready(function () {
                $(""#profileImg"").css(""background"", ""#47a7cc"")

                document.getElementById(""selectedFile"").onchange = function () {
                    document.getElementById(""updatePhotoForm"").submit();
                };
            })
        ");
            EndContext();
#line 116 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
               
    }

#line default
#line hidden
            BeginContext(4118, 1920, true);
            WriteLiteral(@"
    function addFriend(id) {
        $.ajax({
            url: '/api/friendship/' + id,
            type: 'PUT',
            success: function (result) {
                updateDataToRemoveFriend()

                var friendName = document.getElementById('name').innerText
                Push.create(""A Friend was added"", {
                    body: friendName + "" is your friend now"",
                    timeout: 3000,
                    onClick: function () {
                        window.focus();
                        this.close();
                    }
                });
            },
            error: function (error) {
                switch (error.status) {
                    case 401:
                        alert(""You should be authorized to be able to add friend"")
                }
            }
        });
    }

    function removeFriend(id) {
        $.ajax({
            url: '/api/friendship/' + id,
            type: 'DELETE',
            success: function (");
            WriteLiteral(@"result) {
                console.log(result)
                updateDataToAddFriend();

                var friendName = document.getElementById('name').innerText
                Push.create(""A Friend was removed"", {
                    body: friendName + "" is not longer your friend"",
                    timeout: 2000,
                    onClick: function () {
                        window.focus();
                        this.close();
                    }
                });
            },
            error: function (error) {
                switch (error.status) {
                    case 401:
                        alert(""You should be authorized to be able to remove friend"")
                }
            }
        });
    }

    function updateDataToAddFriend() {
        $('#friendsContainer').empty();

        $('<a href=""#"" onclick=""addFriend(' + ");
            EndContext();
            BeginContext(6039, 12, false);
#line 175 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                         Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(6051, 207, true);
            WriteLiteral(" + \')\">Add to Friends</a>\').appendTo($(\'#friendsContainer\'));\r\n    }\r\n\r\n    function updateDataToRemoveFriend() {\r\n        $(\'#friendsContainer\').empty();\r\n\r\n        $(\'<a href=\"#\" onclick=\"removeFriend(\' + ");
            EndContext();
            BeginContext(6259, 12, false);
#line 181 "D:\Programs\Film Share\Film Share\Views\Profile\Index.cshtml"
                                            Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(6271, 90, true);
            WriteLiteral(" + \')\">Remove from Friends</a>\').appendTo($(\'#friendsContainer\'));\r\n    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmShare.ViewModels.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
