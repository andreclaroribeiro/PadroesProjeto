# Chain of Responsibility

### Intenção
Evitar o acoplamento do remetente de uma solicitação ao seu receptor, ao dar a mais de um objeto a oportunidade de tratar a solicitação. Encadear os objetos receptores, passando a solicitação ao longo da cadeia até que um objeto a trate.

### Motivação
Considere um recurso de help sensível ao contexto para uma interface gráfica de usuário. O usuário pode obter informação de ajuda em qualquer parte da interface simplesmente pressionando o botão do mouse sobre ela. A ajuda que é fornecida depende da parte da interface que é selecionada e do seu contexto; por exemplo, um botão numa caixa de diálogo pode ter uma informação de ajuda diferente da de um botão similar na janela principal. Se não houver uma informação específica de ajuda para aquela parte da interface, então o sistema de ajuda deveria exibir uma mensagem de ajuda mais genérica sobre o contexto imediato – por exemplo, a caixa de diálogo como um todo. 
Daí ser natural organizar a informação de ajuda de acordo com a sua generalidade – do mais específico para o mais genérico. Além do mais, está claro que uma solicitação de ajuda é tratada por um entre vários objetos da interface do usuário; qual objeto depende do contexto e de quão específica é a ajuda disponível. 
O problema aqui é que o objeto que na prática fornece a ajuda não é conhecido explicitamente pelo objeto (por exemplo, o botão) que inicia a solicitação de ajuda. O que necessitamos é de uma maneira de desacoplar o botão que inicia a solicitação de ajuda dos objetos que podem fornecer informação de ajuda. O padrão Chain of Responsibility define como isso acontece.
A idéia desse padrão é desacoplar remetentes e receptores fornecendo a múltiplos objetos a oportunidade de tratar uma solicitação. A solicitação é passada ao longo de uma cadeia de objetos até que um deles a trate.

### Aplicabilidade
Utilize Chain of Responsibility quando:
- mais de um objeto pode tratar uma solicitação e o objeto que a tratará não conhecido a priori. O objeto que trata a solicitação deve ser escolhido automaticamente; 
- você quer emitir uma solicitação para um dentre vários objetos, sem especificar explicitamente o receptor; 
- o conjunto de objetos que pode tratar uma solicitação deveria ser especificado dinamicamente.
