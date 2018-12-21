using System.Collections.Generic;

namespace Domain.Challenges
{
    public abstract class BaseClass
    {
        public List<InputValue> AnswerList;
        public InputValue InputValue;
        public abstract IEnumerable<InputValue> Execute(IEnumerable<InputValue> inputValues);

        public BaseClass()
        {
            AnswerList = new List<InputValue>();
            InputValue = new InputValue();
        }
    }
}