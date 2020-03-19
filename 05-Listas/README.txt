
/*

O exemplo de código a seguir demonstra vários métodos da classe genérica Queue<T>. 

O exemplo de código cria uma fila de cadeias de caracteres com capacidade padrão e usa o método Enqueue 
para enfileirar cinco cadeias de caracteres. Os elementos da fila são enumerados, o que não altera o estado
da fila. 

O método Dequeue é usado para remover a primeira cadeia de caracteres da fila. 

O método Peek é usado para examinar o próximo item na fila e, em seguida, 
o método Dequeue é usado para remover a fila.
O método ToArray é usado para criar uma matriz e copiar os elementos de fila para ela, então a matriz 
é passada para o Construtor Queue<T> que usa IEnumerable<T>, criando uma cópia da fila. 

Os elementos da cópia são exibidos.
Uma matriz duas vezes o tamanho da fila é criado e o método CopyTo é usado para copiar os elementos 
da matriz que começam no meio da matriz. O construtor de Queue<T> é usado novamente para criar uma segunda 
cópia da fila que contém três elementos nulos no início.

O método Contains é usado para mostrar que a cadeia de caracteres "quatro" está na primeira cópia da fila,
após o qual o método Clear limpa a cópia e a propriedade Count mostra que a fila está vazia.

*/