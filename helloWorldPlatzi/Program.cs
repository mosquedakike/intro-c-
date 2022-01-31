using System;
using static System.Console;

namespace helloWorldPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
           //metodos
           float[] pricesArray;
           pricesArray = new float[10];
           pricesArray[0] = 1.5f;
           pricesArray[1] = 2.5f;
           pricesArray[2] = 3f;
           pricesArray[3] = 5f;

           Random rnd = new Random();
           
           WriteLine("Hello world, of random numbers");
           WriteLine($"{rnd.Next(1,10)}");

           string ClassTopic = "Metodos de strings";
           string School = "Platzi";
           WriteLine($"Estoy aprendiendo de {ClassTopic} en {School}.");
            
           //Clone
           string SchoolClone = School.Clone().ToString();
           WriteLine("Clone()");
           WriteLine(SchoolClone);
           
           //ComparteTo()
           /*compara el contenido de dos strings, si son iguales devuele 0 true
           y si son diferentes devuelve 1 false */
           WriteLine("ComparteTo()");
           WriteLine(ClassTopic.CompareTo(School));
           WriteLine(School.CompareTo(SchoolClone));
           
           //Contains
           /*Retorna true si el string contiene los caracteres que se pongan en los argumentos
            del metodo*/
           WriteLine("Contains()");
           WriteLine(School.Contains("Pla"));

           //EndsWith
           /*Similar a Contains(), pero para comparar si los caracteres están al final del string.*/
           WriteLine("EndsWith()");
           WriteLine(School.EndsWith("zi"));
           
           //StartsWith
           /*Funciona de la misma manera que EndsWith(), pero en este caso comprueba si empieza con una serie de caracteres indicados.*/
           WriteLine("StartsWith()");
           WriteLine(School.StartsWith("Pl"));
           
           //Equals
           /*Funciona de forma parecida a CompareTo(), pero para indicar si el contenido de ambos strings retorna True o False.*/
           WriteLine("Equals()");
           WriteLine(School.Equals(SchoolClone));
           
           //indexOf()
           /*Regresa la posición dentro del string del carácter indicado en el argumento.*/
           WriteLine("IndexOf()");
           WriteLine(School.IndexOf("a"));
           
           //ToLower() y ToUpper()
           /*Convierten el string en todas letras minúsculas o mayúsculas.*/
           WriteLine("ToLower() y ToUpper()");
           WriteLine(ClassTopic.ToLower());
           WriteLine(ClassTopic.ToUpper());
           
           //Insert()
           /*Inserta un nuevo string dentro de otro en la posición indicada dentro de los argumentos. En este caso es en 6 que es la
            posición después de la última letra de “Platzi”.*/
           WriteLine("Equals()");
           WriteLine(School.Insert(6, " es educación online efectiva"));

           //LastIndexOf()
           /*Regresa la posición de la última vez que aparece el carácter. En este caso la letra “s” aparece varias veces en el string
            y así podemos notar cómo devuelve la última posición en la que aparece.*/
           WriteLine("LastIndexOf()");
           WriteLine(ClassTopic.LastIndexOf("s"));
           
           //Remove()
           /*Elimina los caracteres del string a partir de la posición que le indiquemos hasta el final.*/
           WriteLine("Remove()");
           WriteLine(ClassTopic.Remove(6));
           
           //Replace()
           /*Reemplaza todos los caracteres por otro indicado. En este caso todas las “s” serán cambiadas por “z”.*/
           WriteLine("Replace()");
           WriteLine(ClassTopic.Replace("s", "z"));
           
           
           //Split()
           /*Este es un caso especial donde creamos un nuevo string donde guardamos el string separado en trozos por la letra indicada en
            los argumentos del método. Para este caso se separa por la letra “s” en 3 trozos que son los que imprimimos.*/
           WriteLine("Split()");
           string[] split = ClassTopic.Split(new char[] { 's' });
           WriteLine(split[0]);
           WriteLine(split[1]);
           WriteLine(split[2]);
           
           //Substring()
           /*Devuelve un substring o trozo de string de acuerdo a las posiciones indicadas en los argumentos.*/
           WriteLine("Substring()");
           WriteLine(ClassTopic.Substring(2,10));
           
           //ToCharArray()
           /*Convierte el string en un arreglo de caracteres.*/
           WriteLine("ToCharArray()");
           School.ToCharArray();
           WriteLine(School.ToCharArray()[0]);

           //Trim()
           /*Elimina espacios al principio y al final de un string.*/
           WriteLine("Trim()");
           string TextWithSpaces = "  hola, había espacios al principio y al final ";
           WriteLine(TextWithSpaces.Trim());
        }
    }
}