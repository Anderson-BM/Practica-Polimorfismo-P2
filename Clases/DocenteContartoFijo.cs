using Práctica_OOP_Polimorfismo.Base;

namespace Práctica_OOP_Polimorfismo.Clases
{
    public class DocenteContartoFijo : Empleado
    {
        public decimal Salario;
        public decimal Bonificaciones;

        public DocenteContartoFijo(string nombre, decimal salario, decimal bonificaciones) : base(nombre)
        {

            Salario = salario;
            Bonificaciones = bonificaciones;

        }

        public override decimal CalculoDelSalarioMensual()
        {
            return Salario + Bonificaciones;

        }
        public override string MostrarCargo()
        {
            return "Docente contrato Fijo";
        }
        public override string MostrarBono()
        {
            return "Bono Aplicado de: " + Bonificaciones;
        }
    }
}
