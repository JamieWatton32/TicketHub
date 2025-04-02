using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Azure.Storage.Queues;
using System.Text.RegularExpressions;
using System.Text;
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

      

        [HttpPost]
        public async Task<IActionResult> PostAsync(Ticket ticket) {
            if (ModelState.IsValid == false) {
                BadRequest(ModelState);
            }
            string queueName = "ticketqueue";
            // Get connection string from secrets.json
            string? connectionString = _configuration["AzureStorageConnectionString"];
            if (string.IsNullOrEmpty(connectionString)) {
                return BadRequest("An error was encountered");
            }
            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // serialize an object to json
            string message = JsonSerializer.Serialize(ticket);
            var plainBytes = Encoding.UTF8.GetBytes(message);
            string base64Message = Convert.ToBase64String(plainBytes);
            // send string message to queue
            await queueClient.SendMessageAsync(base64Message);
            
            string jsonTicket = JsonSerializer.Serialize(ticket);
            return Ok(jsonTicket);
        }
    }
}
