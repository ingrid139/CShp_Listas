using System;
using System.Collections.Generic;

namespace _03_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03-Listas, List, Comparable!!");
            //Representa uma lista fortemente tipada de objetos que podem ser acessados por índice. Fornece métodos para pesquisar, classificar e manipular listas.

            //No método List<Carros>, a instrução carros.Sort() classifica(ordena) a lista. Essa chamada para o método Sort da List<T> faz com que o método CompareTo seja chamado automaticamente para os objetos do tipo Carro na List.

            var carros = new List<Carro>
            {
                { new Carro() { Name = "Carro1", Cor = "blue", Velocidade = 20}},
                { new Carro() { Name = "Carro2", Cor = "red", Velocidade = 50}},
                { new Carro() { Name = "Carro3", Cor = "green", Velocidade = 10}},
                { new Carro() { Name = "Carro4", Cor = "blue", Velocidade = 50}},
                { new Carro() { Name = "Carro5", Cor = "blue", Velocidade = 30}},
                { new Carro() { Name = "Carro6", Cor = "red", Velocidade = 60}},
                { new Carro() { Name = "Carro7", Cor = "green", Velocidade = 50}}
            };

            //Sort(Ordenar) os carros pela cor alfabeticamente e depois pela velocidade crescente
            carros.Sort();

            // resultado.
            foreach (Carro carro in carros)
            {
                Console.Write(carro.Cor.PadRight(5) + " ");
                Console.Write(carro.Velocidade.ToString() + " ");
                Console.Write(carro.Name);
                Console.WriteLine();
            }

            Console.ReadKey();

            // Output:
            //  blue  50 Carro4
            //  blue  30 Carro5
            //  blue  20 Carro1
            //  green 50 Carro7
            //  green 10 Carro3
            //  red   60 Carro6
            //  red   50 Carro2
        }
    }
}
