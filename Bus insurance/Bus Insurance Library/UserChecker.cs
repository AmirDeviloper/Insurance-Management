using Bus_Insurance_Library.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Insurance_Library
{
    public static class UserChecker
    {
        private const string me = "C3-72-64-32-3F-45-46-31-B4-B2-70-30-B2-76-66-30-38-35-32-31-C6-C6-42-66-52-38-37-33";
        private const string one = "B0-70-66-30-3F-36-32-31-C6-C6-42-66-52-38-37-33";
        private const string server = "B7-41-36-30-3A-34-32-31-C6-C6-42-66-52-4D-46-42";


        public static bool Checker()
        {
            if (Ids.GetId() == server)
            {
                return true;
            }
            else
            {
                return false;
            }

            // also can use return Ids.GetId() == server;
        }
    }
}
