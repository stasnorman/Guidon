namespace GuidonApp.Models
{
    public class NPCItem
    {
        public int NPCID { get; set; }
        public int ItemID { get; set; }
        public int Price { get; set; } // Цена предмета, если NPC продает его

        public virtual NPC NPC { get; set; }
        public virtual Item Item { get; set; }
    }
}
