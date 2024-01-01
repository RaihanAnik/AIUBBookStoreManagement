using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AllBookInformationDTO
    {
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookWriter { get; set; }
        public string Profit { get; set; }
        public long Quantity { get; set; }
        public long PriceId { get; set; }
        public Nullable<decimal> BuyingPrice { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
    }
}