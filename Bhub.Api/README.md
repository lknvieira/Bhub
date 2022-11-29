# BHub

Projeto teste na seleção de candidatos na BHub

## Features
 - [x] Criação de API com ASP.Net 6
 - [x] Interfaces e injeção de dependencia com Asp.Net 6(https://dotnet.microsoft.com/en-us/download/dotnet/6.0) 
 - [x] Documentação com [Swagger](https://swagger.io/)
 - [x] Ferramentas de Testes:
	- [x] [X-Unit] (https://xunit.net/)
	- [x] [Moq] (https://documentation.help/Moq/)
	- [x] [FluentAssertions] (https://fluentassertions.com/)
## Como executar
### 1. Utilizando Docker

Após Instalar o [Docker], execute no terminal na raiz da solution:
docker-compose up 
A API estará disponível em localhost:5000/swagger.

### 2. Sem utilizar Docker

Será necessário ter .net 6 intalado. Com isso pronto, execute na raíz do projeto:

dotnet run

O servidor estará disponível em localhost:7001.

### 3. Executando testes
Execute na raiz do projeto de teste:

dotnet test