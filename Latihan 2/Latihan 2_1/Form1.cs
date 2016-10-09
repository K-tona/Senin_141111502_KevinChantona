using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        private bool MarkHoliday(DateTime START_date, DateTime END_date)
        {
            if (START_date <= END_date)
            {
                DateTime Selected = START_date;
                TimeSpan NilaiTambah = new TimeSpan(1, 0, 0, 0);
                while (Selected < END_date)
                {
                    if (Selected.DayOfWeek.ToString() == "Sunday" || Selected.DayOfWeek.ToString() == "Saturday")
                    {
                        monthCalendar1.AddBoldedDate(Selected);
                    }
                    Selected = Selected.Add(NilaiTambah);
                }
                return true;
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            DateTime Mulai = new DateTime(2016, 1, 1);
            DateTime Akhir = new DateTime(2017, 1, 1);
            DateTime Birthday = new DateTime(1997, 3, 11);
            if (MarkHoliday(Mulai, Akhir))
            {
                monthCalendar1.AddAnnuallyBoldedDate(Birthday);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime InputDate = new DateTime(2016, domainUpDown2.SelectedIndex + 1, domainUpDown1.SelectedIndex + 1);
                monthCalendar1.AddAnnuallyBoldedDate(InputDate);
                monthCalendar1.UpdateBoldedDates();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime InputDate = new DateTime(2016, domainUpDown2.SelectedIndex + 1, domainUpDown1.SelectedIndex + 1);
                monthCalendar1.RemoveAnnuallyBoldedDate(InputDate);
                monthCalendar1.UpdateBoldedDates();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
