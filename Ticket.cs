using System.ComponentModel.DataAnnotations;

namespace TicketHub {
    public class Ticket {
        public int ConcertId { get; set; } = 0;
        [EmailAddress]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Email is required")]
        public string Email { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        [Phone]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number is required")]
        public string Phone { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        [CreditCard]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Credit card is required")]
        public string CreditCard { get; set; } = string.Empty;
        [Required]
        public string Expiration { get; set; } = string.Empty;
        [Required]
        public string SecurityCode { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string Province { get; set; } = string.Empty;
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
    }
}
