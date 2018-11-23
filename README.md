# Greetings API

Uma simples API de saudação construído com .NET Core 2.1 e Docker.

## Como começar

As instruções abaixo farão com que você tenha uma cópia do projeto e execute na máquina local para fins de desenvolvimento e testes.

### Clonando o repositório

```
git clone https://github.com/fernandoeho/aspnetcore-docker.git
```

### Executando a aplicação

Vá até o diretório onde o reposítório foi clonado e execute na raíz do projeto

```
dotnet restore
```

E rode a apliação executando

```
dotnet run
```

### Docker

Para executar o projeto utilizando o docker-compose.yml, rode

```
docker-compose up -d
```

Cheque o container "apigreetings-alpine" utilizando

```
docker ps
```

Crie uma nova tag para a imagem ser utilizado o Docker Hub

```
docker tag apigreetings-alpine:latest [nome-tag]
```

Faça o upload para o Docker Hub com

```
docker push [nome-tag]
```

## Tecnologias

- [.NET Core 2.1](https://www.microsoft.com/net/download) - Web Framework
- [Docker](https://www.docker.com/) - Containers/Virtualization
