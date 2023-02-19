FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./ControleProjetosAPI/ControleProjetosAPI.csproj"
RUN dotnet publish "./ControleProjetosAPI/ControleProjetosAPI.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal
WORKDIR /app
COPY --from-build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "ControleProjetosAPI.dll"]

##docker build --rm -t controle-projetos/ControleProjetosAPI: latest .
##docker image ls | grep ControleProjetosAPI
##docker run -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 controle-projetos/ControleProjetosAPI