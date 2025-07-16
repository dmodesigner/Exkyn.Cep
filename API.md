# API.md

# Documentação da API - CEP Brasil

## Endpoints

### Obter Todos os Estados

```http
GET /estado
```

#### Resposta:

```json
{
    "success": true,
    "statusCode": 200,
    "list": [
        { "stateID": 1, "fu": "AC", "state": "Acre" },
        { "stateID": 2, "fu": "AL", "state": "Alagoas" }
        // ... demais estados
    ]
}
```

---

### Obter Cidades por ID do Estado

```http
GET /cidade/{estadoID}
```

| Parâmetro | Tipo | Descrição    |
| --------- | ---- | ------------ |
| estadoID  | int  | ID do estado |

#### Resposta:

```json
{
    "success": true,
    "statusCode": 200,
    "list": [
        { "cityID": 1, "city": "Acrelândia", "zipCode": "69945000" }
    ]
}
```

---

### Obter Cidades por UF

```http
GET /cidade/buscar/{uf}
```

| Parâmetro | Tipo   | Descrição       |
| --------- | ------ | --------------- |
| uf        | string | Sigla do estado |

---

### Obter Bairros por EstadoID e CidadeID

```http
GET /bairro/{estadoID}/{cidadeID}
```

| Parâmetro | Tipo | Descrição    |
| --------- | ---- | ------------ |
| estadoID  | int  | ID do estado |
| cidadeID  | int  | ID da cidade |

---

### Obter Bairros por UF e Nome da Cidade

```http
GET /bairro/{uf}/{cidade}
```

| Parâmetro | Tipo   | Descrição       |
| --------- | ------ | --------------- |
| uf        | string | Sigla do estado |
| cidade    | string | Nome da cidade  |

---

### Buscar Endereço por CEP

```http
GET /endereco/busca/{cep}
```

| Parâmetro | Tipo   | Descrição                            |
| --------- | ------ | ------------------------------------ |
| cep       | string | CEP no formato 99999-999 ou 99999999 |

#### Exemplo de Resposta:

```json
{
    "success": true,
    "statusCode": 200,
    "object": {
        "zipCode": "03510040",
        "address": "Rua Doutor Edgar Garcia Vieira",
        "city": "São Paulo",
        "state": "São Paulo",
        "fu": "SP"
    }
}
```

---

### Buscar CEP por Nome de Logradouro

```http
GET /endereco/buscar/cep/{logradouro}
```

| Parâmetro  | Tipo   | Descrição                    |
| ---------- | ------ | ---------------------------- |
| logradouro | string | Nome ou parte do nome da rua |

---

## Observação

As respostas padrão seguem o formato:

```json
{
    "success": true,
    "statusCode": 200,
    "message": null,
    "object": { },
    "list": [ ]
}
```

