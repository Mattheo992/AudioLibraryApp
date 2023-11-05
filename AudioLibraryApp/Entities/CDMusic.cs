namespace AudioLibraryApp.Entities
{
    public class CDMusic : EntityBase
    {
        public string? AlbumTitle { get; set; }

        public string? AlbumArtist { get; set; }


        public override string ToString() => $"Id: {Id}, Album Title: {AlbumTitle}, Album Artist: {AlbumArtist}";
    }
}
