using System.ComponentModel.DataAnnotations;

namespace Atm_Project.Model
{
    public class Account
    {
        [Key]
        [StringLength(34)]
        public string AccountNo { get; set; }
        public Guid AccountKey { get; set; }
        public Customer Customer { get; set; }
        public float Balance { get; set; }

    }
}
