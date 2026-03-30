using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeRecordsIdentity.Pages.Admin
{
    [Authorize(Policy = "Admin")]
    public class UsersModel : PageModel
    {
       
    }
}
