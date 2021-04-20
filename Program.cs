using System;
 
namespace DPRN2_U1_A2_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {     
            /*  Actividad 2   */
            Empleado empleado = new Empleado();
            Console.WriteLine("Ingresar el Salario Mensual: ");
            var salarioInput = Console.ReadLine();
            double sal= double.Parse(salarioInput);
            // decimal salario = Convert.ToDecimal(Console.ReadLine());
            var salarioMensual = sal;
            empleado.Salario = salarioMensual;
            var salarioconaumento = empleado.aumentarSalario(salarioMensual);
            var salarioconaumentoybono = empleado.aumentarSalario(salarioMensual, 0);
            var salarioAnual = empleado.salarioAnual(salarioMensual);
            var salarioAumentadoConBono = empleado.salarioAnual(salarioMensual, 7500.00);
            Console.WriteLine("El Salario Mensual es: " + empleado.Salario);
            Console.WriteLine("El Salario aumentó a " + salarioconaumento);
            Console.WriteLine("El Salario aumentó con bono a " + salarioconaumento);
            Console.WriteLine("El Salario anual es " + salarioAnual);
            Console.WriteLine("El Salario anual con bono es " + salarioAnual);


        }
    }
}
