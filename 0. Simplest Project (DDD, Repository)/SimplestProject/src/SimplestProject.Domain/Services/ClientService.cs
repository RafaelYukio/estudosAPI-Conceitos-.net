using SimplestProject.Domain.Entities;
using SimplestProject.Domain.Interfaces.Repositories;
using SimplestProject.Domain.Interfaces.Services;

namespace SimplestProject.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client?> GetClientByIdAsync(int id)
        {
            var client = await _clientRepository.GetClientByIdAsync(id);
            return client;
        }
    }
}
