FROM microsoft/dotnet:2.0.0-sdk
WORKDIR /app

# copy csproj and restore as distinct layers
COPY OctoTenantApi.csproj .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet publish -c Debug -o publish
ENTRYPOINT ["dotnet", "publish/OctoTenantApi.dll"]