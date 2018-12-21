using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Challenges
{
    public class Challenge_6
    {
        public string Challenge6(IEnumerable<InputValue> inputValues)
        {
            var startDate;
            var endDate;
            var day;
            foreach(var i in inputValues) {
                switch(i.name) 
                {
                    case "startDate":
                        startDate = i.data;
                        break;
                    case "endDate":
                        endDate = i.data;
                        break;
                    case "day":
                        day = i.data;
                        break;
                }

            }
        }
    }

    public class CountDay: BaseClass
    {
        public IEnumerable<InputValue> CountDayInPeriod(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;
            int count = (int)Math.Floor(ts.TotalDays / 7);
            int remainder = (int)(ts.TotalDays % 7);
            int sinceLastDay = (int)(end.DayOfWeek - day);
            if (sinceLastDay < 0) sinceLastDay += 7;

            if (remainder >= sinceLastDay) count++;
            inputValue.name = "count";
            inputValue.data = count.ToString();
            answerlist.Add(inputValue);
            return answerlist;
        }
    }
}
