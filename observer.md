# Observer

### Intenção
Definir uma dependência um-para-muitos entre objetos, de maneira que quando um objeto muda de estado todos os seus dependentes são notificados e atualizados automaticamente.

### Também conhecido como
Dependents, Publish-Subscribe

### Motivação
Um efeito colateral comum resultante do particionamento de um sistema em uma coleção de classes cooperantes é a necessidade de manter a consistência entre objetos relacionados. Você não deseja obter consistência tornando as classes fortemente acopladas, porque isso reduz a sua reusabilidade. 

### Aplicabilidade
Use o padrão Observer em qualquer uma das seguintes situações:
- quando uma abstração tem dois aspectos, um dependente do outro. Encapsulando esses aspectos em objetos separados, permite-se variá-los e reutilizá-los independentemente; 
- quando uma mudança em um objeto exige mudanças em outros, e você não sabe quantos objetos necessitam ser mudados; 
- quando um objeto deveria ser capaz de notificar outros objetos sem fazer hipóteses, ou usar informações, sobre quem são esses objetos. Em outras palavras, você não quer que esses objetos sejam fortemente acoplados.
