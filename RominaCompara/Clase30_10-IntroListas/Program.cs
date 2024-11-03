namespace Clase30_10_IntroListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LISTAS:
            //Colecciones o estructuras q nos permiten guardar datos.
            #region COLECCIONES-TIPOS:

            //-Matriz[filas,columnas]: Tenemos dos dimenciones -i->representan filas / j->representan columnas
            //Es una estructura donde voy a tener columnas y celdas
            //Puedo hacer coincidir una fila con una columna y en tal o cual lugar 
            //guardar un dato.
            //Son mas complicadas de recorrer,de manipular y de cargar.

            //-Otros tipos de colecciones:
            //Nos permiten guardar tipos de datos primitivos como un flotantes, un entero o un char
            //o datos mas complejos como por ejemplo un objeto.
            //Dentro de esas colecciones: 

            //1-LISTAS:conjunto de elementos que estan enlazados (similar a un vector)
            //
            //
            //2-DICCIONARIOS:Funciona como pun diccionario para traducir.
            //Sus dos componentes son : palabras->clave(son unicas) y definiciones()
            //Similar al objeto solo q el objeto define comportamiento y el diccionario solo define estructura

            //3-PILAS:Son estructuras que pueden guardar datos
            //Desapilar.
            //Ueps: Ultimo entrado, primero salido.

            //4-COLAS: Similar a un cola del colecctivo, del banco.
            //Desencolo de abajo hacia arriba
            //Peps = primero entrado, primero salido

            //*Todos estos tipos de colecciones se pueden autogestionar: puedo agregar elementos, quitar elementos,mover elementos 
            //sin la necesidad de crear un algoritmo para q lo haga
            //
            #endregion
            #region DEFINIR LISTAS-CREAR-DECLARAR  Y INSTANCIAR

            ////*Las listas las podemos definir de cualquier tipo
            ////*Son genericas.

            ////Si quiero definir una lista de numeros: 

            ////1)-Para crear una lista vamos a usar la clase "List"

            ////2)-Definir Tipo de dato(T)
            ////*Siempre dentro de los parentesis angulares "<>" pongo el tipo de dato
            ////List<T>
            ////T: tipe. Es el tipo de dato. Puedo pasarle el tipo de dato q quiera(float,int, Persona etc)

            ////3)-Nombre de la lista: de la variable q va a utilizar

            ////*Para tener una lista en memoria tengo q declararla y instanciarla:
            ////List<int> listaNumeros;//->Solo se declaro la lista no se instancio

            ////1-Declaro y instancio en una linea:
            //List<int> listaNumeros = new List<int>();
            ////2-Declarar primero y despues instanciarla en algun momento:
            //List<int> listaNumeros1;
            //listaNumeros1 = new List<int>();

            //Console.WriteLine(listaNumeros.Count); // la lista esta vacia
            //                                       //Cuando empiece a cargar con cosas el Count va a cambiar
            //                                       //COUNT: me dice la cantidad de elementos q tiene la lista.


            ////3-OTRA FORMA DE INICIALIZAR UNA LISTA: Hardcodeando la lista con valores
            //List<int> listaNumeros;
            //listaNumeros = new List<int>() { 3, 6, 5, 9, 7 };
            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            #endregion


            ////*******************************************************************************************
            #region DIFERENCIA ENTRE VECTORES Y LISTAS:
            ////Diferencia entre vectores y listas:
            ////Los vectores son finitos, tienen una cantidad de elementos determinados
            ////si defino un vector de 5 elementos va a tener 5 elementos no puede tener mas
            ////Si quiero q el tamaño se dinamico q vaya cambiando voy a usar una lista

            ////*RECORDAR: DATO Q YO LE PASE AL "ADD" TIENE QUE SER DEL MISMO TIPO DE DATO DE LA LISTA 
            #endregion

            ////*Las listas son idexables: puedo acceder a un elemento de la lista atraves del indice

            ////Ejemplo: Si quiero mostrar el tercer elemento
            //Console.WriteLine(listaNumeros[2]);//accedo al 3° elemento de la lista atraves de su indice
            //                                   //*Las listas indexan en cero(el primer elemento va a ser cero)
            // //********************************************************************************************
            ////*Las listas son objetos iterables:las puedo recorrer con un foreach o con un for.
            ////Para mostrar puedo usar cualquiera de las dos formas.
            //for (int i = 0; i < listaNumeros.Count; i++)
            //{
            //    Console.WriteLine(listaNumeros[i]);
            //}

            //foreach(int numero in listaNumeros)//Es de solo lectura. No podemos modificar el largo de la lista
            //{
            //    Console.WriteLine(numero);
            //}

            //*********************************************************
            ////METODOS QUE ME PERMITEN MANIPULAR LA LISTA: para quitar elementos, ordenarlos, buscar algo dentro de la lista
            //Este tipo de objeto se autogestiona y tiene metodos:
            #region 1-METODO ADD:
            ///1-METODO ADD: Agrega elementos***********************
            //List<int> listaNumeros;
            //listaNumeros = new List<int>();

            //listaNumeros.Add(5);//agregue un elemento
            //listaNumeros.Add(1);
            //listaNumeros.Add(3);
            //listaNumeros.Add(4);

            //Console.WriteLine(listaNumeros.Count);
            #endregion
            #region 2-METODO CONTAINS
            ////2-METODO CONTAINS: devuelve un boleano true o false (verdadero o falso))
            ////si encuentra el valor q yo le pase como parametro
            ////Si quiero saber si la lista contiene el numero 8
            //List<int> listaNumeros;
            //listaNumeros = new List<int>() { 3, 6, 5, 8 , 9, 7 };
            //                  //Posicioens:{0 , 1, 2, 3,  4, 5 }
            //if (listaNumeros.Contains(8))//Booleano true o false
            //{//la lista contiene el numero 8
            //    Console.WriteLine("Si");
            //}
            //else 
            //{
            //    Console.WriteLine("No");
            //}

            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            #endregion
            #region 3-METODO INDEX OFF
            ////3-METODO INDEX OFF: Devuelve un valor entero q indica en q posicion esta el valor q yo pase como parametro.
            //Console.WriteLine(listaNumeros.IndexOf(5));//Devuelve la posicion(indice) donde esta el valor 5
            ////Si tiene varios 5 devuelve la posicion del primero q aparece.
            #endregion
           
            ////4-METODO REMOVE: Puedo remover elementos de una lista.Remueve la primera ocurrencia del dato q estoy buscando
            //listaNumeros.Remove(5);
            //                  //(5) le digo q elemento quiero eliminar

            ////5-METODO REMOVEAT: Elimina la posicion. El elemento q esta en la posicion q le estoy pasando como parametro
            //listaNumeros.RemoveAt(3);//borra el elemento de la posicion 3

            ////**Si paso un elemento q no existe:
            ////listaNumeros.Remove(15); // no tira error
            /////listaNumeros.RemoveAt(55);//Si le paso un indice q no existe-> ERROR-El programa rompe

            ////Retorno del metodo para saber si pudo eliminar o no.
            //bool retorno = listaNumeros.Remove(15);
            //Console.WriteLine(retorno);


            //foreach (int numero in listaNumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            #region 6-METODO CLEAR
            //////Limpiar - vacia la lista pero no la destruye. La lista sigue existiendo en memoria pero vacia

            ////List<int> listaNumeros;
            ////listaNumeros = new List<int>() { 3,6,5,8,5,7};

            ////listaNumeros.Clear();

            ////Console.WriteLine(listaNumeros.Count);
            ////listaNumeros.Add(5);
            ////listaNumeros.Add(1);
            ////listaNumeros.Add(3);
            ////listaNumeros.Add(4);
            ////Console.WriteLine(listaNumeros.Count);//La lista sigue estando en memoria
            #endregion
            #region REDIMENCION VECTORES-LISTAS
            //Las listas cambian de tamaño de acuerdo a la cantidad de elementos que tengan adentro. Se pueden redimencionar.
            //En los vectores para declarar un vector tenemos q definirle la dimencion si o si, y no se puede modificar, si puedo 
            //vaciar esa posicion.

            //En cambio en la lista creo una nueva lista y en cualquier momento le puedo agregar, quitar elementos y
            //cada elemento q agregue va agregando una posicion a esa lista y cuando lo borre elimina elemento.
            //*No es primoridial la posicion si no la cantidad de elementos q tiene
            //Por ejemplo se controla la lista por si tiene 10 elementos o mas y no por posiciones.El orden q tiene adentro
            //cada uno puede cambiar
            #endregion


            //7-METODO SORT: Podemos agarrar una lista y ordenanrla
            List<int> listaNumeros;
            listaNumeros = new List<int>() { 3, 6, 5, 8, 5, 7 };

            listaNumeros.Add(5);
            listaNumeros.Add(1);
            listaNumeros.Add(3);
            listaNumeros.Add(4);
           
            listaNumeros.Sort(); //Ordena de manera ascendente de menor a mayor

            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
