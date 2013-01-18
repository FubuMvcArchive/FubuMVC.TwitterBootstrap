using FubuMVC.Core.UI.Forms;
using HtmlTags.Conventions;

namespace FubuMVC.TwitterBootstrap.Forms
{
    public class HorizontalFormModifier : ITagModifier<FormRequest>
    {
        public bool Matches(FormRequest token)
        {
            return true;
        }

        public void Modify(FormRequest request)
        {
            request.CurrentTag.AddClass("form-horizontal");
        }
    }
}