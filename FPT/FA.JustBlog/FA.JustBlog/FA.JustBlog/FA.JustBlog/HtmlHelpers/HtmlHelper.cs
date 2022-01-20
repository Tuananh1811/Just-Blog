using FA.JustBlog.ViewModels.Tags;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace FA.JustBlog.HtmlHelpers
{
    public static class HtmlHelperCustom
    {
        public static IHtmlString TagLink(this HtmlHelper helper, IList<TagViewModel> tags)
        {
            var html = "<div>";

            var css = new string[] { "badge bg-primary text-wrap ml-2 text-decoration-underline",
                                     "badge bg-success text-wrap ml-2 text-decoration-underline",
                                     "badge bg-warning text-wrap ml-2 text-decoration-underline",
                                     "badge bg-danger text-wrap ml-2 text-decoration-underline",
                                     "badge bg-info text-wrap ml-2 text-decoration-underline" };
            int count = 0;
            foreach (var tag in tags)
            {
                if (count > css.Length) count = 0;
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes.Add("href", "/Tag/" + tag.UrlSlug);
                tb.Attributes.Add("class", css[count]);
                tb.InnerHtml = tag.Name;
                count++;
                html += tb.ToString();
            }
            html = html + "</div>";
            return new MvcHtmlString(html);
        }

    }
}