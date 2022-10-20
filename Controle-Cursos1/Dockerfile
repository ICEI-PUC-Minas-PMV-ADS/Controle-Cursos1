#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

# EST핯IO 1
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# EST핯IO 2
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["./Controle-Cursos1.csproj", "Controle-Cursos1/"]
RUN dotnet restore "Controle-Cursos1/Controle-Cursos1.csproj"
COPY . .
WORKDIR "/src/Controle-Cursos1"
RUN dotnet build "Controle-Cursos1.csproj" -c Release -o /app/build

# EST핯IO 3
FROM build AS publish
RUN dotnet publish "Controle-Cursos1.csproj" -c Release -o /app/publish

# EST핯IO 4
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Controle-Cursos1.dll"]