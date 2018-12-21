using System.Collections.Generic;

namespace Domain.Challenges
{
    public class Challenge_7: BaseClass
    {
        public override IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues)
        {
            foreach (var i in inputValues)
            {
                switch (i.Name)
                {
                    case "number":
                        Answerlist.Add(i);
                        return Answerlist;
                    default:
                        break;
                }
            }

            return Answerlist;
        }
    }
}
