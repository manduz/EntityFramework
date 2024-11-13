using CodeFirstt.Models;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstt
{
    public class IkFormu:IEntity
    {
        [Key]//primary key oldu
        public int Id { get; set; }

        [StringLength(50), Required]
        public string AdSoyad { get; set; }
        [StringLength(100), Required]
        public string Email { get; set; }
        [StringLength(11), Required]

        public string TcNo { get; set; }
        [StringLength(18), Required]

        public string CepNo { get; set; }

        public string CvUrl { get; set; }


    }
}
