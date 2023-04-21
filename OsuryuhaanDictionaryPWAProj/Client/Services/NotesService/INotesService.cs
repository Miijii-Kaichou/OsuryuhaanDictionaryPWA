namespace OsuryuhaanDictionaryPWAProj.Client.Services.NotesService
{
    public interface INotesService
    {
        public NoteModel? currentViewingNote { get; set; }
        public List<NoteModel> noteModels { get; set; }
        public void SetAsCurrentViewing(NoteModel model);
        public void AddNewNote();
        public void RemoveNote(NoteModel model);
        public string RenameIfDuplicate(string title);
        public async Task GetNotes() { }
    }
}
