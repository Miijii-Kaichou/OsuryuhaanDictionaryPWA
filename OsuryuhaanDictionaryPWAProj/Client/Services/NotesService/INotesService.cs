namespace OsuryuhaanDictionaryPWAProj.Client.Services.NotesService
{
    public interface INotesService
    {
        public NoteModel? currentViewingNote { get; set; }
        public NoteModel[] noteModels { get; set; }
        public void SetAsCurrentViewing(NoteModel model);
        public async Task GetNotes() { }
    }
}
