FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Adjust the paths for the .csproj file and the COPY command
COPY ["RIGProjeck/RIGProjeck/RIGProjeck.csproj", "RIGProjeck/"]
COPY . .

WORKDIR "/src/RIGProjeck/RIGProjeck"
RUN dotnet build "RIGProjeck.csproj" -c Release -o /app/build

FROM build AS publish
# Build with more verbosity
RUN dotnet build "RIGProjeck.csproj" -c Release -o /app/build -v n


FROM base AS final
WORKDIR /app

# Adjust the paths for the --from argument in the COPY command
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RIGProjeck.dll"]
