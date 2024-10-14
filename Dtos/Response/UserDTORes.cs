using System.ComponentModel.DataAnnotations;

namespace QLDD.Dtos.Response
{
    public class UserDTORes
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstMidName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? BirthYear { get; set; }
        public int Gender { get; set; }
        public string? Avatar { get; set; }
        [StringLength(20)]
        public string? TaxCode { get; set; }
        [StringLength(5)]
        public string? NationalityCode { get; set; }
        [StringLength(30)]
        public string? NationalityNameTV { get; set; }
        [StringLength(30)]
        public string? NationalityNameQT { get; set; }
        [StringLength(30)]
        public string? Nation { get; set; }
        public int TypeOfIdentificationDocs { get; set; }
        public DateTime? IssueDate { get; set; }
        [StringLength(100)]
        public string? IssuePlace { get; set; }
        public int? Role { get; set; } //0.Cá nhân, 1.Cơ quan tiếp nhận, 2.Cơ quan thẩm định
        public int? AddressID { get; set; }
        public int? IdentificationID { get; set; }
        public int Status { get; set; }
    }
}
