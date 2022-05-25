FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CustomJobHandler/CustomJobHandler.csproj", "CustomJobHandler/"]
RUN dotnet restore "CustomJobHandler/CustomJobHandler.csproj"
COPY . .
WORKDIR "/src/CustomJobHandler"
RUN dotnet build "CustomJobHandler.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CustomJobHandler.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CustomJobHandler.dll"]