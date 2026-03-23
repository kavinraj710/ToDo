# ---------- Build Stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files
COPY . .

# Restore & publish
RUN dotnet restore
RUN dotnet publish -c Release -o out

# ---------- Runtime Stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy published output
COPY --from=build /app/out .

# Expose port
EXPOSE 80

# Run app
ENTRYPOINT ["dotnet", "todo.dll"]
