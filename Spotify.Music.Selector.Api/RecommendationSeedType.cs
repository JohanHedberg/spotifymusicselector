namespace Spotify.Music.Selector.Api
{
    /// <summary>
    /// Enumeration for restricting a <see cref="RecommendationSeed"/>'s type
    /// to what is a possible value when querying the Spotify web API.
    /// </summary>
    public enum RecommendationSeedType
    {
        Artist,
        Album,
        Genre
    }
}