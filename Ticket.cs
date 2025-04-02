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

        [Required]
        [Range(1,10,ErrorMessage = "Quanity of tickets must be between 1 and 10")]
        public int Quantity { get; set; } = 0;

        [Required]
        [CreditCard(ErrorMessage = "Credit card number is required")]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^(0[1 - 9]|1[0 - 2])\\/?([0 - 9]{2})$", ErrorMessage = "Invalid expiration date")] 
        public string Expiration { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^\\d{3,4}$",ErrorMessage = "Invalid security code")]
        public string SecurityCode { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string Address { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Province is required")]
        public string Province { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Postal Code is required")]
        [RegularExpression("^[A-Z]\\d[A-Z] \\d[A-Z]\\d$",ErrorMessage = "Invalid postal code format")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is required")]
        public string Country { get; set; } = string.Empty;
    }
}
