# Documentação da API - CEP Brasil

## Endpoints

#### Retorna todos os estados brasileiros

```http
  GET /estado
```
#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "stateID": 1,
            "fu": "AC",
            "state": "Acre"
        },
        {
            "stateID": 2,
            "fu": "AL",
            "state": "Alagoas"
        },
        {
            "stateID": 3,
            "fu": "AP",
            "state": "Amapá"
        },
        {
            "stateID": 4,
            "fu": "AM",
            "state": "Amazonas"
        },
        {
            "stateID": 5,
            "fu": "BA",
            "state": "Bahia"
        },
        {
            "stateID": 6,
            "fu": "CE",
            "state": "Ceará"
        },
        {
            "stateID": 7,
            "fu": "DF",
            "state": "Distrito Federal"
        },
        {
            "stateID": 8,
            "fu": "ES",
            "state": "Espírito Santo"
        },
        {
            "stateID": 10,
            "fu": "GO",
            "state": "Goiás"
        },
        {
            "stateID": 11,
            "fu": "MA",
            "state": "Maranhão"
        },
        {
            "stateID": 12,
            "fu": "MT",
            "state": "Mato Grosso"
        },
        {
            "stateID": 13,
            "fu": "MS",
            "state": "Mato Grosso do Sul"
        },
        {
            "stateID": 14,
            "fu": "MG",
            "state": "Minas Gerais"
        },
        {
            "stateID": 15,
            "fu": "PA",
            "state": "Pará"
        },
        {
            "stateID": 16,
            "fu": "PB",
            "state": "Paraíba"
        },
        {
            "stateID": 17,
            "fu": "PR",
            "state": "Paraná"
        },
        {
            "stateID": 18,
            "fu": "PE",
            "state": "Pernambuco"
        },
        {
            "stateID": 19,
            "fu": "PI",
            "state": "Piauí"
        },
        {
            "stateID": 20,
            "fu": "RJ",
            "state": "Rio de Janeiro"
        },
        {
            "stateID": 21,
            "fu": "RN",
            "state": "Rio Grande do Norte"
        },
        {
            "stateID": 22,
            "fu": "RS",
            "state": "Rio Grande do Sul"
        },
        {
            "stateID": 23,
            "fu": "RO",
            "state": "Rondônia"
        },
        {
            "stateID": 9,
            "fu": "RR",
            "state": "Roraima"
        },
        {
            "stateID": 25,
            "fu": "SC",
            "state": "Santa Catarina"
        },
        {
            "stateID": 26,
            "fu": "SP",
            "state": "São Paulo"
        },
        {
            "stateID": 27,
            "fu": "SE",
            "state": "Sergipe"
        },
        {
            "stateID": 24,
            "fu": "TO",
            "state": "Tocantins"
        }
    ]
}
```

#### Retorna todas as cidades com base em um estado brasileiro

```http
  GET /cidade/{estadoID}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `estadoID`      | `int` | **Obrigatório**. O ID da cidade que deseja obter as informações |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "cityID": 1,
            "stateID": 1,
            "zipCode": "69945000",
            "city": "Acrelândia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 2,
            "stateID": 1,
            "zipCode": "69935000",
            "city": "Assis Brasil",
            "capital": false,
            "states": null
        },
        {
            "cityID": 3,
            "stateID": 1,
            "zipCode": "69932000",
            "city": "Brasiléia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 4,
            "stateID": 1,
            "zipCode": "69926000",
            "city": "Bujari",
            "capital": false,
            "states": null
        },
        {
            "cityID": 5,
            "stateID": 1,
            "zipCode": "69931000",
            "city": "Capixaba",
            "capital": false,
            "states": null
        },
        {
            "cityID": 6,
            "stateID": 1,
            "zipCode": "69980000",
            "city": "Cruzeiro do Sul",
            "capital": false,
            "states": null
        },
        {
            "cityID": 7,
            "stateID": 1,
            "zipCode": "69934000",
            "city": "Epitaciolândia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 8,
            "stateID": 1,
            "zipCode": "69960000",
            "city": "Feijó",
            "capital": false,
            "states": null
        },
        {
            "cityID": 9,
            "stateID": 1,
            "zipCode": "69975000",
            "city": "Jordão",
            "capital": false,
            "states": null
        },
        {
            "cityID": 10,
            "stateID": 1,
            "zipCode": "69990000",
            "city": "Mâncio Lima",
            "capital": false,
            "states": null
        },
        {
            "cityID": 11,
            "stateID": 1,
            "zipCode": "69950000",
            "city": "Manoel Urbano",
            "capital": false,
            "states": null
        },
        {
            "cityID": 12,
            "stateID": 1,
            "zipCode": "69983000",
            "city": "Marechal Thaumaturgo",
            "capital": false,
            "states": null
        },
        {
            "cityID": 13,
            "stateID": 1,
            "zipCode": "69928000",
            "city": "Plácido de Castro",
            "capital": false,
            "states": null
        },
        {
            "cityID": 14,
            "stateID": 1,
            "zipCode": "69927000",
            "city": "Porto Acre",
            "capital": false,
            "states": null
        },
        {
            "cityID": 15,
            "stateID": 1,
            "zipCode": "69982000",
            "city": "Porto Walter",
            "capital": false,
            "states": null
        },
        {
            "cityID": 16,
            "stateID": 1,
            "zipCode": "0000NULL",
            "city": "Rio Branco",
            "capital": true,
            "states": null
        },
        {
            "cityID": 17,
            "stateID": 1,
            "zipCode": "69985000",
            "city": "Rodrigues Alves",
            "capital": false,
            "states": null
        },
        {
            "cityID": 18,
            "stateID": 1,
            "zipCode": "69955000",
            "city": "Santa Rosa do Purus",
            "capital": false,
            "states": null
        },
        {
            "cityID": 19,
            "stateID": 1,
            "zipCode": "69940000",
            "city": "Sena Madureira",
            "capital": false,
            "states": null
        },
        {
            "cityID": 20,
            "stateID": 1,
            "zipCode": "69925000",
            "city": "Senador Guiomard",
            "capital": false,
            "states": null
        },
        {
            "cityID": 21,
            "stateID": 1,
            "zipCode": "69970000",
            "city": "Tarauacá",
            "capital": false,
            "states": null
        },
        {
            "cityID": 22,
            "stateID": 1,
            "zipCode": "69930000",
            "city": "Xapuri",
            "capital": false,
            "states": null
        },
        {
            "cityID": 9947,
            "stateID": 1,
            "zipCode": "69929000",
            "city": "Campinas",
            "capital": false,
            "states": null
        }
    ]
}
```

#### Retorna todas as cidades com base em um estado brasileiro

```http
  GET /cidade/buscar/{uf}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `uf`      | `string` | **Obrigatório**. A UF da cidade que deseja obter as informações |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "cityID": 1,
            "stateID": 1,
            "zipCode": "69945000",
            "city": "Acrelândia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 2,
            "stateID": 1,
            "zipCode": "69935000",
            "city": "Assis Brasil",
            "capital": false,
            "states": null
        },
        {
            "cityID": 3,
            "stateID": 1,
            "zipCode": "69932000",
            "city": "Brasiléia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 4,
            "stateID": 1,
            "zipCode": "69926000",
            "city": "Bujari",
            "capital": false,
            "states": null
        },
        {
            "cityID": 5,
            "stateID": 1,
            "zipCode": "69931000",
            "city": "Capixaba",
            "capital": false,
            "states": null
        },
        {
            "cityID": 6,
            "stateID": 1,
            "zipCode": "69980000",
            "city": "Cruzeiro do Sul",
            "capital": false,
            "states": null
        },
        {
            "cityID": 7,
            "stateID": 1,
            "zipCode": "69934000",
            "city": "Epitaciolândia",
            "capital": false,
            "states": null
        },
        {
            "cityID": 8,
            "stateID": 1,
            "zipCode": "69960000",
            "city": "Feijó",
            "capital": false,
            "states": null
        },
        {
            "cityID": 9,
            "stateID": 1,
            "zipCode": "69975000",
            "city": "Jordão",
            "capital": false,
            "states": null
        },
        {
            "cityID": 10,
            "stateID": 1,
            "zipCode": "69990000",
            "city": "Mâncio Lima",
            "capital": false,
            "states": null
        },
        {
            "cityID": 11,
            "stateID": 1,
            "zipCode": "69950000",
            "city": "Manoel Urbano",
            "capital": false,
            "states": null
        },
        {
            "cityID": 12,
            "stateID": 1,
            "zipCode": "69983000",
            "city": "Marechal Thaumaturgo",
            "capital": false,
            "states": null
        },
        {
            "cityID": 13,
            "stateID": 1,
            "zipCode": "69928000",
            "city": "Plácido de Castro",
            "capital": false,
            "states": null
        },
        {
            "cityID": 14,
            "stateID": 1,
            "zipCode": "69927000",
            "city": "Porto Acre",
            "capital": false,
            "states": null
        },
        {
            "cityID": 15,
            "stateID": 1,
            "zipCode": "69982000",
            "city": "Porto Walter",
            "capital": false,
            "states": null
        },
        {
            "cityID": 16,
            "stateID": 1,
            "zipCode": "0000NULL",
            "city": "Rio Branco",
            "capital": true,
            "states": null
        },
        {
            "cityID": 17,
            "stateID": 1,
            "zipCode": "69985000",
            "city": "Rodrigues Alves",
            "capital": false,
            "states": null
        },
        {
            "cityID": 18,
            "stateID": 1,
            "zipCode": "69955000",
            "city": "Santa Rosa do Purus",
            "capital": false,
            "states": null
        },
        {
            "cityID": 19,
            "stateID": 1,
            "zipCode": "69940000",
            "city": "Sena Madureira",
            "capital": false,
            "states": null
        },
        {
            "cityID": 20,
            "stateID": 1,
            "zipCode": "69925000",
            "city": "Senador Guiomard",
            "capital": false,
            "states": null
        },
        {
            "cityID": 21,
            "stateID": 1,
            "zipCode": "69970000",
            "city": "Tarauacá",
            "capital": false,
            "states": null
        },
        {
            "cityID": 22,
            "stateID": 1,
            "zipCode": "69930000",
            "city": "Xapuri",
            "capital": false,
            "states": null
        },
        {
            "cityID": 9947,
            "stateID": 1,
            "zipCode": "69929000",
            "city": "Campinas",
            "capital": false,
            "states": null
        }
    ]
}
```

#### Retorna os bairros que pertence a cidade e estado informado

```http
  GET /bairro/{estadoID}/{cidadeID}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `estadoID`      | `int` | **Obrigatório**. O ID do estado  |
