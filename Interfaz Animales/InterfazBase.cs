namespace Practica_API_Parmigiani.Interfaz_Animales
{
    public class InterfazBase
    {
        public string Ataque(IAnimales animal)
        {
            return animal.Ataque();

        }
    }
}
