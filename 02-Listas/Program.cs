using System;
using System.Collections.Generic;

namespace _02_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02-Listas, List!");

            //Representa uma lista de objetos que podem ser acessados por índice. Fornece métodos para pesquisar, classificar e modificar listas.
            Console.WriteLine("Criar Lista");
            CriarLista();

            Console.WriteLine();

            Console.WriteLine("Remover elemento 'coho' da Lista ");
            RemoverElemento();

            Console.WriteLine();

            Console.WriteLine("Números pares: ");
            GetNumerosPares();

            Console.WriteLine();

            Console.WriteLine("Lista de Objeto Galaxy: ");
            GetGalaxiaLista();

            Console.ReadKey();
        }

        /// <summary>
        /// O exemplo a seguir cria uma lista de cadeias de caracteres e, em seguida, itera nas cadeias de caracteres usando uma instrução foreach
        /// </summary>
        public static void CriarLista()
        {
            // Criar lista de strings
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // escrever na tela.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye
        }

        /// <summary>
        /// O exemplo a seguir é igual ao exemplo anterior, exceto que um inicializador de coleção é usado para adicionar elementos à coleção.
        /// </summary>
        public static void CriarListaDeNovo()
        {
            // Criar lista de strings
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // escrever na tela.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook coho pink sockeye
        }

        /// <summary>
        /// O exemplo a seguir remove um elemento da coleção, especificando o objeto a ser removido.
        /// </summary>
        public static void RemoverElemento()
        {
            // Criar lista
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Remover um item específico
            salmons.Remove("coho");

            // escrever na tela.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            // Output: chinook pink sockeye
        }

        public static void GetNumerosPares()
        {
            //lista de números
            var numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Remover números ímpares
            for (var index = numeros.Count - 1; index >= 0; index--)
            {
                //compara resto da divisão  
                if (numeros[index] % 2 == 1)
                {
                    // Remover o item da lista baseado no índex
                    numeros.RemoveAt(index);
                }
            }

            // Utilizado lamba expression baseado no método foreach
            // Lista de objetos genericos.
            numeros.ForEach(numero => Console.Write(numero + " "));
            // Output: 0 2 4 6 8
        }

        /// <summary>
        /// Para o tipo dos elementos na List<T>, você também pode definir sua própria classe. No exemplo a seguir, a classe Galaxy que é usada pela List<T> é definida no código.
        /// </summary>
        public static void GetGalaxiaLista()
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            new Galaxy() { Name="Milky Way", MegaLightYears=0},
            new Galaxy() { Name="Andromeda", MegaLightYears=3}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            }

            // Output:
            //  Tadpole  400
            //  Pinwheel  25
            //  Milky Way  0
            //  Andromeda  3
        }


    }
}
