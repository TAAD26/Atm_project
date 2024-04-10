using System.ComponentModel.DataAnnotations;

namespace Atm_Project.Model
{
    public class Customer
    {
        [StringLength(11)]
        public string PersonalId { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [StringLength(80)]
        public string Address { get; set; }
        [StringLength(6)]
        public string UserId { get; set; }
        [StringLength(24)]
        public string Password { get; set; }
        [Key]
        public Guid AccountKey { get; set; }
    }
}
