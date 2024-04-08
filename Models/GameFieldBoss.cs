namespace GuidonApp.Models
{
    public class GameFieldBoss
    {
        public int GameFieldID { get; set; }
        public int BossID { get; set; }
        public virtual GameField GameField { get; set; }
        public virtual Boss Boss { get; set; }
    }
}
