namespace GuidonApp.Models
{
    public class HeroSkill
    {
        public int HeroID { get; set; }
        public int SkillID { get; set; }

        public virtual Hero Hero { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
