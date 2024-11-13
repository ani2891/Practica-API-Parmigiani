namespace Practica_API_Parmigiani.Herencia_Animales
{
    public class Leon : Animal
    {
        public string Dientes { get; set; }

        public override string Alimentarse()
        {
            return "hora de cazar para el leon";
        }

        public override string Hibernar()
        {
            return "hora de dormir para el leon";
        }


    }
}
