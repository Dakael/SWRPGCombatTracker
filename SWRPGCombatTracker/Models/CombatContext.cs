using Microsoft.EntityFrameworkCore;

namespace SWRPGCombatTracker.Models
{
    public class CombatContext : DbContext
    {
        public CombatContext(DbContextOptions<CombatContext> options) : base(options)
        { }

        public DbSet<DestinyPointsModel> DestinyPoints { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
    }
}