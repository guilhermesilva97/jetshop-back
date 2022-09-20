# jetshop-back

.:: Instruções para rodar o projeto ::.

1 - Executar as querys localizadas no arquivo "QuerySQL.sql" no banco de dados.

2 - Apontar o app settings da API para a nova instância do banco de dados que será usado.


.:: Observações do projeto ::.

- Optei por utilizar link de imagens, ao invés de utilizar um array de bytes (para ganhar tempo na criação).
- Os erros estão sendo tratados de forma genérica, e não está sendo individualmente trabalhados (para ganhar tempo).
- Optei por não utilizar uma camada Service no projeto pois não achei necessário devido a complexidade, mas posteriomente poderia ser implatada juntamente com UnitOfWork ou outras tecnologias.
