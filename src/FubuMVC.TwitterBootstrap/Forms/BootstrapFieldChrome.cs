using System.Collections.Generic;
using FubuMVC.Core.UI.Forms;
using HtmlTags;

namespace FubuMVC.TwitterBootstrap.Forms
{
    public class BootstrapFieldChrome : IFieldChrome
    {
        private readonly HtmlTag _body = new HtmlTag("div").AddClass("controls");

        public HtmlTag LabelTag { get; set; }

        public HtmlTag BodyTag 
        { 
            get { return _body.FirstChild(); }
            set { _body.ReplaceChildren(value); } 
        }

        public IEnumerable<HtmlTag> AllTags()
        {
            yield return ControlGroup();
        }

        public HtmlTag ControlGroup()
        {
            var group = new HtmlTag("div").AddClass("control-group");
            
            if (LabelTag != null)
            {
                group.Append(LabelTag);
            }

            group.Append(_body);

            return group;
        }

        public string Render()
        {
            return ControlGroup().ToString();
        }
    }
}