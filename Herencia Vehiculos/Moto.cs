namespace Practica_API_Parmigiani.Herencia
{
    //sub clase MOTO
    public class Moto : Vehiculo /*hereda propiedades de la super clase vehiculo*/
    {
        public string TipoMoto { get; set; }  /*a su vez, tiene esta caracteristica particular que le asignamos*/

        public override string Acelerar()
        {
            return "la moto acelero";
        }

        public override string Frenar()
        {
            return "la moto freno";

        }






    }
}
