using GuidonApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GuidonApp.ActionApp.OdbContext
{
    // Наследуемся от DbContext
    public class ConnectOdbContext : DbContext
    {
        public ConnectOdbContext(DbContextOptions<ConnectOdbContext> options)
            : base(options)
        {
        }

        // Определение DbSet для каждой сущности, которую вы хотите отобразить в базе данных
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<BossSkill> BossesSkills { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<BossDrop> BossesDrops { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroSkill> HeroesSkills { get; set; }
        public DbSet<NPCItem> NPCsItems { get; set; }
        public DbSet<GameField> GameFields{ get; set; }
        public DbSet<GameFieldBoss> GameFieldBosses { get; set; }
        public DbSet<GameFieldNPC> GameFieldNPCs { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Здесь можно добавить дополнительные конфигурации для моделей
            // например, настройка связей между таблицами, индексы и т.д.
            modelBuilder.Entity<Hero>()
                .HasOne(h => h.GameField) // Hero has one GameField
                .WithOne(g => g.Hero) // GameField has one Hero
                .HasForeignKey<Hero>(h => h.GameFieldID); // Foreign key is in the Hero entity
            modelBuilder.Entity<BossDrop>()
                .HasKey(bd => new { bd.BossID, bd.ItemID });
            modelBuilder.Entity<BossSkill>()
                .HasKey(bs => new { bs.BossID, bs.SkillID });
            modelBuilder.Entity<GameFieldBoss>()
                .HasKey(bs => new { bs.BossID, bs.GameFieldID });
            modelBuilder.Entity<GameFieldNPC>()
                .HasKey(bs => new { bs.NPCID, bs.GameFieldID });
            modelBuilder.Entity<NPCItem>()
                .HasKey(ni => new { ni.NPCID, ni.ItemID });
            modelBuilder.Entity<HeroSkill>()
                .HasKey(bs => new { bs.SkillID, bs.HeroID });

            base.OnModelCreating(modelBuilder);
        }
    }
}
