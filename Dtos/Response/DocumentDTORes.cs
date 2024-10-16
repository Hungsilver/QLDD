using QLDD.Models;
using System.ComponentModel.DataAnnotations;

namespace QLDD.Dtos.Response
{
    public class DocumentDTORes
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? FirstMidName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Birthplace { get; set; }//nơi sinh
        public string? Avatar { get; set; }
        public string? CitizenID { get; set; }//cccd
        public DateTime? IssueDate { get; set; } // ngày cấp
        public string? IssuePlace { get; set; } //nơi cấp
        public string? Nation { get; set; } // dân tộc
        public string? Religion { get; set; } // tôn giáo
        public string? Career { get; set; } // cviec
        public string? NameAndAddressOrganization { get; set; } // tên và dc cơ quan
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? UserID { get; set; }//ID user tạo hồ sơ
        public int? PermanentAddressID { get; set; } // thường trú
        public int? TemporaryAddressID { get; set; } // tạm trú
        public Address? PermanentAddress { get; set; } // dc thuong tru
        public Address? TemporaryAddress { get; set; } // dc tam tru
        public string? NameFather { get; set; }
        public DateTime? BirthDateFather { get; set; }
        public string? NameMother { get; set; }
        public DateTime? BirthDateMother { get; set; }
        public string? NameHubOrWf { get; set; } // name husband or wife
        public DateTime? BirthDateHubOrWf { get; set; }
        public string? SuggestedContent { get; set; }
        public string? DetailContent { get; set; }
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
        public int Status { get; set; }
    }
}
