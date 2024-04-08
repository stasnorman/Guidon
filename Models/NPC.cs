namespace GuidonApp.Models
{
    public class NPC
    {
        public int NPCID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // 'Friendly' или 'Hostile'
        public string Description { get; set; }

        // Связь с таблицей "NPCsItems" для дружелюбных NPC, которые продают предметы
        public virtual ICollection<NPCItem> NPCsItems { get; set; }
    }
}
