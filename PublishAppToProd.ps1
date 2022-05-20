pushd ./PatternflyApp
dotnet publish ./PatternflyApp.csproj -o ../publish
netlify deploy --prod -d ../publish/wwwroot -s symphonious-puppy-7b15cd

popd