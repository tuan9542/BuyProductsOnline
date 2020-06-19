using Models.ResponseModels;
using Models;
using Repositories.Helps;
using System.Collections.Generic;
using System.Linq;
using Models.Enums;
using System;
using Models.TableModels;

namespace Repositories.MasterData
{
    public class Actions_User
    {
        BanHangDbContext dbBanHang = new BanHangDbContext();
        public List<User> GetUsers()
        {
            var users = dbBanHang.Users.ToList();

            return users;
        }
        public ActionResultModels InsertUser(User user)
        {
            var result = new ActionResultModels()
            {
                Result = ResultCode.Fail,
                Message = "Thất bại"
            };
            try
            {
                var newUser = new User();

                newUser.UserName = user.UserName;
                newUser.PassWord = user.PassWord;
                newUser.FirstName = user.FirstName;
                newUser.MiddleName = user.MiddleName;
                newUser.LastName = user.LastName;
                newUser.Birthday = user.Birthday;
                newUser.IDCard = user.IDCard;
                newUser.Address = user.Address;
                newUser.AvatarUrl = user.AvatarUrl;
                newUser.Status = (int)Status.Active;
                newUser.CreateDateTime = user.CreateDateTime;

                dbBanHang.Users.Add(newUser);
                dbBanHang.SaveChanges();

                if (newUser.Id > 0)
                {
                    result = new ActionResultModels()
                    {
                        Result = ResultCode.Success,
                        Message = "Tạo User mới thành công"
                    };
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
            }
            return result;
        }
    }
}