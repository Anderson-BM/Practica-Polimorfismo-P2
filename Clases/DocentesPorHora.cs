using Práctica_OOP_Polimorfismo.Base;

namespace Práctica_OOP_Polimorfismo.Clases
{
    public class DocentesPorHora : Empleado
    {

        private int DocenteHora = 800;
        public int Hora;

        public DocentesPorHora(string nombre, int hora) : base(nombre)
        {
            Hora = hora;
        }

        public override decimal CalculoDelSalarioMensual()
        {
            return Hora * DocenteHora;
        }

        public override string MostrarCargo()
        {
            return "Docente Por Hora";
        }

        public override string MostrarBono()
        {
            return "Bono no Aplicado";
        }


    }
}
