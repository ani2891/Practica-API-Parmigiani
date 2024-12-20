using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Interfaz_Animales; /*va a ir a la carpeta de interfaz animales a buscar*/

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazAnimalController : ControllerBase
    {
        [HttpGet]

        public string interfazAnimal()
        {
            Puercoespin puercoespin = new Puercoespin();
            puercoespin.Ataque();
            puercoespin.Nombre();

            Zorro zorro = new Zorro();
            zorro.Nombre();
            return zorro.Ataque();
        }

        [HttpGet]
        [Route("api/EjemploInterfazAnimalImplementacion")]
        public string EEjemploInterfazAnimalImplementacion()
        {
            IAnimales zorro = new Zorro();
            return zorro.ObtenerDistanciaRecorrida();
        }
    }
}
