
# Megaman API

![Megaman API](https://vignette.wikia.nocookie.net/megaman/images/2/22/Cutman.png)

Megaman API é uma aplicação backend desenvolvida em `.NET Core 3.1`, que fornece informações sobre os bosses do universo Megaman. A API retorna dados no formato JSON com detalhes como ID, código, nome, HP e uma imagem ilustrativa de cada boss.

---

## Exemplo de Resposta JSON
```json
{
  "Id": 1,
  "Code": "DLN/DRN-003",
  "Name": "Cutman",
  "HP": 150,
  "Picture": "https://vignette.wikia.nocookie.net/megaman/images/2/22/Cutman.png"
}
```

---

## Endpoints

### `GET /api/v1/robots`
Retorna a lista de todos os robôs.

**Resposta:**
- 200 OK: Retorna uma lista de objetos `RobotReadDTO`.

### `GET /api/v1/robots/{id}`
Retorna as informações de um robô específico pelo seu ID.

**Parâmetro:**
- `id`: Inteiro que representa o ID do robô.

**Resposta:**
- 200 OK: Retorna o objeto `RobotReadDTO`.
- 404 Not Found: Retorna uma mensagem de erro `"Nenhum robo encontrado"`.

### `POST /api/v1/robots`
Endpoint para criar um novo robô. (Ainda em desenvolvimento.)

---

## Estrutura do Projeto

```
.vs
.vscode
bin
Controllers
Database
middlewares
Models
obj
Properties
Services
appsettings.Development.json
appsettings.json  
global.json
MegamanApi.csproj  
MegamanApi.sln
Program.cs
Startup.cs
```

### Descrição das Pastas e Arquivos
- **Controllers**: Contém os controladores responsáveis por definir os endpoints da API.
- **Database**: Gerenciamento de conexões e configurações relacionadas ao banco de dados.
- **middlewares**: Middlewares personalizados para tratamento de requisições.
- **Models**: Modelos de dados que representam os objetos da aplicação.
- **Services**: Contém a lógica de negócios e serviços da aplicação.
- **Program.cs**: Ponto de entrada da aplicação.
- **Startup.cs**: Configuração da aplicação, incluindo serviços e middlewares.

---

## Tecnologias Utilizadas
- **.NET Core 3.1**: Framework para construção de aplicações web modernas e de alto desempenho. [Visite a documentação oficial](https://docs.microsoft.com/pt-br/dotnet/core/)
- **Entity Framework Core 3.1**: ORM para trabalhar com bancos de dados relacionais usando .NET. [Documentação oficial](https://docs.microsoft.com/pt-br/ef/core/)
- **Newtonsoft.Json 12.0.2**: Biblioteca para manipulação de JSON em .NET. [Documentação oficial](https://www.newtonsoft.com/json)

---

## Dependências do Projeto

| Dependência                           | Versão   | Link                                            |
|----------------------------------------|----------|-------------------------------------------------|
| Microsoft.EntityFrameworkCore           | 3.1.8    | [Documentação](https://docs.microsoft.com/pt-br/ef/core/) |
| Microsoft.EntityFrameworkCore.Design    | 3.1.8    | [Documentação](https://docs.microsoft.com/pt-br/ef/core/) |
| Microsoft.EntityFrameworkCore.SqlServer | 3.1.8    | [Documentação](https://docs.microsoft.com/pt-br/ef/core/providers/sql-server/) |
| Newtonsoft.Json                         | 12.0.2   | [Documentação](https://www.newtonsoft.com/json) |

---

## Como Executar o Projeto

### Pré-requisitos
- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- SQL Server (para armazenamento dos dados)
- Visual Studio ou qualquer editor de texto compatível com `.NET`

### Passos para execução
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```
2. Navegue até a pasta do projeto:
   ```bash
   cd MegamanApi
   ```
3. Restaure as dependências:
   ```bash
   dotnet restore
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```

### Executando em Ambiente de Desenvolvimento
O arquivo `appsettings.Development.json` contém as configurações específicas para o ambiente de desenvolvimento. Certifique-se de que seu banco de dados esteja configurado corretamente.

---

## Contribuição
Sinta-se à vontade para contribuir com o projeto através de _Pull Requests_. Todas as sugestões são bem-vindas!

---

## Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais informações.
