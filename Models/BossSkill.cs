namespace GuidonApp.Models
{
    // Модель для связующей таблицы "BossesSkills"
    public class BossSkill
    {
        public int BossID { get; set; }
        public int SkillID { get; set; }
        public virtual Boss Boss { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
