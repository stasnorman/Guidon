namespace GuidonApp.Models
{
    public class BossDrop
    {
        public int BossID { get; set; }
        public int ItemID { get; set; }
        public float DropRate { get; set; } // Вероятность выпадения предмета

        public virtual Boss Boss { get; set; }
        public virtual Item Item { get; set; }
    }
}
