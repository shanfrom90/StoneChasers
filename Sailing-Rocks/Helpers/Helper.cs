using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Helpers
{
    public static class Helper
    {
        public static string EncryptPassword(string password)
        {
            //implment encryption
            return password;
        }

        public static string GenerateSerial(int length)
        {
            const string chars = "ABCDEFGHJKMNPQRTUVWXYZ2346789";

            Random random = new Random();

            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
