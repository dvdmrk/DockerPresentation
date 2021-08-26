#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DockerRockstar.Api/DockerRockstar.Tests.csproj", "DockerRockstar.Tests/"]
COPY ["DockerRockstar.Api/DockerRockstar.Api.csproj", "DockerRockstar.Api/"]
COPY ["DockerRockstar.Shared/DockerRockstar.Shared.csproj", "DockerRockstar.Shared/"]
RUN dotnet restore "DockerRockstar.Api/DockerRockstar.Api.csproj"
COPY . .
WORKDIR "/src/DockerRockstar.Tests"
RUN dotnet build "DockerRockstar.Tests.csproj" -c Release -o /app/build