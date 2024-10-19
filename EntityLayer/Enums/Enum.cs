using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Enums
{
    public class Enum
    {
        public enum OrderStatus {

            Pending = 1,     // Beklemede
            Paid = 2,        // Ödendi
            Shipped = 3,     // Gönderildi
            Completed = 4,   // Tamamlandı
            Canceled = 5    // İptal Edildi
        };
    }
}
