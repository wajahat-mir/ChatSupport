FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["ChatSupport/ChatSupport.csproj", "ChatSupport/"]
RUN dotnet restore "ChatSupport/ChatSupport.csproj"
COPY . .
WORKDIR "/src/ChatSupport"
RUN dotnet build "ChatSupport.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ChatSupport.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ChatSupport.dll"]