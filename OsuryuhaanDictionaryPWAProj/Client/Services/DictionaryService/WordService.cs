﻿using OsuryuhaanDictionaryPWAProj.Server.Data.Enums;
using OsuryuhaanDictionaryPWAProj.Shared.Data.Enums;
using System.Net.Http.Json;

namespace OsuryuhaanDictionaryPWAProj.Client.Services.DictionaryService
{
    public sealed class WordService : IWordService
    {

        private readonly HttpClient _http;

        public Word? WordOfTheDay { get; set; } = new Word { 
            Id = -1, 
            Name = "Unknown",
            Class = ClassType.Badzudou, 
            Pronounciation = "Unknown", 
            Definition = "N/A",
            Relevancy = RelevancyLevel.Common 
        };

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

        public async Task GenerateWordOfTheDay()
        {
            await Task.Run(() =>
            {
                if (Words == null) return;
                if (Words.Count == 0) return;
                int maxIndex = Words.Count - 1;
                var seed = DateTime.Now.Date.Day;
                Random random = new(seed);
                var index = random.Next(Words.Count);
                if (index > maxIndex)
                {
                    WordOfTheDay = Words[maxIndex];
                    return;
                }
                WordOfTheDay = Words[index];
            });
        }
    }
}