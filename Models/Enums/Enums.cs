using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Enums
{
    public enum Status : short
    {
        Active = 1,
        InActive = 0
    }
    public enum ResultCode : short
    {
        Success = 1,
        Fail = 0
    }
}