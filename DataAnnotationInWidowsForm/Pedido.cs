using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationInWidowsForm
{
    public class Pedido
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(maximumLength: 160, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(maximumLength: 160, MinimumLength = 3)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        public decimal Total { get; set; }
    }
}
