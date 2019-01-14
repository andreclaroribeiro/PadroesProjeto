# Adapter

### Intenção
Converter a interface de uma classe em outra interface, esperada pelos clientes. O Adapter permite que classes com interfaces incompatíveis trabalhem em conjunto – o que, de outra forma, seria impossível.

### Também conhecido como
Wrapper

### Motivação
Algumas vezes, uma classe de um toolkit, projetada para ser reutilizada não é reutilizável porque sua interface não corresponde à interface específica de um domínio requerida por uma aplicação.

### Aplicabilidade
Use o padrão Adapter quando:
- você quiser usar uma classe existente, mas sua interface não corresponder à interface de que necessita; 
- você quiser criar uma classe reutilizável que coopere com classes não-relacionadas ou não-previstas, ou seja, classes que não necessariamente tenham interfaces compatíveis; 
- (somente para adaptadores de objetos) você precisar usar várias subclasses existentes, porém, for impraticável adaptar essas interfaces criando subclasses para cada uma. Um adaptador de objeto pode adaptar a interface da sua classe-mãe.
