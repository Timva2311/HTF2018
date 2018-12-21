using System;
using System.Collections.Generic;

namespace Domain.Challenges
{
    public class Challenge_2: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            int sum = 0;
            foreach (var i in inputValues)
            {
                sum += Int32.Parse(i.Data);
            }
            InputValue.Data = sum.ToString();
            InputValue.Name = "sum";
            Answerlist.Add(InputValue);
            return Answerlist;
        }
    }
}
