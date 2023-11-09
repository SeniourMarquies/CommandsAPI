
# CommandsAPI - Restful Web API
# Overview

This project is a RESTful web API built using ASP.NET Core and the following technologies and techniques:

- MVC Pattern
- DataAnnotations
- DTOs
- AutoMapper
- PostgresSql
- EF Core
- Asp.netCore NewtonsoftJson
- Asp.netCore JsonPatch
- Routing
- Swagger for documentation

The API provides endpoints for creating, reading, updating, and deleting commands.
## Installation

    

    1. Clone the repository:

```bash
  git clone https://github.com/SeniourMarquies/CommandsAPI.git
```

    2. Restore the NuGet packages:


```bash
 cd CommandsAPI/
dotnet restore
```
    3. Run the API:

```bash
dotnet run
```

# Endpoints

The API provides the following endpoints:

- GET /api/commands: Get all commands
- GET /api/commands/{id}: Get a specific command by ID
- PUT /api/commands/{id}: Update an existing command
- DELETE /api/commands/{id}: Delete a specific command

For detailed documentation on the RESTful API, refer to the generated Swagger documentation. The documentation provides comprehensive information on endpoints, data models, authentication requirements, and usage instructions.


![Uygulama Ekran Görüntüsü](https://github.com/SeniourMarquies/CommandsAPI/blob/master/Documentation.png)


# Documentation
The API is documented using Swagger. To view the documentation, open the following URL in your web browser:

```bash
https://localhost:7156/index.html
```









