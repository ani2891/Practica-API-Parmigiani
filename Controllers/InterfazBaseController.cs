using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Interfaz_Animales;

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazBaseController : ControllerBase
    {
        [HttpGet]

        public string interfazAnimalDos()
        {
            InterfazBase interfazBase = new InterfazBase(); /*creo una instancia de mi clase interfaz BASE*/

            Zorro zorro = new Zorro();
            
            return interfazBase.Ataque(zorro); /*le digo a la interfaz que me retorne ese metodo con ese objeto nuevo, zorro*/

           

        }
    }
}
