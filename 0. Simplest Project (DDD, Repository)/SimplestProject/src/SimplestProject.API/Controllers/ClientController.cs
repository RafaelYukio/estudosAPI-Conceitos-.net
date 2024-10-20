using Microsoft.AspNetCore.Mvc;
using SimplestProject.Application.DTOs.Response;
using SimplestProject.Domain.Interfaces.Services;

namespace SimplestProject.API.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetClientResponse>> GetClientByIdAsync(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            var getClientResponse = new GetClientResponse
            {
                Id = client.Id,
                Name = client.Name,
                Age = client.Age,
            };

            return Ok(getClientResponse);
        }
    }
}
