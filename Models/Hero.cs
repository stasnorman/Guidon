namespace GuidonApp.Models
{
    public class Hero
    {
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Description { get; set; }

        // Добавляем координаты для позиционирования героя на игровом поле
        public int PositionX { get; set; } // Горизонтальная позиция
        public int PositionY { get; set; } // Вертикальная позиция

        // Связь с таблицей "HeroSkills"
        public virtual ICollection<HeroSkill> HeroSkills { get; set; }

        // Может быть еще свойство для указания на каком он поле находится
        public int GameFieldID { get; set; }
        public virtual GameField GameField { get; set; }
    }
}
