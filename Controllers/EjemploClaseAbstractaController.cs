using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Ejemplo_clase_abstracta;

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploClaseAbstractaController : ControllerBase
    {
        [HttpGet]
        public string EjemploClaseAbstracta()
        {
            //Auto2 auto2 = new Auto2();
            //return auto2.ObtenerDistanciaRecorrida();

            //Moto2 moto2 = new Moto2();
            //return moto2.ObtenerDistanciaRecorrida();

            //Lobo lobo = new Lobo();
            //return lobo.Comer();

            Tigre tigre = new Tigre();
            return tigre.Comer();
        }

    }
}
