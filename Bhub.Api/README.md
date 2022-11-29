# BHub

Projeto teste na sele��o de candidatos na BHub

## Features
 - [x] Cria��o de API com ASP.Net 6
 - [x] Interfaces e inje��o de dependencia com Asp.Net 6(https://dotnet.microsoft.com/en-us/download/dotnet/6.0) 
 - [x] Documenta��o com [Swagger](https://swagger.io/)
 - [x] Ferramentas de Testes:
	- [x] [X-Unit] (https://xunit.net/)
	- [x] [Moq] (https://documentation.help/Moq/)
	- [x] [FluentAssertions] (https://fluentassertions.com/)
## Como executar
### 1. Utilizando Docker

Ap�s Instalar o [Docker], execute no terminal na raiz da solution:
docker-compose up 
A API estar� dispon�vel em localhost:5000/swagger.

### 2. Sem utilizar Docker

Ser� necess�rio ter .net 6 intalado. Com isso pronto, execute na ra�z do projeto:

dotnet run

O servidor estar� dispon�vel em localhost:7001.

### 3. Executando testes
Execute na raiz do projeto de teste:

dotnet test