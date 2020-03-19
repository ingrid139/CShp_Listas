

O exemplo de código a seguir demonstra vários métodos da classe genérica Stack<T>. 
O exemplo de código cria uma pilha de cadeias de caracteres com capacidade padrão e usa o método Push 
para enviar por push cinco cadeias de caracteres para a pilha. Os elementos da pilha são enumerados, 
o que não altera o estado da pilha. O método Pop é usado para retirar a primeira cadeia de caracteres da pilha. 


O método Peek é usado para examinar o próximo item na pilha e, em seguida, o método Pop é usado para 
desativá-lo.
O método ToArray é usado para criar uma matriz e copiar os elementos da pilha para ela, então a matriz é 
passada para o Construtor Stack<T> que usa IEnumerable<T>, criando uma cópia da pilha com a ordem 
dos elementos invertidos. Os elementos da cópia são exibidos.


Uma matriz duas vezes o tamanho da pilha é criado e o método CopyTo é usado para copiar os elementos 
da matriz que começam no meio da matriz. O construtor de Stack<T> é usado novamente para criar uma cópia 
da pilha com a ordem dos elementos invertidos; Portanto, os três elementos nulos estão no final.


O método Contains é usado para mostrar que a cadeia de caracteres "quatro" está na primeira cópia da pilha, 
após a qual o método Clear limpa a cópia e a propriedade Count mostra que a pilha está vazia.