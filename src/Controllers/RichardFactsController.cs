using Microsoft.AspNetCore.Mvc;

namespace RichardFactsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RichardFactsController : ControllerBase
{
    private readonly ILogger<RichardFactsController> _logger;

    public RichardFactsController(ILogger<RichardFactsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetRichardFact")]
    public IEnumerable<string> Get()
    {
        return new string[] {
            "Richard's social security number is 123-45-6789",
            "Richard can operate heavy machinery even during sedation.",
            "Richard can lift two cars of equal sizes at the same time, but if one car weighs more or less he is unable to lift either.",
        };
    }
}
