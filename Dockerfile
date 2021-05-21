FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebCurrencyConverter/WebCurrencyConverter.csproj", "./"]
RUN dotnet restore "WebCurrencyConverter/WebCurrencyConverter.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WebCurrencyConverter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebCurrencyConverter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebCurrencyConverter.dll"]
