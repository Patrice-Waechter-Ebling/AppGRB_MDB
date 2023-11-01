@echo off
echo Génération de projet C# avec importation database SQL existante
color 4F
dotnet new console
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet ef dbcontext scaffold "Data Source=.\SQLEXPRESS;Initial Catalog=BaseMDB;Integrated Security=True;TrustServerCertificate=Yes" Microsoft.EntityFrameworkCore.SqlServer -o Entities -c ApplicationContexte
dir /a /w
