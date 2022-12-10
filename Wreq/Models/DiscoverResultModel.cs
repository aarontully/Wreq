using Newtonsoft.Json;

namespace Wreq.Models
{
    public class Result
    {
        [JsonProperty("adult")]
        public bool? Adult;

        [JsonProperty("backdrop_path")]
        public string? BackdropPath;

        [JsonProperty("genre_ids")]
        public List<int>? GenreIds;

        [JsonProperty("id")]
        public int? Id;

        [JsonProperty("original_language")]
        public string? OriginalLanguage;

        [JsonProperty("original_title")]
        public string? OriginalTitle;

        [JsonProperty("overview")]
        public string? Overview;

        [JsonProperty("popularity")]
        public double? Popularity;

        [JsonProperty("poster_path")]
        public string? PosterPath;

        [JsonProperty("release_date")]
        public string? ReleaseDate;

        [JsonProperty("title")]
        public string? Title;

        [JsonProperty("video")]
        public bool? Video;

        [JsonProperty("vote_average")]
        public double? VoteAverage;

        [JsonProperty("vote_count")]
        public int? VoteCount;
    }

    public class DiscoverResultModel
    {
        [JsonProperty("page")]
        public int? Page;

        [JsonProperty("results")]
        public List<Result>? Results;

        [JsonProperty("total_pages")]
        public int TotalPages;

        [JsonProperty("total_results")]
        public int? TotalResults;
    }
}
