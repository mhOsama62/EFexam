namespace examDomin
{
    public class Parts
    {
        public int Carid { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int SuppliersID { get; set; }

        // ربط جدول Parts بجدول Cars
        public virtual Cars Car { get; set; }

        // ربط جدول Parts بجدول Suppliers
        public virtual Suppliers Supplier { get; set; }
    }
}
