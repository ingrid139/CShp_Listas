using System;

namespace _01_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01-Listas, Array!");

            //convenção de nomes na variável, repetição de criação da "mesma" variável, não sabemos o tamanho da lista
            int idade_1 = 15;
            int idade_2 = 28;
            int idade_3 = 35;
            int idade_4 = 50;

            int media = (idade_1 + idade_2 + idade_3 + idade_4) / 4;

            Console.WriteLine(media);

            /*==========================================================*/
            Console.WriteLine();

            //tipo referencia 
            //Array = conjunto de elementos de um mesmo tipo de dados onde cada elemento do conjunto é acessado pela posição(índice) 
            //Array de uma dimensão é chamado de Vetor
            int[] idades = new int[6];

            //os índices começam por zero
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            //int indadeNoIndice4 = idades[4];
            int indice = 4;
            int indadeNoIndice4 = idades[indice];

            //interpolação de string, utilizando o $ antecedendo o início da string e inserindo o campo que desejamos concetenar na string entre { }
            Console.WriteLine($"Valor da variável idades na posição 4: {idades[4]}");
            Console.WriteLine($"Valor da variável indadeNoIndice4: {indadeNoIndice4}");

            //valor padrão num array quando nao inicializa
            Console.WriteLine($"Valor da variável idades na posição 5: {idades[5]}");

            //Lenght = número de elementos que esse array possui.
            Console.WriteLine(idades.Length);

            //acumulador irá guardar a soma dos números dentro do laço for
            int acumulador = 0;

            //i = indice
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Acessando o array idades no índice {i}");
                Console.WriteLine($"Valor de idades[{i}] = {idade}");

                acumulador += idade;
            }

            int media2 = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");

            /*==========================================================*/
            Console.WriteLine();

            //Outra forma de inicializar Array sem se preocupar com o seu tamanho
            int[] idadesArray = new int[] 
            { 
                15,
                28,
                35,
                50,
                28
            };

            Console.WriteLine($"Valor da variável idadesArray na posição 4: {idadesArray[4]}");

            Console.ReadKey();
        }
    }
}
