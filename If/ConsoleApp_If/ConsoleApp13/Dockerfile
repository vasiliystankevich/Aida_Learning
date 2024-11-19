FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ConsoleApp_If/ConsoleApp13/ConsoleApp13.csproj", "ConsoleApp13/"]
RUN dotnet restore "ConsoleApp_If/ConsoleApp13/ConsoleApp13.csproj"
COPY . .
WORKDIR "/src/ConsoleApp13"
RUN dotnet build "ConsoleApp13.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp13.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp13.dll"]
