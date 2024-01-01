using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PriceDTO
    {
        public long PriceId { get; set; }
        public int BookId { get; set; }
        public Nullable<decimal> BuyingPrice { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
    }
}
