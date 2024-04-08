namespace GuidonApp.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Например, "Weapon" или "Scroll"
        public string Description { get; set; }
    }
}
