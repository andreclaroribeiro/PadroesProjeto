# Singleton

### Intenção
Garantir que uma classe tenha somente uma instância e fornecer um ponto global de acesso para a mesma.

### Motivação
É importante para algumas classes ter uma, e apenas uma, instância. Por exemplo, embora possam existir muitas impressoras em um sistema, deveria haver somente um spooler de impressoras. Da mesma forma, deveria haver somente um sistema de arquivos e um gerenciador de janelas. Um filtro digital terá somente um conversor A/ D. Um sistema de contabilidade será dedicado a servir somente a uma companhia. 
Como garantimos que uma classe tenha somente uma instância e que essa instância seja facilmente acessível? Uma variável global torna um objeto acessível, mas não impede você de instanciar múltiplos objetos. 
Uma solução melhor seria tornar a própria classe responsável por manter o controle da sua única instância. A classe pode garantir que nenhuma outra instância seja criada (pela interceptação das solicitações para criação de novos objetos), bem como pode fornecer um meio para acessar sua única instância. Este é o padrão Singleton.

### Aplicabilidade
Use o padrão Singleton quando:
- for preciso haver apenas uma instância de uma classe, e essa instância tiver que dar  acesso aos clientes através de um ponto  bem conhecido; 
- a única instância tiver de ser extensível através de subclasses, possibilitando aos clientes usar uma instância estendida sem alterar o seu código.
