using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class DBManager
    {
       public static void SetConnectionString(string connstring, bool tryopen, string userid = "", string password = "")
        {
            SQLUtility.SetConnectionString(connstring, tryopen, userid, password);
        }
    }
}



