using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melidatarea
{
   
        internal class Empleado
        {

            private string nombre;
            private int numeroEmpleado;
            private double salario;
            private bool activo;

            public Empleado(string nombre, int numeroEmpleado, double salario, bool activo = true)
            {
                this.nombre = nombre;
                this.numeroEmpleado = numeroEmpleado;
                this.salario = salario;
                this.activo = activo;
            }

            public string Nombre { get => nombre; }
            public int ObtenerNumeroEmpleado() => numeroEmpleado;
            public double ObtenerSalario() => salario;
            public bool EstaActivo() => activo;

            public void CambiarEstado(bool nuevoEstado)
            {
                this.activo = nuevoEstado;
            }

            public void CalcularNuevoSalario(int porcentajeAumento)
            {
                if (porcentajeAumento < 0 || porcentajeAumento > 100)
                {
                    throw new ArgumentException("El porcentaje de aumento debe estar entre 0 y 100.");
                }

                this.salario += (this.salario * porcentajeAumento) / 100;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Número de empleado: {numeroEmpleado}");
                Console.WriteLine($"Salario: {salario:C}");
                Console.WriteLine($"Estado: {(activo ? "Activo" : "Inactivo")}");
                Console.WriteLine("----------------------");
            }



        }
    }

