# Bridge

### Intenção
Desacoplar uma abstração da sua implementação, de modo que as duas possam variar independentemente.

### Também conhecido como
Handle/Body

### Motivação
Quando uma abstração pode ter uma entre várias implementações possíveis, a maneira usual de acomodá-las é usando a herança. Uma classe abstrata define a interface para a abstração, e subclasses concretas a implementam de formas diferentes. Mas essa abordagem nem sempre é suficientemente flexível. A herança liga uma implementação à abstração permanentemente, o que torna difícil modificar, aumentar e reutilizar abstrações e implementações independentemente.

### Aplicabilidade
Use o padrão Bridge quando:
- desejar evitar um vínculo permanente entre uma abstração e sua implementação. Isso pode ocorrer, por exemplo, quando a implementação deve ser selecionada ou alterada em tempo de execução;
- tanto as abstrações como suas implementações tiverem de ser extensíveis por meio de subclasses. Neste caso, o padrão Bridge permite combinar as diferentes abstrações e implementações e estendê-las independentemente; 
- mudanças na implementação de uma abstração não puderem ter impacto sobre os clientes; ou seja, quando o código dos mesmos não puder ser recompilado. 
- você desejar ocultar completamente a implementação de uma abstração dos clientes. Em C#, a representação de uma classe é visível na interface da classe; 
- tiver uma proliferação de classes, como foi mostrado no primeiro diagrama da seção Motivação. Tal hierarquia de classes indica necessidade de separar um objeto em duas partes. Rumbaugh usa o termo “generalizações aninhadas” (nested generalizations) [RPB+91] para se referir às hierarquias de cada classe; 
- desejar compartilhar uma implementação entre múltiplos objetos (talvez usando a contagem de referências) e este fato deve estar oculto do cliente. Um exemplo simples é a classe String mencionada por Coplien [Cop92], na qual múltiplos objetos podem compartilhar a mesma representação de uma string (StringRep).
