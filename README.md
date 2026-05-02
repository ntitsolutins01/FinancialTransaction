# FinancialTransaction
API responsável por gerar e publicar transações financeiras em tempo real em um cluster Kafka, com produção paralela via threads e compressão

# Clean Architecture Solution Template

[![Build](https://github.com/jasontaylordev/CleanArchitecture/actions/workflows/build.yml/badge.svg)](https://github.com/jasontaylordev/CleanArchitecture/actions/workflows/build.yml)
[![CodeQL](https://github.com/jasontaylordev/CleanArchitecture/actions/workflows/codeql.yml/badge.svg)](https://github.com/jasontaylordev/CleanArchitecture/actions/workflows/codeql.yml)
[![Nuget](https://img.shields.io/nuget/v/Clean.Architecture.Solution.Template?label=NuGet)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template)
[![Nuget](https://img.shields.io/nuget/dt/Clean.Architecture.Solution.Template?label=Downloads)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template)
![Twitter Follow](https://img.shields.io/twitter/follow/jasontaylordev?label=Follow&style=social)

The goal of this template is to provide a straightforward and efficient approach to enterprise application development, leveraging the power of Clean Architecture and ASP.NET Core. Using this template, you can effortlessly create a new app with Angular, React, or Web API only, powered by ASP.NET Core and Aspire. Getting started is easy - simply install the **.NET template** (see below for full details).

If you find this project useful, please give it a star. Thanks! ⭐

## Getting started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) or [Podman](https://podman.io/) (or any OCI-compliant container runtime) — only required when using SQL Server or PostgreSQL. Not required when using SQLite (the default).

## Technologies

* [ASP.NET Core 10](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [Aspire](https://aspire.dev)
* [Entity Framework Core 10](https://docs.microsoft.com/en-us/ef/core/)
* [Angular 21](https://angular.dev/) or [React 19](https://react.dev/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)
* [NUnit](https://nunit.org/), [Shouldly](https://docs.shouldly.org/), [Moq](https://github.com/devlooped/moq) & [Respawn](https://github.com/jbogard/Respawn)
* [Scalar](https://scalar.com/)

## Versions

The `main` branch is on **.NET 10.0**. Previous versions are available:

| Version | Branch |
|---|---|
| .NET 9.0 | [`net9.0`](https://github.com/jasontaylordev/CleanArchitecture/tree/net9.0) 


## License

This project is licensed under the [MIT License](LICENSE).

