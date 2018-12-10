FROM microsoft/dotnet:2.1-sdk AS build-env

MAINTAINER Gokhan Sengun <gokhansengun@gmail.com>

RUN mkdir -p /app

## Copy the csproj files first in order to cache restore
COPY ./sut-test.csproj     /app/

WORKDIR /app

RUN dotnet restore

COPY . /app/

RUN dotnet publish -c Release

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime-env

COPY --from=build-env /app/bin/Release/netcoreapp2.1/publish /usr/local/bin/sut

WORKDIR /usr/local/bin/sut

ENTRYPOINT [ "dotnet", "sut-test.dll" ]
