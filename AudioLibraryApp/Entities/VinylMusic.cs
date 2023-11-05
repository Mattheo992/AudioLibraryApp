namespace AudioLibraryApp.Entities
{
    public class VinylMusic : EntityBase
    {
        public string? AlbumTitle { get; set; }

        public string? AlbumArtist { get; set; }

        public string? PublicationDate { get; set; }

        public override string ToString() => $"Id: {Id}, AlbumTitle: {AlbumTitle}, AlbumArtist: {AlbumArtist}, PublicationDate: {PublicationDate}";
    }
}
