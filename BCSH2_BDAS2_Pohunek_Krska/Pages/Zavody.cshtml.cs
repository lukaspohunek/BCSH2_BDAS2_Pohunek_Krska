using Microsoft.AspNetCore.Mvc.RazorPages;
using BCSH2_BDAS2_Pohunek_Krska; // Make sure to include the correct namespace.

namespace BCSH2_BDAS2_Pohunek_Krska.Pages
{
    public class ZavodyModel : PageModel
    {
        public void OnGet()
        {
            // Access the Zavody class within the Entity namespace.
            Entity.Zavod myZavod = new Entity.Zavod();

            // You can use myZavody to work with your Zavody class.
        }
    }
}

