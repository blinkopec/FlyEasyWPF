using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrationWPF
{
    enum UserStatusEnum
    {
        logged,
        loggedOut,
    }
    static class UserInfo
    {
        public static int id { get; set; }
        public static UserStatusEnum status { get; set; } = UserStatusEnum.loggedOut;
    }
}
