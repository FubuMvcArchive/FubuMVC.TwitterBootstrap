using HtmlTags;

namespace FubuMVC.TwitterBootstrap.Collapsibles
{
    public class CollapsibleTag : HtmlTag
    {
        private readonly HtmlTag _body;

        public CollapsibleTag(string id, string title) : base("div")
        {
            AddClass("accordion-group");
            Id(id);

            var bodyId = id + "-body";

            Add("div").AddClass("accordion-heading").Add("a")
                .AddClass("accordion-toggle")
                .Data("toggle", "collapse")
                .Attr("href", "#" + bodyId)
                .Text(title);

            _body = Add("div").Id(bodyId).AddClasses("accordion-body", "collapse")
                .Add("div").AddClass("accordion-inner");
        }


        public void SetInnerContent(string html)
        {
            _body.AppendHtml(html);
        }
    }
}