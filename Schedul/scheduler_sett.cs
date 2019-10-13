using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Schedul
{
    class Scheduler_sett
    { 
        //Database settings
        private string t_db_connection_String;
        private readonly string t_db_fulpath;
        public string Db_connection
        {
            get { return t_db_connection_String; }
        }
        public string Db_fulpath
        {
            get { return t_db_fulpath; }
        }
        public Scheduler_sett(string file_path)
        {
            t_db_fulpath = file_path;
            t_db_connection_String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + t_db_fulpath;
        }
        private Schema_tables Schema_tables_DB()
        {
            var tbles = new List<Table_schem>();
            var _lst_flds = new List<One_field>();
            try
            {
                using (OleDbConnection conn = new OleDbConnection
                { ConnectionString = t_db_connection_String })
                {
                    conn.Open();
                    using (DataTable rf = conn.GetSchema("Columns"))
                    {
                        DataView dv = rf.DefaultView;
                        dv.Sort = "Table_name asc";
                        using (DataTable rs = dv.ToTable())
                        {
                            string _tble = rs.Rows[0]["Table_name"].ToString().ToLower();
                            long count = rs.Rows.Count;
                            foreach (DataRow row in rs.Rows)
                            {
                                if (_tble != row["Table_name"].ToString().ToLower())
                                {
                                    Table_schem tbl = new Table_schem
                                    {
                                        Table_nam = _tble.ToLower(),
                                        _Fields = _lst_flds
                                    };
                                    tbles.Add(tbl);
                                    _tble = row["Table_name"].ToString().ToLower();
                                    _lst_flds = new List<One_field>();
                                }
                                One_field field = new One_field
                                {
                                    Field_nam = row["Column_name"].ToString().ToLower()
                                };
                                _lst_flds.Add(field);
                                count = count - 1;
                                if (count == 1)
                                {
                                    Table_schem tbl = new Table_schem
                                    {
                                        Table_nam = _tble.ToLower(),
                                        _Fields = _lst_flds
                                    };
                                    tbles.Add(tbl);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            {
                Schema_tables sch = new Schema_tables
                {
                    Sett = tbles
                };
                return sch;
            }
        }
        private Schema_tables Get_schemaXML()
        {
            var tbles = new List<Table_schem>();
            try
            {
                XDocument Doc = XDocument.Load("schemaDB.xml");
                var schema = Doc.Descendants("schema");
                IEnumerable<XElement> tables = schema.Descendants("table");
                foreach (XElement table in tables)
                {
                    var _lst_flds = new List<One_field>();
                    IEnumerable<XElement> fields = table.Descendants("field");
                    foreach (XElement field in fields)
                    {
                        One_field fld = new One_field
                        {
                            Field_nam = field.Element("fname").Value.ToLower(),
                            Field_type = field.Element("type").Value.ToLower()
                        };
                        _lst_flds.Add(fld);
                    }
                    Table_schem tbl = new Table_schem
                    {
                        Table_nam = table.Element("name").Value.ToLower(),
                        _Fields = _lst_flds
                    };
                    tbles.Add(tbl);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            {
                Schema_tables sch = new Schema_tables
                {
                    Sett = tbles
                };
                return sch;
            }
        }
        public bool Chk_dtbase()
        {
            Schema_tables tblxml = Get_schemaXML();
            Schema_tables tblDb = Schema_tables_DB();
            bool is_valid = true;
            foreach (Table_schem tbl in tblxml.Sett)
            {
                string tbl_nam = tbl.Table_nam;
                foreach (One_field fld in tbl._Fields)
                {
                    if (fld.Field_nam.Length < 10 || (fld.Field_nam.Length > 9 & fld.Field_nam.Substring(0, 10) != "CONSTRAINT".ToLower()))
                    {
                        if (!tblDb.Sett.Any(sett => sett.Table_nam == tbl_nam && sett._Fields.Any(field => field.Field_nam == fld.Field_nam)))
                        {
                            is_valid = false;
                        }
                    }
                }
            }

            return is_valid;
        }
        class Schema_tables
        {
            public List<Table_schem> Sett { get; set; }
        }
        class Table_schem
        {
            public string Table_nam { get; set; }
            public List<One_field> _Fields { get; set; }
        }
        class One_field
        {
            public string Field_nam { get; set; }
            public string Field_type { get; set; }
        }
    }

}
