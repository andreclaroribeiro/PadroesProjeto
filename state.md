# State

### Intenção
Permite a um objeto alterar seu comportamento quando o seu estado interno muda. O objeto parecerá ter mudado sua classe.

### Também conhecido como
Objects for States

### Motivação
Considere a classe TCPConnection que representa uma conexão numa rede de comunicações. Um objeto TCPConnection pode estar em diversos estados diferentes: Established (Estabelecida), Listening (Escutando), Closed (Fechada). Quando um objetoTCPConnection recebe solicitações de outros objetos, ele responde de maneira diferente dependendo do seu estado corrente. Por exemplo, o efeito de uma solicitação de Open (Abrir), depende de se a conexão está no seu estado Closed ou no seu estado Established. O padrão State descreve como TCPConnection pode exibir um comportamento diferente em cada estado. 
A idéia chave deste padrão é introduzir uma classe abstrata chamada TCPState para representar os estados da conexão na rede. A classe TCPState declara uma interface comum para todas as classes que representam diferentes estados operacionais. As subclasses de TCPState implementam comportamentos específicos ao estado. Por exemplo, as classes TCPEstablished e TCPClosed implementam comportamento específico aos estados Established e Closed de TCPConnection.

### Aplicabilidade
Use o padrão State em um dos dois casos seguintes:
- o comportamento de um objeto depende do seu estado e ele pode mudar seu comportamento em tempo de execução, dependendo desse estado; 
- operações têm comandos condicionais grandes, de várias alternativas, que dependem do estado do objeto. Esse estado é normalmente representado por uma ou mais constantes enumeradas. Freqüentemente, várias operações conterão essa mesma estrutura condicional. O padrão State coloca cada ramo do comando adicional em uma classe separada. Isto lhe permite tratar o estado do objeto como um objeto propriamente dito, que pode variar independentemente de outros objetos.
