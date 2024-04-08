namespace GuidonApp.Models
{
    public class GameField
    {
        public int GameFieldID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Можно добавить размер поля, если он ограничен
        public int Width { get; set; }
        public int Height { get; set; }

        // Списки сущностей на поле
        public virtual ICollection<GameFieldNPC> GameFieldNPCs { get; set; }
        public virtual ICollection<GameFieldBoss> GameFieldBosses { get; set; }

        // Положение главного героя на этом поле
        // Это предполагает, что на каждом поле может быть только один герой
        // Если героев может быть много, тогда нужно создать отношение "много ко многим"
        public int? HeroID { get; set; }
        public virtual Hero Hero { get; set; }

        // ...
    }
}
