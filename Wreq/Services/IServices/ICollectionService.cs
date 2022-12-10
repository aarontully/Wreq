using Wreq.Models;

namespace Wreq.Services.IServices
{
    public interface ICollectionService
    {
        public Task<List<ProfilesModel>> GetProfilesAsync(SettingsModel settingsModel);
        public Task<bool> PostAsync(PostModel post, SettingsModel settingsModel);
    }
}
