# Easy Dinâmicas

## Endereço de produção

O sistema está hospedado no heroku e você pode acessá-lo em
<https://easy-dinamicas.herokuapp.com/>.

## Pré-requisitos

1. .NET Core 2.1 <https://www.microsoft.com/net/download/dotnet-core/2.1>
1. MySQL <https://dev.mysql.com/downloads/mysql/>

## Preparando o ambiente local

Depois de clonar o projeto e abrir o projeto no seu editor (Visual Studio, 
Visual Studio Code, etc), o primeiro passo será configurar o banco de dados.
Em seu MySQL, crie uma base chamada `Dinamicas`. Depois, abra o arquivo 
`appsettings.Development.json` e altere as credenciais de usuário e senha 
de acordo com o seu banco de dados. Por fim, precisamos executar as *migrations*
para criar as tabelas, através de um dos seguintes comandos:

* No Visual Studio ou PowerShell: `Update-Database`
* No console usando .NET CLI: `dotnet ef database update`

## Executando o projeto

Caso você esteja usando o Visual Studio, você pode subir o servidor apenas
clicando no botão de *play*  ou apertando o botão `F5`. 

Agora se você estiver usando o .NET CLI, abra o terminar e na pasta do projeto
executar o comando `dotnet run`.

Você pode acessar o sistema localmente no endereço <https://localhost:5001/>