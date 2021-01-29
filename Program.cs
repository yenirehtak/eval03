using System;
using Personas;
namespace eval03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dia de nacimiento en numero ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de nacimiento en numero ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Persona obPersona = new Persona (nombre, dia, mes);
            string cadena1 = obPersona.Nombre + ", nacido(a) el " + obPersona.NDia + "/" + obPersona.NMes;
            Console.WriteLine("Imprimiendo información... ");
            Console.Write(cadena1);
        }
    }
}
