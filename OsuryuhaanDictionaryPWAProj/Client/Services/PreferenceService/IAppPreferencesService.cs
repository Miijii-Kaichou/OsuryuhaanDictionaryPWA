using OsuryuhaanDictionaryPWAProj.Client.Data;

namespace OsuryuhaanDictionaryPWAProj.Client.Services.PreferenceService
{
    public interface IAppPreferencesService
    {
        bool EnableCloudSync { get; set; }
        bool EnableAdvanceSearch { get; set; }
        int TotalStudyLength { get; set; }
        int StudyIdleLength { get; set; }
        AppThemeMode ThemeMode { get; set; }
       
        Task SaveToCloud();
        Task<AppPrefData>? LoadFromCloud() { return null; }

        Task SaveToLocal();
        Task<AppPrefData>? LoadFromLocal() { return null; }
    }
}
