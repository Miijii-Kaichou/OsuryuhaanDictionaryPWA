using BlazorBootstrap;

namespace OsuryuhaanDictionaryPWAProj.Client.Services.NotesService
{
    public sealed class NotesService : INotesService
    {
        public NoteModel? currentViewingNote { get; set; }
        public List<NoteModel> noteModels { get; set; } = new()
        {
            new()
            {
                Id = 0,
                Title = "Lorem Ipsum 10 Paragraph Version",
                Subtitle = "Using the most favorite string of characters to represent this note.",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ipsum a arcu cursus vitae congue mauris rhoncus aenean. Posuere urna nec tincidunt praesent. Morbi non arcu risus quis varius quam quisque id. Ut faucibus pulvinar elementum integer enim neque volutpat. Ipsum consequat nisl vel pretium lectus quam. A diam maecenas sed enim ut sem. Varius morbi enim nunc faucibus a pellentesque sit amet. Ut enim blandit volutpat maecenas volutpat blandit aliquam. Vel risus commodo viverra maecenas accumsan lacus vel facilisis. Commodo viverra maecenas accumsan lacus vel facilisis. Neque gravida in fermentum et. Sollicitudin tempor id eu nisl nunc. Non blandit massa enim nec dui nunc mattis. Consectetur adipiscing elit duis tristique sollicitudin nibh sit. Sed risus ultricies tristique nulla aliquet enim tortor at auctor. Dolor morbi non arcu risus."

                        + "\n\nNulla aliquet porttitor lacus luctus accumsan tortor posuere. Elit scelerisque mauris pellentesque pulvinar pellentesque habitant. In est ante in nibh. Semper viverra nam libero justo laoreet sit amet cursus sit. Ullamcorper morbi tincidunt ornare massa eget egestas purus viverra. Vel pharetra vel turpis nunc eget lorem. Proin sed libero enim sed faucibus turpis in eu mi. Est ante in nibh mauris cursus mattis molestie a iaculis. Est lorem ipsum dolor sit amet consectetur adipiscing elit. Sed odio morbi quis commodo. Donec pretium vulputate sapien nec. Dignissim suspendisse in est ante in nibh. Maecenas volutpat blandit aliquam etiam erat velit. Mauris rhoncus aenean vel elit scelerisque mauris pellentesque pulvinar pellentesque. Tellus integer feugiat scelerisque varius morbi enim nunc faucibus. Tempor orci eu lobortis elementum. Eget felis eget nunc lobortis mattis aliquam faucibus."

                        + "\n\nNulla porttitor massa id neque aliquam. Amet dictum sit amet justo donec. Pharetra pharetra massa massa ultricies mi quis hendrerit. Massa sed elementum tempus egestas sed sed risus pretium. Semper quis lectus nulla at volutpat diam ut venenatis tellus. Non enim praesent elementum facilisis leo vel fringilla est. Aliquam id diam maecenas ultricies mi. Phasellus faucibus scelerisque eleifend donec pretium. Lorem mollis aliquam ut porttitor leo. A diam sollicitudin tempor id eu nisl nunc mi. Duis tristique sollicitudin nibh sit amet commodo nulla facilisi nullam. Sed viverra ipsum nunc aliquet bibendum enim facilisis. Sed lectus vestibulum mattis ullamcorper velit sed ullamcorper. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat. Quisque id diam vel quam elementum. Vitae suscipit tellus mauris a. Sed augue lacus viverra vitae congue."

                        + "\n\nMattis aliquam faucibus purus in massa tempor nec feugiat nisl. Mi eget mauris pharetra et ultrices neque ornare aenean. Iaculis at erat pellentesque adipiscing commodo elit at imperdiet dui. Sed odio morbi quis commodo odio aenean sed adipiscing. Pellentesque id nibh tortor id aliquet lectus proin. Morbi enim nunc faucibus a pellentesque sit amet porttitor eget. Vitae ultricies leo integer malesuada nunc vel risus commodo. Id eu nisl nunc mi. Proin nibh nisl condimentum id. Congue mauris rhoncus aenean vel elit scelerisque mauris. Quis blandit turpis cursus in hac habitasse. Euismod in pellentesque massa placerat duis ultricies. Nunc non blandit massa enim nec. Vitae congue mauris rhoncus aenean vel elit."

                        + "\n\nSit amet luctus venenatis lectus magna fringilla. Vel pretium lectus quam id leo. Mauris vitae ultricies leo integer malesuada nunc vel risus. Tellus id interdum velit laoreet id donec. Posuere urna nec tincidunt praesent. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi. Semper auctor neque vitae tempus quam pellentesque. Tellus molestie nunc non blandit massa enim nec. Sollicitudin tempor id eu nisl nunc mi ipsum faucibus vitae. Bibendum neque egestas congue quisque egestas diam in arcu. Pellentesque elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at."

                        + "\n\nConsectetur adipiscing elit ut aliquam purus sit amet luctus venenatis. Neque laoreet suspendisse interdum consectetur libero id faucibus. Ultricies lacus sed turpis tincidunt id. Euismod in pellentesque massa placerat duis ultricies. Dui sapien eget mi proin. Malesuada proin libero nunc consequat interdum. Et netus et malesuada fames ac turpis egestas maecenas. Nulla facilisi morbi tempus iaculis urna id volutpat lacus laoreet. Magna ac placerat vestibulum lectus mauris ultrices eros. Molestie nunc non blandit massa enim nec. Justo nec ultrices dui sapien. Elit duis tristique sollicitudin nibh. Lectus arcu bibendum at varius vel pharetra vel turpis."

                        + "\n\nPlatea dictumst vestibulum rhoncus est pellentesque elit ullamcorper. Mattis aliquam faucibus purus in massa tempor nec. Senectus et netus et malesuada fames. Sit amet dictum sit amet. Mauris in aliquam sem fringilla ut morbi tincidunt augue interdum. Quam lacus suspendisse faucibus interdum posuere lorem ipsum dolor. Ut eu sem integer vitae justo eget magna fermentum. Non nisi est sit amet facilisis. Rhoncus est pellentesque elit ullamcorper dignissim. Congue nisi vitae suscipit tellus mauris a diam maecenas. Congue eu consequat ac felis. Enim facilisis gravida neque convallis a cras semper. Fringilla urna porttitor rhoncus dolor purus non enim praesent. Ornare lectus sit amet est placerat in."

                        + "\n\nTellus cras adipiscing enim eu turpis egestas. Amet nulla facilisi morbi tempus. Praesent semper feugiat nibh sed pulvinar proin gravida. Tortor vitae purus faucibus ornare suspendisse sed nisi lacus sed. Condimentum mattis pellentesque id nibh tortor id. Egestas dui id ornare arcu odio. Vel eros donec ac odio tempor orci. Dui vivamus arcu felis bibendum ut. Egestas pretium aenean pharetra magna ac placerat vestibulum lectus. Quis ipsum suspendisse ultrices gravida. Semper feugiat nibh sed pulvinar proin. Id nibh tortor id aliquet lectus proin. Leo vel orci porta non pulvinar neque laoreet. Libero justo laoreet sit amet cursus. Donec ultrices tincidunt arcu non sodales neque sodales ut."

                        + "\n\nIn tellus integer feugiat scelerisque varius morbi enim nunc faucibus. A scelerisque purus semper eget. Vel facilisis volutpat est velit egestas dui id ornare. Sem et tortor consequat id porta. Lobortis scelerisque fermentum dui faucibus in ornare quam. Vitae nunc sed velit dignissim sodales ut. Enim lobortis scelerisque fermentum dui. Nulla facilisi nullam vehicula ipsum a arcu cursus vitae. Natoque penatibus et magnis dis parturient montes nascetur ridiculus. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Dictum varius duis at consectetur lorem donec massa. Et netus et malesuada fames ac. Sed vulputate odio ut enim. Feugiat nisl pretium fusce id velit. Lacus laoreet non curabitur gravida arcu ac tortor. Cras pulvinar mattis nunc sed. Nisl vel pretium lectus quam."

                        + "\n\nDiam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Leo urna molestie at elementum eu facilisis sed odio morbi. Fermentum et sollicitudin ac orci phasellus egestas. Enim nunc faucibus a pellentesque sit amet porttitor eget. Turpis tincidunt id aliquet risus feugiat. Erat nam at lectus urna duis convallis convallis tellus. Auctor elit sed vulputate mi sit. Lorem dolor sed viverra ipsum nunc aliquet bibendum enim. Urna nec tincidunt praesent semper feugiat nibh sed pulvinar. Nec dui nunc mattis enim ut tellus elementum sagittis. Eu scelerisque felis imperdiet proin fermentum. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam. Integer eget aliquet nibh praesent tristique. Phasellus egestas tellus rutrum tellus pellentesque.",
                Tags = new string?[5]
                {
                                        "UI",
                                        "Web Development",
                                        "Software Development",
                                        "Blazor Webassembly",
                                        "Lorem Ipsum"
                }
            },
            new()
            {
                Id = 1,
                Title = "Testing Model Binding",
                Subtitle = "Learning More About Blazor Today",
                Content = string.Empty,
                Tags = new string?[2]
                {
                    "Blazor",
                    "C#"
                }
            }
        };

