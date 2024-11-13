using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Interfaz;

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazVehiculoController : ControllerBase
    {
        [HttpGet]

        public string InterfazVehiculos()
        {
            Bicicleta bicicleta = new Bicicleta();
            Camion camion = new Camion();

            bicicleta.Frenar();

            camion.Acelerar();
            return camion.Frenar();

        }
    }
}
