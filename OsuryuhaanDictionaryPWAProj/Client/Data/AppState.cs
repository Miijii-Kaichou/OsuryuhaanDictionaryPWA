namespace OsuryuhaanDictionaryPWAProj.Client.Data
{
    public sealed class AppState
    {
        // Collections of words.
        public static Word[]? Words;

        public string CurrentViewName { get; private set; }
        public event Action? StateChanged;
        public AppState()
        {
            CurrentViewName = "Default";
        }

        private void NotifyStateChanged() => StateChanged?.Invoke();
        public void SetName(ReadOnlySpan<char> name)
        {
            CurrentViewName = name.ToString();
            NotifyStateChanged();
        }
    }
}
