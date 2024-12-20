namespace Practica_API_Parmigiani.Ejemplo_clase_abstracta
{
    public abstract class Animal2
    {
        public Animal2()
        {
        }
        public abstract string Comer();
        public string ObtenerDistanciaRecorrida()
        {
            return "El animal corrió 5km";
        }
    }
}
