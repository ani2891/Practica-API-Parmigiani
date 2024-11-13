namespace Practica_API_Parmigiani.Herencia_Animales
{
    public class Aguila : Animal
    {
        public string Plumas { get; set; }

        public override string Alimentarse() /*el override sobreescribe el metodo virtual de la clase principal animal*/
        {
            return "hora de cazar para el aguila";
        }

        public override string Hibernar()
        {
            return "hora de dormir para el aguila";
        }



    }
}
