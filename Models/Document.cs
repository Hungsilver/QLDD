using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QLDD.Models
{
    public class Document
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string? Code { get; set; }
        [StringLength(50)]
        public string? FirstMidName { get; set; }
        public string? LastName { get; set; }
        public string? FullName
        {
            get
            {
                return LastName + " " + FirstMidName;
            }
        }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Birthplace { get; set; }//nơi sinh
        public string? Avatar { get; set; }
        public string? CitizenID { get; set; }//cccd
        public DateTime? IssueDate { get; set; } // ngày cấp
        [StringLength(100)]
        public string? IssuePlace { get; set; } //nơi cấp
        public string? Nation { get; set; } // dân tộc
        public string? Religion { get; set; } // tôn giáo
        public string? Career { get; set; } // cviec
        public string? NameAndAddressOrganization { get; set; } // tên và dc cơ quan
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? UserID { get; set; }//ID user tạo hồ sơ
        //navigate- tạo bản ghi mới để tách biệt dữ liệu của hồ sơ
        public int? PermanentAddressID { get; set; } // thường trú
        public int? TemporaryAddressID { get; set; } // tạm trú
        public Address? PermanentAddress { get; set; } // dc thuong tru
        public Address? TemporaryAddress { get; set; } // dc tam tru
        [StringLength(100)]
        public string? NameFather { get; set; }
        public DateTime? BirthDateFather { get; set; }
        [StringLength(100)]
        public string? NameMother { get; set; }
        public DateTime? BirthDateMother { get; set; }
        [StringLength(100)]
        public string? NameHubOrWf { get; set; } // name husband or wife
        public DateTime? BirthDateHubOrWf { get; set; }
        [StringLength(250)]
        public string? SuggestedContent { get; set; }
        public string? DetailContent { get; set; }
        // mặc định chọn 1 cái nên set là string
        public string? ReceivingAgency { get; set; } // cơ quan tiếp nhận
        //---------đơn đăng kí-----------//
        public string? CoUserName { get; set; } //tên người đồng sử dụng-vợ or chồng
        public DateTime? BirthDateCoUser { get; set; } 
        //giấy chứng nhận đã cấp//
        public string? NumberGCN { get; set; }
        public string? NumberGCNIssue { get; set; }
        public DateTime? DateIssueGCN { get; set; }
        public string? PlaceIssueGCN { get; set; }
        //nd biến động
        public string? ContentBeforeGCN { get; set; }
        public string? ContentAfterGCN { get; set; }
        public string? ReasonGCN { get; set; } // lí do biến động
        public bool? THNVTC { get; set; } //thực hiện nghĩa vụ tài chính
        public bool? IsIssueGCNNew { get; set; } //nhu cầu cấp gcn mới
        public string? UrlFile1 { get; set; }
        public string? UrlGCN { get; set; }
        public string? UrlFile3 { get; set; }
        public string? UrlAttachedFile { get; set; }//file đính kèm
        public int? ProcessUserID { get; set; }//id người xử lí
        public User? ProcessUser { get; set; }//người xử lí
        public int? ProcessInfoID { get; set; }//id thông tin xử lí
        public ProcessInfo? ProcessInfo { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        // thiếu cơ quan thực hiện- xem xét

        //1:Đang xử lí(nd),2:Chờ tiếp nhận(tn),3:Đang xử lí tiếp nhận,
        //4:Đã xử lí tiếp nhận thành công,5:Đã từ chối tiếp nhận,6:Đang chờ thẩm định,
        //7:Đang xử lí hồ sơ thẩm định,8:Đã thẩm định thành công,9:Đã từ chối thẩm định
        public int Status { get; set; }
    }
}
