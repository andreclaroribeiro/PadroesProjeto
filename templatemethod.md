# Template Method

### Intenção
Definir o esqueleto de um algoritmo em uma operação, postergando alguns passos para as subclasses. Template Method permite que subclasses redefinam certos passos de um algoritmo sem mudar a estrutura do mesmo.

### Motivação
Considere um framework para aplicações que fornece as classes Application e Document. A classe Application é responsável por abrir documentos existentes armazenados num formato externo, tal como um arquivo. Um objeto Document representa a informação num documento, depois que ela foi lida do arquivo. 
As aplicações construídas com o framework podem criar subclasses de Application e Document para atender necessidades específicas. Por exemplo, uma aplicação de desenho define as subclasses DrawApplication e DrawDocument; uma aplicação de planilha define as subclasses SpreadsheetApplication e SpreadsheetDocument.

### Aplicabilidade
O padrão Template Method pode ser usado:
- para implementar as partes invariantes de um algoritmo uma só vez e deixar para as subclasses a implementação do comportamento que pode variar. 
- quando o comportamento comum entre subclasses deve ser fatorado e concentrado numa classe comum para evitar a duplicação de código. Este é um bom exemplo de “refatorar para generalizar”, conforme descrito por Opdyke e Johnson [OJ93]. Primeiramente, você identifica as diferenças no código existente e então separa as diferenças em novas operações. Por fim, você substitui o código que apresentava as diferenças por um método-template que chama uma dessas novas operações.
- para controlar extensões de subclasses. Você pode definir um método-template que chama operações “gancho” (ver Conseqüências) em pontos específicos, desta forma permitindo extensões somente nesses pontos.

