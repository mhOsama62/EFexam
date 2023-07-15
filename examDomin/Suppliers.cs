namespace examDomin
{
    public class Suppliers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // ربط جدول Suppliers بجدول Parts
        public virtual List<Parts> Parts { get; set; }
    }
}
