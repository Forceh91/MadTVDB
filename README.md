# MadTVDB

An open-source portable C# library for the "The TVDB" API.  Can be used with any project with .NET Framework 4.5.1 or higher. It will also work with any Windows 8.1, Windows Phone 8.1 and Windows 10 apps.

## Usage

To use this library you need to obtain an API key from The TVDB, which can be found [here](http://thetvdb.com/?tab=apiregister). Once you have done that:

1. Compile this project and reference the MadTVDB.dll.
2. Job done! Now you can access any of the functions provided by the library.

## Example

```c#
using MadTVDB.Models;

MadTVDB.MadTVDB madTVDB = new MadTVDB.MadTVDB("your_api_key_here");
TVDBSearchResponse searchResponse = await madTVDB.Search("The Flash");

// get some information about "The Flash (2014)," including episode information
TVDBSeriesResponse seriesResponse = await madTVDB.SeriesInformation(279121);

// get some information about the banners/artwork for "The Flash (2014)"
TVDBBannerResposne bannerResponse = await madTVDB.SeriesBannerInformation(279121);

// get some information about the posters for "The Flash (2014)"
TVDBBannerResposne bannerResponsePosters = await madTVDB.SeriesBannerInformation(279121, BannerType.Poster);

// get some information about the actors for "The Flash (2014)"
TVDBActorResposne actorResponse = await madTVDB.SeriesActorInformation(279121);

// get information about one particular episode of "The Flash (2014)" - Season 1, Episode 1
TVDBEpisodeResponse episodeResponse = await madTVDB.EpisodeInformation(4812524)
```

The above code would return a list of all shows The TVDB finds that are to do with "The Flash".
