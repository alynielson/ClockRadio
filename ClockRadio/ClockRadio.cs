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
        public string menuOption;
        public DateTime currentUTCTime;
        public string currentAlarmState;
        public string currentRadioStation;
        public string alarmDateTime;
        public string currentRadioState;

        //constructor
        public ClockRadio()
        {
            currentAlarmState = "OFF";
            currentRadioStation = "95.5 FM";
            currentRadioState = "OFF";
    }

        //member methods
        public void GetCurrentCentralTime()
        {
            currentUTCTime = DateTime.UtcNow;
            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(currentUTCTime, cstZone);
            Console.WriteLine(cstTime);
        }

        public void CheckIfAlarmOn()
        {
            if (currentAlarmState == "OFF")
            {
                Console.WriteLine("There is no alarm set!");
            }
            else if (alarmDateTime == "")
            {
                Console.WriteLine("Alarm has no time set!");
            }
            else
            {
                Console.WriteLine("The alarm is " + currentAlarmState + " and is set to " + alarmDateTime + ".");
            }
        }
        public void SwitchAlarmStatus()
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
        }

        public void SetRadioStation()
        {
            Console.WriteLine("What station would you like to set your radio to?");
            currentRadioStation = Console.ReadLine();
            Console.WriteLine("Station changed to " + currentRadioStation + ".");
        }

        public void GetCurrentStation()
        {
            Console.WriteLine("The radio is set to " + currentRadioStation + ".");
        }

        public void SwitchRadioStatus()
        {
            if (currentRadioState == "OFF")
            {
                currentRadioState = "ON";
                Console.WriteLine("Radio is now " + currentRadioState + " and playing " + currentRadioStation + ".");
            }
            else
            {
                currentRadioState = "OFF";
                Console.WriteLine("Radio is now " + currentRadioState + ".");
            }
        }
        
        public void ChooseMenuOption()
        {
            Console.WriteLine("What would you like to do? (1) get current time (2) check if alarm is on or off (3) set alarm or turn it off (4) turn radio on or off (5) see current radio station (6) change radio station");
            menuOption = Console.ReadLine();
            if (menuOption == "1")
            {
                GetCurrentCentralTime();
            }
            else if (menuOption == "2")
            {
                CheckIfAlarmOn();
            }
            else if (menuOption == "3")
            {
                SwitchAlarmStatus();
            }
            else if (menuOption == "4")
            {
                SwitchRadioStatus();
            }
            else if (menuOption == "5")
            {
                GetCurrentStation();
            }
            else if (menuOption == "6")
            {
                SetRadioStation();
            }
            else
            {
                Console.WriteLine("You did not type a valid number! Try again.");
            }
            ChooseMenuOption();
        }

        
    }
}
