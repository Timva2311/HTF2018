using System.Collections.Generic;

namespace Domain.Challenges
{
    public abstract class BaseClass
    {
        public List<InputValue> Answerlist;
        public InputValue InputValue;
        public abstract IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues);

        public BaseClass()
        {
            Answerlist = new List<InputValue>();
            InputValue = new InputValue();
        }
    }
}