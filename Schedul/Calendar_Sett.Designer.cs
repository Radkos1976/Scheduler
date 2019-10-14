namespace Schedul
{
    partial class Calendar_Sett
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendar_hdr = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Wrk_day = new System.Windows.Forms.DataGridView();
            this.exeptions = new System.Windows.Forms.DataGridView();
            this.queue = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_hdr)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wrk_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendar_hdr);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zdefiniowane kalendarze";
            // 
            // calendar_hdr
            // 
            this.calendar_hdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendar_hdr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar_hdr.Location = new System.Drawing.Point(3, 16);
            this.calendar_hdr.Name = "calendar_hdr";
            this.calendar_hdr.Size = new System.Drawing.Size(788, 147);
            this.calendar_hdr.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Wrk_day);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wygenerowane dni kalendarza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exeptions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zdefinowane wyjątki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.queue);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(783, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kolejka dni";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Wrk_day
            // 
            this.Wrk_day.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wrk_day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrk_day.Location = new System.Drawing.Point(3, 3);
            this.Wrk_day.Name = "Wrk_day";
            this.Wrk_day.Size = new System.Drawing.Size(777, 229);
            this.Wrk_day.TabIndex = 0;
            // 
            // exeptions
            // 
            this.exeptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exeptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exeptions.Location = new System.Drawing.Point(3, 3);
            this.exeptions.Name = "exeptions";
            this.exeptions.Size = new System.Drawing.Size(777, 229);
            this.exeptions.TabIndex = 0;
            // 
            // queue
            // 
            this.queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queue.Location = new System.Drawing.Point(0, 0);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(783, 235);
            this.queue.TabIndex = 0;
            // 
            // Calendar_Sett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calendar_Sett";
            this.Text = "Calendar_Sett";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendar_hdr)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Wrk_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView calendar_hdr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Wrk_day;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView exeptions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView queue;
    }
}