using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedul
{
    public static class Settings
    {
        public static string Db_path { get; set; }
        public static string Conn_str { get; set; }        
        static Settings()
        {
            Db_path = Properties.Settings.Default.Db_path;
            Conn_str = Properties.Settings.Default.Conn_str;
        }
        public static void Save()
        {
            Properties.Settings.Default.Db_path = Db_path;
            Conn_str = "Microsoft.ACE.OLEDB.12.0; Data Source =" + Db_path;
            Properties.Settings.Default.Conn_str = Conn_str;
            Properties.Settings.Default.Save();            
        }
    }
}
