FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ShopSync.sln .
COPY ShopSync.Endpoint/ShopSync.Endpoint.csproj ShopSync.Endpoint/ShopSync.Endpoint.csproj
COPY ShopSync.Application/ShopSync.Application.csproj ShopSync.Application/ShopSync.Application.csproj
COPY ShopSync.Infrastructure/ShopSync.Infrastructure.csproj ShopSync.Infrastructure/ShopSync.Infrastructure.csproj
COPY ShopSync.Domain/ShopSync.Domain.csproj ShopSync.Domain/ShopSync.Domain.csproj

RUN dotnet restore

COPY . .

WORKDIR /app/ShopSync.Endpoint

RUN dotnet publish -c Release -o /app/src/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/src/out .

ENTRYPOINT ["dotnet", "ShopSync.Endpoint.dll"]
