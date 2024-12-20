namespace Practica_API_Parmigiani.Interfaz_Animales
{
    public interface IAnimales
    {
        public string Nombre();
        public string Ataque();
        public string ObtenerDistanciaRecorrida()
        {
            return "El animal corrió 5km";
        }

    }
}
