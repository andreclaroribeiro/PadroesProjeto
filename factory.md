[Home][pghome]

# Abstract Factory

### Intenção
Fornecer uma interface para criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

### Também conhecido como
Kit ou Toolkit

### Motivação
Considere um toolkit para construção de interfaces de usuários que suporte múltiplos estilos de interação (look-and-feel) tais como o Motif e o Presentation Manager. Diferentes estilos de interação definem diferentes apresentações e comportamento para os widgets de uma interface de usuário, tais como barras de rolamento, janelas e botões. Para ser portátil entre vários estilos de aparência, uma aplicação não deve codificar rigidamente seus widgets para um determinado padrão. Instanciando classes específicas de estilo de interação para os widgets pela aplicação toda, torna difícil mudar o estilo no futuro. Podemos resolver esse problema definindo uma classe abstrata WidgetFactory que declara uma interface para criação de cada tipo básico de widget. Existe também uma classe abstrata para cada tipo de widget, e subclasses concretas implementam os widgets para interação. A interface de WidgetFactory tem uma operação que retorna um novo objeto widget para cada classe abstrata de widget. Os clientes chamam estas operações para obter instâncias de widget, mas não têm conhecimento das classes concretas que estão usando. Desta forma, os clientes ficam independentes do padrão de interação usado no momento.

### Aplicabilidade
Use o padrão Abstract Factory quando:
- um sistema deve ser independente de como seus produtos são criados, compostos ou representados; 
- um sistema deve ser configurado como um produto de uma família de múltiplos produtos; 
- uma família de objetos-produto for projetada para ser usada em conjunto, e você necessita garantir esta restrição; 
- você quer fornecer uma biblioteca de classes de produtos e quer revelar somente suas interfaces, não suas implementações.


[pghome]<./readme.md>
