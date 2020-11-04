# TEMPORARY BASE
# Define Base 
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
#Copy source files 
COPY *.csproj ./
#Fetching dependencies and building
RUN dotnet restore academy20-zingtech-backend.csproj
COPY . ./
RUN dotnet publish academy20-zingtech-backend.csproj -c Release -o out
# ***** Now we have an artifact or binary *****

# PERMANENT BASE
# Define new base - .NET runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app

# Copy binaries over from the previous image 
COPY --from=build /app/out .

#.dll IS the binarys - dynamic libraries 
#ENTRYPOINT ["dotnet", "academy20-zingtech-backend.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet academy20-zingtech-backend.dll