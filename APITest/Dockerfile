FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["APITest/APITest.csproj", "APITest/"]
RUN dotnet restore "APITest/APITest.csproj"
COPY . .
WORKDIR "/src/APITest"
RUN dotnet build "APITest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "APITest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APITest.dll"]