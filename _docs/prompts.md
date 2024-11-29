contexto:
Este projeto é um projeto de uma api feito em dotnet, para listar os dados dos bosses de megaman, o objetivo principal é ser um backend que fornece jsons no formato abaixo:

```
{
  Id =1,
  Code = "DLN/DRN-003",
  Name = "Cutman",
  HP = 150,
  Picture = "https://vignette.wikia.nocookie.net/megaman/images/2/22/Cutman.png"
}
```

Especificações do projeto:

```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="3.1.8" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.1.8">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.8" />
    <PackageReference Include="Newtonsoft.Json" Version="12.0.2" />
  </ItemGroup>

</Project>
```

os endpoints do projeto são:
namespace Megaman.Controllers

```
{
    //api/v1/robots
    [ApiController]
    [Route("api/v1/robots")]
    public class RobotsController : ControllerBase
    {
        private readonly IRobotServices _services;
        public RobotsController(IRobotServices services)
        {
           _services = services;
        }

        //GET api/robots
        [HttpGet]
        public ActionResult<IEnumerable<RobotReadDTO>> GetAllRobots()
        {
            var robotItems = _services.SearchAll();
            return Ok(robotItems);
        }

        //GET api/v1/robots/{id}
        [HttpGet]
        [Route("{id:int}")]
        public object GetCommandById([FromRoute]int id)
        {
            var robot = _services.SearchById(id);

            if(robot != null)
                return Ok(robot);

                return NotFound(
                        new { message = "Nenhum robo encontrado" }
                );
        }

        //POST api/v1/robots
        [HttpPost]
        public ActionResult RobotSend(){
            return Ok();
        }


    }
}
```

REGRAS:

- Sempre que citar alguma dependência do projeto, deixe ela como hyperlink para a página oficial daquela dependência
- Organize as dependências em uma sessão em formato de tabela

- crie uma estrutura do projeto com base na arvore de pastas abaixo, e crie uma sessão para explicitar as técnicas utilizadas

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
