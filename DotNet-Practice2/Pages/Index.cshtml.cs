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

    public string[] SplitResult { get; set; }

    public void OnPost()
    {
        string sentence = Request.Form["sentence"];
        string splitCharacter = Request.Form["split-character"];
        char sep;
        switch (splitCharacter)
        {
            case "space":
                sep = ' ';
                break;
            case "comma":
                sep = ',';
                break;
            case "full stop":
                sep = '.';
                break;
            case "dash":
                sep = '-';
                break;
            default:
                sep = ' ';
                break;
        }
        // Handle splitting logic
        if (!string.IsNullOrEmpty(sentence))
        { 
            SplitResult = sentence.Split(sep);

            // SplitResult = sentence.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            ViewData["sentence"] = sentence;
            ViewData["splitCharacter"] = splitCharacter;
            ViewData["splitResult"] = SplitResult;
        }
    }
}