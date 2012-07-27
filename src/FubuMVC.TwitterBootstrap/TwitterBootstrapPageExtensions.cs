using FubuLocalization;
using FubuMVC.Core.UI.Navigation;
using FubuMVC.Core.View;
using FubuMVC.TwitterBootstrap.Menus;
using HtmlTags;

namespace FubuMVC.TwitterBootstrap
{
    public static class TwitterBootstrapPageExtensions
    {
        public static HtmlTag TwitterNavBarFor(this IFubuPage page, StringToken menuKey)
        {
            var service = page.Get<INavigationService>();
            var tokens = service.MenuFor(menuKey);

            return new MenuTag(tokens);
        }

        public static HtmlTag TwitterNavBarFor(this IFubuPage page, string menuKey)
        {
            return page.TwitterNavBarFor(new NavigationKey(menuKey));
        }
    }
}