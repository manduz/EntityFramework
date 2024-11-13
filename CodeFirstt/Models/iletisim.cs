using System.ComponentModel.DataAnnotations;

namespace CodeFirstt
{
    public class iletisim : IEntity
    {
        public int Id { get; set; }

        [StringLength(50),Required] //kullanıcının zorunlu girmesini istiyorsam
        public string AdSoyad { get; set; }
        [StringLength(100), Required]
        public string Email { get; set; }
        [StringLength(250), Required]
        public string Mesajiniz { get; set; }

    }
}
