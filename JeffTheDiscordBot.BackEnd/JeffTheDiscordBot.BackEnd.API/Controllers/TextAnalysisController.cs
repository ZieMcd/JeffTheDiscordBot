using Microsoft.AspNetCore.Mvc;

namespace JeffTheDiscordBot.BackEnd.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TextAnalysisController : Controller
{
    public IActionResult AnalyzeText(string text)
    {
        throw new NotImplementedException();
    }
}