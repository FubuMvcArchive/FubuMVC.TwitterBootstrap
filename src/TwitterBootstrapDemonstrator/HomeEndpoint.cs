using System;
using FubuMVC.Navigation;
using HtmlTags;
using System.Collections.Generic;

namespace TwitterBootstrapDemonstrator
{
    public class HomeEndpoint
    {
        private readonly INavigationService _service;

        public HomeEndpoint(INavigationService service)
        {
            _service = service;
        }

        public HomeViewModel Index()
        {
            var outline = new HtmlTag("ul");
            _service.MenuFor(new NavigationKey("TwitterBootstrap")).Each(token =>
            {
                outline.Add("li").Add("a").Text(token.Text).Attr("href", token.Url);
            });

            return new HomeViewModel{
                Outline = outline
            };
        }
    }

    public class HomeViewModel
    {
        public HtmlTag Outline { get; set; }
    }
}