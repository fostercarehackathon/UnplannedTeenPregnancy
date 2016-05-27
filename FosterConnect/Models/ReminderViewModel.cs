using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterConnect.Models
{
    public class ReminderViewModel
    {
        public string Email { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }

        public ReminderType Reminder { get; set; }

        public int Amount { get; set; }
        public FrequencyType Frequency { get; set; }
        public FrequencyEndType FrequencyEnd { get; set; }

        public int FrequencyEndsAfter { get; set; }
        public DateTime FrequencyEndsOnDateTime { get; set; }
        public enum ReminderType
        {
            BirthControl,
            PreNatal,
            Parenting,
            DoctorAppointment,
            SupportGroupMeetup,
            Other
        };

        public enum FrequencyType
        {
            Days,
            Weeks,
            Months,
            Years
        };

        public enum FrequencyEndType
        {
            Never,
            After,
            On
        };

        public Dictionary<string, ReminderType> ReminderTypesDictionary { get; private set; } = new Dictionary
            <string, ReminderType>
        {
            {"Birth Control", ReminderType.BirthControl},
            {"Doctor's Appointment", ReminderType.DoctorAppointment},
            {"Pre Natal Classes", ReminderType.PreNatal},
            {"Parenting Classes", ReminderType.Parenting},
            {"Meet your favorite Support Group", ReminderType.SupportGroupMeetup},
            {"Other", ReminderType.Other}
        };

        public bool ShouldRepeat { get; set; }


    }

}