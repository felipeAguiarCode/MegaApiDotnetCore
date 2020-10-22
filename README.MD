<h1 align="center">
   Api Gamer para estudos
</h1>

<p align="center">
  <img width="660" height="350" src="https://teehunter.com/wp-content/uploads/2015/06/mega-man-t-shirts-banner.jpg">
</p>

</br>
  <p align="center">Api que retorna metadados dos jogos do megaman utilizando ASP.NET CORE</p>
  
<p align="center">
  <a href="#white_check_mark-Features">Features</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#globe_with_meridians-Tecnologias-Implementadas">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#wrench-Como-utilizar">Como Utilizar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Arquitetura">Arquitetura</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-Licença">Licença</a>
</p>


## :white_check_mark: Features

* Web Api construida com Asp.net core API
* Crud utilizando ORM Entity Framework Core
* Utilizado em repository patterns e interfaces para fazer gestão de desacoplamento


## :globe_with_meridians: Tecnologias Implementadas:

Esse projeto foi desenvolvido usando as seguintes tecnologias:

- ASP.NET Core 3.1 (with .NET Core 3.1)
- Entity Framework Core 3.1


## ⚙ Arquitetura

```🌐
src
├── 📂 Controllers      [Rotas para endpoints]
├── 📂 Models           [Modelos do banco de dados]
├── 📂 Services         [Regras de negócio]
├── 📂 Middlwares       [Funções intermediarias pedido HTTP e a resposta final do servidor]
├── 📂 Database         [Estruturas referentes ao banco de dados]
│   ├── 📂 DTOs             [Inputs Models e View Models (Data Transfer Objects)]
│   ├── 📂 EntityFramework  [Arquivos referente ao ORM Entity Framework]
│   │     ├── 📂 Context         [Configurações de contexto do Entity]
│   │     ├── 📂 Migrations      [Migrations para atualização do Banco]
│   ├── 📂 Repositories     [Repository pattern]

🧪Tests [Em construção]
```

## :wrench: Como Utilizar

Clone essa aplicação utilizando o [Git](https://git-scm.com) e siga os próximos passos:

```bash
# 1. Clone esse repositório
$ git clone https://github.com/felipeAguiarCode/MegaApiDotnetCore.git

# 2. Abra o projeto no vs code
Abra o diretório princial no seu vscode utilizando 'code .'

# 3. Faça a restauração das dependências
Utilize o comando 'dotnet restore' para fazer a restauração dos pacotes nuggets

# 4. Rode a aplicação
Use o CMD para executar a API no 'dot.net'
```


## :memo: Licença 
This project is under the MIT license. See the [LICENSE] for more information.


## Autor

| [<img src="https://avatars3.githubusercontent.com/u/37452836?s=96&v=4"><br><sub>Felipe Aguiar</sub>](https://github.com/felipeAguiarCode) |
| :---: |
|[Linkedin](www.linkedin.com/in/felipe-aguiar-047)|
