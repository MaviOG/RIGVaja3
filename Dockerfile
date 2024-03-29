# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Adjust the paths for the .csproj file and the COPY command
COPY ["RIGProjeck/RIGProjeck/RIGProjeck.csproj", "RIGProjeck/"]
COPY . .

WORKDIR "/src/RIGProjeck/RIGProjeck"
RUN dotnet build "RIGProjeck.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "RIGProjeck.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 3: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Adjust the paths for the --from argument in the COPY command
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RIGProjeck.dll"]
