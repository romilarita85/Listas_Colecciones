//Ejercicio 1
//Crea una clase Libro que tenga los siguientes atributos:
//Título(string).
//Género(string).
//Autor(string).
//Lista de editoriales(List<string>).
//Año de publicación (int).
//La clase debe cumplir con los siguientes requerimientos:
//Sobrecarga de Constructores: 
//Implementa tres constructores y aplica llamada de sobrecargas :
//privado, que inicialice la lista
//público, que reciba solo el título, autor  y el género.
//público, que reciba el título, el género, autor y el año de publicación.

//Sobrecarga de Operadores == y !=: Dos objetos de tipo Libro se considerarán iguales si tienen el mismo género y autor .
//Método AgregarEditorial: Permite agregar una editorial a la lista de editoriales.
//Método InfoString(): devuelve la información completa del libro.

//En el main: Crear 3 instancias de libros y dos q comparten los mismos datos
//libro1 con sobrecarga de 3
//libro2 con sobrecarga de los 4
//libro3 igual al libro2
//Usar el metodo AgregarEditorial y agregar 2 0 3 editoriales a cada uno de los libros

using BibliotecaLibro07_11;

namespace Clase07_11_Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear 3 instancias de libros y dos q comparten los mismos datos
            Libro libro1 = new Libro("1984", "ficcion", "Orwell");
            Libro libro2 = new Libro("El Principito", "ficcion", "Exupery", 1970);
            Libro libro3 = new Libro("El Principito", "ficcion", "Exupery", 1970);
            Libro libro4 = new Libro("El Principito", "ficcion", "Exupery", 1970,250);
            Libro libro5 = new Libro("El Principito", "ficcion", "Exupery", 1970,300);

            //Usar el metodo AgregarEditorial y agregar 2 0 3 editoriales a cada uno de los libros
            libro1.AgregarEditorial("Atlantida");
            libro1.AgregarEditorial("Porvenir");
            libro3.AgregarEditorial("Cielos");
            libro2.AgregarEditorial("Cielos");
            libro2.AgregarEditorial("Milliom");
            libro2.AgregarEditorial("Atlantida");
            //*Si uso console.WriteLine solo para mostrar la lista me va a mostrar datos propios de la lista
            //(tipo de objeto,tipo de tipado q esta usando) dentro del metodo InfoToString si quiero q se vea el contenido de la
            ////lista tengo q usar un foreach (interno)
           
            #region Usando metodo InfoToString()
            //Usando metodo InfoToString():
            Console.WriteLine(libro1.InfoString());
            Console.WriteLine("-------------------------");
            Console.WriteLine(libro2.InfoString());
            Console.WriteLine("-------------------------");
            Console.WriteLine(libro3.InfoString());
            Console.WriteLine("-------------------------");
            #endregion

            #region USANDO SOBRECARGA DE OPERADOR == !=:
            //SOBRECARGA DE OPERADOR == !=:
            //if (libro1 == libro2)
            //{
            //    Console.WriteLine("Libro1 y libro2 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Libro1 y libro2 NO son iguales");
            //}


            //if (libro1 == libro3)
            //{
            //    Console.WriteLine("Libro1 y libro3 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Libro1 y libro3 NO son iguales");
            //}


            //if (libro2 == libro3)
            //{
            //    Console.WriteLine("Libro2 y libro3 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Libro2 y libro3 NO son iguales");
            //}
            #endregion
            //***************************************************
            #region USANDO SOBRECARGA DE OPERADOR+:
            //SOBRECARGA DE OPERADOR+:

            //bool seAgrego = libro1 + "Atlantida"; // Libro1 ya tenia atlantida me va a decir q la editorial ya existia en el libro

            //if (seAgrego)
            //{
            //    Console.WriteLine("Se agrego correctamente la editorial");
            //}
            //else 
            //{
            //    Console.WriteLine("La editorial ya existia en el libro");
            //}

            //Agregando una editorial q no existe en el libro********
            //bool seAgrego = libro1 + "Million"; //se agrega a  la lista
            //if (seAgrego)
            //{
            //    Console.WriteLine("Se agrego correctamente la editorial");
            //}
            //else
            //{
            //    Console.WriteLine("La editorial ya existia en el libro");
            //}
            #endregion
            //****************************************************
            #region SOBRECARGA DE OPERADOR+: metodo q recibe dos libros

            //SOBRECARGA DE OPERADOR+: metodo q recibe dos libros

            //bool seAgrego = libro1 + "Million"; //se agrega a  la lista
            //double sumaPrecios = libro4 + libro5;

            //if (seAgrego)
            //{
            //    Console.WriteLine("Se agrego correctamente la editorial");
            //}
            //else
            //{
            //    Console.WriteLine("La editorial ya existia en el libro");
            //}
            //Console.WriteLine($"La suma de los precios de L1 y L2 es: {sumaPrecios} ");

            ////Si quiero saber si funciona o no la sobrecarga de operador + q agrega libro
            ////si no existe en la lista
            //Console.WriteLine(libro1.InfoString());

            //bool seAgrego2 = libro1 + "Million";
            //Console.WriteLine(libro1.InfoString());//-> no lo vuelve a agregar por q ya exite en la lista

            //bool seAgrego3 = libro1 + "otro";
            //Console.WriteLine(libro1.InfoString()); //se agrega por q no estaba en la lista

            //*se agrega siempre y cuando no exista dentro de la lista
            #endregion
            //************************************************************************
            #region CONVERSION EXPLICITA Y IMPLICITA:
            ////CONVERSION IMPLICITA:no le decis nada y implicitamente el leguaje hace la conversion
            ////el leguaje me permite convertir implicitamente un tipo de dato entero a uno flotante
            //float unFloat;
            //int unEntero = 45;
            //unFloat = unEntero; //Asigno el entero al flotante

            ////********************************************************************
            ////CONVERSION EXPLICITA: cuando ponemos el operador de conversion. Nos hacemos cargo de la conversion
            ////de la posible perdida de informacion
            //float unFloat1 = 85.32f; //me hago cargo q el punto 32(valor decimal) lo pierdo
            //int unEntero1;
            ////si quiero asignar el flotante a un entero (quiero convertir un flotante a un entero):
            ////unEntero1 = unFloat1;//no se puede convertir implicitamente el tipo float en int
            ////*TENEMOS QUE CASTEARLO:
            //unEntero1 = (int)unFloat1;
            #endregion
            //******************************************************************
            //SOBRECARGA DE OPERADOR IMPLICIT-EXPLICIT:

            //-SOBRECARGA DE OPERADOR IMPLICIT:************
            //*Para una clase podemos definir de q manera un objeto de esa clase se puede convertir
            //implicitamente y explicitamente en otra cosa->SOBRECARGANDO EL OPERADOR EXPLICIT/IMPLICIT DE LA CLASE

            //Agarramos uno de los libros y lo convertimo implicitamente-USANDO METODO SOBRECARGADO IMPLICIT
            //string dato = libro3; // convierto implicitamente algo del tipo libro a algo de tipo string
            //Console.WriteLine(dato);

            //-SOBRECARGA DE OPERADOR EXPLICIT:

            string dato = libro3; // convierto implicitamente algo del tipo libro a algo de tipo string
            //double precio = libro5;
                        //*No puedo convertir implicitamente un libro a un double tengo q castearlo si o si
            double precio = (double)libro5;
            Console.WriteLine(precio);

            double precio2 = (double)libro2;
            Console.WriteLine(precio);//devuelve 0 
            //Establecemos restriciones para nuestra clase
            //**************************************************************
            ////INSTANCIAR UN LIBRO -USANDO METODO IMPLICITO/CLASE SIN CONSTRUCTOR
            
            ////Instancio un nuevo objeto del tipo libro:
            
            //Libro libro1 = "Jose Perez";//Genero un nuevo libro:
            //Console.WriteLine(libro1.InfoString());//me va a mostrar toda la informacion
            ////-datos por default, el nombre del autor y la lista vacia por q no le cargue nada
            ////Me lo muestra por q esta instanciada
            ////Es una forma de sobrecargar de forma implicita uno de los metodos
            //*********************************************************

        }
    }
}
