namespace examDomin
{
    public class Cars
    {
        public int id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Gear { get; set; }
        public string Km { get; set; }

        // ربط جدول Cars بجدول Parts
        public virtual List<Parts> Parts { get; set; }
    }
}
