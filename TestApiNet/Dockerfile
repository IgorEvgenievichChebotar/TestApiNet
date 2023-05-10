FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestApiNet/TestApiNet.csproj", "TestApiNet/"]
RUN dotnet restore "TestApiNet/TestApiNet.csproj"
COPY . .
WORKDIR "/src/TestApiNet"
RUN dotnet build "TestApiNet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestApiNet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestApiNet.dll"]
