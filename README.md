
# Cep Brasil

Um projeto que contém uma lista vasta de CEP do Brasil. Através desse projeto você encontrara um batch para dar carga nas tabelas do seu banco de dados e uma API que retorna o endereço com base em um CEP fornecido.
## O projeto é dividido em três áreas

- Scripts para SQL Server
- Batch para dar carga nas tabelas
- Web Api para obter o endereço com base no CEP informado.
## Variáveis de Ambiente

Esse projeto faz uso de variáveis de ambiente para uso da conexão com o banco de dados.

*Para executar esse projeto você precisara criar uma variável de ambiente com o nome abaixo e seta as informações para acessar sua base de dados*

`ConnectionStrings:CepBrasil`


## Como Executar o Projeto

#### 1. Criar o banco de dados

Execute o script **Create Table.sql** presente na pasta **.SCRIPTS**.

*O script irá criar o banco de dados e todas as tabelas necessárias para uso da aplicação.*

#### 2. Alimentando as tabelas

Execute o projeto **CreateBase** presente na **solução** para que ele alimente todas as tabelas automaticamente.

*Você recebera uma mensagem para cada tabela que for alimentada.*

#### 3. Executando a API

Após executar as etapas anteriores a API estará pronta para uso. Basta executar o projeto da API e aproveitar.

## Autor

- [@Daniel Moura](https://github.com/dmodesigner/)
## Licença

Esse projeto é oferecido sobre uso da licença MIT. Sendo livre seu uso pessoal ou comercial.

Sendo oferecido sem garantias e de sua total responsabilidade seu uso.

Para maiores detalhes consulte o arquivo de [licença](https://github.com/dmodesigner/Exkyn.Cep/blob/main/LICENSE.txt).