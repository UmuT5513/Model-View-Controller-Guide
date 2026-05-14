using Microsoft.AspNetCore.Razor.TagHelpers;

namespace hafta3.TagHelpers
{
    public class ProductShowTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent("<ul>" +
                "<li>Kalem</li>" +
                "<li>3 TL</li>" +
                "<li>Stok: 1000 </li>" +
                "</ul>");
        }
    }
}
