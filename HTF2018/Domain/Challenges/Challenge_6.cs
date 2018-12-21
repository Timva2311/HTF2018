using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_6: BaseClass
    {
        public IEnumerable<InputValue> Challenge6(IEnumerable<InputValue> inputValues)
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            DayOfWeek day = DayOfWeek.Friday;
            foreach(var i in inputValues) 
            {
                switch(i.Name) 
                {
                    case "startDate":
                        startDate = DateTime.Parse(i.Data);
                        break;
                    case "endDate":
                        endDate = DateTime.Parse(i.Data);
                        break;
                    case "day":
                        day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), i.Data, true);
                        break;
                }
            }
            CountDay countDay = new CountDay();
            var count = countDay.CountDayInPeriod(day, startDate, endDate);
            InputValue.Name = "count";
            InputValue.Data = count.ToString();
            Answerlist.Add(InputValue);
            return Answerlist;
        }
    }

    public class CountDay
    {
        public int CountDayInPeriod(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;
            int count = (int)Math.Floor(ts.TotalDays / 7);
            int remainder = (int)(ts.TotalDays % 7);
            int sinceLastDay = (int)(end.DayOfWeek - day);
            if (sinceLastDay < 0) sinceLastDay += 7;
            if (remainder >= sinceLastDay) count++;
            return count;
        }
    }
}
