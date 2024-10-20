using SimplestProject.Domain.Entities;
using SimplestProject.Domain.Interfaces.Services;

namespace SimplestProject.Domain.Services
{
    public class ClientService : IClientService
    {
        public async Task<Client> GetClientByIdAsync(int id)
        {
            var client = new Client()
            {
                Id = 1,
                Name = "Test",
                Age = 10,
            };

            return client;
        }
    }
}
