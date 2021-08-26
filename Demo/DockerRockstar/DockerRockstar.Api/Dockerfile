#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://0.0.0.0:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DockerRockstar.Api/DockerRockstar.Api.csproj", "DockerRockstar.Api/"]
COPY ["DockerRockstar.Shared/DockerRockstar.Shared.csproj", "DockerRockstar.Shared/"]
RUN dotnet restore "DockerRockstar.Api/DockerRockstar.Api.csproj"
COPY . .
WORKDIR "/src/DockerRockstar.Api"
RUN dotnet build "DockerRockstar.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerRockstar.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerRockstar.Api.dll"]