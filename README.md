# MadTVDB
An open-source portable C# library for the "The TVDB" API.  Can be used with any project with .NET Framework 4.5.1 or higher. It will also work with any Windows 8.1, Windows Phone 8.1 and Windows 10 apps.

## Usage
To use this library you need to obtain an API key from The TVDB, which can be found [here](http://thetvdb.com/?tab=apiregister). Once you have done that:

1. Compile this project and reference the MadTVDB.dll.
2. Job done! Now you can access any of the functions provided by the library.

### Example

```
	using MadTVDB.Models;

	MadTVDB.MadTVDB madTVDB = new MadTVDB.MadTVDB("your_api_key_here");
	TVDBSearchResponse searchResponse = await madTVDB.Search("The Flash");
```

The above could would return a list of all shows The TVDB finds that are to do with "The Flash".
