namespace OsuryuhaanDictionaryPWAProj.Client.Services.PreferenceService
{
    public sealed class AppPreferencesService : IAppPreferencesService
    {
        public bool EnableCloudSync { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EnableAdvanceSearch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TotalStudyLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StudyIdleLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AppThemeMode ThemeMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task LoadFromCloud()
        {
            throw new NotImplementedException();
        }

        public Task LoadFromLocal()
        {
            throw new NotImplementedException();
        }

        public Task SaveToCloud()
        {
            throw new NotImplementedException();
        }

        public Task SaveToLocal()
        {
            throw new NotImplementedException();
        }
    }
}
