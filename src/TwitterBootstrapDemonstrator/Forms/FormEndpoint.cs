namespace TwitterBootstrapDemonstrator.Forms
{
    public class FormEndpoint
    {
         public FormModel get_form(FormModel model)
         {
             return model;
         }

        public string post_form(FormModel model)
        {
            return "Success";
        }
    }

    public class FormModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}