        public void SetAsCurrentViewing(NoteModel model)
        {
            currentViewingNote = model;
        }

        public async Task GetNotes()
        {

        }

        public void AddNewNote()
        {
            NoteModel newModel = new()
            {
                Id = noteModels.Count,
                Title = RenameIfDuplicate("Untitled"),
                Subtitle = string.Empty,
                Content = string.Empty,
                Tags = new string?[0],
                CreatedDateOn = DateTime.Now.Date.ToLongDateString(),
                ModifiedDateOn = DateTime.Now.Date.ToLongDateString()
            };
            noteModels.Add(newModel);
            currentViewingNote = newModel;
        }

        public void RemoveNote(NoteModel model)
        {
            var indexOf = noteModels.IndexOf(model);
            noteModels.Remove(model);
            if (noteModels.Count <= 0)
            {
                currentViewingNote = null;
                return;
            }

            if (indexOf - 1 < 0)
            {
                currentViewingNote = noteModels[indexOf];
                return;
            }

            currentViewingNote = noteModels[indexOf-1];
        }


        public string RenameIfDuplicate(string title)
        {
            var count = 0;
            var newTitle = title;
            foreach (var note in noteModels)
            {
                if (note.Title == newTitle)
                {
                    count++;
                    newTitle = $"{title} ({count})";
                }
            }

            if (count == 0) return title;
            return newTitle;
        }
    }
}
