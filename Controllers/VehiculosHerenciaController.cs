using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica_API_Parmigiani.Herencia;

namespace Practica_API_Parmigiani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosHerenciaController : ControllerBase
    {
        [HttpGet]
        //el método específico debe ejecutarse en respuesta a solicitudes HTTP GET test

        public string GetVehiculo()
        {
            //Vehiculo vehiculo = new Vehiculo();
            //Vehiculo es la clase, el segundo vehiculo es la variable que estamos creando
            //new vehiculo esta creando un nuevo objeto, instanciando la clase, y se lo asigna a esa variable

            Moto moto = new Moto();

            moto.Marca = "yamaha"; /*Asignamos valores a las propiedades del objeto que instanciamos*/
            moto.Modelo = "r3"; /* puedo acceder a estas propiedades, marca y modelo, porque puse que sean public*/
            moto.Acelerar(); /*el metodo que hicimos en la super clase vehiculo*/
            moto.TipoMoto = "sport"; /*la propiedad que pusimos en la clase moto*/

            return moto.Acelerar(); /*cuando se ejecuta el RETURN el programa se detiene, por eso no puedo poner mas de uno*/
           

        }
    
    
    }
}
