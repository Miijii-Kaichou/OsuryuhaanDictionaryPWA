using Microsoft.AspNetCore.Components;

namespace OsuryuhaanDictionaryPWAProj.Client.Models.Notes
{
    public sealed class NoteModel
    {
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        [Parameter]
        public string? Content { get; set; }
        public string?[] Tags { get; set; }
    }
}
