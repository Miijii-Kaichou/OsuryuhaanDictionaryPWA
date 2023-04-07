using OsuryuhaanDictionaryPWAProj.Server.Entities;
using System.Net.Http.Json;

namespace OsuryuhaanDictionaryPWAProj.Client.Services.DictionaryService
{
    public sealed class WordService : IWordService
    {
        private readonly HttpClient _http;

        public WordService(HttpClient http)
        {
            _http = http;
        }

        public List<Word> Words { get; set; } = new List<Word>();

        public Task<Word> GetSingleWord(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetWords()
        {
            var result = await _http.GetFromJsonAsync<List<Word>>("api/Dictionary");
            if (result == null)
                return;
            Words = result;
        }
    }
}
