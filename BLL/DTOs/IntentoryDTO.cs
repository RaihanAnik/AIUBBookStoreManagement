using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class InventoryDTO
    {
        public long InventoryId { get; set; }
        public long BookId { get; set; }
        public long Quantity { get; set; }
        public string BookName { get; set; }
    }
}
