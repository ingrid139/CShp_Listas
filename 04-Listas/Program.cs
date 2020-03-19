using System;
using System.Collections.Generic;

namespace _04_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03-Listas, Sorted!!");

            //Representa uma coleção de pares chave/valor que são classificados por chave com base na implementação de IComparer<T> associada.

            // Criar uma nova instancia de sorted list de strings,  com uma chave de string
            SortedList<string, string> openWith = new SortedList<string, string>();

            // Add alguns elementos nessa lista(SortedList).
            // Não há elementos duplicados, mas alguns valores são duplicados
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // Add método para pegar exception se add uma nova chave que já exista
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
            Console.WriteLine("Chave = \"rtf\", valor = {0}.",  openWith["rtf"]);

            // O indexador pode ser usado para alterar o valor associado à chave
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("Chave = \"rtf\", valor = {0}.", openWith["rtf"]);

            //Se a chave não existir, a configuração do indexador para essa chave adiciona um novo par de chave/valor - key/value.
            openWith["doc"] = "winword.exe";

            // O indexador lança uma exeção se não achar a chave na lista
            try
            {
                Console.WriteLine("Chave = \"tif\", valor = {0}.", openWith["tif"]);
            }
            //exeção de Chave
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
                Console.WriteLine("Valor adicionado para chave = \"ht\": {0}", openWith["ht"]);
            }


            // Quando utiliza-se foreach para uma lista de elementos enumerados
            // os elementos são recuperados como objetos KeyValuePair
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Chave = {0}, Valor = {1}", kvp.Key, kvp.Value);
            }

            //Para recuperar valores isolados, utiliza-se a propriedade Values
            IList<string> ilistValues = openWith.Values;


            // Os elementos da lista são fortemente tipados com o tipo
            // que foram especificados na SorteList Values
            Console.WriteLine();
            foreach (string s in ilistValues)
            {
                Console.WriteLine("Valor = {0}", s);
            }

            // A propriedade Values é uma forma eficiente de recuperar valores pelo índex
            Console.WriteLine("\nRecuperando valores usando Values " + "propriedade: Values[2] = {0}", openWith.Values[2]);

            //Para recuperar chaves isoladas, utiliza-se a propriedade Keys
            IList<string> ilistKeys = openWith.Keys;

            // Os elementos da lista são fortemente tipados com o tipo
            // que foram especificados na SorteList Keys
            Console.WriteLine();
            foreach (string s in ilistKeys)
            {
                Console.WriteLine("Chave = {0}", s);
            }

            // A propriedade Keys é uma forma eficiente de recuperar chaves pelo índex
            Console.WriteLine("\nRecuperando chaves usando Keys " +
               "propriedade: Keys[2] = {0}", openWith.Keys[2]);

            // Utilize o método Remove para remover um par chave/valor - key/value
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Chave \"doc\" não encontrada.");
            }

            Console.ReadKey();

        }

        /* This code example produces the following output:

            An element with Key = "txt" already exists.
            For key = "rtf", value = wordpad.exe.
            For key = "rtf", value = winword.exe.
            Key = "tif" is not found.
            Key = "tif" is not found.
            Value added for key = "ht": hypertrm.exe

            Key = bmp, Value = paint.exe
            Key = dib, Value = paint.exe
            Key = doc, Value = winword.exe
            Key = ht, Value = hypertrm.exe
            Key = rtf, Value = winword.exe
            Key = txt, Value = notepad.exe

            Value = paint.exe
            Value = paint.exe
            Value = winword.exe
            Value = hypertrm.exe
            Value = winword.exe
            Value = notepad.exe

            Indexed retrieval using the Values property: Values[2] = winword.exe

            Key = bmp
            Key = dib
            Key = doc
            Key = ht
            Key = rtf
            Key = txt

            Indexed retrieval using the Keys property: Keys[2] = doc

            Remove("doc")
            Key "doc" is not found.
             */
    }
}
