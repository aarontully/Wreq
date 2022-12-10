using Newtonsoft.Json;
using Wreq.Models;
using Wreq.Services.IServices;

namespace Wreq.Services
{
    public class MovieDbService : IMovieDbService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl = $"https://api.themoviedb.org/3";

        public MovieDbService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        public async Task<List<Result>> GetAsync(string media, string genre, int page)
        {
            media = media.ToLower();
            //media = movie or tv show
            //type = trending, popular etc
            var response = await _client.GetAsync($"{_baseUrl}/discover/{media}?api_key={_configuration["MovieDb:ApiKey"]}&language=en-US&include_adult=false&with_genres={genre}&page={page}");

            if(response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var discover = JsonConvert.DeserializeObject<DiscoverResultModel>(content);
                var trendingMovies = discover.Results;
                if(trendingMovies is not null)
                {
                    return trendingMovies;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
