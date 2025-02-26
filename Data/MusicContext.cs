using Microsoft.EntityFrameworkCore;
using Moment_4_MusicApi.Models;

namespace Moment_4_MusicApi.Data;

public class MusicContext : DbContext
{
    public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }

    public DbSet<Music> Music { get; set; }
}