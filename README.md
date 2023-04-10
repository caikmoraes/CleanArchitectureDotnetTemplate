# Clean Architecture Dotnet Template

This is a base project template based on Clean Architecture principles, learned through [Amichai Mantinband](https://github.com/amantinband)'s videos.

In this template, the layers of `Presentation`, `Application`, `Infrastructure` and `Domain` are already present and configured with dependency injection packages and some injections (Mapster and Mediatr).

## Contents

- [Clean Architecture Layers](#-clean-architecture-layers)
- [Contracts Layer](#-contracts-layers)
- [Presentation Layer](#-api-presentation-layer)
- [Application Layer](#-application-layer)
- [Infrastructure Layer](#-infrastructure-layer)
- [Domain Layer](#-domain-layer)
- [Installation](#-installation)
- [Uninstallation](#-uninstallation)

## Clean Architecture Layers

Here I'll shortly describe the layers in this template.

### Contracts Layer

In this Layer all of API's contracts must be present, requests and responses.

Example:

- Base.Clean.Template.Contracts
  - WeatherForecast
    - WeatherForecastResponse.cs
    - GetWeatherForecastRequest.cs

### API (Presentation) Layer

The presentation layer must have the Controllers, Mapping configurations to map requests objects to Mediatr Query objects and any others configurations about presentations.

### Application Layer

The Application Layer must have all of business rules and required interfaces to access external services like a database for example.

### Infrastructure Layer

The Infrastructure Layer must have all of implementations to access external services.

For example:

- Base.Clean.Template.Application

  - WeatherForecastsApp
    - GetWeatherForecastHandler.cs
  - Common
    - Repositories
      - IWeatherForecastRepository.cs

- Base.Clean.Template.Infrastructure
  - WeatherForecasts
    - WeatherForecastRepository.cs

### Domain Layer

In Domain Layer all of the entities and domain classes must be present.

> For better explanation about Clean Architecture I personally recommend [Amichai Mantinband](https://github.com/amantinband)'s videos and [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures).

## Installation

## Linux/WSL

To install `Clean Architecture Dotnet Template` it's necessary to run the commands below:

```
sh -c "$(curl -fsSL https://raw.githubusercontent.com/caikmoraes/CleanArchitectureDotnetTemplate/main/.template.config/install.sh)"
```

After that, check installation with the command:

```
dotnet new list | grep cleanarch
```

> Unfortunately, I don't have much experience with shell scripts and I want to fix that, so feel free to get in touch with suggestions to improve this tool :smile:

## Uninstallation

To uninstall template it's necessary to go to template's folder:

```
cd $USER/.dotnet/custom_templates/Base.Clean.Template/.template.config
```

and run the command:

```
sh uninstall.sh
```
