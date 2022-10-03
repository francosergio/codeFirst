using DB;
using Microsoft.AspNetCore.Mvc;
using WebAPIClient.Interface;

namespace WebAPIClient.Controllers
{
    [Route("PERSON")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IClient _clientR;

        public ProductController(IClient clientR)
        {
            _clientR = clientR;
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<Client> GetClients()
        {
            return _clientR.GetClients();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetClientsById))]
        public ActionResult<Client> GetClientsById(int id)
        {
            var clientByID = _clientR.GetClientsById(id);
            if (clientByID == null)
            {
                return NotFound();
            }
            return clientByID;
        }

        [HttpPost]
        [ActionName(nameof(CreateClientAsync))]
        public async Task<ActionResult<Client>> CreateClientAsync(Client client)
        {
            await _clientR.CreateClientAsync(client);
            return CreatedAtAction(nameof(GetClientsById), new { id = client.IdClient }, client);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdateClientAsync))]
        public async Task<ActionResult> UpdateClientAsync(int id, Client client)
        {
            if (id != client.IdClient)
            {
                return BadRequest();
            }

            await _clientR.UpdateClientAsync(client);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteClientAsync))]
        public async Task<IActionResult> DeleteClientAsync(int id)
        {
            var client = _clientR.GetClientsById(id);
            if (client == null)
            {
                return NotFound();
            }

            await _clientR.DeleteClientAsync(client);

            return NoContent();
        }
    }

}
