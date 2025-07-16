# Cep Brasil API 🇧🇷

Uma API RESTful completa para consulta de endereços, cidades, estados e bairros do Brasil. O projeto oferece diversos endpoints para buscar informações detalhadas a partir de um CEP, nome de logradouro, ou através de filtros por estado e cidade.

## Sumário

- [Funcionalidades](#funcionalidades)
- [Pré-requisitos](#pré-requisitos)
- [Configuração](#configuração)
- [Executando o Projeto](#executando-o-projeto)
- [Versão Online](#versão-online)
- [Documentação da API](#documentação-da-api)
- [Autor](#autor)
- [Licença](#licença)

## ✨ Funcionalidades

- Consulta de endereço completo por CEP.

- Busca de CEP por nome de logradouro (rua, avenida, etc.).

- Listagem de todos os estados brasileiros.

- Listagem de cidades por estado (utilizando ID ou a sigla UF).

- Listagem de bairros por cidade (utilizando IDs ou nomes).

- Disponibilização de uma versão online para testes e demonstração.

## 📋 Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:

- Git

- Um SDK .NET compatível (ex: .NET 6, 7 ou 8).

- Um banco de dados SQL Server da Microsoft para armazenar os dados.

- Um editor de código de sua preferência, como VS Code ou Visual Studio.

## ⚙️ Configuração

Para executar o projeto localmente, siga os passos abaixo:

1. **Variáveis de Ambiente**\
Este projeto utiliza uma variável de ambiente para a string de conexão com o banco de dados.

Crie uma variável de ambiente chamada ConnectionStrings:CepBrasil e atribua a ela a sua string de conexão.

```
ConnectionStrings:CepBrasil=SuaStringDeConexaoAqui
```
Caso seja de sua preferência pode ser configurado no arquivo de configurações do .NET *appsettings.json*

```json
{
  "ConnectionStrings": {
    "CepBrasil": "Server=localhost;Database=CepBrasil;User Id=sa;Password=SuaSenhaAqui;"
  }
}
```

2. **Banco de Dados**\
Para criar e popular o banco de dados, execute o batch disponível no repositório complementar: [Exkyn.Cep.CreateDataBase](https://github.com/dmodesigner/Exkyn.Cep.CreateDataBase)

## 🚀 Executando o Projeto

Com o ambiente configurado, siga estes passos:

1. **Clone o repositório:**\
   ```bash
   git clone https://github.com/dmodesigner/Exkyn.Cep.git
   ```

2. **Navegue até o diretório do projeto**\
```bash
   cd seu-repositorio
```

3. **Execute a API:**\
Abra o projeto no VS Code e execute o comando:

```bash
dotnet run
```

Ou no Visual Studio, clique em "Iniciar" ou pressione `F5`.

## 🌐 Versão Online (Demonstração)

Caso prefira ver o projeto em execução sem a necessidade de configuração local, acesse a API através da URL base abaixo. Complete a URL com um dos endpoints descritos na documentação.

URL Base: ***[https://cep.exkyn.com.br](https://cep.exkyn.com.br)***

## 📖 Documentação da API

A seguir estão os endpoints disponíveis na API. Veja o detalhamento completo no arquivo [API.md](./API.md).

### Estados

Retorna todos os estados brasileiros

```http
GET /estado
```

```json
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        { "stateID": 1, "fu": "AC", "state": "Acre" },
        { "stateID": 2, "fu": "AL", "state": "Alagoas" },
        { "stateID": 3, "fu": "AP", "state": "Amapá" }
         // ... demais estados
    ]
}
```

### Cidades

Retorna todas as cidades de um estado

```http
GET /cidade/{estadoID}
GET /cidade/buscar/{uf}
```

| Parâmetro | Tipo   | Descrição       |
| --------- | ------ | --------------  |
| estadoID  | int    | ID do estado    |
| uf        | string | Sigla do estado |

```json
{
    "success": true,
    "statusCode": 200,
    "list": [
        { "cityID": 1, "stateID": 1, "zipCode": "69945000", "city": "Acrelândia", "capital": false },
        { "cityID": 2, "stateID": 1, "zipCode": "69935000", "city": "Assis Brasil", "capital": false },
        { "cityID": 16, "stateID": 1, "zipCode": "0000NULL", "city": "Rio Branco", "capital": true }
        // ... demais cidades
    ]
}
```

## 👨‍💻 Autor

Criado por Daniel Moura

[Github](https://github.com/dmodesigner/) | [Linkedin](https://br.linkedin.com/in/danieldmo)

## 📜 Licença

Este projeto é distribuído sob a licença MIT. Isso significa que você tem total liberdade para usar, copiar, modificar e distribuir o projeto, seja para uso pessoal ou comercial.

O software é fornecido "COMO ESTÁ", sem garantias de qualquer tipo. Para mais detalhes, consulte o [arquivo LICENSE](https://github.com/dmodesigner/Exkyn.Cep/blob/main/LICENSE.txt) no repositório.
