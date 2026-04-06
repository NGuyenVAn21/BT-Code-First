using System.ComponentModel.DataAnnotations;

namespace BT_Code_First.Models
{
    public class SinhVien
    {
        public int Id { get; set; }

        [Required]
        public string Ten { get; set; }

        public int Tuoi { get; set; }

        public string DiaChi { get; set; }
    }
}