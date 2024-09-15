namespace MusicHub
{
    using System;
    using System.Text;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            //DbInitializer.ResetDatabase(context);

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albums = context.Producers
                .Include(x => x.Albums)
                .ThenInclude(x => x.Songs)
                .ThenInclude(x => x.Writer)
                .First(x => x.Id == producerId)
                .Albums.Select(x => new
                {
                    AlbumName = x.Name,
                    ReleaseDate = x.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = x.Producer.Name,
                    AlbumSongs = x.Songs.Select(s => new
                    {
                        SongName = s.Name,
                        SongPrice = s.Price,
                        SongWriterName = s.Writer.Name
                    })
                        .OrderByDescending(s => s.SongName)
                        .ThenBy(s => s.SongWriterName),

                    TotalPrice = x.Price,
                })
                .OrderByDescending(x => x.TotalPrice)
                .AsEnumerable();

            StringBuilder sb = new StringBuilder();
            foreach (var album in albums)
            {
                sb.AppendLine($"-AlbumName: {album.AlbumName}");
                sb.AppendLine($"-ReleaseDate: {album.ReleaseDate}");
                sb.AppendLine($"-ProducerName: {album.ProducerName}");
                sb.AppendLine("-Songs:");

                int count = 1;
                if (album.AlbumSongs.Any())
                {
                    foreach (var song in album.AlbumSongs)
                    {
                        sb.AppendLine($"---#{count++}");
                        sb.AppendLine($"---SongName: {song.SongName}");
                        sb.AppendLine($"---Price: {song.SongPrice:f2}");
                        sb.AppendLine($"---Writer: {song.SongWriterName}");
                    }
                }
                sb.AppendLine($"-AlbumPrice: {album.TotalPrice:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .Include(s => s.SongPerformers)
                    .ThenInclude(sp => sp.Performer)
                .Include(s => s.Writer)
                .Include(s => s.Album)
                    .ThenInclude(a => a.Producer)
                .AsEnumerable()
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(s => new
                {
                    SongName = s.Name,
                    WriterName = s.Writer.Name,
                    Performers = s.SongPerformers.Select(sp => new
                    {
                        PerformerName = sp.Performer.FirstName + " " + sp.Performer.LastName
                    }),
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration,
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.WriterName)
                .AsEnumerable();


            StringBuilder sb = new StringBuilder();

            int count = 1;
            foreach (var song in songs)
            {
                sb
                    .AppendLine($"-Song #{count++}")
                    .AppendLine($"---SongName: {song.SongName}")
                    .AppendLine($"---Writer: {song.WriterName}");

                if (song.Performers.Any())
                {
                    if (song.Performers.ToList().Count==1)
                    {
                        sb.AppendLine($"---Performer: {song.Performers.First().PerformerName}");
                    }
                    else
                    {
                        foreach (var performer in song.Performers.OrderBy(p=>p.PerformerName))
                        {
                            sb.AppendLine($"---Performer: {performer.PerformerName}");
                        }
                    }

                }

                sb
                    .AppendLine($"---AlbumProducer: {song.AlbumProducer}")
                    .AppendLine($"---Duration: {song.Duration.ToString("c")}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
