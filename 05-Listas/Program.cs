using System;
using System.Collections.Generic;

namespace _05_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05-Listas, Queue!");

            //Representa uma coleção - fila (Queue) - primeiro a entrar, primeiro a sair de objetos.

            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // Uma fila (Queue) pode ser enumerada sem deturbar seu conteúdo
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Pegar o próximo item no dequeue: {0}",
                numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //Criar uma cópia da fila (queue), usando o método ToArray e o construtor que aceita IEnumerable<T>
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nConteúdo da primeira cópia: ");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // Crie uma matriz com o dobro do tamanho da fila e copie (CopyTo) os elementos da fila (queue), 
            // começando no meio da matriz.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Crie uma segunda fila (queue), usando o construtor que aceita um
            // IEnumerable(Of T).
            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nConteúdo da segunda cópia, com duplicatas e nulos:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            
            // Reset fila
            queueCopy.Clear();

            // Método Count 
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);

            Console.ReadKey();

        }
    }
}
