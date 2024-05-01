using Microsoft.AspNetCore.Mvc.RazorPages;

namespace my_razor_page.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;

    public void OnGet()
    {
        _logger.LogInformation("OnGet was called.");
    }
}
