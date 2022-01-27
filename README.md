# ECommerce API

Based on a challenge. ITs project was made on .NET CORE 5.0 Web Api.

Example of Many to Many, one to many using EF ORM, Repository Pattern, SOLID Concepts,
JWT Token Gen.

This uses SQL SERVER Driver(but easlity changeable donwload the proper EF extension).

## Steps to run

- Download .NET CORE SDK 5.0
- Download a instance of a proper instance of SQL SERVER, and get its string connection 
- Change String connection on appsettings.json
- update-database command to apply the migrations (already has a seed)
- dotnet run


## Next Improvements

- Crate a Separate Project for User Login and authorization
- Create Rich Domain (with Fluent Validation, Domains Exceptions)
- Crate Unit Tests
- Uses a service intead of repository injection on auth controller
- Create ad standardize custom controllers responses (e.g OkObjectResult)

## Next Goals

- Use Dapper ORM
- Use Identity
- Use Other DB (Postgrees, Cosmos)
