FROM microsoft/aspnetcore-build:1.1.1

# target app folder
WORKDIR /app

# copy the project
COPY . .

# restore .net core packages
RUN dotnet restore -r debian.8-x64

# publish optimized app for debian
RUN dotnet publish -c Release -o out -r debian.8-x64

# run web server
ENTRYPOINT ["dotnet", "out/netcorelive.dll", "-r", "debian.8-x64"]