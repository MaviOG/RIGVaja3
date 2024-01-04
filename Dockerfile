FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["RIGProjeck/RIGProjeck/RIGProjeck.csproj", "RIGProjeck/"]
COPY . .

WORKDIR "/src/RIGProjeck"
RUN dotnet build "RIGProjeck.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RIGProjeck.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RIGProjeck.dll"]
