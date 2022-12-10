using Wreq.Models;

namespace Wreq.Services.IServices
{
    public interface IMovieDbService
    {
        public Task<List<Result>> GetAsync(string media, string genre, int page);
    }
}
