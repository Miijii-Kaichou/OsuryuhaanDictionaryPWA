using OsuryuhaanDictionaryPWAProj.Server.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OsuryuhaanDictionaryPWAProj.Server.Entities
{
    public sealed class Word
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ClassType Class { get; set; }
        public string? Pronounciation { get; set; }
        public string? Definition { get; set; }
        public Word[]? Synonyms { get; set; }
        public Word[]? Antonyms { get; set; }
        public string[]? Sentences { get; set; }
    }
}
