namespace GuidonApp.Models
{
    public class Boss
    {
        public int BossID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public string Description { get; set; }

        // Связь с таблицей "BossSkills"
        public virtual ICollection<BossSkill> BossSkills { get; set; }
    }
}
