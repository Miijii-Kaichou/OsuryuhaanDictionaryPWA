using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OsuryuhaanDictionaryPWAProj.Server.Entities
{
    public sealed class WordListItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("FK_WORD_ID")]
        public int Word_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("FK_WORD_LIST_GROUP_ID")]
        public int WordListGroup_Id { get; set; }
    }
}
