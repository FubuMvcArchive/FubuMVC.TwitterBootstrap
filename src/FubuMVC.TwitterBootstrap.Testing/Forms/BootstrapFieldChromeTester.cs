using FubuMVC.TwitterBootstrap.Forms;
using FubuTestingSupport;
using HtmlTags;
using NUnit.Framework;

namespace FubuMVC.TwitterBootstrap.Testing.Forms
{
    [TestFixture]
    public class BootstrapFieldChromeTester
    {
        private BootstrapFieldChrome theChrome;

        [SetUp]
        public void SetUp()
        {
            theChrome = new BootstrapFieldChrome();
        }

        [Test]
        public void renders_the_label_and_control()
        {
            var input = new HtmlTag("input").Attr("type", "text");
            var label = new HtmlTag("label").Text("Test");

            theChrome.LabelTag = label;
            theChrome.BodyTag = input;

            theChrome.Render()
                .ShouldEqual("<div class=\"control-group\"><label>Test</label><div class=\"controls\"><input type=\"text\" /></div></div>");
        }

        [Test]
        public void no_label()
        {
            var input = new HtmlTag("input").Attr("type", "text");

            theChrome.BodyTag = input;

            theChrome.Render()
                .ShouldEqual("<div class=\"control-group\"><div class=\"controls\"><input type=\"text\" /></div></div>");
        }
    }
}