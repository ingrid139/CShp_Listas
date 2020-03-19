using System;
using System.Collections.Generic;

namespace _06_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05-Listas, Stack!");

            //Representa uma coleção UEPS (último a entrar, primeiro a sair) de tamanho variável das instâncias do mesmo tipo especificado.

            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            // A stack pode ser enumerada sem deturbar seu conteúdo.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Pegar o próximo item do destack: {0}",
                numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());

            // Criar uma cópia da fila (stack), usando o método ToArray e o construtor que aceita IEnumerable<T> 
            Stack<string> stack2 = new Stack<string>(numbers.ToArray());

            Console.WriteLine("\nConteúdo da primeira cópia:");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }


            // Crie uma matriz com o dobro do tamanho da fila (stack) e copie (CopyTo) os elementos da fila (stack), 
            // começando no meio da matriz.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);


            // Crie uma segunda fila (stack), usando o construtor que aceita um
            // IEnumerable(Of T).
            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nConteúdo da segunda cópia, com duplicatas e nulos:");
            foreach (string number in stack3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");

            // Reset fila
            stack2.Clear();

            // Método Count 
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

            Console.ReadKey();
        }
    }
}
