using DB;
using Microsoft.EntityFrameworkCore;

namespace WebAPIClient.Interface
{
    public class ClientR : IClient
    {
        protected readonly BI_TESTGENContext _context;
        public ClientR(BI_TESTGENContext context)=>_context=context;
        
        public async Task<Client> CreateClientAsync(Client client)
        {
            await _context.Set<Client>().AddAsync(client);
            await _context.SaveChangesAsync();
            return client;

        }

        public async Task<bool> DeleteClientAsync(Client client)
        {
            if (client is null)
            {
                return false;
            }
            _context.Set<Client>().Remove(client);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientsById(int id)
        {
            return _context.Clients.Find(id);
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
