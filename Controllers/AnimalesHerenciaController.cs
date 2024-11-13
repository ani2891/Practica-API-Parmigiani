using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Herencia_Animales; /*Corroborar que este siempre en la carpeta correcta*/

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalesHerenciaController : ControllerBase
    {
        [HttpGet]

        public string GetAnimal()
        {

            Aguila aguila = new Aguila();
            aguila.Region = "america";
            aguila.Tipo = "ave";
            aguila.Hibernar();
            aguila.Plumas = "marrones";

            Leon leon = new Leon();
            leon.Alimentarse();
            leon.Tipo = "felino";
            leon.Region = "africa";
            leon.Dientes = "filosos";

            return leon.Alimentarse();
            
   

        }
    }
}
