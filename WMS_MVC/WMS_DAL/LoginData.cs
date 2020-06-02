using System;
using WMS_Entity;

namespace WMS_DAL
{
    public class LoginData
    {
        public int Login(UserInfo u)
        {
            string str = $"select count(1) from UserInfo where UserName='{u.UserName}' and Pwd='{u.Pwd}'";
            return (int)DBHelper.ExecuteScalar(str);


        }
    }
}
