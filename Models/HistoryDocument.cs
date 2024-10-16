using System.ComponentModel.DataAnnotations.Schema;

namespace QLDD.Models
{
    public class HistoryDocument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Action { get; set; }
        public string? TimeChange { get; set; }
        public int? UserId { get; set; } 
        public int? DocumentId { get; set; } 
        public User? User { get; set; }// người edit
        public Document? Document { get; set; }//hồ sơ

    }
}
