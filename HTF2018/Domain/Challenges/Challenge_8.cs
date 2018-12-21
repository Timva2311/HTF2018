using System.Collections.Generic;

namespace Domain.Challenges
{
    public class Challenge_8: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            String input = "";
            foreach (var i in inputValues)
            {
                input += i.name;
                input += i.data;
            }
            Expression e = new Expression(input);
            InputValue.Data = e.Evaluate();
            InputValue.Name = "answer";
            AnswerList.Add(InputValue);
            InputValue.Data = ;
            InputValue.Name = "answer";
            AnswerList.Add(InputValue);
            return AnswerList;
        }
    }
}
