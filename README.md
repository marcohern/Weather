# Weather

A simple weather forecast system written in CSharp and Angular.

The SCharp portion is an API that itself queries 2 remote api's:
- https://geocoding.geo.census.gov: Turns addresses into earth coordinates.
- https://api.weather.gov: Determines the weather in the area specified by given earth coordinates.

## Installation

1. Download the source code to a folder, for example c:/src/Weather.
1. Open the c:/src/Weather folder with vscode.
1. You can start by building the angular app first:
  1. cd Angular
  1. ng build
  1. This will send the production build to CSharp/wwwroot
1. Now that the client side app is built, we can build and run the server side
1. cd CSharp
1. you may click on the Run & Debug tab of vscode, then click on the green play button to start a web server
1. The app should open on your default browser at this point.

Enjoy!