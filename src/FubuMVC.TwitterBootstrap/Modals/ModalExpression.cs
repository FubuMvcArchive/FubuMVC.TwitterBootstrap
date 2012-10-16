using System.Web;
using FubuMVC.Core.Assets;
using FubuMVC.Core.UI;
using FubuMVC.Core.View;
using HtmlTags;

namespace FubuMVC.TwitterBootstrap.Modals
{
    //<a data-toggle="modal" href="#myModal" class="btn btn-primary btn-large">Launch demo modal</a>

    public class ModalExpression : IHtmlString
    {
        private readonly IFubuPage _page;
        private readonly ModalTag _tag;

        public ModalExpression(IFubuPage page, string id)
        {
            _page = page;

            page.Asset("twitter/bootstrap-modal.js");
            _tag = new ModalTag(id);
        }

        public string ToHtmlString()
        {
            return ToString();
        }

        public ModalExpression Label(string label)
        {
            _tag.Label.Text(label);
            return this;
        }

        public ModalExpression AddCloseButton(string text)
        {
            _tag.AddCloseButton(text);
            return this;
        }

        public ModalExpression AddButton(string text, string id)
        {
            _tag.AddFooterButton(text).Id(id);
            return this;
        }

        public ModalExpression UsePartial(object model, bool withModelBinding = false)
        {
            var text = _page.Partial(model, withModelBinding);
            _tag.Body.Encoded(false).Text(text.ToString());

            return this;
        }

        public ModalExpression UsePartial<T>() where T : class
        {
            var text = _page.Partial<T>();
            _tag.Body.Encoded(false).Text(text.ToString());

            return this;
        }

        public override string ToString()
        {
            return _tag.ToString();
        }
    }


    public class ModalTag : HtmlTag
    {
        private readonly HtmlTag _body;
        private readonly HtmlTag _footer;
        private HtmlTag _label;

        public ModalTag(string id) : base("div")
        {
            var labelId = id + "Label";
            var bodyId = id + "Body";

            AddClass("modal");
            AddClass("hide");

            Id(id);
            Attr("tabindex", "-1");
            Attr("role", "dialog");
            Attr("aria-labelledby", labelId);
            Attr("aria-hidden", "true");
            Attr("data-show", "false");

            var header = Add("div");
            header.AddClass("modal-header");
            header.Add("button").Attr("type", "button").AddClass("close").Attr("data-dismiss", "modal").Attr("aria-hidden", "true").Text("x");

            _label = header.Add("h3").Id(labelId);

            _body = Add("div").Id(bodyId).AddClass("modal-body");

            _footer = Add("div").AddClass("modal-footer");
        }

        public HtmlTag Footer
        {
            get { return _footer; }
        }

        public HtmlTag Body
        {
            get { return _body; }
        }

        public HtmlTag Label
        {
            get { return _label; }
        }

        public void AddCloseButton(string text)
        {
            _footer.Add("button").AddClass("btn").Attr("data-dismiss", "modal").Attr("aria-hidden", "true").Text(text);
        }

        public HtmlTag AddFooterButton(string text)
        {
            return Add("button").AddClasses("btn", "btn-primary").Text(text);
        }
    }


    /*
  <div class="modal" id="routeModal" tabindex="-1" role="dialog" aria-labelledby="routeModalLabel" aria-hidden="true" data-show="false">
    <div class="modal-header">
      <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
      <h3 id="routeModalLabel">Route/Chain Visualization</h3>
    </div>
    <div id="routeBody" class="modal-body">
      there's some stuff here that will get replaced at a later time
    </div>
    <div class="modal-footer">
      <button class="btn" data-dismiss="modal" aria-hidden="true">Close</button>
      <button class="btn btn-primary">Save changes</button>
    </div>
  </div>
     */
}