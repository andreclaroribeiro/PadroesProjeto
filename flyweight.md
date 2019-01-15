# Flyweight

### Intenção
Usar compartilhamento para suportar eficientemente grandes quantidades de  objetos de granularidade fina.

### Motivação
Algumas aplicações poderiam se beneficiar da sua estruturação em  objetos em todo o seu projeto, porém, uma implementação ingênua seria proibitivamente cara. 
Por exemplo, a maioria das implementações de editores de documentos tem recursos para formatação e edição de textos que são, até certo ponto, modularizados. Editores de documento orientados a objetos usam objetos para representar elementos embutidos, tais como tabelas e figuras. No entanto, normalmente eles não chegam a usar objetos para cada caractere do documento, mesmo que, se assim o fizessem, promovessem ao máximo a flexibilidade na aplicação. Caracteres e elementos embutidos poderiam, então, ser tratados uniformemente com relação à maneira como são desenhados e formatados. A aplicação poderia ser estendida para suportar novos conjuntos de caracteres sem afetar outras funcionalidades. A estrutura dos objetos da aplicação poderia imitar a estrutura física do documento. O diagrama da página 188 mostra como o editor de documentos pode usar objetos para representar caracteres. 
O aspecto negativo de tal estruturação é o seu custo. Mesmo documentos de tamanhos moderados podem requerer centenas de milhares de objetos-caracteres, o que consumirá uma grande quantidade de memória, podendo incorrer num custo inaceitável em tempo de execução. O padrão Flyweight descreve como compartilhar objetos para permitir o seu uso em granularidades finas sem incorrer num custo proibitivo.

### Aplicabilidade
A eficiência do padrão Flyweight depende muito de como e onde ele é usado. Aplique o padrão Flyweight quando todas as condições a seguir forem verdadeiras:
- uma aplicação utiliza um grande número de objetos; 
- os custos de armazenamento são altos por causa da grande quantidade de objetos; 
- a maioria dos estados de objetos pode ser tornada extrínseca; 
- muitos grupos de objetos podem ser substituídos por relativamente poucos objetos compartilhados, uma vez que estados extrínsecos são removidos; 
- a aplicação não depende da identidade dos objetos. Uma vez que objetos Flyweights podem ser compartilhados, testes de identidade produzirão o valor verdadeiro para objetos conceitualmente distintos.
