using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class ClockRadio
    {
        //member variables
        public DateTime currentUTCTime;
        public string currentAlarmState = "OFF";
        public string currentRadioStation;
        public string alarmDateTime;

        //constructor


        //member methods
        public void GetCurrentCentralTime()
        {
            currentUTCTime = DateTime.UtcNow;
            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(currentUTCTime, cstZone);
            Console.WriteLine(cstTime);
            Console.ReadLine();
        }

        public void switchAlarmStatus()
        {
            if (currentAlarmState == "OFF")
            {
                currentAlarmState = "ON";
                Console.WriteLine("What time would you like to set your alarm to?");
                alarmDateTime = Console.ReadLine();
                Console.WriteLine("Your alarm is now " + currentAlarmState + ". It is set to " + alarmDateTime + ".");
            }
            else
            {
                currentAlarmState = "OFF";
                Console.WriteLine("Your alarm is now " + currentAlarmState + ".");
            }
            
            Console.ReadLine();
        }

        
    }
}
