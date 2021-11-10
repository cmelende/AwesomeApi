FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["AwesomeApi/AwesomeApi.csproj", "AwesomeApi/"]
RUN dotnet restore "AwesomeApi/AwesomeApi.csproj"
COPY . .
WORKDIR "/src/AwesomeApi"
RUN dotnet build "AwesomeApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AwesomeApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AwesomeApi.dll"]
