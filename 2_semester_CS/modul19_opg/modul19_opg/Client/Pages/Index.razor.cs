using Microsoft.AspNetCore.Components.Forms;
using modul19_opg.Shared.Models;

namespace modul19_opg.Client.Pages
{
    public partial class Index
    {
        private Product ProductModel = new Product();
        private EditContext EditContext;

        protected override void OnInitialized()
        {
            EditContext = new EditContext(ProductModel);
        }

        private void HandleSubmit()
        {
            Console.WriteLine("HandleSubmit Called...");

            if (EditContext.Validate())
            {
                Console.WriteLine("Form is Valid...");
            }
            else
            {
                Console.WriteLine("Form is Invalid...");
            }
        }
    }

}