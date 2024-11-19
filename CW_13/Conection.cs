using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_13
{
    public static class Conection
    {
        public static string ConnectionString { get; set; }

        static Conection()
        {
            ConnectionString = @"Data Source=DESKTOP-J6I42F2\SQLEXPRESS;Initial Catalog=NorthWind;User ID=SA;Password=123456;TrustServerCertificate=True;";
        }
    }
}
