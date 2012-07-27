using FubuMVC.Core;

namespace TwitterBootstrapDemonstrator
{
    public class DemonstratorRegistry : FubuRegistry
    {
        public DemonstratorRegistry()
        {
            Views.TryToAttachWithDefaultConventions();
            Routes.HomeIs<HomeEndpoint>(x => x.Index());
        }
    }
}