using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Class1
    {
        public static String login_type, id;

        public Class1()
        {
            login_type = "";
            id = "";
        }

        public Class1(String type,String id_no)
        {
            login_type = type;
            id = id_no;
        }

        public static String getType()
        {
            return login_type;
        }

        public static String getID()
        {
            return id;
        }
    }
}
