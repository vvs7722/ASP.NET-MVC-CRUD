
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required,MinLength(2)]
        [DisplayName("Name First")]
        public string? FirstName { get; set; }
        [Required, MinLength(2)]
        public string? LastName { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }

    }
}
