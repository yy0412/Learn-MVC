using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;
//using Microsoft.AspNet.Razor.TagHelpers.TagHelperContext;

namespace AuthoringTagHelpers.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
            var content = await context.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            output.Attributes["href"] = "mailto:" + target;
            output.Content.SetContent(target);
        }
    }

}
