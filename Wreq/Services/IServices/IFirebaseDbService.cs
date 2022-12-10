using Wreq.Models;

namespace Wreq.Services.IServices
{
    public interface IFirebaseDbService
    {
        public Task<SettingsModel> ReadSettings(string user, string type);
        public Task<bool> UpdateSettings(SettingsModel model, string user, string type);
        public Task<ProfilesModel> ReadProfiles(string user);
        public Task<bool> UpdateProfiles(ProfilesModel model, string user);
    }
}
