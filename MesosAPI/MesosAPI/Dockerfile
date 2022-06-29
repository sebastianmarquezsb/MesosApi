FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY *.csproj ./app/MesosApi/
WORKDIR /app/MesosApi
RUN dotnet restore

COPY . ./
RUN dotnet publish -o out /p:PublishWithAspNetCoreTargetManifest="false"

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
ENV ASPNETCORE_URLS http://+:80
WORKDIR /app
COPY --from=build /app/MesosApi/out ./
ENTRYPOINT ["dotnet", "MesosAPI.dll"]