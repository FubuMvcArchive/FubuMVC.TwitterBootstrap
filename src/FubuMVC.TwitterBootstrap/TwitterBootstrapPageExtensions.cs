using FubuLocalization;
using FubuMVC.Core.Runtime;
using FubuMVC.Core.UI;
using FubuMVC.Core.UI.Navigation;
using FubuMVC.Core.View;
using FubuMVC.TwitterBootstrap.Collapsibles;
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

        public static CollapsiblePartialExpression CollapsiblePartialFor<TInputModel>(this IFubuPage page) where TInputModel : class
        {
            page.Asset("twitter/activate-collapsible.js");
            return new CollapsiblePartialExpression(() => page.Partial<TInputModel>());
        }

        public static CollapsiblePartialExpression CollapsiblePartialFor(this IFubuPage page, object input)
        {
            page.Asset("twitter/activate-collapsible.js");
            return new CollapsiblePartialExpression(() => page.PartialFor(input));
        }

        public static CollapsiblePartialExpression CollapsiblePartialFor<TInputModel>(this IFubuPage page, TInputModel model) where TInputModel : class
        {
            page.Asset("twitter/activate-collapsible.js");
            return new CollapsiblePartialExpression(() => page.PartialFor(model));
        }
    }
}