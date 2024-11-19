FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ConsoleApp_If/ConsoleApp11/ConsoleApp11.csproj", "ConsoleApp11/"]
RUN dotnet restore "ConsoleApp_If/ConsoleApp11/ConsoleApp11.csproj"
COPY . .
WORKDIR "/src/ConsoleApp11"
RUN dotnet build "ConsoleApp11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp11.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp11.dll"]
