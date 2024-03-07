using AutoMapper;
using BackEntradas.Data.Entradas;
using BackPeliculas.Dtos.EntradaDtos;
using BackPeliculas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackPeliculas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaRepository _repository;
        private readonly IMapper _mapper;

        public EntradaController(IEntradaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<EntradaResponseDto>> CreateEntrada([FromBody] EntradaRequestDto entradaDto)
        {
            try
            {
                var entrada = _mapper.Map<Entrada>(entradaDto);

                await _repository.CreateEntradaAsync(entrada);

                if (await _repository.SaveChangesAsync())
                {
                    var entradaResponseDto = _mapper.Map<EntradaResponseDto>(entrada);
                    return Ok(entradaResponseDto);
                }
                else
                {
                    return StatusCode(500, "No se pudo guardar la entrada en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrió un error al crear la entrada: {ex.Message}");
            }
        }
    }
}
