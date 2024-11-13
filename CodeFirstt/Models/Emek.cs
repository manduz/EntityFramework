using System.Data.Entity;

namespace CodeFirstt
{
    public class Emek
    {
        public emekContext() : base("emekBaglanti")
        {

        }
        public virtual DbSet<IkFormu> IkFormust { get; set; }

        public virtual DbSet<iletisim> Iletisim { get; set; }
    }
}
