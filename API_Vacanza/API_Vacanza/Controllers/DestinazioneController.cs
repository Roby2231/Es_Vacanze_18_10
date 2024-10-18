using API_Vacanza.Services;
using API_Vacanza.Controllers;
using Microsoft.AspNetCore.Mvc;
using API_Vacanza.Models;

namespace API_Vacanza.Controllers
{
    [ApiController]
    [Route("api/destinazione")]
    public class DestinazioneController : Controller
    {
        private readonly DestinazioneServices _service;

        public DestinazioneController(DestinazioneServices service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<IEnumerable<DestinazioneDTO>> ListaDestinazioni()
        {
            return Ok(_service.CercaTutti());
        }
    }
}
