using System.Text;

namespace BibliotecaPersonas06_11
{
    public class Persona
    {

        string nombre;
        string ciudad;
        int edad;
        string dni;
        List<Disco> discos;//atributo q paso a ser una coleccion -Lista de tipo disco
        double dinero;
        //SOBRECARGA DE CONSTRUCTORES:

        //Constructor va a tener varias versiones de como construir una persona
        //LLAMADA DEL CONSTRUCTOR:
        //*Cuando realizamos sobrecargas podemos realizar la llamada del constructor anterior
        
        //*Por lo general segun el tipo de sobrecarga -> "El constructor que recibe mas parametros
        //siempre va a terminar llamando al q recibe menos
        
        //*Para evitar la repeticion de estar asignando los mismos valores-Hacemos que los constructores
        //se vayan llamando unos a otros
        
        //*Si no hago la llamada de constructor la lista solo va a quedar inicializada en el constructor vacio
        
        //*Cuatro sobrecargas de constructores-> cuatro versiones distintas
        //1°Sobrecarga-Constructor vacio
        private Persona()
        {
            this.discos = new List<Disco>();//las listas por lo general se inicializan en el constructor
            this.dinero = 0;
        }
        //:this() -> identifica q estoy llamando al constructor q no recibe parametros
        //2°Sobrecarga
        public Persona(string nombre, string dni)
            : this() //hace la llamada al constructor vacio
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        //3°sobrecarga
        public Persona(string nombre, int edad, string dni)
            : this(nombre, dni)//llamo al constructor anterior
        {
            this.edad = edad;
            //this.nombre = nombre;
            //this.dni= dni;
        }
        //4°Sobrecarga
        public Persona(string nombre, string ciudad, int edad, string dni)
            : this(nombre, edad, dni)
        {
            this.ciudad = ciudad;
        }
       
        //*Tengo el llamado de todos los constructores 
        //*No voy a tener repeticion de lineas de codigo q hacer asignaciones a los distintos atributos
        //*Me aseguro q siempre llame al constructor vacio y inicialize mi lista de discos
        //*Puedo ir construyendo el objeto en cascada
        
        //PROPIEDADES: de lectura y escritura.
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
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

        public List<Disco> Discos
        {
            set
            {
                this.discos = value;//tengo q hasignarle (si yo recibiera algo por medio de la propertie) q va a recibir esa lista
                //value: hace referencia al valor q le estoy pasando
            }
            get
            {
                return this.discos;
            }

        }

        public double Dinero { get => dinero; set => dinero = value; }

        public string MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}   -   Dni: {dni}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Ciudad: {ciudad}");
            sb.AppendLine($"Dinero: {dinero}");
            sb.AppendLine("-------------------------------------");

            return sb.ToString();

        }
        public static void MostrarPersonas(List<Persona> lista)
        {
            //lista.ForEach(persona => Console.WriteLine(persona.MostrarPersona())); //->iterador

            //Cuando tengo q recorrer una coleccion q esta indexada q podemos iterar es mas comodo usar foreach
            foreach (Persona unaPersona in lista)
            {
                Console.WriteLine(unaPersona.MostrarPersona());
            }
        }
        public static bool EliminarPersona(List<Persona> lista, Persona p)
        {
            int index = -1;
            bool sePudo = false;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nombre == p.nombre && lista[i].Dni == p.Dni)
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
        //***************************
        //SOBRECARGA DE METODOS:
        //Para sobrecarga de metodos:
        //*El nombre tiene q ser el mismo por q sino pasan a ser dos metodos distintos
        //*Cambiar la cantidad de parametros q recibe
        //*Cambiar los tipos de datos q estoy recibiendo
        //-Voy a tener tantas sobrecargas del mismo metodo como funcionalidades le quiera dar
        //********************
        //Metodo para agregar dinero:
        public void AgregarDinero(double cant)
        {
            this.dinero = cant;
        }
        //Metodo para recibir dinero de un sueldo y de ese sueldo quiero q tenga un bonus
        //de un porcentaje.
        /// <summary>
        /// Agrega dinero con un 10% extra
        /// </summary>
        /// <param name="cant"> cantidad de dinero</param>
        
        public double AgregarDinero(int cant)
        {
            int porcentaje = 10;

            this.dinero = cant + cant * porcentaje / 100;

            return this.dinero;
        }


        public void AgregarDinero(double cant, int porcentaje)
        {
            this.dinero = cant + cant * porcentaje / 100;
        }
        //-Una sobrecarga es valida si solo si la firma de la sobrecarga es distinta a la firma de otro metodo
        //-Orden de los parametros puede ser distinto

         //SOBRECARGA DE OPERADORES:
        public static bool operator !=(Persona unaPersona, Persona otraPersona)
        {
            return !(unaPersona == otraPersona);

        }
        
        
        public static bool operator ==(Persona unaPersona, Persona otraPersona)
        {
            bool resultado = false;

            if (unaPersona.nombre == otraPersona.nombre && unaPersona.edad == otraPersona.edad)
            {
                resultado = true;
            }

            return resultado;
        }

        public static double operator +(Persona unaPersona, Persona otraPersona)
        {
            return unaPersona.dinero + otraPersona.dinero;
        }

        public static double operator +(Persona unaPersona, double valor)
        {
            unaPersona.dinero = unaPersona.Dinero + valor;
            return unaPersona.dinero;
        }

    }
}
