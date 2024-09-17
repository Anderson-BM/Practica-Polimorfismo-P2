using Práctica_OOP_Polimorfismo.Base;

namespace Práctica_OOP_Polimorfismo.Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Empleado> empleados = new List<Empleado>
           {
           new DocentesPorHora("Anderson", 25),
           new DocenteContartoFijo("Francis", 25000, 700),
           new EmpleadoAdministrativo("Marcelo", 35000, 500)
           };

            Console.WriteLine("--------------------------- DATOS ----------------------------------------------\n\n\n");
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
               Console.WriteLine($" {empleado.MostrarCargo()}: {empleado.Nombre}, salario: {empleado.CalculoDelSalarioMensual()}, { empleado.MostrarBono()}");
                Console.WriteLine("---------------------------------------------------------------------------------");
            }

            Console.WriteLine("Precione Enter para salir");
            Console.ReadLine();

        }
    }
}
