# dotnet CLI

dotnet new globaljson
dotnet new sln -n BasicAutofac


dotnet new console -n BasicAutofac.ConsoleApp
dotnet sln .\BasicAutofac.sln add .\BasicAutofac.ConsoleApp\
dotnet add .\BasicAutofac.ConsoleApp\ package Autofac


dotnet new web -n BasicAutofac.WebApp
dotnet sln .\BasicAutofac.sln add .\BasicAutofac.WebApp\
dotnet add .\BasicAutofac.WebApp\ package Autofac


