# Docker Onboarding

## Install Chocolatey

Executeing the following command in powershell with 'Admin' privlidges will install Chocolatey Package Manager.

```
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
```
## Install Everything Else
Executeing the following command in powershell with 'Admin' privlidges will install all of the software documented in the [Docker Onboarding](#) Powershell script.
```
iex ((new-object net.webClient).DownloadString('https://raw.githubusercontent.com/dvdmrk/DockerPresentation/main/docker-presentation.ps1'))
```