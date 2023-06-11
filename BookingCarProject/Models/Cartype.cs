using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookingCarProject.Models
{
    public class Cartype
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="กรุณาป้อนชื่อรถ")]
        [DisplayName("ขื่อรถ")]
        public string Name { get; set; }
        [DisplayName("ประเภทรถ")]
        public string Type { get; set; }
        [DisplayName("จำนวนที่นั่ง")]
        [Range(2, 14,ErrorMessage ="กรุณาป้อนจำนวนที่นั่งตั้งแต่ 2-14 ที่นั่ง")]
        public int Seat { get; set; }


    }
}
