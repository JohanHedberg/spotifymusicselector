# spotifymusicselector
A short demo project on how to consume the Spotify Web API using a dotnet core web api and a React application build with typescript and styled with Material UI.

## Getting started

### Creating a Spotify Application
The first thing you need to do is make sure you have an Application registered at Spotify to associate your program with. You creates such an Application by going to https://developer.spotify.com, log in with an existing Spotify account and then create your Application.

### Add authentication configuration
In Visual Studio, right-click the Spotify.Music.Selector.Web project and click Manage User Secrets in the context menu. Paste in the following snippet in the file the secrets.json file that is opened.

```
{
  "Authentication": {
    "ClientId": "sb4255ea65464dbaacfbbf437ec31",
    "ClientSecret": "wefd11d8043gdg43d82c33f68d45458",
    "CallbackUri": "http://localhost:50136/callback"
  }
}
```
Replace the fictious values with your Client ID and Client Secret from the Spotify Developer Dashboard.

### Build and run your solution in Visual Studio
By now, all you need should be in place for you to compile and run the solution in Visual Studio.