using FubuMVC.Core.UI.Navigation;
using TwitterBootstrapDemonstrator.CollapsiblePartial;
using TwitterBootstrapDemonstrator.Modals;
using TwitterBootstrapDemonstrator.Navigation;

namespace TwitterBootstrapDemonstrator
{
    // SAMPLE: NavigationRegistry
    public class TwitterBootstrapDemonstrationNavigation : NavigationRegistry
    {
        public TwitterBootstrapDemonstrationNavigation()
        {
            ForMenu("TwitterBootstrap");

            Add += MenuNode.ForAction<NavigationEndpoint>("Navigation Bar", x => x.get_navigation_bar());
            Add += MenuNode.ForAction<CollapsiblePartialEndpoint>("Collapsible Partials", x => x.get_collapsible_partial());
            Add += MenuNode.ForAction<ModalEndpoint>("Modal Popups", x => x.get_modal());
        }
    }
    // ENDSAMPLE
}