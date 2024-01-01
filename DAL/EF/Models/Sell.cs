using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class sell
    {
        public long SellId { get; set; }
        public int BookId { get; set; }
        public long InventoryId { get; set; }
        public System.DateTime SellDate { get; set; }
        public int SellQuantity { get; set; }
    }
}