using System;
using FubuMVC.TwitterBootstrap.Collapsibles;
using HtmlTags;

namespace TwitterBootstrapDemonstrator.CollapsiblePartial
{
    public class CollapsiblePartialEndpoint
    {
        // SAMPLE: UsingCollapsibleTag
        public CollapsiblePartialViewModel get_collapsible_partial()
        {
            var inner = new HtmlTag("div");
            for (var i = 0; i < 5; i++ )
            {
                inner.Add("p").Text(Guid.NewGuid().ToString());
            }


            var tag = new CollapsibleTag("acc1", "This is the collapsible tag");
            tag.SetInnerContent(inner.ToString());

            return new CollapsiblePartialViewModel{
                Tag = tag
            };
        }
        // ENDSAMPLE


    }

    public class CollapsiblePartialViewModel
    {
        public HtmlTag Tag { get; set; }
    }
}