| `cidadeID`      | `int` | **Obrigatório**. O ID da cidade  |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "neighborhoodID": 32555,
            "cityID": 1,
            "stateID": 1,
            "neighborhood": "Centro",
            "cities": null,
            "states": null
        }
    ]
}
```

#### Retorna os bairros que pertence a cidade e estado informado

```http
  GET /bairro/{uf}/{cidade}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `uf`      | `string` | **Obrigatório**. A UF do estado  |
| `cidade`      | `string` | **Obrigatório**. O nome da cidade  |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "neighborhoodID": 32555,
            "cityID": 1,
            "stateID": 1,
            "neighborhood": "Centro",
            "cities": null,
            "states": null
        }
    ]
}
```

#### Retorna os dados do CEP informado

```http
  GET /endereco/busca/{cep}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `cep`      | `string` | **Obrigatório**. CEP que deseja buscar as informações no formato 99999-999 ou 99999999  |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": {
        "zipCode": "03510040",
        "address": "Rua Doutor Edgar Garcia Vieira",
        "neighborhood": "Vila Matilde",
        "city": "São Paulo",
        "capital": true,
        "state": "São Paulo",
        "fu": "SP"
    },
    "list": null
}
```

#### Retorna os dados do CEP informado

```http
  GET /endereco/buscar/cep/{logradouro}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `logradouro`      | `string` | **Obrigatório**. Nome da rua ou parte do nome da rua que deseja obter o CEP |

#### Exemplo de resposta

```javascript
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": null,
    "list": [
        {
            "zipCode": "03510040",
            "address": "Rua Doutor Edgar Garcia Vieira",
            "neighborhood": "Vila Matilde",
            "city": "São Paulo",
            "capital": true,
            "state": "São Paulo",
            "fu": "SP"
        },
        {
            "zipCode": "45204105",
            "address": "Rua Edgar Garcia Ribeiro Filho",
            "neighborhood": "São Judas Tadeu",
            "city": "Jequié",
            "capital": false,
            "state": "Bahia",
            "fu": "BA"
        }
    ]
}
```