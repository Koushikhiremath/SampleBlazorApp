FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Server/SampleApp.Server.csproj", "Server/"]
RUN dotnet restore "Server/SampleApp.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "SampleApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleApp.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleApp.Server.dll"]