using Microsoft.EntityFrameworkCore;
using SimplestProject.Domain.Entities;
using SimplestProject.Domain.Interfaces.Repositories;
using SimplestProject.Infrastructure.Context;

namespace SimplestProject.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public readonly DbSet<Client> _DbSet;
        public readonly DataContext _context;

        public ClientRepository(DataContext dataContext)
        {
            _DbSet = dataContext.Set<Client>();
            _context = dataContext;
        }

        public async Task<Client?> GetClientByIdAsync(int id)
        {
            return await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
