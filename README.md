# **Contexto do projeto**

Primeira aplicação utilizando .NET C#, criando uma aplicação de console e seus testes unitários.
<br/>
O tão querido "Hello World" !!
<br/>

## **Stacks utilizadas no projeto**

Foi utilizado o .NET Core na versão 6.0
<br/>
A biblioteca de testes xUnit e a Fluent Assertions
<br/>

## **Como iniciar o projeto localmente**

Caso queira iniciar o projeto localmente devera ter instalado o .NET 6.0 e seguir os seguintes passos:
<br/>
Primeiro clone o projeto:
<br/>

```sh
git clone git@github.com:KleversonEller/exercise-hello-world-sharp.git
```
<br/>

Em seguida entre na pasta do projeto e utilize o seguinte comando para instalar as dependências do projeto:
<br/>

```sh
cd exercise-hello-world-sharp/src
dotnet restore
```
<br/>

Caso queira executar os testes basta utilizar:
<br/>

```sh
cd ola-mundo.Test
dotnet test
```
