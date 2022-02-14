
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster
MAINTAINER Paulo Neto
WORKDIR /app
COPY . .
RUN dotnet restore ./formando-devs-api
RUN dotnet build ./formando-devs-api --configuration Release -o build
RUN ls -la
EXPOSE 8080
ENTRYPOINT [ "dotnet" , "/app/build/formando-devs-api.dll" ]
