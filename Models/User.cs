using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDD.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string? Code { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        [StringLength(50)]
        public string? FirstMidName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? BirthYear { get; set; }
        public int? Gender { get; set; }
        public string? Avatar { get; set; }
        [StringLength(20)]
        public string? TaxCode { get; set; }
        public string? PhoneNumber { get; set; } 
        public string? Email { get; set; }
        //start để sau:
        [StringLength(5)]
        public string? NationalityCode { get; set; }
        [StringLength(30)]
        public string? NationalityNameTV { get; set; }
        [StringLength(30)]
        public string? NationalityNameQT { get; set; }
        //end để sau:
        [StringLength(30)]
        public string? Nation { get; set; } // dân tộc
        public string? Religion { get; set; } // tôn giáo
        public string? Career { get; set; } // cviec
        public string? NameAndAddressOrganization { get; set; } // tên và dc cơ quan
        public string? Birthplace { get; set; }//nơi sinh
        public string? CitizenID { get; set; }//cccd
        //public int? TypeOfIdentificationDocs { get; set; }
        public DateTime? IssueDate { get; set; } // ngày cấp
        [StringLength(100)]
        public string? IssuePlace { get; set; } //nơi cấp
        public int? Role { get; set; } //0.Cá nhân, 1.Cơ quan tiếp nhận, 2.Cơ quan thẩm định
        public int? PermanentAddressID { get; set; } // thường trú
        public int? TemporaryAddressID { get; set; } // tạm trú
        //ho gd
        public int? HouseHoldID { get; set; }
        public int? RoleInFamily { get; set; }//0:đồng sử dụng(vợ/chồng),1:cha,2.mẹ
        public int Status { get; set; }
        public HouseHold? HouseHold { get; set; }
        public Address? PermanentAddress { get; set; } // dc thuong tru
        public Address? TemporaryAddress { get; set; } // dc tam tru
    }
}
