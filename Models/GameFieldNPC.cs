namespace GuidonApp.Models
{
    public class GameFieldNPC
    {
        public int GameFieldID { get; set; }
        public int NPCID { get; set; }
        public virtual GameField GameField { get; set; }
        public virtual NPC NPC { get; set; }
    }
}
