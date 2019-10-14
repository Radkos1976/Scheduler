namespace Schedul
{
    partial class Mainfrm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ToolPnl = new System.Windows.Forms.ToolStrip();
            this.count_Refr = new System.Windows.Forms.ToolStripButton();
            this.Refr_now = new System.Windows.Forms.ToolStripButton();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.calendar_sett = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dbconn = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileDlg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ToolPnl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 408);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.ToolPnl);
            this.toolStripContainer1.TopToolStripPanel.Enabled = false;
            // 
            // ToolPnl
            // 
            this.ToolPnl.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolPnl.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.ToolPnl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.count_Refr,
            this.Refr_now,
            this.Settings,
            this.calendar_sett});
            this.ToolPnl.Location = new System.Drawing.Point(3, 0);
            this.ToolPnl.Name = "ToolPnl";
            this.ToolPnl.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolPnl.Size = new System.Drawing.Size(199, 42);
            this.ToolPnl.TabIndex = 0;
            // 
            // count_Refr
            // 
            this.count_Refr.BackColor = System.Drawing.SystemColors.Control;
            this.count_Refr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.count_Refr.Checked = true;
            this.count_Refr.CheckOnClick = true;
            this.count_Refr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.count_Refr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.count_Refr.Image = ((System.Drawing.Image)(resources.GetObject("count_Refr.Image")));
            this.count_Refr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.count_Refr.Name = "count_Refr";
            this.count_Refr.Size = new System.Drawing.Size(39, 39);
            this.count_Refr.Text = "Włącz automatyczne odświeżanie";
            // 
            // Refr_now
            // 
            this.Refr_now.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refr_now.Image = ((System.Drawing.Image)(resources.GetObject("Refr_now.Image")));
            this.Refr_now.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refr_now.Name = "Refr_now";
            this.Refr_now.Size = new System.Drawing.Size(39, 39);
            this.Refr_now.Text = "Odśwież dane";
            // 
            // Settings
            // 
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(39, 39);
            this.Settings.Text = "Pokaż historyczne dane";
            this.Settings.ToolTipText = "Ustawienia serwisu";
            // 
            // calendar_sett
            // 
            this.calendar_sett.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calendar_sett.Image = ((System.Drawing.Image)(resources.GetObject("calendar_sett.Image")));
            this.calendar_sett.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.calendar_sett.Name = "calendar_sett";
            this.calendar_sett.Size = new System.Drawing.Size(39, 39);
            this.calendar_sett.Text = "Ustawienia kalendarzy";
            this.calendar_sett.Click += new System.EventHandler(this.calendar_sett_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbconn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dbconn
            // 
            this.dbconn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbconn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDlg});
            this.dbconn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbconn.Image = ((System.Drawing.Image)(resources.GetObject("dbconn.Image")));
            this.dbconn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.dbconn.Name = "dbconn";
            this.dbconn.Size = new System.Drawing.Size(213, 21);
            this.dbconn.Text = "Brak podłączonej bazy danych";
            this.dbconn.ToolTipText = "Brak podłączonej bazy";
            // 
            // openFileDlg
            // 
            this.openFileDlg.Name = "openFileDlg";
            this.openFileDlg.Size = new System.Drawing.Size(147, 22);
            this.openFileDlg.Text = "Wybierz plik";
            this.openFileDlg.Click += new System.EventHandler(this.OpenFileDlg_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Mainfrm";
            this.Text = "Harmonogram zadań";
            this.Load += new System.EventHandler(this.Mainfrm_Enter);
            this.Move += new System.EventHandler(this.Mainfrm_Enter);
            this.Resize += new System.EventHandler(this.Mainfrm_Enter);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ToolPnl.ResumeLayout(false);
            this.ToolPnl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip ToolPnl;
        internal System.Windows.Forms.ToolStripButton count_Refr;
        internal System.Windows.Forms.ToolStripButton Settings;
        internal System.Windows.Forms.ToolStripButton Refr_now;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripButton calendar_sett;
        internal System.Windows.Forms.ToolStripDropDownButton dbconn;
        private System.Windows.Forms.ToolStripMenuItem openFileDlg;
    }
}

