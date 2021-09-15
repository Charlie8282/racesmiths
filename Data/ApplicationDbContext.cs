using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using racesmiths.Models;

namespace racesmiths.Data
{
    public class ApplicationDbContext : IdentityDbContext<RSUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Champ> Champs { get; set; }
        //public DbSet<ChampRule> ChampRules { get; set; }
        //public DbSet<ChampSetting> ChampSettings { get; set; }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public DbSet<Race> Races { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<RSUser> ClubUsers { get; set; }
        public DbSet<racesmiths.Models.Event> Event { get; set; }
        public DbSet<racesmiths.Models.Race> Race { get; set; }

    }
}
