# Scripts

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



## File Structure

![Docker is a platform for packaging an application and all of its dependencies including operating system into a single container called an image. This container lives longside other containers on top of the docker platform, host operating system, and physical hardware.](https://www.docker.com/sites/default/files/d8/2018-11/docker-containerized-appliction-blue-border_2.png "Docker Container Structure")

Conceptually, containers are much easier to understand when you examine the underlying file structure and contents.

### Clone the Repo

If you're participating in the follow along demo, run `git clone ...` in a termal to copy the project contents from GitHub to your local machine.

### Install VSCode Extensions

- **Omnisharp** 
  - Intellsense for C# .NET Core/ Standard/ Framework
  - `code --install-extension ms-dotnettools.csharp` 
- **Docker**
  - Container/ Image/ Registry/ Volume/ etc information
  - `code --install-extension ms-azuretools.vscode-docker`

### File Structure

```
.
├── docker-compose.yml
├── docker-compose.ci.build.yml
├── ApiProject
│   ├── Dockerfile
│   ├── ApiProject.csproj
│   ├── ...
├── AngularProject
│   ├── Dockerfile
│   ├── packages.json
│   ├── ...
```

### File Syntax


## Demo

