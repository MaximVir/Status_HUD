using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhaegal.Time
{
    class Timemethods : Timeabstract
    {
        public override string GetTime()
        {
            string time;

            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime universal = zone.ToUniversalTime(DateTime.Now);
            time = universal.TimeOfDay.ToString();

            return time;
        }

        public override string GetDay()
        {
            string day;

            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime universal = zone.ToUniversalTime(DateTime.Now);
            day = universal.DayOfWeek.ToString();

            return day;
        }
    }
}
