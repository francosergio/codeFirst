using DB;

namespace WebAPIClient.Interface
{
    public interface IClient
    {
        /*C        (CREATE) */
            Task<Client> CreateClientAsync(Client client);

        /*R         (READ)   */
            IEnumerable<Client> GetClients();
            Client GetClientsById(int id); //GET by id (READ)
        /*U          (UPDATE)*/
            Task<bool> UpdateClientAsync(Client client);
        /*D           (DELETE)*/
            Task<bool> DeleteClientAsync(Client client);
    }

}
