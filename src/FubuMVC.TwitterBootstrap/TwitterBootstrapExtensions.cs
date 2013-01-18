using FubuMVC.Core;
using FubuMVC.Core.UI;
using FubuMVC.TwitterBootstrap.Forms;

namespace FubuMVC.TwitterBootstrap
{
    public class TwitterBootstrapExtensions : IFubuRegistryExtension
    {
        public void Configure(FubuRegistry registry)
        {
            registry.Import<HtmlConventionRegistry>(x =>
            {
                x.FieldChrome<BootstrapFieldChrome>();
                x.Labels.Add(new BootstrapLabelModifier());
                x.Forms.Add(new HorizontalFormModifier());
            });
        }
    }
}