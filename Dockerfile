FROM microsoft/aspnetcore-build:1.1.1

WORKDIR /app

# copy project.json and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

#copy and build everything else
COPY . .

RUN dotnet --version
RUN dotnet publish -c Release -o out -r debian.8-x64

ENTRYPOINT ["dotnet", "out/netcorelive.dll", "-r", "debian.8-x64"]