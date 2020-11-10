### Build image, can be executed with `docker build --target build ...`
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app 
COPY *.csproj ./
RUN dotnet restore academy20-zingtech-backend.csproj
RUN dotnet tool restore 
COPY . ./
RUN dotnet publish academy20-zingtech-backend.csproj -c Release -o out

# Called only if the build image is targeted with --target
CMD ASPNETCORE_URLS=http://*:$PORT dotnet watch out/academy20-zingtech-backend.dll
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet out/academy20-zingtech-backend.dll

### Production image
# ASP.NET image containing runtime only: no SDK in here
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS deploy
WORKDIR /app

# Only copy the compiled binaries: no tests or other code 
COPY --from=build /app/out .

# Command to execute on `docker run ...`
CMD ASPNETCORE_URLS=http://*:$PORT dotnet academy20-zingtech-backend.dll