namespace Practica_API_Parmigiani.Herencia
{
    //sub clase AUTO
    public class Auto : Vehiculo
    {
        public string NroChasis { get; set; }

        public override string Acelerar()
        {
            return "el auto acelero";
        }

        public override string Frenar()
        {
            return "el auto freno";

        }







    }

}
