FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ConsoleApp9/ConsoleApp9.csproj", "ConsoleApp9/"]
RUN dotnet restore "ConsoleApp9/ConsoleApp9.csproj"
COPY . .
WORKDIR "/src/ConsoleApp9"
RUN dotnet build "ConsoleApp9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp9.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp9.dll"]
