O exemplo de código a seguir cria um Dictionary<TKey,TValue> vazio de cadeias de caracteres com chaves 
de cadeias e usa o método Add para adicionar alguns elementos. O exemplo demonstra que o método Add 
gera um ArgumentException ao tentar adicionar uma chave duplicada.

O exemplo usa a propriedade Item[TKey] (o indexador em C#) para recuperar valores, demonstrando
que um KeyNotFoundException é gerado quando uma chave solicitada não está presente e mostrando 
que o valor associado a uma chave pode ser substituído.


O exemplo mostra como usar o TryGetValue método como uma forma mais eficiente para recuperar valores, 
se um programa geralmente deve tentar valores de chave que não estão no dicionário e ele mostra como 
usar o ContainsKey método para testar se uma chave existe antes de chamar o Add método.

O exemplo mostra como enumerar as chaves e os valores no dicionário e como enumerar as chaves e
os valores sozinhos usando a propriedade Keys e a propriedade Values.

Por fim, o exemplo demonstra o método Remove.