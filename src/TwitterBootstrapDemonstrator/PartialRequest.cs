using System;
using HtmlTags;

namespace TwitterBootstrapDemonstrator
{
    // SAMPLE: PartialInCollapsible
    public class HtmlTagPartialEndpoint
    {
        public HtmlTag HtmlPartial(PartialRequest request)
        {
            var inner = new HtmlTag("div");
            for (var i = 0; i < 5; i++)
            {
                inner.Add("p").Text(Guid.NewGuid().ToString());
            }

            return inner;
        }
    }

    public class PartialRequest { }
    // ENDSAMPLE


}