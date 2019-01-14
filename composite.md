# Composite

### Intenção
Compor objetos em estruturas de árvore para representarem hierarquias partes-todo. Composite permite aos clientes tratarem de maneira uniforme objetos individuais e composições de objetos.

### Motivação
Aplicações gráficas, tais como editores de desenhos e sistemas de captura esquemática, permitem aos usuários construir diagramas complexos a partir de componentes simples. O usuário pode agrupar componentes para formar componentes maiores, os quais, por sua vez, podem ser agrupados para formar componentes ainda maiores. Uma implementação simples poderia definir classes para primitivas gráficas, tais como Texto e Linhas, além de outras classes que funcionam como recipientes (containers) para essas primitivas. 
Porém, há um problema com essa abordagem: o código que usa essas classes deve tratar objetos primitivos e objetos recipientes de modo diferente, mesmo se na maior parte do tempo o usuário os trata de forma idêntica. Ter que distinguir entre esses objetos torna a aplicação mais complexa. O padrão Composite descreve como usar a composição recursiva de maneira que os clientes não tenham que fazer essa distinção.

### Aplicabilidade
Use o padrão Composite quando:
- quiser representar hierarquias partes-todo de objetos; 
- quiser que os clientes sejam capazes de ignorar a diferença entre composições de objetos e objetos individuais. Os clientes tratarão todos os objetos na estrutura composta de maneira uniforme.
