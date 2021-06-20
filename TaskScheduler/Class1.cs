using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace TaskScheduler
{
    public static class Class1
    {
        public static TaskDefinition createTask(TaskService taskService)
        {

            TaskDefinition td = taskService.NewTask();
            return td;
        }
        public static void Timecreate(Trigger tr, int hour, int min, int sec)
        {
            tr.Repetition.Interval = new TimeSpan(hour, min, sec);

        }
      
        public  static int Months(CheckBox ch)
        {
            if (ch.Checked)
            {
                switch (ch.Name)
                {
                    case "chOcak": return (int)MonthsOfTheYear.January;
                    case "chSubat": return (int)MonthsOfTheYear.February;
                    case "chMart": return (int)MonthsOfTheYear.March;
                    case "chNisan": return (int)MonthsOfTheYear.April;
                    case "chMayis": return (int)MonthsOfTheYear.May;
                    case "chHaziran": return (int)MonthsOfTheYear.June;
                    case "chTemmuz": return (int)MonthsOfTheYear.July;
                    case "chAgustos": return (int)MonthsOfTheYear.August;
                    case "chEylul": return (int)MonthsOfTheYear.September;
                    case "chEkim": return (int)MonthsOfTheYear.October;
                    case "chKasim": return (int)MonthsOfTheYear.November;
                    case "chAralik": return (int)MonthsOfTheYear.December;
                    default: return 0;
                }
            }
            else
                return 0;
        }
        public static void Checked( GroupBox gb)
        {
            foreach (Control item in gb.Controls)
            {

                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }

            }
       

}

public static int Weeks(CheckBox ch)
        {
            if (ch.Checked)
            {
                switch (ch.Name)
                {
                    case "chPazar": return (int)DaysOfTheWeek.Sunday;
                    case "chPazartesi": return (int)DaysOfTheWeek.Monday;
                    case "chSali": return (int)DaysOfTheWeek.Tuesday;
                    case "chCarsamba": return (int)DaysOfTheWeek.Wednesday;
                    case "chPersembe": return (int)DaysOfTheWeek.Thursday;
                    case "chCuma": return (int)DaysOfTheWeek.Friday;
                    case "chCumartesi": return (int)DaysOfTheWeek.Saturday;
                    default: return 0;
                }
            }
            else  return 0;
        }

    }
}
