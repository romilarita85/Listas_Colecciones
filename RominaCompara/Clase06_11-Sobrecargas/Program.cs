namespace Clase06_11_Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Juan", "CABA", 25, "33333333");
            Persona p2 = new Persona("Maria", "CABA", 25, "33333333");
            Persona p3 = new Persona("Luis", "Lanus", 28, "444444444");
            Persona p4 = new Persona("Carlos", "CABA", 30, "55555555");

            double dinero = p1.AgregarDinero(50000);
            p2.AgregarDinero(35528.99);
            p3.AgregarDinero(10000, 80);
            p4.AgregarDinero(5000);

            if (p1 != p2)
            {
                Console.WriteLine("Son distintos");
            }
            else
            {
                Console.WriteLine("Son iguales");
            }
            Console.WriteLine("pepe" + "luis");
            //List<Persona> miLista = new List<Persona>();
            //miLista.Add(p1);
            //miLista.Add(p2);
            //miLista.Add(p3);
            //miLista.Add(p4);

            //Persona.MostrarPersonas(miLista);

            double total;
            total = p1 + p2;

            Console.WriteLine(total);

            double cantidad;
            cantidad = p3 + 500;
            Console.WriteLine(cantidad);




        }
    }
}
