//crear la clase persona, con los siguientes atributos: nombre(string), ciudad(string), edad(entero) y dni(string). 
//crear un constructor parametrizado y propiedades de lectura/escritura para cada atributo. 
//crear el método de instancia mostrarpersona, que retorna un string creado a partir de un objeto
//de la clase stringbuilder con los datos de la instancia. 
//en el main, crear 5 personas y agregarlas a una lista. 
//en la clase persona crear un método estático que reciba una lista de personas,
//y permita mostrar cada una de las instancias de la lista.
using System.ComponentModel;
using System.Text;

namespace BibliotecaPersonas31_10
{
    public class Persona
    {//crear la clase persona, con los siguientes atributos:
     //nombre(string), ciudad(string), edad(entero) y dni(string).
        string nombre;
        string ciudad;
        int edad;
        string dni;
        public Persona() 
        { 
        }
        //crear un constructor parametrizado y propiedades de lectura/escritura para cada atributo. 
        public Persona(string nombre, string ciudad, int edad, string dni)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.edad = edad;
            this.dni = dni;
        }
        //El constructor por parametro puede recibir cualquier cosa:
        // por ejemplo: algo de tipo persona, un StringBuilder.
        //Puedo recibir una lista por los parametros del constructor
        public Persona( string ciudad, int edad, string dni,Persona persona,StringBuilder sb)
        {
           
            this.ciudad = ciudad;
            this.edad = edad;
            this.dni = dni;
        }

        //public void AsignarNombre()
        //{
        //    this.nombre = "mandarina";
        //}

        //PROPERTIES:
        //Las properties pueden ser autocontenidas y no representar un atributo como tal

        //*Nombre de la propertie siempre es el nombre del atributo q estoy trabajando y va en mayuscula

        //*No recibimos un valor pero internamente sabe q vamos a trabajar con un valor -> VALUE
        //palabra reservada q tienen las properties para hacer referencia al valor q van a estar recibiendo

        //El valor q reciba (Nombre) cuando use la propertie la tengo q asignar al atributo
        //q quiero modificar (this.nombre = value)
        //Solo las properties pueden trabajar con la palabra "value".
        public string Nombre//Las properties van con mayucula
        {
            set //se encarga de dar un valor al atributo q representa
            { 
                this.nombre = value; 
            }
            get//siempre retorna valor del atributo
            {
                return this.nombre;
                     //this.nombre del atributo 
            }
        }
        public string Ciudad 
        {
            set 
            {
                this.ciudad = value;
            }
            get 
            {
                return this.ciudad;
            }
        }
        public int Edad 
        {
            set 
            {
                this.edad = value;  
            }
            get 
            {
                return this.edad;
            }
        }
        public string Dni 
        {
            set 
            {
                this.dni = value;
            }
            get 
            {
                return this.dni;
            }
        }

        //Crear el método de instancia mostrarpersona, que retorna un string creado a partir de un objeto
        //de la clase stringbuilder con los datos de la instancia. 
        public string MostrarPersona()
        { //nombre(string), ciudad(string), edad(entero) y dni(string).
            StringBuilder sb = new StringBuilder();//Nueva instancia de la clase stringBuilder
            sb.AppendLine($"Nombre:{this.nombre} - Dni:{this.dni}");
            sb.AppendLine($"Ciudad:{this.ciudad}");
            sb.AppendLine($"Edad:{this.edad}");

            //StringBuilder: Va armando un conjunto de texto y despues me lo devuelve como un unico string 
            sb.AppendLine("--------------------------------------");
            return sb.ToString();
            //Si tengo q retornar el objeto sb del tipo StringBuilder. No puedo retornar el objeto como tal
            //->tengo q usar el metodo ToString()
            //sb: no es un string. Es un objeto del tipo StringBuilder
        }

        //En la clase persona crear un método estático que reciba una lista de personas,
        //y permita mostrar cada una de las instancias de la lista.
        public static void MostrarPersonas(List<Persona>lista) 
        {                                //tipo de dato:Lista de tipo persona

            ////Puedo recorrer la lista con cualquier bucle repetitivo(while,for,foreach etc)
            ////*Si solo voy a recorrer la lista lo mas aconsejable es un foreach
            //1-Usando foreach:
            //foreach (Persona p in lista)//recorre cada uno de los elementos de la lista
            //{//p: representa cada persona q vaya sacando de la lista en cada iteracion
            //    Console.WriteLine(p.MostrarPersona());
            //}

            //2-Usando For:
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i].MostrarPersona());
            //    //Si quiero acceder a un elemento de la lista uso corchetes y similar a un vector
            //    //*Todas las colecciones estan indexadas. El indice es el numero de posicion
            //    //q esta ocupando el elemento en ese momento
            //    //****************************************************
            //    //lista[i]. ->accedo a lo q halla en la posicion de mi lista.Lo trabajo como un elemento
            //    //lista. -> Controlo la lista como tal.Accedo a todos los metodos de la lista.
            //}

            //3-Usando ForEach:
            lista.ForEach(persona => Console.WriteLine(persona.MostrarPersona()));
        
        
        }
        //METODO (para q el metodo Remove elimine por valor)
        //encapsulo el metodo Remove***************

        //public static bool EliminarPersona(List<Persona>lista, Persona p) 
        //{
        //    int index = -1;//inicializo el indice en -1(posicion invalida de un indice-index-)
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        //elimino por un valor q estoy buscando
        //        if (lista[i].Nombre == p.nombre && lista[i].Dni == p.dni)//Criterio para identificar q dos personas son iguales
        //        {
        //            index = i;
        //            break;
        //        }

        //    }
        //    lista.RemoveAt(index);

        //    return index != -1;
          
        //}
        public static bool EliminarPersona(List<Persona> lista, Persona p)
        {
            int index = -1;//inicializo el indice en -1(posicion invalida de un indice-index-)
            bool sePudo = false;
            for (int i = 0; i < lista.Count; i++)
            {
                //elimino por un valor q estoy buscando
                if (lista[i].Nombre == p.nombre && lista[i].Dni == p.dni)//Criterio para identificar q dos personas son iguales
                {
                    index = i;
                    break;
                }

            }

            if (index != -1) 
            { 
                lista.RemoveAt(index);
                sePudo = true;
            }

            return sePudo;
        }

    }
}
