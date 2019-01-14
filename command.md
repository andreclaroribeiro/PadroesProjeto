# Command

### Intenção
Encapsular uma solicitação como um objeto, desta forma permitindo parametrizar clientes com diferentes solicitações, enfileirar ou fazer o registro (log) de solicitações e suportar operações que podem ser desfeitas.

### Também conhecido como
Action, Transaction

### Motivação
Algumas vezes é necessário emitir solicitações para objetos sem nada saber sobre a operação que está sendo solicitada ou sobre o seu receptor. Por exemplo, toolkits para construção de interfaces de usuário incluem objetos como botões de menus que executam uma solicitação em resposta à entrada do usuário. Mas o toolkit não pode implementar a solicitação explicitamente no botão ou menu porque somente as aplicações que utilizam o toolkit sabem o que deveria ser feito e em qual objeto. Como projetistas de toolkits, não temos meios de saber qual o receptor da solicitação ou as operações que ele executará. 

### Aplicabilidade
Use o padrão Command quando você deseja:
- parametrizar objetos por uma ação a ser executada, da forma como os objetos MenuItem fizeram acima. Você pode expressar tal parametrização numa linguagem procedural através de uma função callback, ou seja, uma função que é registrada em algum lugar para ser chamada em um momento mais adiante. Os Commands são uma substituição orientada o objetos para callbacks; 
- especificar, enfileirar e executar solicitações em tempos diferentes. Um objeto Command pode ter um tempo de vida independente da solicitação orginal. Se o receptor de uma solicitação pode ser representado de uma maneira independente do espaço de endereçamento, então você pode transferir um objeto command para a solicitação para um processo diferente e lá atender a solicitação; 
- suportar desfazer operações. A operação Execute, de Command, pode armazenar estados para reverter seus efeitos no próprio comando. A interface de Command deve ter acrescentada uma operação Unexecute, que reverte os efeitos de uma chamada anterior de Execute. Os comandos executados são armazenados em uma lista histórica. O nível ilimitado de desfazer e refazer operações é obtido percorrendo esta lista para trás e para frente, chamando operações Unexecute e Execute, respectivamente;
- suportar o registro (logging) de mudanças de maneira que possam ser reaplicadas no caso de uma queda de sistema. Ao aumentar a interface de Command com as operações carregar e armazenar, você pode manter um registro (log) persistente das mudanças. A recuperação de uma queda de sistema envolve a recarga dos comandos registrados a partir do disco e sua reexecução com a operação Execute. 
- estruturar um sistema em torno de operações de alto nível construídas sobre operações primitivas. Tal estrutura é comum em sistemas de informação que suportam transações. Uma transação encapsula um conjunto de mudanças nos dados. O padrão Command fornece uma maneira de modelar transações. Os Commands têm uma interface comum, permitindo invocar todas as transações da mesma maneira. O padrão também torna mais fácil estender o sistema com novas transações.
