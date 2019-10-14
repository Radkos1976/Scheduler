using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedul
{
    public partial class Calendar_Sett : Form
    {
        
        public Calendar_Sett()
        {
            InitializeComponent();
            get_dataset_cal_hdr();
        }
        private async void get_dataset_cal_hdr()
        {
            string con = Schedul.Settings.Conn_str;
            using (OleDbConnection conn = new OleDbConnection {
                ConnectionString =con})
            {
                await conn.OpenAsync();
                using (OleDbCommand command = new OleDbCommand("" +
                    "SELECT calendar_hdr.id, calendar_hdr.Valid_from, calendar_hdr.Valid_to, dbstate.state," +
                    " calendar_hdr.calendar_types_day FROM(calendar_hdr INNER JOIN dbstate " +
                    "ON calendar_hdr.state = dbstate.id)", conn) { CommandType = CommandType.Text })
                {                    
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        using (DataTable hdr = new DataTable())
                        {
                            hdr.Load(reader);
                            calendar_hdr.DataSource = hdr;
                        }                        
                    }
                }
            }
        }

    }
}
