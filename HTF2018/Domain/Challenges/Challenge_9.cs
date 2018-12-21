using System.Collections.Generic;

namespace Domain.Challenges
{
    public class Challenge_9: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            foreach (var i in inputValues)
            {
                switch (i.Name)
                {
                    case "number":
                        AnswerList.Add(i);
                        return AnswerList;
                    default:
                        break;
                }
            }

            return AnswerList;
        }
    }
}
