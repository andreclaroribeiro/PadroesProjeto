# Prototype

### Intenção
Especificar os tipos de objetos a serem criados usando uma instância-protótipo e criar novos objetos pela cópia desse protótipo.

### Motivação
Você poderia construir um editor para partituras musicais customizando um framework geral para editores gráficos, acrescentando novos objetos que representam notas, pausas e pentagramas. O editor do framework pode ter uma paleta de ferramentas para acrescentar esses objetos de música à partitura. A paleta também incluiria ferramentas para selecionar, mover e manipular objetos de música de outra forma. O usuário clicaria na ferramenta de uma semínima para adicionar semínimas à partitura. Ou poderia usar a ferramenta de movimentação para mover uma nota para cima ou para baixo nas linhas de pauta, desta forma alterando seu registro sonoro. 

### Aplicabilidade
Use o padrão Prototype quando um sistema tiver que ser independente de como os seus produtos são criados, compostos e representados; e
- quando as classes a instanciar forem especificadas em tempo de execução, por exemplo, por carga dinâmica; ou 
- para evitar a construção de uma hierarquia de classes de fábricas paralela à hierarquia de classes de produto; ou 
- quando as instâncias de uma classe puderem ter uma dentre poucas combinações diferentes de estados. Pode ser mais conveniente instalar um número correspondente de protótipos e cloná-los, ao invés de instanciar a classe manualmente, cada vez com um estado apropriado.
