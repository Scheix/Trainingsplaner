namespace Trainingsplaner
{
    partial class FrmTerminKalender
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
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 9;
            this.monthCalendar1.ActiveMonth.Year = 2016;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("de-AT");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.BackColor1 = System.Drawing.Color.ForestGreen;
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxDate = new System.DateTime(2026, 9, 8, 18, 43, 21, 81);
            this.monthCalendar1.MinDate = new System.DateTime(2006, 9, 8, 18, 43, 21, 81);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(539, 362);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weekdays.TextColor = System.Drawing.Color.ForestGreen;
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.TextColor = System.Drawing.Color.ForestGreen;
            this.monthCalendar1.DayQueryInfo += new Pabo.Calendar.DayQueryInfoEventHandler(this.monthCalendar1_DayQueryInfo);
            this.monthCalendar1.DayDoubleClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar1_DayDoubleClick);
            this.monthCalendar1.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.monthCalendar1_DaySelected);
            this.monthCalendar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monthCalendar1_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Termin erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTerminKalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(539, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.MaximizeBox = false;
            this.Name = "FrmTerminKalender";
            this.Text = "FrmTerminKalender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTerminKalender_FormClosed);
            this.Load += new System.EventHandler(this.FrmTerminKalender_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Pabo.Calendar.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}