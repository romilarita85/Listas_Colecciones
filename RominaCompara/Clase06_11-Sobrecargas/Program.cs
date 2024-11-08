using BibliotecaPersonas06_11;

namespace Clase06_11_Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SOBRECARGAS:
            //Posibilidad de usar distintos comportamientos de nuestros metodos

            #region SOBRECARGA DE CONSTRUCTORES
            //SOBRECARGA DE CONSTRUCTORES:(Hacer un constructor con distintas cantidades de parametros-se hace con llamadas de sobrecargas)
            //Creamos en clase persona varias versiones de como construir una persona.
            //Distintas formas de crear un objeto
            //Cuando vamos al main a crear una persona podemos usar mas de uns constructor(sobrecargas-overloads)

            //*Al instanciar una persona con el constructor vacio si quiero ver cuantos elementos tiene la lista
            //Persona persona1 = new Persona();

            //Console.WriteLine(persona1.Discos.Count);si la lista esta inicializada me va a devolver cero por consola
            //si no esta instanciada me devuelve null o error por consola
            //******************************
            //Persona persona1 = new Persona("Jose","4544545454");
            //Console.WriteLine(persona1.Discos.Count);
            //***********************************
            ////*Si llamo a un constructor donde no hice el llamado del constructor vacio ni la sobrecarga

            //Persona persona1 = new Persona("Jose",40, "4544545454");
            //Console.WriteLine(persona1.Discos.Count);
            ////No hay una referencia real del objeto - me tira error 
            ////*En ningun momento estoy inicializando la lista y tampoco hago el llamado al constructor anterior
            ////q si la inicializa

            //********************************
            #endregion
            //*********************************************
            #region SOBRECARGA DE METODOS
            //SOBRECARGA DE METODOS: Distintas forma de usar un metodo.
            ////En el main ->Solo voy a ver la llamada de un metodo con el mismo nombre
            //Persona persona1 = new Persona("Jose","Bs AS",40, "4544545454");

            //persona1.AgregarDinero(250);//sobrecarga del segundo metodo metodo
            //Console.WriteLine(persona1.Dinero);

            //Console.WriteLine("******************************");
            //persona1.AgregarDinero(250.0);//sobrecarga del primer metodo metodo
            //Console.WriteLine(persona1.Dinero);

            //Console.WriteLine("******************************");
            //persona1.AgregarDinero(250.0,10);//sobrecarga del tercer metodo metodo
            //Console.WriteLine(persona1.Dinero);
            //*****************************************
            #endregion


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
