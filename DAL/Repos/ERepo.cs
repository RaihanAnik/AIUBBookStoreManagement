using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ERepo
    {
        public BookStoreEntities db;
        public ERepo()
        {
            db = new BookStoreEntities();
        }
    }
}
