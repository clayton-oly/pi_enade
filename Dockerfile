# Estágio de construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar apenas o arquivo csproj e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar todo o resto e compilar o aplicativo
COPY . ./
RUN dotnet publish -c Release -o out

# Estágio de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar apenas os arquivos necessários para executar o aplicativo
COPY --from=build /app/out ./

# Comando para iniciar o aplicativo
CMD ["dotnet", "ProjetoEnade.dll"]
