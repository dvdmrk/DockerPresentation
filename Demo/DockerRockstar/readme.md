# DockerRockstar

The easy way to accelarate your application development.

## Technologies

- NET Core 5 API
- NET Standard 2.1 Library
- Angular 12
- Docker

### Requirements

- Dotnet 5 SDK
- Docker
- Angular 12 CLI

## Features

- [x] Docker Support 
- [x] Enterprise Solution Architecture
- [x] GitHub .NET CI Action
- [x] GitHub Angular CI Action

## Steps

1. Clone this repo
2. Run `dotnet new -i [path to repo root]`
3. Run `dotnet new dockerrockstar [application name]`
4. Run `docker-compose -f docker-compose.debug up` from root scaffolded solution directory
5. Run `npm i` from `[application name].Web`
6. Run `ng serve` from `[application name].Web`

## Roadmap

- Project level templates for common requirements
- CI/ CD/ Release infrastructure 