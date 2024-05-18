FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PortalBusiness.Api/PortalBusiness.Api.csproj", "PortalBusiness.Api/"]
RUN dotnet restore "PortalBusiness.Api/PortalBusiness.Api.csproj"
COPY . .
WORKDIR "/src/PortalBusiness.Api"
RUN dotnet build "PortalBusiness.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PortalBusiness.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PortalBusiness.Api.dll"]