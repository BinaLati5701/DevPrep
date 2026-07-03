using System.ComponentModel.DataAnnotations.Schema;

namespace DevPrep.Api.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; } = string.Empty;

        public string AccountType { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        public bool IsActive { get; set; }
    }
}
