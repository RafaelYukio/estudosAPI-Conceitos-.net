using SimplestProject.Domain.Entities;

namespace SimplestProject.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<Client> GetClientByIdAsync(int id);
    }
}
