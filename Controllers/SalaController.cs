using AutoMapper;
using BackPeliculas.Data.Salas;
using BackPeliculas.Dtos.SalaDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackSalas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalaRepository _repository;
        private IMapper _mapper;

        public SalaController(
            ISalaRepository repository,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _repository = repository;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalaResponseDto>>> GetSalas()
        {
            var peli = await _repository.GetAllSalas();
            return Ok(_mapper.Map<IEnumerable<SalaResponseDto>>(peli));
        }
    }
}
