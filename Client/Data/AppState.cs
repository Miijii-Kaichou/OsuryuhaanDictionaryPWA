namespace OsuryuhaanDictionaryBlazorApp.Client.Data
{
    public class AppState
    {
        public AppState()
        {
            CurrentViewName= "Default";
        }

        public string? CurrentViewName { get; private set; } = "Default";
        public event Action? StateChanged;
        private void NotifyStateChanged() => StateChanged?.Invoke();
        public void SetName(ReadOnlySpan<char> newName)
        {
            CurrentViewName= newName.ToString();
            NotifyStateChanged();
        }
    }
}
