# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY LearnWeb.sln ./
COPY src/LearnWeb.Api/LearnWeb.Api.csproj src/LearnWeb.Api/
COPY tests/LearnWeb.Tests/LearnWeb.Tests.csproj tests/LearnWeb.Tests/
RUN dotnet restore src/LearnWeb.Api/LearnWeb.Api.csproj
COPY src/ src/
RUN dotnet publish src/LearnWeb.Api/LearnWeb.Api.csproj -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app .
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
USER $APP_UID
ENTRYPOINT ["dotnet", "LearnWeb.Api.dll"]
