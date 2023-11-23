using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int UserAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // PayPal, CreditCard, etc.
        //public virtual UserAccount UserAccount { get; set; }
    }
}
