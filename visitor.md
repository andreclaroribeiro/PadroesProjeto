# Visitor

### Intenção
Representar uma operação a ser executada nos elementos de uma estrutura de objetos. Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre os quais opera.

### Motivação
Considere um compilador que representa programas como árvores sintáticas abstratas. Ele necessitará executar operações nas árvores sintáticas abstratas para análises “semânticas estáticas”, como verificar se todas as variáveis estão definidas. Também necessitará gerar código executável. Assim, poderá definir operações para verificação de tipos, otimização de código, análise de fluxo, verificação se as variáveis receberam valores antes de serem usadas, e assim por diante. Além do mais, poderíamos usar as árvores sintáticas abstratas para pretty-printing, reestruturação de programas, instrumentação de código e computação de várias métricas de um programa. 
A maioria dessas operações necessitará tratar nós que representam comandos de atribuição de forma diferente de nós que representam variáveis ou expressões aritméticas. Portanto, existirá uma classe para comandos de atribuição, outra para acessos a variáveis, uma outra para expressões aritméticas, e assim por diante. Naturalmente, o conjunto das classes-nó depende da linguagem que está sendo compilada. Porém, ele não muda muito para uma determinada linguagem.

### Aplicabilidade
Use o padrão Visitor quando:
- uma estrutura de objetos contém muitas classes de objetos com interfaces que diferem e você deseja executar operações sobre esses objetos que dependem das suas classes concretas; 
- muitas operações distintas e não-relacionadas necessitam ser executadas sobre objetos de uma estrutura de objetos, e você deseja evitar “a poluição” das suas classes com essas operações. Visitor lhe permite manter juntas operações relacionadas, definindo-as em uma única classe. Quando a estrutura do objeto for compartilhada por muitas aplicações, use Visitor para por operações somente naquelas aplicações que as necessitam; 
- as classes que definem a estrutura do objeto raramente mudam, porém, você freqüentemente deseja definir novas operações sobre a estrutura. A mudança das classes da estrutura do objeto requer a redefinição da interface para todos os visitantes, o que é potencialmente oneroso. Se as classes da estrutura do objeto mudam com freqüência, provavelmente é melhor definir as operações nessas classes.
