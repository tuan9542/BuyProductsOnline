using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using Repositories.Helps;
namespace MasterData
{
    public class Get
    {
        BanHangDbContext dbBanHang = new BanHangDbContext();
        public List<Models.TableModels.KhachHang> GetKhachHangs()
        {
            var khachHangs = dbBanHang.KhachHangs.ToList();

            return khachHangs;
        }
        public List<Models.TableModels.Product> GetProducts()
        {
            var products = dbBanHang.Products.ToList();

            return products;
        }
        public List<Models.TableModels.User> GetUsers()
        {
            var users = dbBanHang.Users.ToList();

            return users;
        }

    }
}