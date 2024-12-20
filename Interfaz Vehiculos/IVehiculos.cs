namespace Practica_API_Parmigiani.Interfaz
{
    public interface IVehiculos
    {
        public string Acelerar(); /*aca DEFINO todos los tipos de metodos que va a tener la interfaz*/
        public string Frenar();
        public string ObtenerDistanciaRecorrida()
        {
            return "el vehiculo recorrio 20km";
        }

    }
}
