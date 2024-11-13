namespace Practica_API_Parmigiani.Herencia_Animales
{
    //clase principal
    public class Animal
    {
        public string Tipo { get; set; }
        public string Region { get; set; }

        public Animal()
        {
            
        }

        public virtual string Alimentarse()
        {
            return "hora de cazar";
        }

        public virtual string Hibernar()
        {
            return "hora de dormir";
        }

    }

}
