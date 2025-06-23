using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HyperTasks.Pages;

/// <summary>
/// IndexModel class for the Razor Pages application.
/// </summary>
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnGet()
    {
        return RedirectToPage("/Tasks");
    }
}