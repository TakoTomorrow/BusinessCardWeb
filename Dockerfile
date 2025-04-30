FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5800
EXPOSE 56000

RUN apt-get update && apt-get install -y unzip curl \
    && curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /vsdbg

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY BusinessCardWeb.Server/ ./BusinessCardWeb.Server/

RUN dotnet restore ./BusinessCardWeb.Server/BusinessCardWeb.Server.csproj
RUN dotnet publish ./BusinessCardWeb.Server/BusinessCardWeb.Server.csproj -c Debug -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "BusinessCardWeb.Server.dll"]
