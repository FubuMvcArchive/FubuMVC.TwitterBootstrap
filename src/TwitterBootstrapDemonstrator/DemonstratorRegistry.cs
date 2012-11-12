using FubuMVC.Core;

namespace TwitterBootstrapDemonstrator
{
    // SAMPLE: FubuRegistry
    public class DemonstratorRegistry : FubuRegistry
    {
        public DemonstratorRegistry()
        {
            Routes.HomeIs<HomeEndpoint>(x => x.Index());

            // Registering the navigation registry
            Policies.Add<TwitterBootstrapDemonstrationNavigation>();
        }
    }
    // ENDSAMPLE
}