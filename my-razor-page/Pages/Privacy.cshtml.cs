using Microsoft.AspNetCore.Mvc.RazorPages;

namespace my_razor_page.Pages;

public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
{
    private readonly ILogger<PrivacyModel> _logger = logger;

    public void OnGet()
    {
        _logger.LogInformation("OnGet was called.");
    }
}

