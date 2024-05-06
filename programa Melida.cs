using melidatarea;
using System;
namespace SegundaTarea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear lista de empleados
            List<Empleado> listaEmpleados = new List<Empleado>()
        {
            new Empleado("Juan", 101, 30000),
            new Empleado("María", 102, 35000),
            new Empleado("Pedro", 103, 32000, false)
        };

            // Mostrar detalles de todos los empleados
            Console.WriteLine("Detalles de los empleados:");
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            // Cambiar estado del empleado con número 103
            int numeroEmpleadoCambiarEstado = 103;
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.CambiarEstado(true); // Activar empleado
                Console.WriteLine("\nDetalles del empleado actualizado:");
                empleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                Console.WriteLine($"\nEmpleado con número {numeroEmpleadoCambiarEstado} no encontrado.");
            }

            // Aumentar salario del empleado con número 103 en un 10%
            AumentarSalarioEmpleado(listaEmpleados, 103, 10);
        }

        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }
            }

            return null;
        }

        static void AumentarSalarioEmpleado(List<Empleado> listaEmpleados, int numeroEmpleado, int porcentajeAumento)
        {
            int indiceEmpleado = BuscarEmpleadoPorNumero(listaEmpleados, numeroEmpleado);

            if (indiceEmpleado != -1)
            {
                listaEmpleados[indiceEmpleado].CalcularNuevoSalario(porcentajeAumento);
                Console.WriteLine($"\nEl salario del empleado {listaEmpleados[indiceEmpleado].Nombre} ha sido aumentado en un {porcentajeAumento}%.");
            }
            else
            {
                Console.WriteLine($"\nEmpleado con número {numeroEmpleado} no encontrado.");
            }
        }
    }







}