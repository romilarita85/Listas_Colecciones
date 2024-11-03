//Listas

//crear la clase persona, con los siguientes atributos: nombre(string), ciudad(string), edad(entero) y dni(string). 
//crear un constructor parametrizado y propiedades de lectura/escritura para cada atributo. 
//crear el método de instancia mostrarpersona, que retorna un string creado a partir de un objeto
//de la clase stringbuilder con los datos de la instancia. 
//en el main, crear 5 personas y agregarlas a una lista. 
//en la clase persona crear un método estático que reciba una lista de personas,
//y permita mostrar cada una de las instancias de la lista.
using BibliotecaPersonas31_10;

namespace Clase31_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region USO DE PROPERTIES-INVOCACION 
            //Persona p1 = new Persona();
            //string n;
            //n = p1.Nombre; //Leo el valor-(similar a un get)obtengo el valor del objeto intanciado en p1

            //p1.Nombre = "algo";//Asigno un valor.similar a un set-> Donde el string "algo" representa el VALUE
            //****************************************************

            ////*Entra en ejecucion lo q tengo programado dentro del metodo "AsignarNombre" una vez q invoque el metodo.
            ////recien ahi se ingresa la palabra "mandarina".
            //Persona p0 = new Persona("bs as", 34, "45121212");
            //p0.AsignarNombre();

            //Console.WriteLine(p0.Nombre);

            //Lo mismo pasa en las properties, para q entren en accion debo invocarlas
            #endregion
            Persona p1 = new Persona("Jose","Bs As", 22, "64654564");
            Persona p2 = new Persona("Lorena", "Quilmes", 22, "45656564");
            Persona p3 = new Persona("Pedro", "Lomas", 22, "34556666");
            Persona p4 = new Persona("Micaela", "Lomas", 22, "35913898");
            Persona p5 = new Persona("Marcela", "Parque Avellaneda", 22, "6567564");
            Persona p6 = new Persona("Aurelio", "Constitucion", 22, "41114564");

            #region AGREGAR PERSONAS A LA LISTA/ADD/COUNT
            ////°Si quiero agregar las personas a una lista(una a una):
            ////Debo crear una lista -> declararla y instanciarla
            //List<Persona> personas = new List<Persona>();
            ////Nombre de la lista tiene q ser plural: "personas"

            //ADD-AGREGAR ELEMENTOS A MI LISTA/ COUNT
            ////METODO ADD: Asigno valores adento de mi lista: 
            ///Agrego todas las personas adentro de mi lista
            ///No necesariamente tieneN q estar en orden.

            ////personas.Add(p2);
            ////personas.Add(p3);
            ////personas.Add(p4);
            ////personas.Add(p5);
            ////personas.Add(p6);

            ////Count: es dinamico en base a la cantidad de elementos q voy agregando a la lista
            ////Los valores q va a tener count van aumentando a medida q voy interactuando con mi lista

            //Console.WriteLine(personas.Count);
            //personas.Add(p1);
            //personas.Add(p2);
            //Console.WriteLine(personas.Count);
            //personas.Add(p3);
            //personas.Add(p4);
            //personas.Add(p5);
            //Console.WriteLine(personas.Count);
            //personas.Add(p6);
            //Console.WriteLine(personas.Count);

            #endregion
            #region AGREGAR TODAS LAS PERSONAS JUNTAS A MI COLECCION
            ////°Si quiero agregar todas las personas juntas a mi coleccion.

            //List<Persona> personas = new List<Persona>() {p1,p2,p3,p4,p5,p6 };
            ////Abro llaves al lado del constructor y voy agregando los elementos (p1,p2 ,p3 etc)       
            ////similar a vectores.
            //Persona.MostrarPersonas(personas);
            #endregion
            #region AGREGAR NUMEROS ENTEROS/REMOVE 
            ////Si quiero agregar numeros enteros:
            //List<int> numeros = new List<int>() {45,85,22,12,45,89,12,0 };

            //Console.WriteLine("Lista original de numeros: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}

            ////Remove: Si quiero eliminar un elemento de la lista.
            //numeros.Remove(22); //Le digo q elimine el numero 22

            //Console.WriteLine("Lista de numeros eliminando el numero 22: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}
            ////Si tuviera q eliminar el 45 y hay dos 45 me elimina el primero por q
            ////donde se cumple con la condicion tiene un break internamente y deja
            ////de buscarlo.
            #endregion
            #region USO REMOVEALL

            //List<int> numeros = new List<int>() { 45, 85, 22, 12, 45, 89, 12, 0 };

            //Console.WriteLine("Lista original de numeros: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}

            ////RemoveAll: 
            //numeros.RemoveAll(numeros=> numeros == 45);

            //Console.WriteLine("Lista de numeros eliminando el numero 22: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}
            ////Los numeros se pasan por valor.Por ende con Remove se elimina por valor.
            ////Estoy modificando la lista.
            ////-Si elimino elementos q estan harcodeados dentro de la lista los pierdo 
            ////dejan de existir
            ////-Si elimino elementos q estan instanciados. Por mas q los elimine de la lista siguen existiendo.
            ////Solo lo saco de la coleccion. Se modifica el tamaño de la coleccion (lista).
            #endregion
            #region METODO FIND
            ////Find: Encuentra un valor determinado
            //List<int> numeros = new List<int>() { 45, 85, 22, 12, 45, 89, 12, 0 };
            //int numeroBuscado;
            ////Lo q esta dentro de mi lista "numeros" encontralo y devolvelo.
            //numeroBuscado = numeros.Find(numero => numero == 89);
            //                                    //condicion
            //Console.WriteLine(numeroBuscado);
            ////predicate: hace referencia a un metodo q evalua una condicion(igual q un if)
            ////internamente recorre todo lo q esta dentro de mi coleccion

            ////Si quiero q encuentre numero mayor q 43: me devuelve el primero q encuentra el 45.
            //numeroBuscado = numeros.Find(numero => numero > 43);
            //Console.WriteLine(numeroBuscado);
            #endregion
            #region USANDO METODO REMOVE Y FIND
            ////quiero q me elimine el ultimo elemento
            //List<int> numeros = new List<int>() { 45, 85, 22, 12, 45, 89, 12, 0 };

            //Console.WriteLine("Lista original de numeros: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}

            //numeros.Remove(numeros.Find(numero => numero == 0));
            //                         //resultado q sale de un metodo find
            //Console.WriteLine("Lista de numeros eliminando - el retorno de find : ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region METODO REMOVEALL Y FIND ALL
            ////Si quiero eliminar todos
            //List<int> numeros = new List<int>() { 45, 85, 22, 12, 45, 89, 12, 0 };

            //Console.WriteLine("Lista original de numeros: ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}

            //numeros.RemoveAll(numero => numero == numeros.Find(numero => numero > 70));
            //                                                  //resultado q sale de un metodo find
            //Console.WriteLine("Lista de numeros eliminando - el retorno de find : ");

            //foreach (int n in numeros)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            //***************************************************************************
            ////Si quiero eliminar la persona 1 de la lista:****************************

            //List<Persona> personas = new List<Persona>() { p1, p2, p3, p4, p5, p6 };

            //Console.WriteLine("*********Lista original********** ");
            //Persona.MostrarPersonas(personas);

            //personas.Remove(p1);
            //Console.WriteLine("*********Lista eliminando P1*********");
            //Persona.MostrarPersonas(personas);

            //*************************************************************************
            #region REMOVE:POSICIONES DE MEMORIA POR REFERENCIA
            ////REMOVE-> borra por posiciones de memoria por referencia.*******************
            //List<Persona> personas = new List<Persona>() { p1, p2, p3, p4, p5, p6 };
            //Persona p7 = p1;//-> Comparten la misma direccion de memoria
            ////Cuanno cree p7 le asigne la misma direccion de memoria q p1.(p7 no esta instanciado)
            //personas.Add(p7);

            //p7.Nombre = "Pinocho"; // Se modifica p1 y p7, no solo p7
            //Console.WriteLine("*********Lista original********** ");
            //Persona.MostrarPersonas(personas);

            //personas.Remove(p7);//se elimino p1 (no p7) -> p7 es una referencia a p1
            //Console.WriteLine("*********Lista eliminando P7*********");
            //Persona.MostrarPersonas(personas);
            //p1.Nombre = "Miquel"; // cambia nombre en p1 y p7
            #endregion
            //************************************************************************
            ////*Si quiero q p7 sea una nueva instancia con los mismos valores de p1:
            ////le voy psando campo a campo los mismos valores
            ////new: define una nueva asignacion de memoria para esa construccion

            //List<Persona> personas = new List<Persona>() { p1, p2, p3, p4, p5, p6 };
            //Persona p7 = new Persona(p1.Nombre,p1.Ciudad,p1.Edad,p1.Dni);//objeto melliso
            //personas.Add(p7);

            //p1.Nombre = "Pinocho";

            //Console.WriteLine("Lista original de numeros: ");
            //Persona.MostrarPersonas(personas);
            //personas.Remove(p7);

            //Console.WriteLine("Lista de numeros eliminando - el retorno de find : ");
            //Persona.MostrarPersonas(personas);

            //**************************************************************************
            #region USANDO METODO CON REMOVE ENCAPSULADO
            ////Remove-> en los numeros elimina por valor y en los objetos elimina por referencia

            ////PUEDO MODIFICAR Q EN VEZ DE POR REFERENCIA ELIMINE POR VALOR: Creando un metodo estatico 
            ////en biblioteca de clases.

            //List<Persona> personas = new List<Persona>() { p1, p2, p3, p4, p5, p6 };

            //Console.WriteLine("Lista original********* ");
            //Persona.MostrarPersonas(personas);
            //Persona.EliminarPersona(personas, p6);

            //Console.WriteLine("Lista de numero eliminando p6 con metodo");
            //Persona.MostrarPersonas(personas);
            #endregion
            //**************************************************************************
            #region METODO REMOVE ENCAPSULADO/ELEMENTO QUE NO ESTA EN LA LISTA
            ////Si creo una nueva persona q no esta en la lista:

            //List<Persona> personas = new List<Persona>() { p1, p2, p3, p4, p5, p6 };
            //Persona personaX = new Persona("Jose", "Bs As", 22, "64654564");
            ////a personaX le paso los mismos valores q p1 y no la agrego a la lista
            //Console.WriteLine("Lista original********* ");
            //Persona.MostrarPersonas(personas);

            //if (Persona.EliminarPersona(personas, personaX))// elimina a jose (p1)
            //{
            //    Console.WriteLine("Persona encontrada y eliminada");
            //}
            //else
            //{
            //    Console.WriteLine("Persona no encontrada");
            //}
            ////El metodo elimina a la persona q encuentra con los valores de coincidencia
            ////q encuentra de la persona q yo le pase por parametro

            //Console.WriteLine("Lista con personaX eliminada usando metodo");
            //Persona.MostrarPersonas(personas);
            #endregion
            //*********************
            List<int> num = new List<int>() {13,15,22,87,90,91}; 
            num.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("*******************************");
            //Elimina numeros pares usando RemoveAll
            num.RemoveAll(numero => numero%2 == 0);

            
            num.ForEach(x => Console.WriteLine(x));






           




        }

    }
}
