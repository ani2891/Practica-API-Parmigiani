namespace Practica_API_Parmigiani.Interfaz
{
    public class Camion : IVehiculos
    {
        public string Acelerar() 
        {
            return "el camion va rapido";
        }

        //aca se implementan todos los metodos, si o si, por eso van con return
        //no puedo crear metodos en la interfaz y no implementarlos, ese es el contrato

        public string Frenar ()
        {
            return "el camion freno";
        }
    }
}
