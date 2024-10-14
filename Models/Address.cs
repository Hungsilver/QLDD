using System.ComponentModel.DataAnnotations.Schema;

namespace QLDD.Models
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? WardCode { get; set; }
        public string? AddressDetail { get; set; }
        public string? Street { get; set; }
        public string? Hamlet { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? Province { get; set; }
        public int Status { get; set; }
    }
}
