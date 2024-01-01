using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BookDTO
    {
        public long BookId { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookWriter { get; set; }
        public bool IsActive { get; set; }
    }
}
