namespace GuidonApp.Models
{
    // Модель для таблицы "Skills"
    public class Skill
    {
        public int SkillID { get; set; }
        public string Name { get; set; }
        public int Cooldown { get; set; }
        public string Description { get; set; }
    }
}
