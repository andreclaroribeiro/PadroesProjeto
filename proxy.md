# Proxy

### Intenção
Fornece um substituto (surrogate) ou marcador da localização de outro objeto para controlar o acesso a esse objeto.

### Também conhecido como
Surrogate

### Motivação
Uma razão para controlar o acesso a um objeto é adiar o custo integral de sua criação e inicialização até o momento em que realmente necessitamos usá-lo. Considere um editor de documentos que pode embutir objetos gráficos num documento. Alguns objetos gráficos, tais como grandes imagens “rasterizadas”, podem ser muito caros para serem criados. A abertura de documentos deveria ser rápida, assim, deveríamos evitar a criação, de uma só vez, de todos os objetos caros  quando o documento é aberto. De qualquer forma, isso não é necessário porque nem todos esses objetos estarão visíveis no documento ao mesmo tempo. 
Essas restrições sugerem a criação de tais objetos caros sob demanda, o que, neste caso, ocorre quando uma imagem se torna visível. Mas o que colocamos num documento no lugar da imagem? E como podemos ocultar o fato de que o objeto é criado sob demanda de maneira que não compliquemos a implementação do editor? Por exemplo, essa implementação não deveria produzir impacto sobre o código de apresentação e formatação.
A solução é usar outro objeto, um proxy (procurador), que funciona como um substituto temporário da imagem real. 

### Aplicabilidade
O padrão Proxy é aplicável sempre que há necessidade de uma referência mais versátil, ou sofisticada, do que um simples apontador para um objeto. Aqui apresentamos diversas situações comuns nas quais o padrão Proxy é aplicável:

1. Um remote proxy fornece um representante local para um objeto num espaço de endereçamento diferente. NEXTSTEP[Add94] usa a classe NXProxy para esta finalidade. Coplien [Cop92] chama este tipo de proxy de um “embaixador” (ambassador). 
2. Um virtual proxy cria objetos caros sob demanda. O ImageProxy descrito na seção Motivação é um exemplo de um proxy deste tipo. 
3. Um protection proxy controla o acesso ao objeto original. Os proxies de proteção são úteis quando os objetos devem ter diferentes direitos de acesso. Por exemplo, KernelProxies, no sistema operacional Choices [CIRM93], fornece um acesso protegido aos objetos do sistema operacional. 
4. Um smart reference é um substituto para um simples pointer que executa ações adicionais quando um objeto é acessado. Usos típicos incluem:
- contar o número de referências para o objeto real, de modo que o mesmo possa ser liberado automaticamente quando não houver mais referências (também chamadas de smart pointers [Ede92]); 
- carregar um objeto persistente para a memória quando ele for referenciado pela primeira vez; 
- verificar se o objeto real está bloqueado antes de ser acessado, para assegurar que nenhum outro objeto possa mudá-lo.
