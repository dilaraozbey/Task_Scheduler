using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskScheduler
{

    public partial class Form1 : Form
    {
        static TaskService taskService = new TaskService();
        static TaskDefinition td = Class1.createTask(taskService);

        static int Hour_;
        static int Minute_;
        static int Second_;
        static TaskFolder folder;

        public Form1()
        {

            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            td.Settings.Hidden = true;
            td.Settings.Priority = System.Diagnostics.ProcessPriorityClass.High;
            td.Principal.RunLevel = TaskRunLevel.Highest;

        }


        private void Daily_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            monthly_cbx.Checked = false;
            weekly_cbx.Checked = false;
            if (Daily_Cbx.Checked == true)
            {
                DaysGbx.Hide();
                MonthGbx.Hide();
            }
            else
            {
                DaysGbx.Show();
                MonthGbx.Show();


            }
        }
        private void weekly_cbx_CheckedChanged(object sender, EventArgs e)
        {
            monthly_cbx.Checked = false;
            Daily_Cbx.Checked = false;

            if (weekly_cbx.Checked == true)
            {
                MonthGbx.Hide();
            }
            else
            {
                Class1.Checked(DaysGbx);
                MonthGbx.Show();




            }
        }

        private void monthly_cbx_CheckedChanged(object sender, EventArgs e)
        {
            weekly_cbx.Checked = false;
            Daily_Cbx.Checked = false;
            if (monthly_cbx.Checked == true)
            {
                DaysGbx.Hide();
            }
            else
            {
                Class1.Checked(MonthGbx);
                DaysGbx.Show();


            }

        }

        private void taskName_bx_TextChanged(object sender, EventArgs e)
        {



        }



        private void description_bx_TextChanged(object sender, EventArgs e)
        {
            td.RegistrationInfo.Description = description_bx.Text;
        }

        private void DaysList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hour_ValueChanged(object sender, EventArgs e)
        {
            Hour_ = decimal.ToInt32(Hour.Value);
        }

        private void Minute_ValueChanged(object sender, EventArgs e)
        {
            Minute_ = decimal.ToInt32(Minute.Value);
        }

        private void second_ValueChanged(object sender, EventArgs e)
        {
            Second_ = decimal.ToInt32(second.Value);
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {

            if ( taskName_bx.Text==""| description_bx.Text=="" |( Daily_Cbx.Checked==false&& monthly_cbx.Checked==false && weekly_cbx.Checked==false) )
            {
                MessageBox.Show("Missing Informationn!");
            }

            else
            {

                string Task_Name = taskName_bx.Text;
                if (Daily_Cbx.Checked == true)
                {
                    Microsoft.Win32.TaskScheduler.DailyTrigger daily = new DailyTrigger();
                    Class1.Timecreate(daily, Hour_, Minute_, Second_);


                }
                else if (weekly_cbx.Checked == true)
                {
                    Microsoft.Win32.TaskScheduler.WeeklyTrigger weekly = new WeeklyTrigger();
                    Class1.Timecreate(weekly, Hour_, Minute_, Second_);
                    weekly.DaysOfWeek = (DaysOfTheWeek)Class1.Weeks(chpazartesi) | (DaysOfTheWeek)Class1.Weeks(chSali) | (DaysOfTheWeek)Class1.Weeks(chCarsamba) | (DaysOfTheWeek)Class1.Weeks(chPersembe) | (DaysOfTheWeek)Class1.Weeks(chCuma) | (DaysOfTheWeek)Class1.Weeks(chCumartesi) | (DaysOfTheWeek)Class1.Weeks(chPazar);
                    td.Triggers.Add(weekly);

                }
                else if (monthly_cbx.Checked == true)
                {
                    Microsoft.Win32.TaskScheduler.MonthlyTrigger monthly = new MonthlyTrigger();
                    Class1.Timecreate(monthly, Hour_, Minute_, Second_);
                    monthly.MonthsOfYear = (MonthsOfTheYear)Class1.Months(chOcak) | (MonthsOfTheYear)Class1.Months(chSubat) | (MonthsOfTheYear)Class1.Months(chMart) | (MonthsOfTheYear)Class1.Months(chNisan) | (MonthsOfTheYear)Class1.Months(chMayis) | (MonthsOfTheYear)Class1.Months(chHaziran) | (MonthsOfTheYear)Class1.Months(chTemmuz) | (MonthsOfTheYear)Class1.Months(chAgustos) | (MonthsOfTheYear)Class1.Months(chEylul) | (MonthsOfTheYear)Class1.Months(chEkim) | (MonthsOfTheYear)Class1.Months(chKasim) | (MonthsOfTheYear)Class1.Months(chAralik);
                    td.Triggers.Add(monthly);
                }
                else
                {
                    MessageBox.Show("Please select repetition interval!");
                }

                td.Actions.Add("notepad.exe", Task_Name);
                string name = "Tasklar";

                try
                {
                    folder = taskService.RootFolder.CreateFolder("Tasklar");
                    taskService.RootFolder.RegisterTaskDefinition(name + "\\" + Task_Name, td);

                }
                catch
                {
                    taskService.RootFolder.RegisterTaskDefinition(name + "\\" + Task_Name, td);
                }
                MessageBox.Show("Mission Completed!");
                
                this.Close();
               
                var bilgi = taskService.FindTask("");
                bilgi.Run();

            }



          

           
        }


    }
}
