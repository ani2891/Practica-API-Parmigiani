namespace Practica_API_Parmigiani.Herencia
{
    public class Vehiculo /*clase principal, es publica asi que puede ser accedida desde cualquier parte del codigo*/
    {
        public string Marca { get; set; } /*propiedades publicas que le vamos a agregar al objeto*/
        public string Modelo { get; set; }

        public Vehiculo()
        {

        }
        public virtual string Acelerar() /*metodo de tipo string que en el return va a mostrar ese mensaje*/
        {
            return "el vehiculo acelero"; /*los metodos que NO son de tipo void, siempre tienen return*/
        }

        public virtual string Frenar() /*virtual significa que el metodo se puede sobreescribir*/
        {
            return "el vehiculo freno";

        }
    }

}