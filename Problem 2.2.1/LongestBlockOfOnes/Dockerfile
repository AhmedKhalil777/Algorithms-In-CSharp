FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Problem 2.2.1/LongestBlockOfOnes/LongestBlockOfOnes.csproj", "LongestBlockOfOnes/"]
RUN dotnet restore "Problem 2.2.1/LongestBlockOfOnes/LongestBlockOfOnes.csproj"
COPY . .
WORKDIR "/src/LongestBlockOfOnes"
RUN dotnet build "LongestBlockOfOnes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LongestBlockOfOnes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LongestBlockOfOnes.dll"]
