using Microsoft.AspNetCore.Mvc;
using OsuryuhaanDictionaryPWAProj.Server.Data.Enums;
using OsuryuhaanDictionaryPWAProj.Server.Entities;
using OsuryuhaanDictionaryPWAProj.Shared.Data.Enums;

namespace OsuryuhaanDictionaryPWAProj.Server.Controllers
{
    /// <summary>
    /// When reading from the database, we'll then cache all of this data to be used for the majority
    /// of the application. This controller is not exclusive to the Search Razor Page allow, but 
    /// will be used all over.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DictionaryController : ControllerBase
    {
        // Mock-Up Data
        public static List<Word> Words = new()
        {
            new Word {
                Id=1, 
                Name="Heyao", 
                Class=ClassType.Sasudou,
                Definition="Hello; Good Afternoon",
                Pronounciation="HEH-YAOO",
                Relevancy=RelevancyLevel.Common
            },
            new Word 
            {
                Id=2, 
                Name="Sachu",
                Class=ClassType.Kuudzudou,
                Definition="Front (in front of something)", 
                Pronounciation="SAH-CHEW",
                Relevancy=RelevancyLevel.Common},
            new Word 
            {
                Id=3, 
                Name="Shukuhadzumyayen", 
                Class=ClassType.Kuudzudou,
                Definition="The phenomenon in which you have long-lasting motivation, but suddenly you start feeling lazy, unwilling, or unmotivated despite no actual external or internal triggers.",
                Pronounciation="SHOE-KOO-HAHD-ZOO-MYA-YEN", 
                Relevancy=RelevancyLevel.Colliquial
            },
            new Word 
            {
                Id=4, 
                Name="Topudandzu", 
                Class=ClassType.Dondonshidzudou, 
                Definition="The act of going up and down (e.g. bouncing, elevating, shaking vertically, rising to a high-point and dropping it, etc.); One's mood fluctating from positive to negative; To have mood swings; The act of continously being distracted of a task", 
                Pronounciation="SAH-CHEW", 
                Relevancy=RelevancyLevel.Colliquial
            }
        };


        [HttpGet]
        public async Task<ActionResult<List<Word>>> GetWords()
        {
            await Task.CompletedTask;
            return Ok(Words);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Word>> GetSingleWord(int id)
        {
            await Task.CompletedTask;
            var word = Words.FirstOrDefault(w => w.Id == id);
            if (word == null)
                return NotFound(word);
            return Ok(word);
        }
    }
}
