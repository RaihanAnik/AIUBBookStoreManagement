using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Inventory
    { 
     public long InventoryId { get; set; }
    public long BookId { get; set; }
    public long Quantity { get; set; }
}
}