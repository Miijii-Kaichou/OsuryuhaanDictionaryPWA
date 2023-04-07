using OsuryuhaanDictionaryPWAProj.Server.Entities;

namespace OsuryuhaanDictionaryPWAProj.Client.Services.DictionaryService
{
    public interface IWordService
    {
        List<Word> Words { get; set; }
        Task GetWords();
        Task<Word> GetSingleWord(int id);
    }
}
