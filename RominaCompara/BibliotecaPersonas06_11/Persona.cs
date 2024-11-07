using System.Text;

namespace BibliotecaPersonas06_11
{
    public class Persona
    {

        string nombre;
        string ciudad;
        int edad;
        string dni;
        List<Disco> discos;
        double dinero;

        private Persona()
        {
            this.discos = new List<Disco>();
            this.dinero = 0;
        }
        public Persona(string nombre, string dni)
            : this()
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Persona(string nombre, int edad, string dni)
            : this(nombre, dni)
        {
            this.edad = edad;
        }
        public Persona(string nombre, string ciudad, int edad, string dni)
            : this(nombre, edad, dni)
        {
            this.ciudad = ciudad;
        }

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
                this.discos = value;
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

            //lista.ForEach(persona => Console.WriteLine(persona.MostrarPersona()));

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

        public void AgregarDinero(double cant)
        {
            this.dinero = cant;
        }

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
