using AudioLibraryApp.Entities;
using AudioLibraryApp.Repositories;
using AudioLibraryApp.Data;


var cdmusicRepository = new SqlRepository<CDMusic>(new AudioLibraryDbContext());
AddCdMusics(cdmusicRepository);
AddVinylmusics(cdmusicRepository);
WriteAllToConsole(cdmusicRepository);

static void AddCdMusics(IRepository<CDMusic> cdmusicRepository)
{
    cdmusicRepository.Add(new CDMusic { AlbumTitle = "The number of the beast", AlbumArtist = "Iron Maiden" });
    cdmusicRepository.Add(new CDMusic { AlbumTitle = "Deep Purple in Rock", AlbumArtist = "Deep Purple" });
    cdmusicRepository.Add(new CDMusic { AlbumTitle = "The Great War", AlbumArtist = "Sabaton" });
    cdmusicRepository.Save();
}

static void AddVinylmusics(IWriteRepository<VinylMusic> vinylRepository)
{
    vinylRepository.Add(new VinylMusic { AlbumTitle = "Impera", AlbumArtist = "Ghost" });
    vinylRepository.Add(new VinylMusic { AlbumTitle = "Royal Tea", AlbumArtist = "Joe Bonamassa" });
    vinylRepository.Add(new VinylMusic { AlbumTitle = "Paranoid", AlbumArtist = "Black Sabbath" });
    vinylRepository.Save();

}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}