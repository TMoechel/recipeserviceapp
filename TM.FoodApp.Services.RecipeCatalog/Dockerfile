#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["TM.FoodApp.Services.RecipeCatalog/TM.FoodApp.Services.RecipeCatalog.csproj", "TM.FoodApp.Services.RecipeCatalog/"]
RUN dotnet restore "TM.FoodApp.Services.RecipeCatalog/TM.FoodApp.Services.RecipeCatalog.csproj"
COPY . .
WORKDIR "/src/TM.FoodApp.Services.RecipeCatalog"
RUN dotnet build "TM.FoodApp.Services.RecipeCatalog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TM.FoodApp.Services.RecipeCatalog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TM.FoodApp.Services.RecipeCatalog.dll"]
