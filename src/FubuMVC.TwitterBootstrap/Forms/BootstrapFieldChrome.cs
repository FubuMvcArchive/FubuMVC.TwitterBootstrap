using System;
using System.Collections.Generic;
using FubuMVC.Core.UI.Forms;
using HtmlTags;

namespace FubuMVC.TwitterBootstrap.Forms
{
    public class BootstrapFieldChrome : IFieldChrome
    {
        private readonly HtmlTag _body = new HtmlTag("div").AddClass("controls");
	    private readonly Lazy<HtmlTag> _controlGroup;

	    public BootstrapFieldChrome()
	    {
		    _controlGroup = new Lazy<HtmlTag>(buildControlGroup);
	    }

        public HtmlTag LabelTag { get; set; }

        public HtmlTag BodyTag 
        { 
            get { return _body.FirstChild(); }
            set { _body.ReplaceChildren(value); } 
        }

		public HtmlTag ControlGroup { get { return _controlGroup.Value; } }

        public IEnumerable<HtmlTag> AllTags()
        {
            yield return buildControlGroup();
        }

        private HtmlTag buildControlGroup()
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
            return ControlGroup.ToString();
        }
    }
}