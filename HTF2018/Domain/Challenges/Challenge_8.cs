using System;
using System.Collections.Generic;
using NCalc;

namespace Domain.Challenges
{
    public class Challenge_8: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            String input = "";
            foreach (var i in inputValues)
            {
                input += i.Name;
                input += i.Data;
            }
            Expression e = new Expression(input);
            InputValue.Data = e.Evaluate().ToString();
            InputValue.Name = "answer";
            AnswerList.Add(InputValue);
            InputValue.Data = input;
            InputValue.Name = "formula";
            AnswerList.Add(InputValue);
            return AnswerList;
        }
    }
}
