using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.TableModels
{
    public class User
    {
        public long? Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Birthday_Day { get; set; }
        public int? Birthday_Month { get; set; }
        public int? Birthday_Year { get; set; }
        public string IDCard { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public short? Status { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}