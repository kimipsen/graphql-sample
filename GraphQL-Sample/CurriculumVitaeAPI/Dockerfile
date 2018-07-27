FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY CurriculumVitaeAPI/CurriculumVitaeAPI.csproj CurriculumVitaeAPI/
RUN dotnet restore CurriculumVitaeAPI/CurriculumVitaeAPI.csproj
COPY . .
WORKDIR /src/CurriculumVitaeAPI
RUN dotnet build CurriculumVitaeAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CurriculumVitaeAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CurriculumVitaeAPI.dll"]
