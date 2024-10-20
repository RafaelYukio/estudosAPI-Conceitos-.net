using SimplestProject.Domain.Entities;

namespace SimplestProject.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task<Client?> GetClientByIdAsync(int id);
    }
}
