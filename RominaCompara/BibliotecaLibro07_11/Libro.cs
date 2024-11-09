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
using System.Text;

namespace BibliotecaLibro07_11
{
    public class Libro
    {
        string titulo;
        string genero;
        string autor;
        List<string> listaDeEditoriales; //si trabajo con una lista la tengo q inicializar en un constructor
        int anioDePublicacion;
        double precio;
        //Sobrecarga de Constructores: 
        //Implementa tres constructores y aplica llamada de sobrecargas :
        //privado, que inicialice la lista
        private Libro()//Es importante q el constructor q inicializa la lista sea llamado
        {
            listaDeEditoriales = new List<string>();
        }
        //público, que reciba solo el título, autor  y el género.
        public Libro(string titulo, string autor, string genero)
            :this()
        {
            this.titulo = titulo;
            this.genero = genero;
            this.autor = autor;
          
        }
        //público, que reciba el título, el género, autor y el año de publicación.
        public Libro(string titulo, string autor, string genero, int anioDePublicacion) 
            : this(titulo, autor, genero)
        {
            this.anioDePublicacion = anioDePublicacion;
        }
        //Podria tener un constructor q reciba la lista de datos: recibe la lista como parametro
        public Libro(string titulo, string autor, string genero, List<string> listaDeEditoriales, int anioDePublicacion) 
            : this(titulo,autor, genero,anioDePublicacion)
        {
            this.listaDeEditoriales = listaDeEditoriales;//le paso los valores q recibe por parametro
            
        }
        //*No estoy obligado a hacer la llamada de la sobrecarga de los constructores con el anterior
       //Puedo llamar a cualquier de los constructores q respete la cantidad de parametros q yo le voy a pasar
        public Libro(string titulo, string autor, string genero, int anioDePublicacion, double precio) 
            : this(titulo, autor, genero, anioDePublicacion)
        {
            this.precio = precio;
        }
        

        //REGLA: El constructor q tiene mas parametros siempre va a llamar al q tenga menos

        //****************************************************
        //Sobrecarga de Operadores == y !=: Dos objetos de tipo Libro se considerarán iguales si tienen el mismo género y autor .
        //Si o si tiene q ser estatico por q la comparacion tiene q ser propia de la clase
        //podria ser de instancia pero no estariamos dandole un nuevo comportamiento al == propio de la clase
        //si no estariamos haciendo un nuevo metodo para la instancia del objeto y no tiene sentido
        public static bool operator ==(Libro libro1, Libro libro2)
        {
            bool result = false;
            if (libro1.genero == libro2.genero && libro1.autor == libro2.autor)
            {
                result = true;
            }

            return result;
        }
       
        public static bool operator !=(Libro libro1, Libro libro2)
        {
            return !(libro1 == libro2);
        }
        //Método InfoString(): devuelve la información completa del libro.
        public string InfoString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El titulo es : {this.titulo}");
            sb.AppendLine($"El autor es : {this.autor}");
            sb.AppendLine($"El genero es : {this.genero}");
            sb.AppendLine($"El año de publicacion es  : {this.anioDePublicacion}");
            sb.AppendLine($"La lista de editoriales es: ");

            //Para ver los valores q estan dentro de mi lista uso foreach(para ver el contenido))
            foreach (string item in listaDeEditoriales)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }

        //Método AgregarEditorial: Permite agregar una editorial a la lista de editoriales.
        public void AgregarEditorial(string editorial)//cuando recibiamos un string lo agregamos a la lista
        {
            listaDeEditoriales.Add(editorial);
        }
        //SOBRECARGAR OPERADOR+ :
        //Cuando utilicemos el + y recibamos algo del tipo Libro y un string me lo agregue a la lista
        
        //public static [tipo de dato] operator [operador] (sobrecarga s,[tipo de dato x]){}
        public static bool operator +(Libro l, string editorial) 
        {
            bool existe = false;//

            foreach (string item in l.listaDeEditoriales)
            {
                if (item == editorial)
                {//si la editorial q le estoy pasando ya existe en mi lista d editoriales
                 //no agrego el dato
                    existe = true;//si encontro la editorial deja de buscar
                }
            }
            //Si no lo encontro:si no existe(la editorial) lo agrega
            if (existe == false)
            {
                l.listaDeEditoriales.Add(editorial);//agregamos el dato(editorial) q recibo por parametro a la lista
            }

            return !existe;

        }
        //SOBRECARGA operador+ : metodo q reciba dos libros
        public static double operator +(Libro l1, Libro l2) 
        { //Toma el valor del precio del l1 y el valor de precio del l2 y me va a retornar esa suma
            double suma = l1.precio + l2.precio;
            return suma;
        }
        //******************************************************************
        //SOBRECARGA DE OPERADOR IMPLICIT-EXPLICIT:
        
        //*SOBRECARGA DE OPERADOR IMPLICIT:****
        //Cuando convierto implicitamente un libro a un string obtenemos el autor
        //public static implicit operator string(Libro libro) 
        //{//al momento de convertir un libro a algo el operador puede devolver el autor
        //    string ret = "";

        //    ret = libro.autor;
        //    return ret;
        //}
        //Podriamos concatenar el nombre y el autor:
        public static implicit operator string(Libro libro)
        {//al momento de convertir un libro a algo el operador puede devolver el autor
            string ret = "";

            ret = $"Autor:{libro.autor} - Genero: {libro.genero}";
            return ret;
        }

        //*SOBRECARGA DE OPERADOR EXPLICIT:*****
        public static implicit operator double(Libro libro) 
        {
            return libro.precio;
        }
        //************************************************************
        //Ejemplo: Se puede hacer q dentro de cada operador enmascare la instancia de una clase:
        //la clase no tenga los constructores como tal (clase sin constructores) y q esten escondidos dentro de los 
        //dentro de cada operador enmarcaraba la instancia de una nueva clase
       
        //Sobrecargamos metodo implicito-donde recibo un string y con ese string devuelvo un libro
        //es la unica forma q tengo de instanciar libros
        //public static implicit operator Libro(string autor) 
        //{                                   //recibimos un string
        //    Libro l = new Libro();//-el metodo crea una instancia con el constructor vacio(por defecto)
        //   //Como estoy dentro de la clase puedo acceder a sus atributos que son privados(por ejemplo al autor, a la lista etc)
        //    l.autor = autor;//le doy un valor
        //    l.listaDeEditoriales = new List<string>();//instanciamos la lista

        //    return l;//retorno el libro q acabo de crear
        //}
        //****************************************************************
        //Si quiero hacer mas privado o encapsulado: puedo dejar el constructor privado declarado
        //Y la unica forma de instanciar el libro va a ser dentro de la clase
        //public static implicit operator Libro(string autor)
        //{                                   //recibimos un string
        //    Libro l = new Libro();//-el metodo crea una instancia con el constructor vacio(por defecto)
        //                          //Como estoy dentro de la clase puedo acceder a sus atributos que son privados(por ejemplo al autor, a la lista etc)
        //    l.autor = autor;//le doy un valor

        //    return l;//retorno el libro q acabo de crear
        //}

    }
}


