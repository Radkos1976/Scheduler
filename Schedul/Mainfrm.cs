using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedul
{
    public partial class Mainfrm : Form
    {
        static readonly string Db_path = Schedul.Settings.Db_path;
        ToolTip UserHelper = new ToolTip
        {
            ShowAlways = true,
            IsBalloon = true,
            UseAnimation = true,
            UseFading = true
        };
        public Mainfrm()
        {         
            InitializeComponent();            
        }
        private void SetDb_nam()
        {
            dbconn.Text = "Podłączono do bazy : " + Schedul.Settings.Db_path;
        }
        private bool Is_db()
        {
            return !(Schedul.Settings.Db_path == "");        
        }
        private void Valid_database_selected()
        {

        }
        private void Sel_db(bool Is_selected)
        {
            if (Is_selected)
            {
                dbconn.BackColor = System.Drawing.Color.AliceBlue;
                UserHelper.Hide(statusStrip1);
                toolStripContainer1.TopToolStripPanel.Enabled = true;
            }
            else
            {
                dbconn.BackColor = Color.Yellow;
                toolStripContainer1.TopToolStripPanel.Enabled = false;
                UserHelper.Show("Prosze ustawić połączenie z bazą danych", statusStrip1, 0, 20);
            }        
        }       
        private void OpenFileDlg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open_dlg = new OpenFileDialog
            {
                Title = "Proszę wybrać plik bazy danych",
                Filter = "Pliki bazy danych access|*.accdb"
            })
            {
                if (open_dlg.ShowDialog() == DialogResult.OK)
                {

                    //Provider = Microsoft.ACE.OLEDB.12.0; Data Source =| DataDirectory |\scheduler.accdb
                    Scheduler_sett chk= new Scheduler_sett(open_dlg.InitialDirectory + open_dlg.FileName);
                    if (chk.Chk_dtbase())
                    {
                        Schedul.Settings.Db_path = open_dlg.InitialDirectory + open_dlg.FileName;
                        Schedul.Settings.Save();
                        Sel_db(true);
                        SetDb_nam();
                    }
                    else
                    {
                        MessageBox.Show("Wybrana baza niezgodna ze schematem", "Sprawdzenie bazy danych");
                    }
                }
            }
        }
        private void Mainfrm_Enter(object sender, EventArgs e)
        {
            if (Is_db())
            {
                SetDb_nam();
                Sel_db(true);
            }
            else
            {
                Sel_db(false);
            }
        }

        private void calendar_sett_Click(object sender, EventArgs e)
        {
            Calendar_Sett cal = new Calendar_Sett();
            cal.Show();
        }
    }
}
