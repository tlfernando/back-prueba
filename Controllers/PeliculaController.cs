using AutoMapper;
using BackPeliculas.Data.Peliculas;
using BackPeliculas.Dtos.PeliculaDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackPeliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaRepository _repository;
        private IMapper _mapper;

        public PeliculaController(
            IPeliculaRepository repository,
            IMapper mapper
        )
        {
            _mapper = mapper;
            _repository = repository;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeliculaResponseDto>>> GetPeliculas()
        {
            var peli = await _repository.GetAllPeliculas();
            return Ok(_mapper.Map<IEnumerable<PeliculaResponseDto>>(peli));
        }
    }
}
