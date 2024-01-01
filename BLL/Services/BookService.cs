using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookServices
    {
        public static BookDTO Add(BookDTO t)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookDTO, Book>());

            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(t);

            var repo = DataAccessFactory.BookDataAccess().Add(data);

            return null;
        }


        public static PriceDTO AddPrice(PriceDTO p)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PriceDTO, Price>());


            Price u = new Price();

            u.BookId = p.BookId;
            u.BuyingPrice = p.BuyingPrice;
            u.SellingPrice = p.SellingPrice;

            var repo = DataAccessFactory.PriceDataAccess().Add(u);

            return null;
        }

        public static List<BookDTO> Show()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookDTO, Book>());
            var mapper = new Mapper(config);
            var repo = DataAccessFactory.BookDataAccess().Get();
            // var bookDTOList = mapper.Map<List<BookDTO>>(repo);


            var data = (from r in repo
                        select new BookDTO
                        {
                            BookId = r.BookId,
                            BookName = r.BookName,
                            BookType = r.BookType,
                            BookWriter = r.BookWriter,
                            IsActive = r.IsActive


                        }).ToList();
            return data;
        }
        public static List<BookDTO> ShowActiveBooks()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookDTO, Book>());
            var mapper = new Mapper(config);
            var repo = DataAccessFactory.BookDataAccess().Get();
            // var bookDTOList = mapper.Map<List<BookDTO>>(repo);
            var data = (from r in repo
                        where r.IsActive == true
                        select new BookDTO
                        {
                            BookId = r.BookId,
                            BookName = r.BookName,
                            BookType = r.BookType,
                            BookWriter = r.BookWriter,
                            IsActive = r.IsActive


                        }).ToList();
            return data;
        }
        public static List<UserDTO> ShowAllUsers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>());
            var mapper = new Mapper(config);
            var repo = DataAccessFactory.UsersDataAccess().Get();
            var data = (from r in repo
                        select new UserDTO
                        {
                            IntUserId = r.IntUserId,
                            UserName = r.UserName,
                            UserType = r.UserType,
                            UserEmail = r.UserEmail,
                            Age = r.Age,
                            Address = r.Address,
                            Mobile = r.Mobile,
                            Password = r.Password,
                            IsActive = r.IsActive



                        }).ToList();
            return data;
        }

        public static List<UserDTO> ShowAllActiveUsers()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>());
            var mapper = new Mapper(config);
            var repo = DataAccessFactory.UsersDataAccess().Get();
            // var bookDTOList = mapper.Map<List<BookDTO>>(repo);
            var data = (from r in repo
                        where r.IsActive == true
                        select new UserDTO
                        {
                            IntUserId = r.IntUserId,
                            UserName = r.UserName,
                            UserType = r.UserType,
                            UserEmail = r.UserEmail,
                            Age = r.Age,
                            Address = r.Address,
                            Mobile = r.Mobile,
                            Password = r.Password,
                            IsActive = r.IsActive



                        }).ToList();
            return data;
        }
        public static List<AllBookInformationDTO> ReportInventory()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>());
            var mapper = new Mapper(config);


            var repo = DataAccessFactory.BookDataAccess().Get();
            var inventories = DataAccessFactory.InventoryDataAccess().Get();
            var prices = DataAccessFactory.PriceDataAccess().Get();

            var data = (from r in repo
                        join b in inventories on r.BookId equals b.BookId
                        join p in prices on r.BookId equals p.BookId
                        select new AllBookInformationDTO
                        {
                            BookName = r.BookName,
                            BookType = r.BookType,
                            BookWriter = r.BookWriter,
                            Quantity = b.Quantity,
                            PriceId = p.PriceId,
                            BuyingPrice = p.BuyingPrice,
                            SellingPrice = p.SellingPrice,
                            Profit = (p.SellingPrice - p.BuyingPrice) > 0 ? "Profit" : "Loss"
                        }).ToList();
            return data;
        }
    }
    }
