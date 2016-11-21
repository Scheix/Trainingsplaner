using iTextSharp.text;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainingsplaner
{
    public partial class FrmTerminKalender : Form
    {
        SQLiteConnection trainingsDB = new SQLiteConnection("Data Source=Trainingsplaner.sqlite;Version=3;");
        Form menuRef;
        public FrmTerminKalender(Form menu)
        {
            InitializeComponent();
            this.menuRef = menu;
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenUebersicht = false;
            }
        }

        private void monthCalendar1_DayQueryInfo(object sender, DayQueryInfoEventArgs e)
        {
            //if (e.Date.DayOfWeek == DayOfWeek.Saturday || e.Date.DayOfWeek == DayOfWeek.Sunday)
            //{
            //    e.Info.BackColor1 = Color.LightBlue;
            //    e.Info.BackColor2 = Color.LightBlue;
            //    //e.Info.ImageListIndex = 3;
            //    e.Info.GradientMode = mcGradientMode.Horizontal;
            //    // Set ownerdraw = true to add custom formatting
            //    e.OwnerDraw = true;
            //}
        }
        private void monthCalendar1_DaySelected(object sender, DaySelectedEventArgs e)
        {
            var date = e.Days;
            List<string> name = new List<string>();
            List<string> dates = new List<string>();
            trainingsDB.Open();
            for (int i = 0; i < date.Length; i++)
            {
                string select = "select name, date from termine where date = '" + date[i].ToString() + "'";
                SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
                command.ExecuteNonQuery();
                SQLiteDataReader reader = command.ExecuteReader();
                int check = 0;
                while (reader.Read())
                {
                    name.Add("" + reader["name"]);
                    for (int j = 0; j < dates.Count; j++)
                    {
                        if (dates[j].Equals("" + reader["date"]))
                        {
                            check++;
                        }
                    }
                    if (check == 0)
                    {
                        dates.Add("" + reader["date"]);
                        check = 0;
                    }
                }   
            }
            trainingsDB.Close();
            if (name.Count != 0)
            {
                FrmTerminDetails frm = new FrmTerminDetails(this);
                frm.Dates = dates;
                frm.Show();
            }
        }

        private void FrmTerminKalender_Load(object sender, EventArgs e)
        {
            //FormatDates();
            LoadCalender();
            DateTime d = DateTime.Now;
            int month = d.Month;
            monthCalendar1.ActiveMonth.Month = d.Month;
            monthCalendar1.ActiveMonth.Year = d.Year;
        }

        private void monthCalendar1_DayDoubleClick(object sender, DayClickEventArgs e)
        {
            string date = ""+e.Date;
            string[] x = date.Split('.');
            int day = Convert.ToInt32(x[0]);
            int month = Convert.ToInt32(x[1]);
            int year = Convert.ToInt32(x[2]);
            if (MessageBox.Show("Möchten sie einen Termin erstellen?", "Termin",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string value = "Terminname";
                if (InputBox("Termin erstellen", "Bitte bennen Sie Ihren Termin:", ref value) == DialogResult.OK)
                {
                    trainingsDB.Open();
                    DateItem d = new DateItem();
                    d.Date = new DateTime(year, month, day);
                    d.BackColor1 = Color.ForestGreen;
                    d.Text = value;
                    monthCalendar1.AddDateInfo(d);
                    string insert = "insert into termine (name, date) values ('"+value+"','"+date+"')";
                    SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                    command.ExecuteNonQuery();
                    trainingsDB.Close();
                }
            }
        }

        private void monthCalendar1_KeyDown(object sender, KeyEventArgs e)
        {
            string day = (monthCalendar1.SelectedDates[0].Day < 10) ? "0" + monthCalendar1.SelectedDates[0].Day : ""+monthCalendar1.SelectedDates[0].Day;
            string month = (monthCalendar1.SelectedDates[0].Month < 10) ? "0" + monthCalendar1.SelectedDates[0].Month : "" + monthCalendar1.SelectedDates[0].Month;
            string year = ""+monthCalendar1.SelectedDates[0].Year;
            string date = day + "." + month + "." + year;
            if (MessageBox.Show("Möchten sie einen Termin erstellen?", "Termin",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string value = "Terminname";
                if (InputBox("Termin erstellen", "Bitte bennen Sie Ihren Termin:", ref value) == DialogResult.OK)
                {
                    trainingsDB.Open();
                    DateItem d = new DateItem();
                    d.Date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                    d.BackColor1 = Color.Aqua;
                    d.Text = value;
                    monthCalendar1.AddDateInfo(d);
                    string insert = "insert into termine (name, date) values ('" + value + "','" + date + "')";
                    SQLiteCommand command = new SQLiteCommand(insert, trainingsDB);
                    command.ExecuteNonQuery();
                    trainingsDB.Close();
                }
            }
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public void LoadCalender()
        {
            monthCalendar1.ResetDateInfo();
            trainingsDB.Open();
            string select = "select * from termine";
            SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] x = reader["date"].ToString().Split('.');
                int day = Convert.ToInt32(x[0]);
                int month = Convert.ToInt32(x[1]);
                int year = Convert.ToInt32(x[2]);
                DateItem d = new DateItem();
                d.Date = new DateTime(year, month, day);
                d.BackColor1 = Color.ForestGreen;
                d.Text = reader["name"].ToString(); ;
                monthCalendar1.AddDateInfo(d);
            }
            trainingsDB.Close();
        }

        private void FrmTerminKalender_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (menuRef.GetType() == typeof(Form1))
            {
                ((Form1)menuRef).OpenUebersicht = true;
            }
        }
        //public static DialogResult InfoBox(List<string> date ,List<string> values)
        //{
        //    Form form = new Form();
        //    Button buttonOk = new Button();
        //    int counter = 20;

        //    form.Text = "Termine";
        //    for (int i = 0; i < date.Count; i++)
        //    { 
        //        Label termin = new Label();
        //        termin.Text = "Termine am " + date[i] + ":";
        //        termin.SetBounds(9, counter, 372, 13);
        //        termin.AutoSize = true;
        //        form.Controls.AddRange(new Control[] { termin });
        //        for (int j = 0; j < values.Count; j++)
        //        {
        //            Label l = new Label();
        //            l.Text = values[j];
        //            l.SetBounds(9, counter + 20, 372, 13);
        //            counter = counter * 2;
        //            l.AutoSize = true;
        //            form.Controls.AddRange(new Control[] { l });
        //        }
        //    }

        //    buttonOk.Text = "OK";
        //    buttonOk.DialogResult = DialogResult.OK;
        //    //x,y,b,h
        //    buttonOk.SetBounds(228, 72, 75, 23);

        //    buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        //    form.ClientSize = new Size(446, 157); //new Size(396, 107);
        //    form.Controls.AddRange(new Control[] { buttonOk });
        //    //form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        //    form.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    form.StartPosition = FormStartPosition.CenterScreen;
        //    form.MinimizeBox = false;
        //    form.MaximizeBox = false;
        //    form.AcceptButton = buttonOk;

        //    DialogResult dialogResult = form.ShowDialog();
        //    return dialogResult;
        //}

        //private void monthCalendar1_DayClick(object sender, DayClickEventArgs e)
        //{
        //    // Auch noch überprüfen ob an diesem Tag, mehr als 1 Termin ansteht
        //    string date = "" + e.Date;
        //    List<string> name = new List<string>();
        //    trainingsDB.Open();
        //    string select = "select name from termine where date = '"+date+"'";
        //    SQLiteCommand command = new SQLiteCommand(select, trainingsDB);
        //    command.ExecuteNonQuery();
        //    SQLiteDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        name.Add(""+reader["name"]);
        //    }
        //    trainingsDB.Close();
        //    if (name.Count != 0)
        //    {
        //        //MessageBox.Show(name, "Termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        InfoBox(date, name);
        //    }           
        //}
    }
}
