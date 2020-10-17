# Arquitetura
src
    📂|- Controllers
    📂|- Services
    📂|- Database
        📂|- DTOs
        📂|- EntityFramework
        📂|- Repositories
    📂|- Middlewares
    📂|- Models

# Padronização:
- Controllers no plural
- Models no singular

# Services lifetimes
- AddSingleton
    - O Mesmo para todas Requisições
- AddScoped
    - Criado um para cada client request
- Transient
    - Nova instancia é criada toda vez

# Pontos importantes
- Sempre dependa de contratos, nunca de implementação

parei em [2h 44m 15s](https://www.youtube.com/watch?v=fmvcAzHpsk8&t=7454s)



# Adicionado migrations com:
dotnet ef migrations add  InitialMigration -o Database/Entity/Migrations

# Sobre Data Bindings:
https://docs.microsoft.com/en-us/aspnet/core/mvc/advanced/custom-model-binding?view=aspnetcore-3.1

# Sobre testes
- Crie um projeto de testes com: 
        dotnet new mstest -o NetCoreTesting.Tests

- Referencia no projeto principal com:
        dotnet add reference ..\NetCoreTesting.Core\NetCoreTesting.Core.csproj.

- adicione:
- dotnet add package Microsoft.VisualStudio.QualityTools.UnitTestFramework --version 11.0.50727.1