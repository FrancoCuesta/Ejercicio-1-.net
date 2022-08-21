// See https://aka.ms/new-console-template for more information
using shared;
using System.Collections;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi Primera App");
        List<Persona> list = new List<Persona>();
        do
        {
            try
            {
                Console.WriteLine("Nueva Persona");
                Persona p = new Persona();
                Console.WriteLine("Nombre: ");
                p.Nombre = Console.ReadLine();
                Console.WriteLine("Documento: ");
                p.Documento = Console.ReadLine();
                Console.WriteLine("Fecha Nacimiento: ");
                DateTime thisDate1 = Convert.ToDateTime(Console.ReadLine());
                p.SetFechaNacimiento(thisDate1);
                Console.WriteLine("Persona");
                Console.WriteLine("Documento: " + p.Documento);
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Fnacimiento: " + p.GetFechaNacimiento());
                list.Add(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex.Message);
            }
        } while (!Console.ReadLine().Equals("EXIT"));
        Console.WriteLine("Personas");
        Persona[] list2 = list.ToList().OrderBy(x => x.GetFechaNacimiento()).ToArray();
        list2.ToList().ForEach(x => Console.WriteLine(x.Mostrar()));
        Console.ReadLine();
    }
}