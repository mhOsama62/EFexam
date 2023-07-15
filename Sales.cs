namespace examDomin
{
    public class Sales
    {
        public int id { get; set; }
        public double Total { get; set; }

        // ربط جدول Sales بجدول Cars
        public int CarID { get; set; }
        public virtual Cars Car { get; set; }

        // ربط جدول Sales بجدول Custmor
        public int CustmorID { get; set; }
        public virtual Custmor Custmor { get; set; }
    }
}
