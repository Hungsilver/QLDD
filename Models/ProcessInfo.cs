using System.ComponentModel.DataAnnotations.Schema;

namespace QLDD.Models
{
    public class ProcessInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? ReceptionDate { get; set; } //ngày tiếp nhận
        public DateTime? DueDate { get; set; }//ngày hẹn trả
        public DateTime? DueProcessDate { get; set; }//hạn xử lí quy trình     
        public int? TypeReception { get; set; } // hình thức tiếp nhận
        public int? TypeReceiceDate { get; set; }// hình thức nhận kết quả

    }
}
