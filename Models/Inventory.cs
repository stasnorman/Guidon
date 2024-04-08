namespace GuidonApp.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int HeroId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Hero Hero { get; set; }
    }
}
