using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5Crash.Util
{
    public static class HashUtil
    {
        public static String md5(long num)
        {
            MD5 crypto = MD5.Create();
            byte[] t = crypto.ComputeHash(Encoding.UTF8.GetBytes(num.ToString()));
            crypto.Clear();
            string hash = "";
            for (int i = 0;i< t.Length; i++)
            {
                hash = hash + t[i].ToString("X");
            }
            return hash;
        }
    }
}
