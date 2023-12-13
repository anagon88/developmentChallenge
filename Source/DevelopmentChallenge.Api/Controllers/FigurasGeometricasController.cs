
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentChallenge.Api.Controllers
{
    public class FigurasGeometricasController : ControllerBase
    {
        private readonly IFormasGeometricasService _service;

        public FigurasGeometricasController(IFormasGeometricasService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Imprimir(List<FormaGeometrica> formas,int idioma)
        {
            _service.Imprimir(formas, idioma);

            return Ok(null);
        }
    }
}
