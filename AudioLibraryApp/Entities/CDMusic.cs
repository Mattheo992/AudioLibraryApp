namespace AudioLibraryApp.Entities
{
    public class CDMusic : EntityBase
    {
        public string? AlbumTitle { get; set; }

        public string? AlbumArtist { get; set; }

        public int? PublicationDate { get; set; }

        public override string ToString() => $"Id: {Id}, AlbumTitle: {AlbumTitle}, AlbumArtist: {AlbumArtist}, PublicationDate: {PublicationDate}";
    }
}
