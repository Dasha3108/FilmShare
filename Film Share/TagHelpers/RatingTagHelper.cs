using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.TagHelpers
{
    public class RatingTagHelper : TagHelper
    {
        private readonly IEnumerable<int> ratings = Enumerable.Range(0, 11);

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "select";

            var html = "";
            foreach (var rating in ratings)
            {
                html += $@"<option>{rating}</option>";
            }

            output.Content.SetHtmlContent(html);

        }
    }
}
