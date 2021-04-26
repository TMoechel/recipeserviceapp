FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TM.FoodApp.Api/TM.FoodApp.Api.csproj", "TM.FoodApp.Api/"]
RUN dotnet restore "TM.FoodApp.Api/TM.FoodApp.Api.csproj"
COPY . .
WORKDIR "/src/TM.FoodApp.Api"
RUN dotnet build "TM.FoodApp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TM.FoodApp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TM.FoodApp.Api.dll"]
