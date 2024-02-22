using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace api
{
    public class message
    {
        private readonly ILogger<message> _logger;

        public message(ILogger<message> logger)
        {
            _logger = logger;
        }

        [Function("message")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
           return new JsonResult(new { text = "Hello from the API" });
        }
    }
}
