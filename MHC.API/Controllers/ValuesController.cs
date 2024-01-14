using MHC.Infrastructure.Entities;
using MHC.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MHC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGenericRepository<Treatment> _repository;
        public ValuesController(IGenericRepository<Treatment> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var t = await _repository.GetAllAsync();
            return Ok(t);
        }
    }
}
