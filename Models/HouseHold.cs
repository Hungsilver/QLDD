using System.ComponentModel.DataAnnotations.Schema;

namespace QLDD.Models
{
    public class HouseHold
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? AddressID { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
