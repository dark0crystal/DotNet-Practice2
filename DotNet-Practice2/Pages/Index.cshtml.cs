using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNet_Practice2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public void OnPost()
    {
        if (HttpContext.Request.Query["sentence"].Count > 0)
        {
            string sentence =Request.Form["sentence"];
            ViewData["sentence"] = sentence;
            string splitCharacter = Request.Form["split-character"];
            Console.WriteLine(sentence);
        }
    }
}