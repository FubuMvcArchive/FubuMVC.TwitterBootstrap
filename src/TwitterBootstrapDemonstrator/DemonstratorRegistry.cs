using FubuMVC.Core;

namespace TwitterBootstrapDemonstrator
{
    // SAMPLE: FubuRegistry
    public class DemonstratorRegistry : FubuRegistry
    {
        public DemonstratorRegistry()
        {
            Views.TryToAttachWithDefaultConventions();
            Routes.HomeIs<HomeEndpoint>(x => x.Index());

            // Registering the navigation registry
            Navigation<TwitterBootstrapDemonstrationNavigation>();
        }
    }
    // ENDSAMPLE
}