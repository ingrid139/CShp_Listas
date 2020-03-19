using System;
using System.Collections.Generic;

namespace _07_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05-Listas, Dictionary!");

            //Representa uma coleção de chaves e valores.

            // Crie um new dictionary de strings, com chave de string.
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // add alguns elementos nessa lista (dictionary).
            // Não há elementos duplicados, mas alguns valores são duplicados
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //Add método para pegar exception se add uma nova chave que já exista
            try
            {
                //chave duplicada
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Um elemento com a Chave = \"txt\" já existe.");
            }

            // A propriedade Item é outro nome para o indexador, portanto, você pode omitir seu nome ao acessar elementos
            Console.WriteLine("Chave = \"rtf\", valor = {0}.", openWith["rtf"]);

            // O indexador pode ser usado para alterar o valor associado à chave
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("Chave = \"rtf\", valor = {0}.",
                openWith["rtf"]);


            //Se a chave não existir, a configuração do indexador para essa chave adiciona um novo par de chave/valor - key/value.
            openWith["doc"] = "winword.exe";

            // O indexador lança uma exeção se não achar a chave na lista (dictionary)
            try
            {
                Console.WriteLine("Chave = \"tif\", valor = {0}.", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Chave = \"tif\" não encontrada.");
            }

            // Quando um programa geralmente tenta achar chaves que não constam da lista,
            // o TryGetValue pode ser uma maneira mais eficiente de recuperar valores.
            string value = "";

            //sintaxe: tenta achar a chave "tif" (Try(entrada)-GetValue(saída-retorno)), 
            //caso não encontre retorna (out) o valor (valor) que pode ser utilizado em seguida dentro do if
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("Chave = \"tif\", valor = {0}.", value);
            }
            else
            {
                Console.WriteLine("Chave = \"tif\" não encontrada.");
            }

            // ContainsKey pode ser usado para testar(verificar se já existe) chaves antes de inserí-las
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Valor adicionado para chave = \"ht\": {0}",                    openWith["ht"]);
            }

            // Quando utiliza-se foreach para uma lista de elementos enumerados
            // os elementos são recuperados como objetos KeyValuePair
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Chave = {0}, Valor = {1}",
                    kvp.Key, kvp.Value);
            }

            //Para recuperar valores isolados, utiliza-se a propriedade Values
            Dictionary<string, string>.ValueCollection valueColl = openWith.Values;

            // Os elementos da lista são fortemente tipados com o tipo
            // que foram especificados na dictionary Values
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Valor = {0}", s);
            }

            //Para recuperar chaves isoladas, utiliza-se a propriedade Keys
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // Os elementos da lista são fortemente tipados com o tipo
            // que foram especificados na dictionary Keys
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Utilize o método Remove para remover um par chave/valor - key/value
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Chave \"doc\" não encontrada.");
            }



            Console.ReadKey();
        }
    }
}
