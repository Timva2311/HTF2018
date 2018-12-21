using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_6 : BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            string startDate;
            string endDate;
            string day;
            foreach(var i in inputValues) {
                switch(i.Name) 
                {
                    case "startDate":
                        startDate = i.Data;
                        break;
                    case "endDate":
                        endDate = i.Data;
                        break;
                    case "day":
                        day = i.Data;
                        break;
                }

            }

            return null;
        }
    }

    public class CountDay
    {
        public IEnumerable<InputValue> CountDayInPeriod(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;
            int count = (int)Math.Floor(ts.TotalDays / 7);
            int remainder = (int)(ts.TotalDays % 7);
            int sinceLastDay = (int)(end.DayOfWeek - day);
            if (sinceLastDay < 0) sinceLastDay += 7;

            if (remainder >= sinceLastDay) count++;
            InputValue.Name = "count";
            InputValue.Data = count.ToString();
            Answerlist.Add(InputValue);
            return Answerlist;
        }
    }
}
