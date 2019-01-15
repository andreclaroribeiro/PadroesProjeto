# Iterator

### Intenção
Fornecer um meio de acessar, seqüencialmente, os elementos de um objeto agregado sem expor a sua representação subjacente.

### Também conhecido como
Cursor

### Motivação
Um objeto agregado, tal como uma lista, deveria fornecer um meio de acessar seus elementos sem expor a sua estrutura interna. Além do mais, você pode querer percorrer a lista de diferentes maneiras, dependendo do que quiser fazer. Mas, provavelmente, você não irá quer inflar a interface da lista com operações para diferentes percursos, ainda que possa antecipar aquelas de que necessitará. Você também pode precisar ter mais de um percurso pendente sobre a mesma lista. 
O padrão Iterator permite fazer tudo isto. A idéia-chave nesse padrão é retirar a responsabilidade de acesso e percurso do objeto lista e colocá-la em um objeto iterator. A classe Iterator define uma interface para acessar os elementos da lista. Um objeto iterator é responsável por manter a posição do elemento corrente; ou seja, sabe quais elementos já foram percorridos. 

### Aplicabilidade
Use o padrão Iterator:
- para acessar os conteúdos de um objeto agregado sem expor a sua representação interna; 
- para suportar múltiplos percursos de objetos agregados; 
- para fornecer uma interface uniforme que percorra diferentes estruturas agregadas (ou seja, para suportar a iteração polimórfica).
