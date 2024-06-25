
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY DockerCourseApi.csproj .
RUN dotnet restore "DockerCourseApi.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet publish "DockerCourseApi.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DockerCourseApi.dll"]
