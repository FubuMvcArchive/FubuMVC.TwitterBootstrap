using System.Reflection;
using FubuMVC.Core.UI.Elements;
using FubuMVC.TwitterBootstrap.Forms;
using FubuTestingSupport;
using HtmlTags;
using NUnit.Framework;

namespace FubuMVC.TwitterBootstrap.Testing.Forms
{
    [TestFixture]
    public class BootstrapLabelModifierTester
    {
        [Test]
        public void adds_the_control_label_class()
        {
            var request = ElementRequest.For(new object(), (PropertyInfo)null);
            request.ReplaceTag(new HtmlTag("label"));

            new BootstrapLabelModifier().Modify(request);

            request.CurrentTag.HasClass("control-label").ShouldBeTrue();
        }
    }
}