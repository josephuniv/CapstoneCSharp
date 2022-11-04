using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Capstone.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            if(validate(Request.Form["username"]))              
                Response.Redirect("/Contact");
           
                
        }

        public bool validate(String u)
        {
            if(u == "aa")
                return true;
            else
                return false;
        }
    }
}
