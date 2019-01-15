# Mediator

### Intenção
Definir um objeto que encapsula a forma como um conjunto de objetos interage. O Mediator promove o acoplamento fraco ao evitar que os objetos se refiram uns aos outros explicitamente e permite variar suas interações independentemente.

### Motivação
O projeto orientado a objetos encoraja a distribuição de comportamento entre vários objetos. Tal distribuição pode resultar em uma estrutura de objetos com muitas conexões entre eles; na pior das situações, cada objeto acaba tendo conhecimento sobre todos os outros objetos. 
Embora o particionamento de um sistema em muitos objetos geralmente melhore a reusabilidade, a proliferação de interconexões tende a reduzi-la novamente. Muitas interconexões tornam menos provável que um objeto possa funcionar sem o apoio de outros – o sistema funciona como se fosse monolítico. Além do mais, pode ser difícil de mudar o comportamento do sistema de maneira significativa, uma vez que o comportamento está distribuído entre muitos objetos. Como resultado, você pode se ver forçado a definir muitas subclasses para customizar e adaptar o comportamento do sistema.

### Aplicabilidade
Utilize o padrão Mediator quando:
- um conjunto de objetos se comunica de maneiras bem-definidas, porém complexas. As interdependências resultantes são desestruturadas e difíceis de entender. 
- a reutilização de um objeto é difícil porque ele referencia e se comunica com muitos outros objetos. 
- um comportamento que está distribuído entre várias classes deveria ser customizável, ou adaptável, sem excessiva especialização em subclasses.
