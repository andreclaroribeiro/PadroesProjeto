# Memento

### Intenção
Sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneira que o objeto possa ser restaurado para esse estado mais tarde.

### Também conhecido como
Token

### Motivação
Algumas vezes é necessário registrar o estado interno de um objeto. Isso é necessário na implementação de mecanismos de checkpoints e de desfazer (operações) que permitem aos usuários retroceder de operações-tentativas ou recuperar-se de erros. Você deve salvar informação de estado em algum lugar, de modo que possa restaurar os objetos aos seus estados prévios. Porém, objetos normalmente encapsulam parte ou todos os seus estados, tornando-os inacessíveis a outros objetos e impossíveis de serem salvos externamente. Expor este estado violaria o encapsulamento, o que pode comprometer a confiabilidade e a extensibilidade da aplicação.

### Aplicabilidade
Use o padrão Memento quando:
- um instantâneo de (alguma porção do) estado de um objeto deve ser salvo de maneira que possa ser restaurado para esse estado mais tarde;
- uma interface direta para obtenção do estado exporia detalhes de implementação e romperia o encapsulamento do objeto.
