using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BookRepo : ERepo,
       IRepo<Book, int, Book>,
       IRepo<User, int, User>,
       IRepo<Inventory, int, Inventory>,
       IRepo<Price, int, Price>,
       IRepo<sell, int, sell>
    {
        public Book GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        Book IRepo<Book, int, Book>.Add(Book obj)
        {
            Book b = new Book();


            b.BookName = obj.BookName;
            b.BookType = obj.BookType;
            b.BookWriter = obj.BookWriter;
            b.IsActive = true;
            db.Books.Add(b);
            db.SaveChanges();
            return b;


        }

        User IRepo<User, int, User>.Add(User obj)
        {
            User b = new User();
            b.UserName = obj.UserName;
            b.UserType = obj.UserType;
            b.UserEmail = obj.UserEmail;
            b.Age = obj.Age;
            b.Address = obj.Address;
            b.Mobile = obj.Mobile;
            b.Password = obj.Password;
            b.IsActive = obj.IsActive;
            db.Users.Add(b);
            db.SaveChanges();
            return b;


        }

        Inventory IRepo<Inventory, int, Inventory>.Add(Inventory obj)
        {
            Inventory b = new Inventory();


            b.BookId = obj.BookId;
            b.Quantity = obj.Quantity;
            db.Inventories.Add(b);
            db.SaveChanges();
            return b;
        }

        Price IRepo<Price, int, Price>.Add(Price obj)
        {
            Price b = new Price();
            b.BuyingPrice = obj.BuyingPrice;
            b.SellingPrice = b.SellingPrice;
            b.PriceId = obj.PriceId;
            b.BookId = obj.BookId;
            db.Prices.Add(b);
            db.SaveChanges();
            return b;

        }

        sell IRepo<sell, int, sell>.Add(sell obj)
        {
            sell b = new sell();
            b.BookId = obj.BookId;
            b.InventoryId = obj.InventoryId;
            b.SellDate = obj.SellDate;
            b.SellQuantity = obj.SellQuantity;
            db.sells.Add(b);
            db.SaveChanges();
            return b;
        }

        bool IRepo<Book, int, Book>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepo<User, int, User>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Inventory, int, Inventory>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Price, int, Price>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepo<sell, int, sell>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Book> IRepo<Book, int, Book>.Get()
        {
            return db.Books.ToList();
        }

        List<User> IRepo<User, int, User>.Get()
        {
            return db.Users.ToList();
        }

        List<Inventory> IRepo<Inventory, int, Inventory>.Get()
        {
            return db.Inventories.ToList();
        }

        List<Price> IRepo<Price, int, Price>.Get()
        {
            return db.Prices.ToList();
        }

        List<sell> IRepo<sell, int, sell>.Get()
        {
            return db.sells.ToList();
        }

        List<Book> IRepo<Book, int, Book>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IRepo<User, int, User>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Inventory> IRepo<Inventory, int, Inventory>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Price> IRepo<Price, int, Price>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<sell> IRepo<sell, int, sell>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        User IRepo<User, int, User>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        Inventory IRepo<Inventory, int, Inventory>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        Price IRepo<Price, int, Price>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        sell IRepo<sell, int, sell>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }

        Book IRepo<Book, int, Book>.Update(Book obj)
        {
            var exists = db.Books.Where(x => x.BookId == obj.BookId).FirstOrDefault();

            exists.BookName = obj.BookName;
            exists.BookType = obj.BookType;
            exists.BookWriter = obj.BookWriter;
            exists.IsActive = obj.IsActive;
           
            db.SaveChanges();

            return exists;

        }

        User IRepo<User, int, User>.Update(User obj)
        {
            throw new NotImplementedException();
        }

        Inventory IRepo<Inventory, int, Inventory>.Update(Inventory obj)
        {
            throw new NotImplementedException();
        }

        Price IRepo<Price, int, Price>.Update(Price obj)
        {
            throw new NotImplementedException();
        }

        sell IRepo<sell, int, sell>.Update(sell obj)
        {
            throw new NotImplementedException();
        }
    }


}