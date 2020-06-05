using System;
using System.Collections.Generic;
using WMS_Entity;

namespace WMS_DAL
{
    public class LoginData
    {
        public UserInfo Login(UserInfo u)
        {
            string str = $"select count(1) from UserInfo where UserName='{u.UserName}' and Pwd='{u.Pwd}'";


            string str1 = $"select IsOK from UserInfo where UserName='{u.UserName}' and Pwd='{u.Pwd}'";
            //string str2 = $"select UserName from UserInfo where UserName='{u.UserName}' ";

            u.IsLogin = Convert.ToInt32(DBHelper.ExecuteScalar(str));
            u.Isok = Convert.ToInt32(DBHelper.ExecuteScalar(str1));
            //u.Name = DBHelper.GetToList<List<UserInfo>>(str2)[0].ToString();

            return u;

        }
    }
}
