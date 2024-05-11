FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["EfCore8_SentinelValues/EfCore8_SentinelValues.csproj", "EfCore8_SentinelValues/"]
RUN dotnet restore "EfCore8_SentinelValues/EfCore8_SentinelValues.csproj"
COPY . .
WORKDIR "/src/EfCore8_SentinelValues"
RUN dotnet build "EfCore8_SentinelValues.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EfCore8_SentinelValues.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EfCore8_SentinelValues.dll"]
