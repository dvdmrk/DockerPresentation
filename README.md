# README

**Docker for .NET Developers** - Seamless CI/CD and releases, if that’s the Docker dream… why is it such a nightmare?

## Docker Onboarding

Before we can get started building containers and executing docker commands we need to configure our computers with an IDE, Docker Desktop, and GIT. 

> Running linux containers requires a linux subsystem because linux containers cannot share a kernel with windows, this means windows 10 pro/ enterprise users should enable Hyper-V.

### Install Docker
[Docker Desktop](https://desktop.docker.com/win/stable/amd64/Docker%20Desktop%20Installer.exe) Download Link

### Install Chocolatey

Executeing the following command in powershell with 'Admin' privlidges will install Chocolatey Package Manager.

```
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
```

### Install Everything Else
Executeing the following command in powershell with 'Admin' privlidges will install all of the software documented in the [Docker Onboarding](https://github.com/dvdmrk/DockerPresentation/blob/main/Scripts/docker-onboarding.ps1) Powershell script.

<details>
<summary>Tools Installed</summary>

**Recomended**

- Node JS - Provided by docker image
- // Node Version Manager - Alternative to Node
- .NET Core SDK - Provided by docker image
- Git Bash - CLI for cloning demo repo

**Optional**

- Visual Studio Code - Any IDE will suffice
- SQL Server Management Studio - For connecting to SQL DB
- HeidiSQL - For connecting to PostgreSQL DB

**Unnecessary**

- MySQL Workbench - For connecting to MySQL DB

Visual Studio Code
</details>

```
iex ((new-object net.webClient).DownloadString('https://raw.githubusercontent.com/dvdmrk/DockerPresentation/main/Scripts/docker-onboarding.ps1'))
```

### Alternative

Alternatively, if you're using your preconfigured development machine you can just install docker desktop. The chocolatey command to install this is: `choco install docker-desktop` the `-y` paramater will accept the download/ installation, the `--force` paramater will force it to install/ reinstall.

## Install VSCode Extensions

- **Omnisharp** 
  - Intellsense for C# .NET Core/ Standard/ Framework
  - `code --install-extension ms-dotnettools.csharp` 
- **Docker**
  - Container/ Image/ Registry/ Volume/ etc information
  - `code --install-extension ms-azuretools.vscode-docker`

## Clone the Repo

If you're participating in the follow along demo, run `git clone https://github.com/dvdmrk/DockerPresentation` in a termal to copy the project contents from GitHub to your local machine.

## Cheat Sheet

### Build Server

- `docker image build -t dvdmrk/dockerrockstar-web:latest DockerRockstarSpa`
- `docker image build -t dvdmrk/dockerrockstar-api:latest -f DockerRockstar.Api/Dockerfile .`
- `docker images` or `docker image ls`
- `docker image rm {{space delimited list of image name or ids}}`
- `docker container run -d --name web -p 8082:80 dvdmrk/dockerrockstar-web:latest`
- `docker ps` for running containers || `docker ps -a` for all containers || `docker container ls`
- `docker container stop {{space delimitted list of container name/ ids}}`
- `docker container start {{container name}}`

### Container Registry

- `docker login`
- `docker image push dvdmrk/dockerrockstar-api:latest`
- `docker image push dvdmrk/dockerrockstar-web:latest`

### Deploy/ Scale

- `docker-compose -v`
- `docker-compose up`
- `docker-compose -f docker-compose.ci.yml up`
- `docker swarm init` `docker swarm leave`
- `docker node ls`
- `docker service create --name web -p 8082:80 --replicas 3 dockerrockstarweb`
- `docker service scale web=5`
- `docker stack deploy -c docker-compose.stack.yml dockerrockstar`
- `docker stack ls`
- `docker stack servcies dockerrockstar`
- `docker stack ps dockerrockstar`
- `docker stack rm dockerrockstar`


