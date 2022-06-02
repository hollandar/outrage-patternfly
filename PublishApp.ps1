pushd ./src/PatternflyApp
dotnet publish ./PatternflyApp.csproj -o ../../publish --configuration Release
netlify deploy -d ../../publish/wwwroot -s symphonious-puppy-7b15cd

popd