using Microsoft.AspNetCore.Components;

namespace OsuryuhaanDictionaryPWAProj.Client.Models.Notes
{
    public sealed class NoteModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        [Parameter]
        public string? Content { get; set; }
        public string?[] Tags { get; set; }
        public string? CreatedDateOn { get; set; }
        public string? ModifiedDateOn { get;set; }
    }
}
