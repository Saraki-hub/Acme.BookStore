using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Acme.BookStore.Web.Pages;

[AllowAnonymous]
public class IndexModel : BookStorePageModel
{
    public IActionResult OnGet()
    {
        return RedirectToPage("/Books/Index");
    }
}
