using Repositories.Helps;
using System;
using System.Collections.Generic;
using System.Linq;
using Models.ResponseModels;
using Models.TableModels;
using Models.Enums;
namespace MasterData
{
    public class Insert
    {
        BanHangDbContext dbBanHang = new BanHangDbContext();
        public ActionResultModels InsertUser(User user)
        {
            var result = new ActionResultModels(){
                Result = ResultCode.Fail,
                Message = "Thất bại"
            };
            try
            {
                User newUser = new User();

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