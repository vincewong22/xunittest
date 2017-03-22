rem build library project
dotnet restore src/AddressLibrary
dotnet build src/AddressLibrary

rem build test project
dotnet restore test/AddressTest
dotnet build test/AddressTest
