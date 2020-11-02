FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore academy20-zingtech-backend.csproj
COPY . ./
RUN dotnet publish academy20-zingtech-backend.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "academy20-zingtech-backend.dll"]