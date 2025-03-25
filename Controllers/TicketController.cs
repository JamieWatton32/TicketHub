using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TicketHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase {
        private readonly ILogger<TicketController> _logger;
        private readonly IConfiguration _configuration;

        public TicketController(ILogger<TicketController> logger, IConfiguration configuration) {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get(Ticket ticket) {
            if (ModelState.IsValid == false) {
                BadRequest(ModelState);
            }
            string jsonTicket = JsonSerializer.Serialize(ticket);
            return Ok(jsonTicket);
        }

        [HttpPost]
        public IActionResult Post(Ticket ticket) {
            if (ModelState.IsValid == false) {
                BadRequest(ModelState);
            }
            string jsonTicket = JsonSerializer.Serialize(ticket);
            return Ok(jsonTicket);
        }
    }
}
