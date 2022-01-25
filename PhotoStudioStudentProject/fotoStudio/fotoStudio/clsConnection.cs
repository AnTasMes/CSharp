using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace fotoStudio
{
    class clsConnection
    {
        public static string connection = "datasource=127.0.0.1;" +
                "Database=studio;" +
                ";username=root;password=";
    }
}
