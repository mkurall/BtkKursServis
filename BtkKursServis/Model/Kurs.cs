using System.ComponentModel.DataAnnotations.Schema;

namespace BtkKursServis.Model
{
    [Table("TblKurslar")]
    public class Kurs
    {
        public int Id { get; set; }
        [Column("KursAdi")]
        public string Ad { get; set; }
        public DateTime KursTarihi { get; set; }
    }
}
