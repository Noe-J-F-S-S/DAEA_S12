namespace APIDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public List<Detail> Details { get; set; }

        public bool IsActive { get; set; }
    }
}
