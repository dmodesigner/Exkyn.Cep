# CEP Brasil API

API REST para consulta de CEPs, estados, cidades e bairros do Brasil. Disponibiliza endpoints para busca de dados de localidades brasileiras via HTTP.

## Sumário

- [Sobre](#sobre)
- [Variáveis de Ambiente](#variáveis-de-ambiente)
- [Como Executar](#como-executar)
- [Versão Online](#versão-online)
- [Documentação da API](#documentação-da-api)
- [Autor](#autor)
- [Licença](#licença)

## Sobre

Esse projeto tem como objetivo fornecer uma API pública para consulta de informações de localidades brasileiras, como estados, cidades, bairros e CEPs.

## Variáveis de Ambiente

Antes de executar o projeto, configure a seguinte variável de ambiente com sua string de conexão:

```
ConnectionStrings:CepBrasil=SuaStringDeConexaoAqui
```

## Como Executar

1. **Criar Banco de Dados**\
   Utilize o projeto [Exkyn.Cep.CreateDataBase](https://github.com/dmodesigner/Exkyn.Cep.CreateDataBase) para gerar as estruturas necessárias no banco.

2. **Configurar Variáveis de Ambiente**\
   Defina a string de conexão conforme informado acima.

3. **Executar a API**\
   Abra o projeto em seu editor (Visual Studio ou VS Code) e inicie a aplicação.

## Versão Online

A API está disponível em produção no endereço:

[https://cep.exkyn.com.br](https://cep.exkyn.com.br)

Consulte os endpoints conforme descrito na [Documentação da API](./API.md).

## Documentação da API

Veja o detalhamento completo no arquivo [API.md](./API.md).

## Autor

- Criado por Daniel Moura
[Github](https://github.com/dmodesigner/) | [Linkedin](https://br.linkedin.com/in/danieldmo)

## Licença

Distribuído sob a licença MIT.\
Para mais informações, consulte o [arquivo de licença](https://github.com/dmodesigner/Exkyn.Cep/blob/main/LICENSE.txt).

---