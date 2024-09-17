
namespace Práctica_OOP_Polimorfismo.Base
{
    public abstract class Empleado
    {
       public  string Nombre;

        public Empleado(string Nombre) {
            this.Nombre = Nombre;
        }

        public abstract decimal CalculoDelSalarioMensual();


        public virtual string MostrarCargo()
        {
            return "Empleado";
        }

        public virtual string MostrarBono()
        {
            return "Bono";
        }

    }
}
