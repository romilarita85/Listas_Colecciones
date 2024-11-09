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
                if (lista[i].nombre == p.nombre && lista[i].Dni == p.Dni)//Criterio para identificar q dos personas son iguales
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
        //************************************************
        //SOBRECARGA DE METODOS:(dar distintos comportamientos ante una misma accion)
        //Para sobrecarga de metodos:
        //*El nombre tiene q ser el mismo por q sino pasan a ser dos metodos distintos
       
        //*Cambiar la cantidad de parametros q recibe
        
        //*Cambiar los tipos de datos q estoy recibiendo
        //-Voy a tener tantas sobrecargas del mismo metodo como funcionalidades le quiera dar
        //-Tener en cuenta la firma - no puedo tener dos firmas iguales
        //intercambiar en una firma dos tipos de datos me genera una firma nueva-> es una firma valida
        
        //*La sobrecarga no afecta al tipo de retorno.
        
        //*Importa el tipo y la cantidad de los parametros q yo le pase (no se tiene q repetir el tipo de dato q yo le pase)
        //En cantidad y en tipo de dato puede variar
        //Los parametros no son significativos- el nombre del parametro no es importante
        //********************************************************************************************
        
        //Metodo para agregar dinero:
        public void AgregarDinero(double cant)//funciona como un setter
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
        //*****************************************************************
        //*Si yo quisiera repetir esa sobrecarga con un void me tira error -> es la misma sobrecarga
        //una devuelve double y otra no devuelve nada
        //public void AgregarDinero(int cant)
        //{
        //    int porcentaje = 10;

        //    this.dinero = cant + cant * porcentaje / 100;

        //    return this.dinero;
        //}
        //******************************************************************
        public void AgregarDinero(double cant, int porcentaje)
        {
            this.dinero = cant + cant * porcentaje / 100;
        }
        //-Una sobrecarga es valida si solo si la firma de la sobrecarga es distinta a la firma de otro metodo
        //-Orden de los parametros puede ser distinto
        //********************************************************
        //SOBRECARGA DE OPERADORES: + - * % > < == !=
        //Operadores tienen una funcionalidad esta funcionalidad la puedo cambiar(torcer)
        //para ciertas situaciones algunos operadores van a tener otro comportamiento
        //Atravez de la sobrecarga de operadores podemos redefinir de q manera el == va a comparar dos objetos
        //Yo le voy a enseñar cuando dos personas son iguales.
        //Ejemplo: Dos personas son iguales cuando comparten el mismo nombre, la misma edad y la misma ciudad o nombre y documento
        //Voy a sobrecargar el operador == de la clase persona
        //
        //si modifico el comportamiento del == ->si sobrecargo el operador == estoy obligado a sobrecargar el operador distinto
       //El operador == requiere que tambien se defina el operador coincidente != (distinto)
        public static bool operator !=(Persona unaPersona, Persona otraPersona)
        {
            #region REPETICION DE CODIGO
            //    bool resultado = false;
            //    //uso if para comparar
            //    if (unaPersona.nombre != otraPersona.nombre && unaPersona.edad != otraPersona.edad)
            //    {//quiero q sean iguales si comparten el mismo nombre y la misma edad
            //        resultado = true;
            //    }
            //    return resultado;
            #endregion

            return !(unaPersona == otraPersona);//-> PARA NO UTILIZAR EL MISMO CODIGO (reutilizacion de codigo)

        }
        public static bool operator ==(Persona unaPersona, Persona otraPersona)
        {
            //LOGICA PARA QUE DOS PERSONAS SE PUEDAN COMPARAR
            bool resultado = false;
            //uso if para comparar
            if (unaPersona.nombre == otraPersona.nombre && unaPersona.edad == otraPersona.edad)  
            {//quiero q sean iguales si comparten el mismo nombre y la misma edad
                resultado = true;
            }
            return resultado;
        }
        //SOBRECARGA DEL OPERADOR + DE LA CLASE PERSONA
        
        //1°sobrecarga operador+
        //Agarrar dos personas y devuelvan a tanta plata entre las dos
        public static double operator +(Persona unaPersona, Persona otraPersona)
        {
            return unaPersona.dinero + otraPersona.dinero;
        }
        //2°sobrecarga operador+
        //
        public static double operator +(Persona unaPersona, double valor)
        {
            unaPersona.dinero = unaPersona.Dinero + valor;
            return unaPersona.dinero;
        }

    }
}
