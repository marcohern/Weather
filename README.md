# Weather

A simple weather forecast system written in CSharp and Angular.

The CSharp portion is an API that itself queries 2 remote api's:
- https://geocoding.geo.census.gov: Turns addresses into earth coordinates.
- https://api.weather.gov: Determines the weather in the area specified by given earth coordinates.

## Installation

1. Download/clone the source code to a folder, for example c:/src/Weather.
1. Open the c:/src/Weather folder with vscode.
1. You can start by building the angular app first:
1. cd Angular
2. npm install (to download/update dependencies)
3. ng build
4. This will send the production build to CSharp/wwwroot
5. Now that the client side app is built, we can build and run the server side
6. cd CSharp
7. You may need to update nuget packages beforehand, I dont remember the command. I suspect the build will do that but im not sure, and im too lazy to test.
8. you may click on the Run & Debug tab of vscode, then click on the green play button to start a web server
9. The app should open on your default browser at this point. If not, you may open the url: http://localhost:7025/index.html, or just add the index.html to the address.

## Use

Just type in an address (required) and a optionally a city, state or zip.
Click the Get Weather button to receive a forecast of the location. Not all locations work, so try a US city like in California or New York.

No validations are applied, so, use a certified Anti-Error Radiation suit to avoid Acute Error Frustration Radiation sickness.

Enjoy!
