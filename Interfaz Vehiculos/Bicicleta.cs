namespace Practica_API_Parmigiani.Interfaz
{
    public class Bicicleta : IVehiculos /*la bicicleta implementa la interfaz vehiculos*/
    {
        public string Acelerar()
        {
            return "la bici va rapido";
        }

        public string Frenar()
        {
            return "la bici freno";
        }



    }
}
